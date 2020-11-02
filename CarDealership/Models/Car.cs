using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class Car
    {
        [Key]
        public string _id { get; set; }

        public string Make { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        public double Price { get; set; }

        public bool HasSunRoof { get; set; }

        public bool IsFourWheelDrive { get; set; }

        public bool HasLowMiles { get; set; }

        public bool HasPowerWindws { get; set; }

        public bool HasNavigation { get; set; }

        public bool HasHeatedSeat { get; set; }
    }
}
