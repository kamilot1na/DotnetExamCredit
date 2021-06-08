using System;
using System.Collections.Generic;
using System.Linq;

namespace DotnetExamConsole
{
    class Program
    {
        static List<string> TryAgainFio()
        {
            Console.WriteLine("\nTry again!!!");
            Console.Write("Write Your FIO right here in strong format <Surname Name Middlename>  ----> ");
            string fio = Console.ReadLine();
            List<string> fio_parse = fio.Split(' ').ToList();
            return fio_parse;
        }
        static List<string> TryAgainPass()
        {
            Console.WriteLine("\nTry again!!!");
            Console.Write(
                "Now, you need to enter your Passport information in format: <[Series number] [№] [Who given] [Date] [Info of registration]> ----->");
            string pass = Console.ReadLine();
            List<string> pass_parse = pass.Split(' ').ToList();
            return pass_parse;
        }

        static void ItsOk()
        {
            Console.WriteLine("\nIt's ok, lets go next!");
        }

        static void Main(string[] args)
        {
            var user = new User();
            var userInfo = new UserInfo();
            Console.WriteLine("---------------------------------------------------" +
                              "\nHello, this is an application that can help you get a loan " +
                              "\nWe need some info about you " +
                              "\nOk, lets do it!" +
                              "\nFirst of all we need your Passport Information" +
                              "\nFor all session I'll help you to write right information" +
                              "\nAll information you entering will be separated by spaces (It's very important!!!)");
            Console.Write("Write Your FIO right here in strong format <Surname Name Middlename>  ----> ");
            string fio = Console.ReadLine();
            List<string> fio_parse = fio.Split(' ').ToList();
            while (true)
            {
                if (fio_parse.Count == 3 && fio_parse[0] != null && fio_parse[1] != null && fio_parse[2] != null)
                {
                    ItsOk();
                    var user_fio = new Fio();
                    user_fio.Name = fio_parse[1];
                    user_fio.Surname = fio_parse[0];
                    user_fio.MiddleName = fio_parse[2];
                    user.Fio = user_fio;
                    break;
                }
                else
                {
                    fio_parse = TryAgainFio();
                }
            }

            Console.Write(
                "Now, you need to enter your Passport information in format: <[Series number] [№] [Who given] [Date] [Info of registration]> ----->");
            string pass = Console.ReadLine();
            List<string> pass_parsed = pass.Split(' ').ToList();
            while (true)
            {
                if (pass_parsed.Count == 5 && pass_parsed[0] != null && pass_parsed[1] != null &&
                    pass_parsed[2] != null && pass_parsed[3] != null && pass_parsed[4] != null)
                {
                    ItsOk();
                    var user_pass = new Passport();
                    user_pass.Series = pass_parsed[0];
                    user_pass.Number = pass_parsed[1];
                    user_pass.WhoGiven = pass_parsed[2];
                    user_pass.Date = pass_parsed[3];
                    user_pass.InfoOfReg = pass_parsed[4];
                    user.Passport = user_pass;
                    break;
                }
                else
                {
                    pass_parsed = TryAgainPass();
                }
            }

            Console.Write("Enter your age --->");
            string age = Console.ReadLine();
            while (true)
            {
                if (age != null)
                {
                    ItsOk();
                    user.Age = Convert.ToInt32(age);
                    break;
                }
                else
                {
                    Console.WriteLine("\nTry Again!!!");
                    age = Console.ReadLine();
                }
            }
            Console.Write("Are you convicted? Enter [+] or [-]   ---->");
            string isConvicted = Console.ReadLine();
            while (true)
            {
                if (isConvicted == "+" || isConvicted == "-")
                {
                    ItsOk();
                    if (isConvicted == "+")
                        userInfo.IsConvicted = true;
                    if (isConvicted == "-")
                        userInfo.IsConvicted = false;
                    break;
                }

                Console.WriteLine("\nTry Again!!)!");
                Console.WriteLine("Enter [+] or [-]");
                isConvicted = Console.ReadLine();
            }
            Console.Write("Enter your needed sum of credit in one number  ----->");
            string creditSum = Console.ReadLine();
            while (true)
            {
                if (creditSum != null)
                {
                    ItsOk();
                    userInfo.CreditSum = Convert.ToInt32(creditSum);
                    break;
                }
                else{
                Console.WriteLine("\nTry Again!!)!");
                Console.Write("Enter a number --->");
                creditSum = Console.ReadLine();
                }
            }
            Console.Write("Enter your Target of Credit in format: [Is Potreb = + or -] [Do you have prop = + or -] [Is it Re Credit = + or -]  ----->");
            string target = Console.ReadLine();
            List<string> target_parse = target.Split(' ').ToList();
            while (true)
            {
                if (target_parse.Count == 3 && (target_parse[0] == "+" || target_parse[0] == "-") &&  (target_parse[1] == "+" || target_parse[1] == "-") &&  (target_parse[2] == "+" || target_parse[2] == "-") )
                {
                    ItsOk();
                    var user_target = new Target();
                    if (target_parse[0] == "+")
                        user_target.IsPotreb = true;
                    else
                        user_target.IsPotreb = false;
                    if (target_parse[1] == "+")
                        user_target.HaveProperty = true;
                    else
                        user_target.HaveProperty = false;
                    if (target_parse[1] == "+")
                        user_target.IsReCredit = true;
                    else
                        user_target.IsReCredit = false;
                    userInfo.Target = user_target;
                    break;
                }
                else{
                    Console.WriteLine("\nTry Again!!)!");
                    Console.Write("Enter your Target of Credit in format: [Is Potreb = + or -] [Do you have prop = + or -] [Is it Re Credit = + or -]  ----->");
                    target = Console.ReadLine();
                    target_parse = target.Split(' ').ToList();
                }
            }
            Console.Write("Enter your Employment info in format: [Is Labor = + or -] [Have individual Company = + or -] [Are you frilance = + or -] [Do you have any job = + or -] ----->");
            string employ = Console.ReadLine();
            List<string> employ_parse = employ.Split(' ').ToList();
            while (true)
            {
                if (employ_parse.Count == 4 && (employ_parse[0] == "+" || employ_parse[0] == "-") &&  (employ_parse[1] == "+" || employ_parse[1] == "-") &&  (employ_parse[2] == "+" || employ_parse[2] == "-") &&  (employ_parse[3] == "+" || employ_parse[3] == "-") )
                {
                    ItsOk();
                    var user_employ = new Employment();
                    if (employ_parse[0] == "+")
                        user_employ.IsLabor = true;
                    else
                        user_employ.IsLabor = false;
                    if (employ_parse[1] == "+")
                        user_employ.HaveIp = true;
                    else
                        user_employ.HaveIp = false;
                    if (employ_parse[2] == "+")
                        user_employ.IsFrilance = true;
                    else
                        user_employ.IsFrilance = false;
                    if (employ_parse[3] == "+")
                        user_employ.IsUnemployment = true;
                    else
                        user_employ.IsUnemployment = false;
                    
                    userInfo.Employment = user_employ;
                    break;
                }
                else{
                    Console.WriteLine("\nTry Again!!)!");
                    Console.Write("Enter your Employment info in format: [Is Labor = + or -] [Have individual Company = + or -] [Are you frilance = + or -] [Do you have any job = + or -] ----->");
                    employ = Console.ReadLine();
                    employ_parse = employ.Split(' ').ToList();
                }
            }
            Console.Write("Do you have any another credits, enter in format: [+ or -]");
            string another = Console.ReadLine();
            while (true)
            {
                if (another != null && (another =="+" || another =="-"))
                {
                    ItsOk();
                    if (another == "+")
                        userInfo.HaveOtherCredits = true;
                    else{
                        userInfo.HaveOtherCredits = true;
                    }
                    break;
                }
                else{
                    Console.WriteLine("\nTry Again!!)!");
                    Console.Write("Enter your Employment info in format: [Is Labor = + or -] [Have individual Company = + or -] [Are you frilance = + or -] [Do you have any job = + or -] ----->");
                    employ = Console.ReadLine();
                    employ_parse = employ.Split(' ').ToList();
                }
            }
            Console.Write("Now, you need to enter your information about Zalog, enter in format: [Do you have a car: if you not enter a [-] else a car's age] [Do you have property = + or -] [Do you have a surety = + or -]   ----->");
            string zalog = Console.ReadLine();
            List<string> zalog_parse = zalog.Split(' ').ToList();
            while (true)
            {
                if (zalog_parse.Count == 3 && zalog_parse[0] != null && zalog_parse[1] != null &&
                    zalog_parse[2] != null)
                {
                    var user_zalog = new Zalog();
                    ItsOk();
                    var user_car = new Car();
                    if (zalog_parse[0] != "-")
                    {
                        user_car.Age = Convert.ToInt32(zalog_parse[0]);
                        user_zalog.Car = user_car;
                    }
                    else
                    {
                        user_car.Age = -1;
                        user_zalog.Car = user_car;
                    }
                    if (zalog_parse[1] == "+")
                    {
                        user_zalog.HaveProperty = true;
                    }
                    else
                    {
                        user_zalog.HaveProperty = false;
                    }
                    if (zalog_parse[2] == "+")
                    {
                        user_zalog.HaveSurety = true;
                    }
                    else
                    {
                        user_zalog.HaveSurety = false;
                    }

                    userInfo.Zalog = user_zalog;
                    break;

                }
                Console.WriteLine("\nTry Again!!)!");
                Console.Write("Now, you need to enter your information about Zalog, enter in format: [Do you have a car: if you not enter a [-] else a car's age] [Do you have property = + or -] [Do you have a surety = + or -]   ----->");
                zalog = Console.ReadLine();
                zalog_parse = zalog.Split(' ').ToList();
            }
            //// Time To calculate !!!
            userInfo.User = user;
            var score = 0;
            double precent = 0.3;
            var isGood = false;
            if(userInfo.User.Age >= 21 && userInfo.User.Age < 29){
                if (userInfo.CreditSum < 1000000)
                    score += 12;
                else if (userInfo.CreditSum >= 1000000 && userInfo.CreditSum <= 3000000)
                    score += 9;
            }

            if (userInfo.User.Age >= 29 && userInfo.User.Age < 60)
                score += 12;
            if (userInfo.User.Age >= 60 && userInfo.User.Age <= 72)
                if (userInfo.Zalog.HaveProperty || userInfo.Zalog.HaveSurety || userInfo.Zalog.Car.Age != -1)
                    score += 8;
            if (!userInfo.IsConvicted)
                score += 15;
            if (userInfo.Employment.IsLabor)
                score += 14;
            if (userInfo.Employment.HaveIp)
                score += 12;
            if (userInfo.Employment.IsFrilance)
                score += 8;
            if(userInfo.Employment.IsOld)
                if (userInfo.User.Age < 70)
                    score += 5;
            if (userInfo.Target.IsPotreb)
                score += 14;
            if (userInfo.Target.HaveProperty)
                score += 8;
            if (userInfo.Target.IsReCredit)
                score += 12;
            if (userInfo.Zalog.HaveProperty)
                score += 14;
            if (userInfo.Zalog.HaveSurety)
                score += 12;
            if (userInfo.Zalog.Car.Age < 3)
                score += 8;
            else
            {
                score += 3;
            }
            if(!userInfo.HaveOtherCredits)
                if (!userInfo.Target.IsReCredit)
                    score += 15;
            if (userInfo.CreditSum >= 0 && userInfo.CreditSum <= 1000000)
                score += 12;
            else if (userInfo.CreditSum >= 1000001 && userInfo.CreditSum <= 5000000)
                score += 14;
            else if (userInfo.CreditSum >= 5000001 && userInfo.CreditSum <= 10000000)
                score += 8;
            
            ////
            if (score > 80){
                isGood = true;
                if (score >= 84 && score <= 88)
                    precent = 0.26;
                else if (score > 88 && score <= 92)
                    precent = 0.22;
                else if (score > 92 && score <= 96)
                    precent = 0.19;
                else if (score > 96 && score < 100)
                    precent = 0.15;
                else if (score == 100)
                    precent = 0.125;
            }

            if (isGood)
            {
                Console.WriteLine("Ваш кредит одобрен!!! Cо ставкой " + precent*100 + "%");
                Console.WriteLine("Ваш балл потребителя составил: " + score);
            }
            else{
                Console.WriteLine("К сожалению, мы не можем одобрить ваш кредит");
                Console.WriteLine("Ваш балл потребителя составил: " + score);
            }
        }
    }
}