using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectWinForm
{
    public class Seat
    {
        public int Number { get; set; }
        public bool Reserved { get; set; }

        public Seat(int number)
        {
            Number = number;
            Reserved = false;
        }

    }
}
