using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Example_Three
{
    public class HotelRoom
    {
        public int RoomNumber { get; set; }
        public bool IsBooked { get; private set; }
        public void MarkAsBooked()
        {
            IsBooked = true;
        }
    }
}
