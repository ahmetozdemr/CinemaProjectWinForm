using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectWinForm
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategotyId { get; set; }
        public int Price { get; set; }
        public string Time { get; set; }     
        public int MovieTheaterId { get; set; }
        public string FilmImage { get; set; }
    }
}
