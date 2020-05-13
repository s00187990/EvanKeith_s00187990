using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvanKeith_s00187990
{
    public class Phone
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public void IncreasePrice(int percentage)
        {
            Price += (percentage / Price) * 100;
        }


    }
}
