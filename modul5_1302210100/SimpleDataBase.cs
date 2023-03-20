using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210100
{
    internal class SimpleDataBase <T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }
        
        public void addData(T data, DateTime date)
        {
            this.storedData.Add(data);
            this.inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0;i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i + 1) + " berisi : " + this.storedData[i] + 
                    ", Yang di simpan pada Waktu UTC : " + this.inputDates[i]);
            }
        }
    }
}
