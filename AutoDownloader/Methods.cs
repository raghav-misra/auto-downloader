using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace AutoDownloader
{
    public class AutoUpdate
    {
        private static byte[] GetFileViaHTTP(Uri WebURL)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadData(WebURL);
            }
        }

        private static List<string> CreateList(Uri WebURL)
        {
            var result = GetFileViaHTTP(WebURL);
            string str = Encoding.UTF8.GetString(result);
            string[] strArr = str.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<string> almo = new List<string>();
            almo.AddRange(strArr);
            var final = new List<string>();
            foreach (string x in almo)
            {
                final.Add(x.Trim());
            }
            return final;

        }

        public static void Update(Uri InfoFileURL, Decimal CurrentVersion, String DownloadFileName)
        {
            var list = CreateList(InfoFileURL);
            if (list.Count != 2)
            {
                MessageBox.Show("Invalid File Layout", "Oops! An Unexpected Error Occurred:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!(list[0].StartsWith("(DownloadURL): ") & list[1].StartsWith("(Version): ")))
            {
                MessageBox.Show("Invalid File Layout", "Oops! An Unexpected Error Occurred:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string link = list[0].Substring(15);
            string version = list[1].Substring(12);
            decimal decversion = Convert.ToDecimal(version);

            if (decversion <= CurrentVersion)
            {
                return;
            }

            var check = MessageBox.Show("The latest version is v" + version + "\nDownload?", "Latest Version", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (check == DialogResult.No | check == DialogResult.Abort)
            {
                return;
            }

            using (var client = new WebClient())
            {
                client.DownloadFile(link, DownloadFileName);
                MessageBox.Show("Download Successful", "Yay!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
