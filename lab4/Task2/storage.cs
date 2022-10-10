using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    public class Storage
    {
        List<Cars> cars;

        public Storage(Car car1, Car car2) : this(car1, car2, null)
        {

        }

        public Storage(Car car1, Car car2 , Car car3)
        {
            cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);

            if (car3 != null)
            carss.Add(car3);
        }

        public void ShowTree()
        {
            foreach (Car car in cars)
            {           
                car.ShowMethods();
            }
        }
    }
}