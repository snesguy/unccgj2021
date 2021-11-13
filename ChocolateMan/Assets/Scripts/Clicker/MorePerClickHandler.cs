using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MorePerClickHandler : MonoBehaviour
{
    public Text text;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        text.text = "More per MORE (" + StatsKeeper.chocolatePerClickCost + ")";
    }

    // Update is called once per frame
    void Update()
    {
        if(StatsKeeper.chocolate >= StatsKeeper.chocolatePerClickCost)
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
        if(StatsKeeper.chocolate > StatsKeeper.chocolatePerClickCost)
        {
            StatsKeeper.chocolatePerClick *= 2;
            StatsKeeper.chocolate -= StatsKeeper.chocolatePerClickCost;
            StatsKeeper.chocolatePerClickCost = StatsKeeper.CalculateNextUpgradeCost(StatsKeeper.chocolatePerClickCost);
            text.text = "More per MORE (" + StatsKeeper.chocolatePerClickCost + ")";
            if(StatsKeeper.chocolate < StatsKeeper.chocolatePerClickCost)
            {
                button.interactable = false;
            }
        }
    }
}
