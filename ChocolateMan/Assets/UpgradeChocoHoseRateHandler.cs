using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeChocoHoseRateHandler : MonoBehaviour
{
    public Text text;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        text.text = "Fire MORE Chocolate (" + StatsKeeper.chocolatePerScondCost + ")";
    }

    // Update is called once per frame
    void Update()
    {
        if (StatsKeeper.chocolate >= StatsKeeper.chocolatePerScondCost)
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
        if (StatsKeeper.chocolate > StatsKeeper.chocolatePerScondCost)
        {
            StatsKeeper.chocolatePerSecond *= 2;
            StatsKeeper.chocolate -= StatsKeeper.chocolatePerScondCost;
            StatsKeeper.chocolatePerScondCost = StatsKeeper.CalculateNextUpgradeCost(StatsKeeper.chocolatePerScondCost);
            text.text = "Fire MORE Chocolate (" + StatsKeeper.chocolatePerScondCost + ")";
            if (StatsKeeper.chocolate < StatsKeeper.chocolatePerScondCost)
            {
                button.interactable = false;
            }
        }
    }
}
