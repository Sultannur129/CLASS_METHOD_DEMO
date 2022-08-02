namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ali";
            customer1.Surname = "Bekçi";
            customer1.age = 26;
            customer1.field = "Mühendis";
            customer2.Id = 2;
            customer2.Name = "Veli";
            customer2.Surname = "Bekçi";
            customer2.age = 23;
            customer2.field = "İşçi";
            CustomerManager cma1=new CustomerManager();
            cma1.Set(customer1);
            cma1.Set(customer2);
            
            cma1.Write();
            Console.WriteLine("Müşteri Eklendi.");
            Console.WriteLine("------------------------------");
            cma1.Remove(customer1);
            cma1.Write();
            Console.WriteLine("Müşteri Silindi.");
            Console.WriteLine("------------------------------");

        }
    }
}