using BaggageSortingSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaggageSortingSimulator.ViewModel
{
    public class ViewModel : ViewModelBase
    {
        private int[] trucks = new int[9];
        public ViewModel()
        {
            Trucks[1] = 10;
            Trucks[2] = 11;
        }

        public int[] Trucks
        {
            get { return trucks; }
            set
            {
                trucks = value;
                OnPropertyChanged();
            }
        }

        private void CollectionChanged(object sender, EventArgs e)
        {
            CollectionEventArgs ea = (CollectionEventArgs)e;
            //foreach (Terminal terminal in ea.TerminalList)
            //{
            //    Trucks[terminal.TerminalNumber] = (terminal.LuggageToBeBoarded.Count);
            //}
            switch (ea.TerminalNumber)
            {
                case 1:
                    Trucks[1] = ea.LuggageList.Count;
                    break;
                case 2:
                    Trucks[2] = ea.LuggageList.Count;
                    break;
                case 3:
                    Trucks[3] = ea.LuggageList.Count;
                    break;
                case 4:
                    Trucks[4] = ea.LuggageList.Count;
                    break;
                case 5:
                    Trucks[5] = ea.LuggageList.Count;
                    break;
                case 6:
                    Trucks[6] = ea.LuggageList.Count;
                    break;
                case 7:
                    Trucks[7] = ea.LuggageList.Count;
                    break;
                case 8:
                    Trucks[8] = ea.LuggageList.Count;
                    break;
                default:
                    break;
            }
        }
    }
}
