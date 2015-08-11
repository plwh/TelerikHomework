﻿/*
A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console. */

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Doe";
        byte age = 34;
        char sex = 'm';
        long personalID = 8306112507;
        int employeeNumber = 27560000;
        Console.WriteLine(@"
First name:{0}
Last name:{1}
Age:{2}
Sex:{3}
Personal ID:{4}
Employee number:{5}",firstName,lastName,age,sex,personalID,employeeNumber);
    }
}
