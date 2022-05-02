using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Services
{

    internal class SimpleRandom : IRandom
    {
        private double state;
        public SimpleRandom()
        {
            state = DateTime.Now.Ticks / 1000.0;
        }
        public double NextDouble()
        {
            state = (state + Math.PI) * state;
            state = state - Math.Floor(state);
            return state;
        }
    }

}
