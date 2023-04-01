using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectWinForm
{
    public class Room
    {
        public string Name { get; set; }
        public List<Seat> Seats { get; set; }

        public Room(string name, int numSeats)
        {
            Name = name;
            Seats = new List<Seat>();

            for (int i = 1; i < numSeats; i++)
            {
                Seats.Add(new Seat(i));
            }
        }
    }
}
