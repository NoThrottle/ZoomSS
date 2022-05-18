using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomSS
{
    public partial class ZoomSS : Form, IMessageFilter
    {
        public static string FilenamePrefixText;
        public static string NumberIndex;

        #region Draggable Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private HashSet<Control> controlsToMove = new HashSet<Control>();


        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN &&
                 controlsToMove.Contains(Control.FromHandle(m.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }
        #endregion

        public ZoomSS()
        {
            InitializeComponent();
            TakeSS.Enabled = false;

            //UI Dynamic Updates
            Settings.MouseEnter += new EventHandler(Settings_MouseEnter);
            Settings.MouseLeave += new EventHandler(Settings_MouseLeave);
            infobutton.MouseEnter += new EventHandler(InfoButton_MouseEnter);
            infobutton.MouseLeave += new EventHandler(InfoButton_MouseLeave);

            //Window Drag
            Application.AddMessageFilter(this);
            controlsToMove.Add(this);
            controlsToMove.Add(IndexCount);
            controlsToMove.Add(label1);
            controlsToMove.Add(label3);

            //Preview on Hover
            CustomToolTip tip = new CustomToolTip();
            //tip.SetToolTip(button1, "text");
            //button1.Tag = Properties.Resources.pelican; // pull image from the resources file
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetBounds_Click(object sender, EventArgs e)
        {
            SnippingTool.Snip();
        }

        private void TakeSS_Click(object sender, EventArgs e)
        {
            string m = SnippingTool.TakeSS();
            while(m != "done")
            {
            }
            SetIndexValue();

        }

        private void FilenamePrefix_TextChanged(object sender, EventArgs e)
        {
            FilenamePrefixText = FilenamePrefix.Text;

            string check = FilenamePrefixText;
            if (!string.IsNullOrWhiteSpace(check) && check.All(char.IsLetter))
            {
                TakeSS.Enabled = true;
            }
            else
            {
                TakeSS.Enabled = false;
            }

            FilenamePrefixText = FilenamePrefix.Text;
        }


        public static string GetFilenamePrefix()
        {
            string answer = FilenamePrefixText;

            return answer;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void infobutton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }

        private void SetIndexValue()
        {
            IndexCount.Text = (Int32.Parse(SaveManager.ProcessPath("count")) - 1).ToString();
        }

        private void IndexCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void FilenamePrefix_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(FilenamePrefix, "Filename prefix works by saving the screenshot with the filename prefix plus appending a number to the end of it.");
        }

        #region UI Dynamic Updates

        #region Info Button
        void InfoButton_MouseLeave(object sender, EventArgs e)
        {
            this.infobutton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.info_idle));
        }

        void InfoButton_MouseEnter(object sender, EventArgs e)
        {
            this.infobutton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.info_hover));
        }
        #endregion

        #region Settings
        void Settings_MouseLeave(object sender, EventArgs e)
        {
            this.Settings.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.settings_idle));
        }

        void Settings_MouseEnter(object sender, EventArgs e)
        {
            this.Settings.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.settings_hover));
        }
        #endregion

        #endregion

        #region System Tray
        private void exit_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon.Visible = true;
        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon.Visible = false;
        }
        private void CMStray_Opening(object sender, CancelEventArgs e)
        {

        }
        private void exitapplication_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Dispose();
            Application.Exit();
        }

        #endregion

    }
    class CustomToolTip : ToolTip
    {
        public CustomToolTip()
        {
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        void OnPopup(object sender, PopupEventArgs e) // use this event to set the size of the tool tip
        {
            e.ToolTipSize = new Size(600, 1000);
        }

        void OnDraw(object sender, DrawToolTipEventArgs e) // use this to customzie the tool tip
        {
            Graphics g = e.Graphics;

            // to set the tag for each button or object
            Control parent = e.AssociatedControl;
            Image pelican = parent.Tag as Image;

            //create your own custom brush to fill the background with the image
            TextureBrush b = new TextureBrush(new Bitmap(pelican));// get the image from Tag

            g.FillRectangle(b, e.Bounds);
            b.Dispose();
        }
    }

}

