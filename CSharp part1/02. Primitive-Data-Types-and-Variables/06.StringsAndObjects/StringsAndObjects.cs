﻿/* Declare two string variables and assign them with Hello and World.
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting) */

using System;

class StringsAndObjects
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";
        object concatenation = str1 +" "+str2;
        string result = (string)concatenation;

    }
}
