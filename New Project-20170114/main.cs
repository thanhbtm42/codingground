using System.IO;
using System;

class Program
{
    static void Main()
    {
        int opt=0;
        String input;
        Console.WriteLine("Lab1: Programming with c#");
        Console.WriteLine("Student name: Nguyen Tuan Anh");
        Console.WriteLine("Student ID: SE01234");
        Console.WriteLine("Class ID: SE1009");
        Console.WriteLine("MENU");
        
        Console.WriteLine("1.	Register a staff");
        Console.WriteLine("2.	Register a product type");
        Console.WriteLine("3.	Register a product");
        Console.WriteLine("4.	Exit");
        Console.Write("Please enter 1, 2, 3, or 4:");
        input=Console.ReadLine();
        if(!Int32.TryParse(input, out opt))
        {
            Console.WriteLine("Please Enter 1 ,2 ,3 ,4!");
            Console.WriteLine("Please enter 1, 2, 3, or 4:");
        }
         switch (opt)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
    }
    void registerStaff(){
        String name;
        String address;
        String phone;
        String bankAccount;
        String isManager;
        Console.Write("Enter Staff name: ");
        name=Console.ReadLine();
        Console.Write("Enter Address: ");
        address=Console.ReadLine();
        Console.Write("Enter Phone: ");
        phone=Console.ReadLine();
        Console.Write("Enter Bank account: ");
        bankAccount=Console.ReadLine();
        Console.Write("Is manager (y/n): ");
        isManager=Console.ReadLine();
        Staff sf=new Staff(name,address,phone,bankAccount,isManager);
    }
    
    class Staff{
        public static int idFlag=0;
        int id;
        String name;
        String address;
        String phone;
        String bankAccount;
        String isManager;
        public Staff(String name, String address, String phone, String bankAccount, String isManager){
            this.name=name;
            this.address=address;
            this.phone=phone;
            this.bankAccount=bankAccount;
            this.isManager=isManager;
            this.id=idFlag;
            idFlag++;
        }
      
    }
}
