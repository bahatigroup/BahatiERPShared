using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BahatiERP.Server.BaseClasses
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        protected void IncrementCount()
        {
            currentCount++;
        }

        protected int thread = 0;
        protected void Multithread()
        {

            for (int i = 1; i < 10; i++)
            {

                thread += 2;
            }
        }
    }
}
