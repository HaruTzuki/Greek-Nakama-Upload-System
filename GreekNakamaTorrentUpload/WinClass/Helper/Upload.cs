using System;
using System.Net;
using System.Windows.Forms;

namespace GreekNakamaTorrentUpload.WinClass.Helper
{
    class Upload
    {
        //Varible
        private string _username;
        private string _password;
        private string _path;

        //Constructors

        public Upload() { }

        public Upload(string username, string password, string path)
        {
            this._username = username;
            this._password = password;
            this._path = path;
        }

        public void StartUploading(string filePath, string fileName)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Credentials = new NetworkCredential(_username, _password);
                    client.UploadFile("ftp://greek-nakama.com/public_html/blog/torrents/files/" + fileName, "STOR", filePath);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while uploading the file. Check your credentials or Internet Connection and try again.", "Error while uploading...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
