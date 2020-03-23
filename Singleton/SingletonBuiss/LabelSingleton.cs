using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton.SingletonBuiss
{
    public class LabelSingleton
    {
        private static LabelSingleton instance = null;

        public string texto1 = "";
        public string texto2 = "";
        public string texto3 = "";
    
        public LabelSingleton()
        {
            using (Models.SingletonTxTContext  db = new Models.SingletonTxTContext())
            {
                var lstLabels = db.Label.ToList();

                texto1 = lstLabels.Where(d => d.Id == 1).First().Text;
                texto2 = lstLabels.Where(d => d.Id == 2).First().Text;
                texto3 = lstLabels.Where(d => d.Id == 3).First().Text;

            }

        }
        public static LabelSingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new LabelSingleton();
                return instance;
            }
        }
    }
}
