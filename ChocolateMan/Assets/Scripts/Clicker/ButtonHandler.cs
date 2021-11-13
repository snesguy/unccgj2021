using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public BallSpawner ballSpawner;

    public void MoreChocolate()
    {
        StatsKeeper.MoreChocolateManual();
        ballSpawner.SpawnBall();
    }

    public void MoreTankFill()
    {
        StatsKeeper.FillTank(1_000_000_000_000_000_000);
    }

    public void MoreTankFill10()
    {
        StatsKeeper.FillTank(10);
    }

    public void MoreTankFill100()
    {
        StatsKeeper.FillTank(100);
    }

    public void MoreTankFill10000()
    {
        StatsKeeper.FillTank(10_000);
    }

    public void MoreTankFill100000000()
    {
        StatsKeeper.FillTank(100_000_000);
    }
}
