using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;

namespace ZoomSS
{
    class SaveManager
    {
        private static string mainpath = Form3.MainPath();
        private static string prefix;

        private static string CheckDir()
        {
            //find or create a folder in main path with the date
            string Date = DateTime.Today.ToString("yyyy-MM-dd");
            string checkpath = System.IO.Path.Combine(mainpath, Date);

            if (Directory.Exists(checkpath))
            {
                return checkpath;
            }
            else
            {
                // create path then re run function
                System.IO.Directory.CreateDirectory(checkpath);
                return checkpath;
            }

        }

        public static string GetPath()
        {
            //process path and return it

            string givepath = ProcessPath("path");

            return givepath;
        }

        public static string ProcessPath(string GetWhat)
        {
            string path = CheckDir();
            prefix = ZoomSS.GetFilenamePrefix();

            if (path != null)//if there is a path
            {

                string[] files = Directory.GetFiles(path, prefix + "*.png");

                if (files.Length != 0)//if there is files that match the prefix then -->>>
                {
                    int count = 2;

                    while(File.Exists(Path.Combine(path, (prefix + count + ".png"))))
                    {
                        count = count + 1;
                    }

                    string filename = prefix + count + ".png";
                    string givepath = Path.Combine(path, filename);

                    if(GetWhat == "path")
                    {
                        return givepath;
                    }
                    else
                    {
                        return count.ToString();
                    }



                }
                else // if there is no files with the prefix then -->>>
                {

                    string filename = prefix + "1.png";
                    string givepath = Path.Combine(path, filename);

                    if (GetWhat == "path")
                    {
                        return givepath;
                    }
                    else
                    {
                        return "1";
                    }

                }

            }
            else //retry if no path
            {

                SnippingTool.TakeSS();

                if (GetWhat == "path")
                {
                    return null;
                }
                else
                {
                    return "0";
                }

            }
        }
    }
}