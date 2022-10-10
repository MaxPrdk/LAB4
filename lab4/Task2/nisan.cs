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
            return Speed() + 110;
        }
public override void Repair()
        {
            condition += 50;
        }

        public int Speed()
        {
            return speed + 60;
        }
    }
}