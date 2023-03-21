using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210101
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase() { 
            storedData= new List<T>();
            inputDates = new List<DateTime>();
        }
        public void AddNewData(T X) { 
            storedData.Add(X); 
            inputDates.Add(DateTime.Now);
        }

        public void printAllData() { 
            for(int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine(storedData[i] +" yang disimpan pada waktu " + inputDates[i]);
            }
        }
    }
}
