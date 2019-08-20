using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VideoGame
    {
        public VideoGame()
        { }
        public int id { get; set; }
        public String Name { get; set; }
        public string Platform { get; set; }
        public string ESRBRating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Developer { get; set; }

    }
}
