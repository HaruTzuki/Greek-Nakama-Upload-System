using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace GreekNakamaTorrentUpload.WinClass.Helper
{
    static class Helper
    {

        static public Exception LoadedError = new Exception("Error while load the file. Error code: 0x01.");

        static public void BrowseFiles(TextBox txt_torrent, Label lbl_file)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Torrent files|*.torrent";
                ofd.Multiselect = false;
                ofd.Title = "Browse the torrent file...";
                DialogResult DL = ofd.ShowDialog();
                if (DL == DialogResult.OK)
                {
                    txt_torrent.Text = ofd.FileName;
                    lbl_file.Text = ofd.SafeFileName;
                }

            }
        }


        static public void SaveToJson(string content)
        {
            string contentForSave = JsonConvert.SerializeObject(content, Formatting.Indented);
            File.WriteAllText("settings.json", contentForSave);
        }

        static public void SaveToJson(Credentials credentials)
        {
            string contentForSave = JsonConvert.SerializeObject(credentials, Formatting.Indented);
            File.WriteAllText("settings.json", contentForSave);
        }

        static public Credentials LoadFromJson()
        {
            Credentials loadedContents;
            loadedContents = JsonConvert.DeserializeObject<Credentials>(System.IO.File.ReadAllText("settings.json"));
            return loadedContents;
        }
    }
}
