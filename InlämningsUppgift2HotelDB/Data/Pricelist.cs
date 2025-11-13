using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift2HotelDB.Data
{
    public class Pricelist
    {
        public const int SingleRoomPricePerNight = 700;
        public const int DoubleRoomPricePerNight = 1100;

        public static int GetTotalAmount(string roomType, int totalNights)
        {
            switch (roomType)
            {
                case "Enkelrum":
                    return SingleRoomPricePerNight * totalNights;
                    break;
                    case "Dubbelrum":
                    return DoubleRoomPricePerNight * totalNights;
                    break;
            }
            return 0;
        }

    }
}
