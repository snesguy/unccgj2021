using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeTank : MonoBehaviour
{
    public Text text;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        text.text = "More in the Tank (" + StatsKeeper.ChocoTankSizeUpgradeCost + ")";
    }

    // Update is called once per frame
    void Update()
    {
        if (StatsKeeper.chocolate >= StatsKeeper.ChocoTankSizeUpgradeCost)
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
        if (StatsKeeper.chocolate > StatsKeeper.ChocoTankSizeUpgradeCost)
        {
            StatsKeeper.maxTankCapacity *= 3;
            StatsKeeper.chocolate -= StatsKeeper.ChocoTankSizeUpgradeCost;
            StatsKeeper.ChocoTankSizeUpgradeCost = StatsKeeper.CalculateNextUpgradeCost(StatsKeeper.ChocoTankSizeUpgradeCost);
            text.text = "More in the Tank (" + StatsKeeper.ChocoTankSizeUpgradeCost + ")";
            if (StatsKeeper.chocolate < StatsKeeper.ChocoTankSizeUpgradeCost)
            {
                button.interactable = false;
            }
        }
    }
}
