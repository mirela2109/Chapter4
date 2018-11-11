using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("CompanyName: ");
            string CompanyName = Console.ReadLine();
            Console.Write("CompanyAddress: ");
            string CompanyAddress = Console.ReadLine();
            Console.Write("CompanyPhone: ");
            string CompanyPhone = Console.ReadLine();
            Console.Write("CompanyFax: ");
            string CompanyFax = Console.ReadLine();
            Console.Write("CompanySite: ");
            string CompanySite = Console.ReadLine();

            Console.Write("ManagerFname: ");
            string ManagerFname = Console.ReadLine();
            Console.Write("ManagerLname: ");
            string ManagerLname = Console.ReadLine();
            Console.Write("ManagerPhone: ");
            string ManagerPhone = Console.ReadLine();
            string ManagerFullname = ManagerFname + " " + ManagerLname;
            Console.WriteLine("Company: {0},{1},{2},{3},{4}",CompanyName,CompanyAddress,CompanyPhone,
                CompanyFax,CompanySite);
            Console.WriteLine("Manager: {0},{1}",ManagerFullname,ManagerPhone);
        }
    }
}
