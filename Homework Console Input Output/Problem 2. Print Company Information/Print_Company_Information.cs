using System;

class Print_Company_Information
{
    static void Main()
    {
        Console.Write("Company name: ");
        string compName = Console.ReadLine();
        
        Console.Write("Company address: ");
        string compAddress = Console.ReadLine();
        
        Console.Write("Phone number: ");
        string phone = Console.ReadLine();
        
        Console.Write("Fax number: ");
        string Fax = Console.ReadLine();
        if (Fax == "")
        {
            Fax = "(no fax)";
        }
        Console.Write("Web site: ");
        string Web = Console.ReadLine();
        
        Console.Write("Manager first name: ");
        string firstName = Console.ReadLine();
        
        Console.Write("Manager last name: ");
        string lastName = Console.ReadLine();
        
        Console.Write("Manager age: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.Write("Manager phone: ");
        string managPhone = Console.ReadLine();


        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6}(age:\n {7}, tel. {8})", compName, compAddress, phone, Fax, Web, firstName, lastName, age, managPhone);
    }
}
