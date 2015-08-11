using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Please enter your birthdate in format (dd.MM.yyyy):");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Today;
        int age = today.Year - birthday.Year;
        if (birthday > today.AddYears(-age)) age--;
        Console.WriteLine("Your current age is:{0}. Your age after ten years will be:{1}",age,age+10);
    }
     
}

