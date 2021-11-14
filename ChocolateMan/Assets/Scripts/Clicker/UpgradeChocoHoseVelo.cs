using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeChocoHoseVelo : MonoBehaviour
{
    public Text text;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        text.text = "Fire Chocolate FAST (" + StatsKeeper.firingVelocityCost + ")";
    }

    // Update is called once per frame
    void Update()
    {
        if (StatsKeeper.chocolate >= StatsKeeper.firingVelocityCost)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    public void UpgradeMorePerMore()
    {
        if (StatsKeeper.chocolate > StatsKeeper.firingVelocityCost)
        {
            StatsKeeper.firingVelocity *= 2;
            StatsKeeper.chocolate -= StatsKeeper.firingVelocityCost;
            StatsKeeper.firingVelocityCost = StatsKeeper.CalculateNextUpgradeCost(StatsKeeper.firingVelocityCost);
            text.text = "Fire Chocolate FAST (" + StatsKeeper.firingVelocityCost + ")";
            if (StatsKeeper.chocolate < StatsKeeper.firingVelocityCost)
            {
                button.interactable = false;
            }
        }
    }
}
