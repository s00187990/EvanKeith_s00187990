using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvanKeith_s00187990;

namespace DbManager
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneInfo db = new PhoneInfo();

            using (db) 
            {
                Phone p1 = new Phone() { Name = "Samsung S20", Price = 500, OperatingSystem = "Android", OS_Image = "/images/android.png", Phone_Image = "/images/s20.jpg" };
                Phone p2 = new Phone() { Name = "iPhone 11", Price = 600, OperatingSystem = "IOS", OS_Image = "/images/apple.png", Phone_Image = "/images/iPhone11.jpg" };

                db.phoneInfo.Add(p1);
                db.phoneInfo.Add(p2);

                db.SaveChanges();
            }
        }
    }
}
