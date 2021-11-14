using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StatsKeeper
{
    public static long chocolate = 50;
    public static long maxTankCapacity = 50;
    public static long ChocoTankSizeUpgradeCost = 50;
    public static long chocolateInTank = 50;
    public static long day = 1;
    public static long chocolatePerClick = 1;
    public static long chocolatePerClickCost = 100;
    public static float firingVelocity = 5.0f;
    public static long firingVelocityCost = 20;
    public static long chocolatePerSecond = 2;
    public static long chocolatePerScondCost = 25;
    public static float chocolateSize = 1.0f;
    public static long chocolateSizeCost = 1;
    public static float chocolateSizeRamp = 1.1f;
    public static int chocoBuddyCount = 1;
    public static float chocoBuddyWorkRate = 10.0f;
    public static long chocoBuddyUpgradeCost = 1000;

    public static void MoreChocolateManual()
    {
        chocolate += chocolatePerClick;
    }

    public static void MoreChocolateBuddy()
    {
        chocolate += chocoBuddyCount;
    }

    public static void FillTank(long amount)
    {
        if(amount > chocolate)
            amount = chocolate;
        if(amount > maxTankCapacity - chocolateInTank)
            amount = maxTankCapacity - chocolateInTank;
        chocolateInTank += amount;
        chocolate -= amount;
    }

    public static long CalculateNextUpgradeCost(long previousCost, float ramp=2.2f)
    {
        return (long)(previousCost * ramp);
    }

    public static string LongToText(long longValue)
    {
        string stringValue = longValue.ToString();

        for(int i = stringValue.Length; i > 3; i -= 3)
        {
            stringValue = stringValue.Insert(i-3, ",");
        }

        return stringValue;
    }
}
