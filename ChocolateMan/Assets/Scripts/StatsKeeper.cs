using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StatsKeeper
{
    public static long chocolate = 50;
    public static long maxTankCapacity = 50;
    public static long chocolateInTank = 0;
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

    public static void MoreChocolateManual()
    {
        chocolate += chocolatePerClick;
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
        bool moreThanThousand = longValue >= 1_000;
        bool moreThanHundred = longValue >= 100;
        string stringValue = "";
        if(longValue >= 1_000_000_000_000_000_000)
        {
            long val = longValue % 1_000_000_000_000_000_000;
            stringValue += val;
            longValue -= val;
        }
        if(longValue >= 1_000_000_000_000_000)
        {
            long val = longValue % 1_000_000_000_000_000;
            stringValue += val;
            longValue -= val;
        }
        if(longValue >= 1_000_000_000_000)
        {
            long val = longValue % 1_000_000_000_000;
            stringValue += val;
            longValue -= val;
        }
        if(longValue >= 1_000_000_000)
        {
            long val = longValue % 1_000_000_000;
            stringValue += val;
            longValue -= val;
        }
        if(longValue >= 1_000_000)
        {
            long val = longValue % 1_000_000;
            stringValue += val;
            longValue -= val;
        }
        if(longValue >= 1_000)
        {
            long val = longValue % 1_000;
            stringValue += val;
            longValue -= val;
        }
        if(moreThanThousand && longValue < 100)
        {
            stringValue += "0";
        }
        if(moreThanHundred && longValue < 10)
        {
            stringValue += "0";
        }
        stringValue += longValue;
        return stringValue;
    }
}
