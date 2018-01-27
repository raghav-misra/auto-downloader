using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDownloader
{
    public partial class DownloadButton : Button
    {
        public DownloadButton()
        {
            InitializeComponent();
            BackColor = Color.White;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = Color.Black;
        }

        public DownloadButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        [Category("DownloadSettings")]
        public Uri FileInfoURL { get; set; }

        [Category("DownloadSettings")]
        public string SaveFileName { get; set; }

        [Category("DownloadSettings")]
        public decimal AssemblyVersion { get; set; }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            AutoUpdate.Update(FileInfoURL, AssemblyVersion, SaveFileName);
        }
    }
}
