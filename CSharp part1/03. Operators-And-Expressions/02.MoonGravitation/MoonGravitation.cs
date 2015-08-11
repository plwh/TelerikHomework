/* The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth. */

using System;

class MoonGravitation
{
    static void Main()
    {
        Console.Write("Please enter your weight:");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = weightOnEarth * 0.17;
        Console.WriteLine("Weight on Earth:{0}\nWeight on Moon:{1}", weightOnEarth, weightOnMoon);
    }
}

