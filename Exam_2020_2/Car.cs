using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2020_2
{
    public abstract class Car
    {
        public bool isSedan;
        public string seats;
        // public string carName;

        // bu olduğu için wagon Ctor tek arg ile yazılabildi.
        public Car()
        {
        }

        public Car(bool isSedan, string seats)
        {
            this.isSedan = isSedan;
            this.seats = seats;
        }

        public bool getIsSedan()
        {
            return isSedan;
        }

        public string getSeats()
        {
            return seats;
        }

        public abstract string getMileage();
    }

    public class WagonR : Car
    {
        protected int mileage = 0;

        public WagonR(int mileage)
        {
            isSedan = false;
            seats = "4";
            this.mileage = mileage;
        }

        public override string getMileage()
        {
            return this.mileage.ToString() + "kmpl";
        }
    }


}
