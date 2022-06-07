using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PSD
{
    internal class Program
    {
        static Customer customer;
        static Random rand = new Random();
        static List<Clothes> shoppingCart = new List<Clothes>();

        //main
        static void Main(string[] args)
        {
            customerLogin();
            greetCust();

            int inpMenu = 0;
            do
            {
                printMenu();
                inpMenu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (inpMenu)
                {
                    case 1:
                        printCategoryProduct();
                        break;
                    case 2:
                        shoppingCartMenu();
                        break;
                }
            } while (inpMenu != 3);

        }
        //end of main

        //print menu
        static void printMenu()
        {
            Console.WriteLine("E - Commerce Pakaian");
            Console.WriteLine("====================");
            Console.WriteLine("1. Buy Clothes");
            Console.WriteLine("2. Shopping Cart");
            Console.WriteLine("3. Exit");
            Console.Write("Choose >> ");
        }
        //end of print menu

        //category
        static void printCategoryProduct()
        {
            int inpMenu=0;

            do
            {
                Console.WriteLine("=====Clothes=====");
                Console.WriteLine("Pilih Kategori Pakaian");
                Console.WriteLine("1. T - Shirts");
                Console.WriteLine("2. Jackets");
                Console.WriteLine("3. Dress");
                Console.WriteLine("4. Jeans");
                Console.WriteLine("5. Shorts");
                Console.WriteLine("6. Exit");
                Console.Write("Choose >> ");
                inpMenu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (inpMenu)
                {
                    case 1:
                        Console.WriteLine("===Clothes===");
                        Console.WriteLine("=T - Shirts=");
                        Console.WriteLine("=1000=");
                        
                        string inpUkuranTShirt = "";
                        
                        do
                        {
                            Console.Write("Choose Size T-Shirt [XS/S/M/L/XL/XXL]: ");
                            inpUkuranTShirt = Console.ReadLine();
                        } while (!inpUkuranTShirt.Equals("XS") && !inpUkuranTShirt.Equals("S") && !inpUkuranTShirt.Equals("M") && !inpUkuranTShirt.Equals("L") && !inpUkuranTShirt.Equals("XL") && !inpUkuranTShirt.Equals("XXL"));
                        
                        string colorTshirt = clothesColor();
                        if (shoppingCartValidation())
                        {
                            shoppingCart.Add(new Clothes("T-shirt",inpUkuranTShirt,1000,colorTshirt));
                            Console.WriteLine("Success add to shopping cart");
                        }
                        break;

                    case 2:
                        Console.WriteLine("===Clothes===");
                        Console.WriteLine("=Jacket=");
                        Console.WriteLine("=5000=");
                        string inpUkuranJacket= "";
                        do
                        {
                            Console.Write(" Pilih ukuran Jackets [XS/S/M/L/XL/XXL] >> ");
                            inpUkuranJacket = Console.ReadLine();
                        } while (!inpUkuranJacket.Equals("XS") && !inpUkuranJacket.Equals("S") && !inpUkuranJacket.Equals("M") && !inpUkuranJacket.Equals("L") && !inpUkuranJacket.Equals("XL") && !inpUkuranJacket.Equals("XXL"));
                        string colorJacket = clothesColor();

                        if (shoppingCartValidation())
                        {
                            shoppingCart.Add(new Clothes("Jacket",inpUkuranJacket,5000,colorJacket));
                            Console.WriteLine("Success add to shopping cart");
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine("===Clothes===");
                        Console.WriteLine("=Dress=");
                        Console.WriteLine("=10000=");
                        string inpUkuranDress="";
                        do
                        {
                            Console.Write(" Pilih ukuran Dress [XS/S/M/L/XL/XXL] >> ");
                            inpUkuranDress = Console.ReadLine();
                        } while (!inpUkuranDress.Equals("XS") && !inpUkuranDress.Equals("S") && !inpUkuranDress.Equals("M") && !inpUkuranDress.Equals("L") && !inpUkuranDress.Equals("XL") && !inpUkuranDress.Equals("XXL"));
                        string colorDress = clothesColor();
                        if (shoppingCartValidation())
                        {
                            shoppingCart.Add(new Clothes("Dress", inpUkuranDress, 10000, colorDress));
                            Console.WriteLine("Success add to shopping cart");
                        }
                        break;
                    case 4:
                        Console.WriteLine("===Clothes===");
                        Console.WriteLine("=Jeans=");
                        Console.WriteLine("=8000=");
                        string inpUkuranJeans="";
                        do
                        {
                            Console.Write(" Pilih ukuran Jeans [XS/S/M/L/XL/XXL] >> ");
                            inpUkuranJeans = Console.ReadLine();
                        } while (!inpUkuranJeans.Equals("XS") && !inpUkuranJeans.Equals("S") && !inpUkuranJeans.Equals("M") && !inpUkuranJeans.Equals("L") && !inpUkuranJeans.Equals("XL") && !inpUkuranJeans.Equals("XXL"));
                        string colorJeans = clothesColor();
                        if (shoppingCartValidation())
                        {
                            shoppingCart.Add(new Clothes("Jeans", inpUkuranJeans, 8000, colorJeans));
                            Console.WriteLine("Success add to shopping cart");
                        }
                        break;
                    case 5:
                        Console.WriteLine("===Clothes===");
                        Console.WriteLine("=Shorts=");
                        Console.WriteLine("=5000=");
                        string inpUkuranShorts="";
                        do
                        {
                            Console.Write(" Pilih ukuran Shorts [XS/S/M/L/XL/XXL] >> ");
                            inpUkuranShorts = Console.ReadLine();
                        } while (!inpUkuranShorts.Equals("XS") && !inpUkuranShorts.Equals("S") && !inpUkuranShorts.Equals("M") && !inpUkuranShorts.Equals("L") && !inpUkuranShorts.Equals("XL") && !inpUkuranShorts.Equals("XXL"));
                        string colorShorts = clothesColor();
                        if (shoppingCartValidation())
                        {
                            shoppingCart.Add(new Clothes("Shorts", inpUkuranShorts, 5000, colorShorts));
                            Console.WriteLine("Success add to shopping cart");
                        }
                        break;
                }

            } while (inpMenu != 6);
        }
        //Input Color
        static string clothesColor()
        {
            string inpColor = "";
            do
            {
                Console.Write("Choose Your Color [Black | White | Blue]: ");
                inpColor = Console.ReadLine();
            } while (!inpColor.Equals("Black") && !inpColor.Equals("White") && !inpColor.Equals("Blue"));
            return inpColor;
        }
        //End Color

        //Validation
        static bool shoppingCartValidation()
        {
            string inpValidation;
            do
            {
                Console.Write("Masukkan pakaian kedalam Shopping Cart [Yes/No] >>  ");
                inpValidation = Console.ReadLine();
            } while (!inpValidation.Equals("Yes") && !inpValidation.Equals("No"));

            if (inpValidation.Equals("Yes")){
                return true;
            }
            return false;
        }
        //end Validation

        //customer
        public static void customerLogin()
        {
            string customerName = "";
            string customerID = "";
            int customerAge = 0;
            string customerAddress = "";
            string customerPhone = "";
            int customerBalance = 0;
            do
            {
                Console.Write("Insert customer name [length must be 5 to 20]: ");
                customerName = Console.ReadLine();
            } while (customerName.Length < 5 || customerName.Length > 20);
            do
            {
                Console.Write("Insert customer phone [length must less than 13]: ");
                customerPhone = Console.ReadLine();
            } while (customerPhone.Length > 13);
            do
            {
                Console.Write("Insert customer Address [must start with Jalan]: ");
                customerAddress = Console.ReadLine();
            } while (!customerAddress.StartsWith("Jalan"));
            do
            {
                Console.Write("Insert customer Balance [balance > 0]: ");
                customerBalance = Convert.ToInt32(Console.ReadLine());
            } while (customerBalance <= 0);
            Console.Write("input customer age: ");
            customerAge = Convert.ToInt32(Console.ReadLine());
            customerID = "CS" + rand.Next(0,10) + rand.Next(0,10) + rand.Next(0,10);
            customer = new Customer(customerID,customerName,customerAge,customerPhone,customerAddress, customerBalance);

            Console.WriteLine();
            
        }
        //end customer

        //greet customer
        public static void greetCust()
        {
            Console.WriteLine("Customer Data");            
            Console.WriteLine("=============");
            Console.WriteLine("Customer ID      : {0}", customer.customerID);
            Console.WriteLine("Customer Name    : {0}", customer.customerName);
            Console.WriteLine("Customer Age     : {0}", customer.customerAge);
            Console.WriteLine("Customer Phone   : {0}", customer.customerPhone);
            Console.WriteLine("Customer Address : {0}", customer.customerAddress);
            Console.WriteLine("Customer Balance : {0}", customer.customerBalance);
            Console.WriteLine("Enjoy your time at our store {0}!!",customer.customerName);
            Console.WriteLine();
        }
        //end greet 

        // view shopping cart
        public static void view()
        {
            int number = 1;
            Console.WriteLine("Shopping Cart");
            Console.WriteLine("===========================");
            foreach (var data in shoppingCart)
            {
                Console.WriteLine("Order {0}", number++);
                Console.WriteLine("Clothes Name : {0}", data.clothesName);
                Console.WriteLine("Clothes Size : {0}", data.clothesSize);
                Console.WriteLine("Clothes Color: {0}", data.clothesColor);
                Console.WriteLine("Clothes Price: {0}", data.clothesPrice);
                Console.WriteLine("===========================\n");

            }
            Console.WriteLine();
        }
        //end shopping cart

        public static void shoppingCartMenu()
        {
            view();

            int inpMenu = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("E - Commerce Menu");
                Console.WriteLine("===================");
                Console.WriteLine("Balance : {0}", customer.customerBalance);
                Console.WriteLine("1. Remove Product");
                Console.WriteLine("2. Order");
                Console.WriteLine("3. Exit");
                Console.Write("Choose >> ");
                inpMenu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch(inpMenu){
                    case 1:
                        remove();
                        break;
                    case 2:
                        order();
                        break;
                }
            } while (inpMenu != 3);
        }

        //Remove product
        public static void remove()
        {
            int productRemove;

            if (!shoppingCart.Any())
            {
                Console.WriteLine("Your shopping cart is empty!");
                return;
            } else
            {
                do
                {
                    Console.Write("Select The Product Number that you want to remove : ");
                    productRemove = Convert.ToInt32(Console.ReadLine());
                } while (productRemove < 1 || productRemove > shoppingCart.Capacity);

                shoppingCart.RemoveAt(productRemove - 1);
                Console.WriteLine("The Product has been successfully removed...");
                Console.WriteLine();

                view();
                Console.WriteLine();
            }

        }
       //end Remove
      
        public static void order()
        {
            int totalPrice = 0;
            if (!shoppingCart.Any())
            {
                Console.WriteLine("Your shopping cart is empty!");
                return;
            }
            else{
                foreach (var item in shoppingCart)
                {
                    totalPrice += item.clothesPrice;
                }
                Console.WriteLine("Total Price of your Shopping Cart : " + totalPrice);
                orderValidation(totalPrice);
            }
        }
        public static void orderValidation(int totalPrice)
        {
            string inpValidationOption = "";
            do
            {
                Console.Write("Order all the clothes ? [Yes/No] : ");
                inpValidationOption = Console.ReadLine();
            } while (!inpValidationOption.Equals("Yes") && !inpValidationOption.Equals("No"));

            if (inpValidationOption.Equals("Yes"))
            {              
                if (customer.customerBalance < totalPrice)
                {
                    Console.WriteLine("Your balance is insufficient");
                    return;
                }
                else
                {
                   customer.customerBalance -= totalPrice;
                   Console.WriteLine("Order Succesfully added");
                   shoppingCart.Clear();
                   Console.WriteLine();
                }
            } else {
                return;
            }

            
        }

    }
}
