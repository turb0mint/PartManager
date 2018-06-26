using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public sealed class PartsRegister
    {
        
        private static PartsRegister instance = null;
        private static readonly object padlock = new object();
        public List<SparePart> PartsList = new List<SparePart>();

        public event EventHandler<int> PartsListChange;


        private PartsRegister()
        {
           
        }

        public static PartsRegister Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PartsRegister();
                    }
                    return instance;
                }
            }
        }

        public void AddPart(SparePart Part)
        {
            PartsList.Add(Part);
            Refresh();
        }

        public void Refresh()
        {
            PartsListChange?.Invoke(this, 1);
        }

        public List<SparePart> GetParts()
        {
            return PartsList;
        }
    }
}
