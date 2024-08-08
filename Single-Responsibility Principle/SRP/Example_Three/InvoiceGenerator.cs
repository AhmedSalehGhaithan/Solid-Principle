using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Example_Three
{
    public class InvoiceGenerator
    {
        public string GenerateInvoice(HotelRoom room)
        {
            if (room.IsBooked)
            {
                // Logic to generate an invoice for the booked room
                return $"Invoice for Room {room.RoomNumber}";
            }
            return string.Empty;
        }
    }
}
