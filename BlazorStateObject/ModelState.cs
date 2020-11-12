using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStateObject
{
    public class ModelState
    {
        public int Totalsum { get; set; } = 0;

        public void AddNumber(int number)
        {
            Totalsum += number;
        }
        public void ResetSum()
        {
            Totalsum = 0;
        }
    }
}
