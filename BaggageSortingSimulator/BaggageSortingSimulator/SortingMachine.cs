using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaggageSortingSimulator.System;
using BaggageSortingSimulator.Model;

namespace BaggageSortingSimulator
{
    public class SortingMachine
    {
        private static SortingMachine instance;
        private DAL dal = new DAL();
        private Terminal term = new Terminal();
        public Queue<Luggage> Luggages = new Queue<Luggage>();
        List<Terminal> Terminals = new List<Terminal>();

        public static SortingMachine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SortingMachine();
                }
                return instance;
            }
        }
        private SortingMachine()
        {

        }
        public void SendToTerminal(int dest)
        {
            foreach(Luggage l in Luggages)
            {
                if (dal.Destinations.ContainsKey(l.Destination))
                {
                    //send to terminal
                    Terminals[l.Destination].TerminalConveyor.Enqueue(l);
                    
                }
                else
                {
                    //Send to lost and found
                }
            }

            
        }
        
        //public void SetTerminalStatus(int terminalNo)//Checks what status the terminal have
        //{

        //    switch (terminalNo)
        //    {
        //        case 0:
        //            Terminals.Add("Not Active");
        //            break;
        //        case 1:
        //            Terminals.Add(dal.GetDestination(0));
        //            break;
        //        case 2:
        //            Terminals.Add(dal.GetDestination(1));
        //            break;
        //        case 3:
        //            Terminals.Add(dal.GetDestination(2));
        //            break;
        //        case 4:
        //            Terminals.Add(dal.GetDestination(3));
        //            break;
        //        case 5:
        //            Terminals.Add(dal.GetDestination(4));
        //            break;
        //        case 6:
        //            Terminals.Add(dal.GetDestination(5));
        //            break;
        //        case 7:
        //            Terminals.Add(dal.GetDestination(6));
        //            break;
        //        case 8:
        //            Terminals.Add(dal.GetDestination(7));
        //            break;
                    
        //    }

        //}
        
    }
    
}
