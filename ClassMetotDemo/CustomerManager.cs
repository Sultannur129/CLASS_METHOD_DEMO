using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {

        List<Customer> list = new List<Customer>();
        public void Set(Customer cm1)
        {
            

            list.Add(cm1);
        }
        public void Remove(Customer cm1)
        {
            list.Remove(cm1);

        }

        public void Write()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Id+" "+item.Name+" "+item.Surname+" "+item.age+" "+item.field);
            }
        }
    }
}
