using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaggageSortingSimulator.Model
{
    public class CollectionEventArgs : EventArgs
    {
        List<Luggage> luggageList;
        int terminalNumber;

        public List<Luggage> LuggageList { get => luggageList; set => luggageList = value; }
        public int TerminalNumber { get => terminalNumber; set => terminalNumber = value; }

        public CollectionEventArgs(List<Luggage> luggage, int terminalNumber)
        {
            LuggageList = luggage;
            TerminalNumber = terminalNumber;
        }
    }
}
