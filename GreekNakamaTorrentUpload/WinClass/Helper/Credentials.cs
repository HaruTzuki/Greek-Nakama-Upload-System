//This is a class for Credentials to load and save

namespace GreekNakamaTorrentUpload.WinClass.Helper
{
    public class Credentials
    {
        public string WebImageFolder { get; set; } //Web Destination. Where can program find images
        public string FTPServer { get; set; } //FTP Server Adress e.g ftp://192.168.1.2
        public string FTPUsername { get; set; } //FTP Username
        public string FTPPassword { get; set; } //FTP Password
    }
}
