using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreekNakamaTorrentUpload.WinClass
{
    class AnimeList
    {
        public int Id { get; set; }
        public string AnimeName { get; set; }
        public string AnimeSlug { get; set; }

        public AnimeList()
        {
            //Empty
        }

        public AnimeList(int Id, string AnimeName, string AnimeSlug)
        {
            this.Id = Id;
            this.AnimeName = AnimeName;
            this.AnimeSlug = AnimeSlug;
        }


    }
}
