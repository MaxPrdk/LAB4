using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Toyota : Car
    {
        public override int CalculateSpeed()
        {
            return Speed() + 100;
        }
        public override void Repair()
        {
            condition += 30;
        }
        public int Speed()
        {
            return speed + 50;
        }
    }
}