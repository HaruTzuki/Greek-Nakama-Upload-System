namespace GreekNakamaTorrentUpload.WinClass
{
    public static class Queries
    {
        public static string LoadComboBox()
        {
            return "SELECT * FROM gn_anime";
        }

        public static string InsertToDatabase(string name, string downloadLink, string imageLink, string uploadDate)
        {
            return "INSERT INTO tracker (name, downloadlink, imageLink, uploadDate) VALUES (" +
                "'" + name + "'" +
                ",'" + downloadLink + "'" +
                ",'" + imageLink + "'" +
                ",'" + uploadDate + "'" +
                ")";

        }
    }
}
