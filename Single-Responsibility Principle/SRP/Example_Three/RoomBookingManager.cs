using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Example_Three
{
    public class RoomBookingManager
    {
        public bool BookRoom(HotelRoom room)
        {
            if (!room.IsBooked)
            {
                room.MarkAsBooked();
                return true;
            }
            return false;
        }
        public bool CheckAvailability(HotelRoom room)
        {
            return !room.IsBooked;
        }
    }
}
