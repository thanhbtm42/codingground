using System.IO;
using System;
using System.Collections;

class Program
{
    
    static void Main()
    {
        int opt=0;
        String input;
        while(opt!=4){
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
                    registerStaff();
                    break;
                case 2:
                    registerType();
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
    }
    static void registerStaff(){
        
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
        String s = String.Format("{0,-6} {1,-15} {2,-15} {3,-15} {4,-15}", "id", "name", "phone","bankAccount","isManager");
         Console.WriteLine(s);
        Staff.printAll();
    }
    
    static void registerProduct(){
        
        int tID;
        String tname=null;
        String name;
        String descr;
        String userGuide;
        String country;
        int price;
        int sellPrice;
        while(name==null){
        Console.Write("Enter Type ID: ");
        tID=Console.ReadLine();
        tname=ProductType.checkType(tID);
        }
        Console.Write("Enter Address: ");
        address=Console.ReadLine();
        Console.Write("Enter Phone: ");
        phone=Console.ReadLine();
        Console.Write("Enter Bank account: ");
        bankAccount=Console.ReadLine();
        Console.Write("Is manager (y/n): ");
        isManager=Console.ReadLine();
        Staff sf=new Staff(name,address,phone,bankAccount,isManager);
        String s = String.Format("{0,-6} {1,-15} {2,-15} {3,-15} {4,-15}", "id", "name", "phone","bankAccount","isManager");
         Console.WriteLine(s);
        Staff.printAll();
    }
    
    static void registerType(){
        String name;
        Console.Write("Enter Product type name: ");
        name=Console.ReadLine();
        ProductType pt=new ProductType(name);
         String s = String.Format("{0,-6} {1,-15}", "Id", "Name");
           Console.WriteLine(s);
        ProductType.printAll();
    }
    
    class Staff{
        public static ArrayList staffList=new ArrayList();
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
            staffList.Add(this);
        }
        public static void printAll(){
            foreach(Staff s in staffList){
                Console.WriteLine(s);
            }
        }
        public override string ToString(){
            String s = String.Format("{0,-6} {1,-15} {2,-15} {3,-15} {4,-15} ", id, name,phone,bankAccount,isManager);
            return s;
        }
      
    }
    
    class ProductType{
        public static ArrayList typeList=new ArrayList();
        public static int idFlag=1;
        int id;
        String name;
        public ProductType(String name){
            this.id=idFlag;
            this.name=name;
            typeList.Add(this);
            idFlag++;
        }
        public int getId(){
            return id;
        }
        public String getName(){
            return name;
        }
         public static void printAll(){
            foreach(ProductType s in typeList ){
                Console.WriteLine(s);
            }
        }
        public override string ToString(){
            String s = String.Format("{0,-6} {1,-15}", id, name);
            return s;
        }
        public static String checkType(int id){
            foreach(ProductType s in typeList ){
               if(s.getId()==id){
                   return s.getName();
                   break;
               };
            }
            return null;
        }
    }
    class Product{
        public static ArrayList pList=new ArrayList();
        int tID;
        String name;
        String descr;
        String userGuide;
        String country;
        int price;
        int sellPrice;
        public Product(int tID, String name, String descr,String userGuide, String country, int price, int sellPrice){
            this.tID=tID;
            this.name=name;
            this.descr=descr;
            this.userGuide=userGuide;
            this.country=country;
            this.price=price;
            this.sellPrice=sellPrice;
            pList.Add(this);
        }
    }
}
