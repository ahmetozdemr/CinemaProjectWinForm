﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjectWinForm
{
    public class Seat
    {
        public int Id { get; set; }
        public int MovieTheaterId { get; set; }
        public bool CheckFill { get; set; }
    }
}
