using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaggageSortingSimulator.System;

namespace BaggageSortingSimulator.Model
{
    class Counter
    {
        private static int counterIncrementer = 1;
        private int counterId;
        private bool isOpen;
        LuggageFactory lf = new LuggageFactory();

        public int CounterId { get => counterId; set => counterId = value; }
        public bool IsOpen { get => isOpen; set => isOpen = value; }

        public Counter()
        {
            counterId = counterIncrementer++;
        }
            
        public void SendLuggage()
        {
            SortingMachine.Instance.Luggages.Enqueue(lf.CreateLuggage());
        }
    }
}
