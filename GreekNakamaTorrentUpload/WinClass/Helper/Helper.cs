using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreekNakamaTorrentUpload.WinClass.Helper
{
    static class Helper
    {
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
                    lbl_file.Text = "File Name : " + ofd.SafeFileName;
                }

            }
        }


        static public void SaveToJson(string content)
        {
            string contentForSave = JsonConvert.SerializeObject(content, Formatting.Indented);
            File.WriteAllText("settings.json", contentForSave);
        }

        static public void SaveToJson(string[] contents)
        {
            string contentForSave = JsonConvert.SerializeObject(contents.ToArray(), Formatting.Indented);
            File.WriteAllText("settings.json", contentForSave);
        }

        static public string LoadFromJson()
        {
            string loadedContents;
            try
            {
                loadedContents = JsonConvert.DeserializeObject<string>(System.IO.File.ReadAllText("settings.json"));
            }
            catch (Exception)
            {
                return "0x01";
            }

            return loadedContents;
        }
    }
}
