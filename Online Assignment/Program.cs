using System;

namespace Online_Assignment
{
    
        class Program
        {
            static void Main()
            {
                FirstName ename = new FirstName();
                ename.evBannedUser += Warning;
                ename.User();
                Console.ReadLine();
            }
            static void Warning(object sender, BannedUserEventArgs e)
            {
                Console.WriteLine("{0}, you're Banned from the Organization", e.Name);
                

        }
        }

        public class FirstName
        {
            public event EventHandler<BannedUserEventArgs> evBannedUser;
            public void User()
            {
                Console.WriteLine("Please Enter You Name : ");
                string UserName =Console.ReadLine();
                UserName.ToLower();



                if (UserName == "jack" || UserName == "stephen" || UserName == "mathew")
                {
                    evBannedUser(this, new BannedUserEventArgs(UserName));
                }
                else
                {
                Console.WriteLine("{0}, you're Welcome!", UserName);
            }
            }
        }

        public class BannedUserEventArgs : EventArgs
        {
            public BannedUserEventArgs(string m)
            {
                Name = m;
            }
            public string Name { get; set; }
        }
    
}
