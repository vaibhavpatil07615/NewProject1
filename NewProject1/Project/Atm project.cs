using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1.Project
{
    public  class cardHolder
    {


        // withdraw,deposit,and check balance.
        string cardnum;
        int pin;
        string firstname;
        string lastname;
        double balance;
       // private static object currentUser;

        public cardHolder(string cardnum,int pin,string firstname,string lastname , double balance)
        {
            this.cardnum = cardnum;
            this.pin = pin;
            this.firstname = firstname;
            this.lastname = lastname;
            this.balance = balance;
        }
        public string getnum() // use diffrent get, set property for each parameter and call them in diffrent functions as per
                                 // requirement.
        {
               return cardnum;
        }
        public int getpin()
        {
            return pin;
        }
        public string getfirstname()
        {
            return firstname;
        }
        public string getlastname()
        {
            return lastname;
        }
        public double getbalance()
        {
            return balance;
        }
        public void setNum(string newCardNum) // set methods.
        {
            cardnum = newCardNum;
        }
        public void setPin(int newPin)
        {
            pin = newPin;
        }
        public void setFirstName(string newFirstName)
        {
            firstname = newFirstName;
        }
        public void setLastName(string newLastName)
        {
            lastname = newLastName;
        }
        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }

      public   static void Main(string[] args)
        {
            void printOptions() // menu.
            {
                Console.WriteLine("please choose from one of the following options");
                Console.WriteLine(" 1. Deposit");
                Console.WriteLine(" 2. Withdraw");
                Console.WriteLine(" 3. Show balance");
                Console.WriteLine(" 4.  Exit");


            }
            void deposit(cardHolder currentuser)
            {
                Console.WriteLine(" how much money you want  to deposit");
                double deposit = double.Parse(Console.ReadLine());
                currentuser.setBalance(deposit);
                Console.WriteLine(" thank you for deposit money. your new balance is :" + currentuser.getbalance());
            }

            void withdraw(cardHolder currentuser)
            {
                Console.WriteLine(" how much money you want to withdraw:");
                double withdraw = double.Parse(Console.ReadLine());
                // check user has enough money or not.
                if (currentuser.getbalance() < withdraw)
                {
                    Console.WriteLine("insuffficient balance....");
                }
                else
                {
                    
                    currentuser.setBalance(currentuser.getbalance() - withdraw); // balance after withdraw = getbalance- withdraw.
                    Console.WriteLine(" thank you..visit again..");
                }
            }
            void balance (cardHolder  currentuser)
            {
                Console.WriteLine(" current balance : " + currentuser.getbalance());

            }
            List<cardHolder> cardHolders = new List<cardHolder>(); // object of cardholder class in list format.
            cardHolders.Add(new cardHolder("12345678910",1234,"vaibhav","patil" , 10000));
            cardHolders.Add(new cardHolder("12345678911", 1235, "mayur", "sahu", 20000));
            cardHolders.Add(new cardHolder("12345678912", 1236, "ashwini", "bhalerav", 30000));
            cardHolders.Add(new cardHolder("12345678913", 1237, "madhuri", "mali", 40000));
            cardHolders.Add(new cardHolder("12345678914", 1238, "hitesh", "pawar", 50000));

            Console.WriteLine(" welcome to SBI ATM");
            Console.WriteLine(" please enter your debit card number");
            string debitcardNum = "";
            cardHolder currentuser;
            while (true)
            {
                try // when we try 
                {


                    debitcardNum = Console.ReadLine();
                    // check in db that number is right or not.
                    currentuser = cardHolders.FirstOrDefault(a => a.cardnum == debitcardNum);
                    if (currentuser != null) { break; }
                    else Console.WriteLine(" card not recognized.. please try again");


                }
                catch
               {
                    Console.WriteLine(" card not recognized.. please try again");

               }
            }
            Console.WriteLine(" enter your pin");
            int userPin = 0;
            while (true)
            {
              

                    userPin = int.Parse(Console.ReadLine());
                    // check in db that number is right or not.

                    if (currentuser.getpin() == userPin) { break; }
                    else Console.WriteLine(" Incorrect Pin.. please try again");


                
               
              
            }

                Console.WriteLine(" welcome " + currentuser.getfirstname() + "  :)");
                int option = 0;
                do
                {
                    printOptions();
                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    catch { }
                    if (option == 1) { deposit(currentuser); }
                    else if (option == 2) { withdraw(currentuser); }
                    else if (option == 3) { balance(currentuser); }
                    else if (option == 4) { break; }
                    else { option = 0; }



                }
                while (option != 4);
                Console.WriteLine(" thank you... visit again .. have a nice day..");

            













        }




    }
}
