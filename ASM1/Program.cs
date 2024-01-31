// See https://aka.ms/new-console-template for more information
using System.Net.Sockets;

Console.WriteLine("Program for calculating water bill");

void WaterBill()
{
    Console.Write("Enter customer's name: ");
    string customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Please choose the type of customer.");
    Console.WriteLine("Enter 1 if you are Household customer.");
    Console.WriteLine("Enter 2 if you are Administrative agency, public services.");
    Console.WriteLine("Enter 3 if you are Production units.");
    Console.WriteLine("Enter 4 if you are Business services.");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {
        //Household customer
        //Required number of family members
        Console.WriteLine("Enter number of family members: ");
        int numberMember = Convert.ToInt32(Console.ReadLine());
        if (numberMember >= 1)
        {
            Console.WriteLine("Enter last month's water number: ");
            int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            if (waterNumberLastMonth >= 0)
            {
                Console.WriteLine("Enter this month's water number: ");
                int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
                if (waterNumberLastMonth <= waterNumberCurrentMonth)
                {
                    int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
                    double waterNumberPeople = waterNumber / numberMember;
                    double money = 0;
                    if (waterNumberPeople > 0 && waterNumber <= 10)
                    {
                        money = waterNumber * 5973 * 1.1;
                    }
                    else if (waterNumberPeople > 20 && waterNumberPeople <= 30)
                    {
                        money = waterNumber * 8699 * 1.1;
                    }
                    else
                    {
                        money = waterNumber * 15929 * 1.1;
                    }
                    Console.WriteLine("Your family's water bill is: {0} dong", money);
                }
                else
                {
                    Console.WriteLine("Last month's water number can't be bigger than this month's");
                }
            }
            else
            {
                Console.WriteLine("Water number can't be negative.");
            }
        }
        else
        {
            Console.WriteLine("Family member can't be smaller than 1");
        }
    }
    else if (typeCustomer == 2)
    {
        //Administrative agency, public services
        Console.WriteLine("Enter last month's water number: ");
        int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
        if (waterNumberLastMonth >= 0)
        {
            Console.WriteLine("Enter this month's water number: ");
            int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterNumberLastMonth <= waterNumberCurrentMonth)
            {
                int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
                double money = 0;
                money = waterNumber * 9955 * 1.1;
                Console.WriteLine("Your administrative agency or public service's water bill is: {0} dong", money);
            }
            else
            {
                Console.WriteLine("Last month's water number can't be bigger than this month's");
            }
        }
        else
        {
            Console.WriteLine("Water number can't be negative.");
        }
    }
    else if (typeCustomer == 3)
    {
        //Production units
        Console.WriteLine("Enter last month's water number: ");
        int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
        if (waterNumberLastMonth >= 0)
        {
            Console.WriteLine("Enter this month's water number: ");
            int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterNumberLastMonth <= waterNumberCurrentMonth)
            {
                int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
                double money = 0;
                money = waterNumber * 11615 * 1.1;
                Console.WriteLine("Your production unit's water bill is: {0} dong", money);
            }
            else
            {
                Console.WriteLine("Last month's water number can't be bigger than this month's");
            }
        }
        else
        {
            Console.WriteLine("Water number can't be negative.");
        }
    }
    else if (typeCustomer == 4)
    {
    //Business services
    Console.WriteLine("Enter last month's water number: ");
    int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
    if (waterNumberLastMonth >= 0)
    {
        Console.WriteLine("Enter this month's water number: ");
        int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterNumberLastMonth <= waterNumberCurrentMonth)
        {
            int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
            double money = 0;
            money = waterNumber * 22068 * 1.1;
            Console.WriteLine("Your business service's water bill is: {0} dong", money);
        }
        else
        {
            Console.WriteLine("Last month's water number can't be bigger than this month's");
        }
    }
    else
    {
        Console.WriteLine("Water number can't be negative.");
    }

    }
    else
    {
        Console.WriteLine("Please enter a valid number from 1 to 4.");
    }
}

//Run the program
WaterBill();