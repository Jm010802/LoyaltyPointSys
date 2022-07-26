using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using AppLayer;
using DataLayer;

namespace RewardPoints
{
    public class CreateUser
    {
        public static void UserCreation()
        {
            Console.WriteLine("Now we create a new user");

            List<string> dataList = new List<string>();

            string studNo;
            Console.WriteLine("Enter account name: ");
            studNo = Console.ReadLine().Trim();

            if (LPSValidator.ValidateLoginUser(studNo))
            {
                dataList.Add(studNo);
                Console.WriteLine("Successfully created your account");
                using (StreamWriter sw = new StreamWriter(File.Create("C:\\Users\\ADMIN\\source\\repos\\RewardPoints\\RewardPoints\\CreateUser.txt")))
                {
                    sw.WriteLine(studNo);
                    sw.Close();
                }
                Login.UserLogin();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return;
            }
        }
    }
}
