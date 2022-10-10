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
            return Speed() + 90;
        }
        public override void Repair()
        {
            condition += 70;
        }
        public int Speed()
        {
            return speed + 45;
        }
    }
}