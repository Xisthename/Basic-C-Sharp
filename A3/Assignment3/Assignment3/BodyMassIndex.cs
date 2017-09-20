using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /// <summary>
    /// Daniel Petersén
    /// 2017-09-18
    /// </summary>
    class BodyMassIndex
    {
        private String name;
        private bool metricUnits;
        private double height;
        private double weight;

        public void SetName(String name)
        {
            this.name = name;
        }

        public void SetUnit(bool metricUnits)
        {
            this.metricUnits = metricUnits;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public void SetWeight(double weight)
        {
            this.weight = weight;
        }



        public String GetName()
        {
            return name;
        }

        public double GetHeight()
        {
            return height;
        }

        public double GetWeight()
        {
            return weight;
        }
    }
}
