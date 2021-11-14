using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChocoBuddyUpgradeHandler : MonoBehaviour
{
    public Text text;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        text.text = "FASTER BUDDIES (" + StatsKeeper.chocoBuddyUpgradeCost + ")";
    }

    // Update is called once per frame
    void Update()
    {
        if (StatsKeeper.chocolate >= StatsKeeper.chocoBuddyUpgradeCost)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    public void UpgradeWorkRate()
    {
        if (StatsKeeper.chocolate > StatsKeeper.chocoBuddyUpgradeCost)
        {
            StatsKeeper.chocoBuddyWorkRate *= 0.1f;
            StatsKeeper.chocolate -= StatsKeeper.chocoBuddyUpgradeCost;
            StatsKeeper.chocoBuddyUpgradeCost = StatsKeeper.CalculateNextUpgradeCost(StatsKeeper.chocoBuddyUpgradeCost);
            text.text = "FASTER BUDDIES (" + StatsKeeper.chocoBuddyUpgradeCost + ")";
            if (StatsKeeper.chocolate < StatsKeeper.chocoBuddyUpgradeCost)
            {
                button.interactable = false;
            }
        }
    }
}
