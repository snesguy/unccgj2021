using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeChocoSize : MonoBehaviour
{
    public Text text;
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        text.text = "Chocolate BIG (" + StatsKeeper.chocolateSizeCost + ")";
    }

    // Update is called once per frame
    void Update()
    {
        if (StatsKeeper.chocolate >= StatsKeeper.chocolateSizeCost)
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
        if (StatsKeeper.chocolate > StatsKeeper.chocolateSizeCost)
        {
            StatsKeeper.chocolateSize *= StatsKeeper.chocolateSizeRamp;
            StatsKeeper.chocolate -= StatsKeeper.chocolateSizeCost;
            StatsKeeper.chocolateSizeCost = StatsKeeper.CalculateNextUpgradeCost(StatsKeeper.chocolateSizeCost);
            text.text = "Chocolate BIG (" + StatsKeeper.chocolateSizeCost + ")";
            if (StatsKeeper.chocolate < StatsKeeper.chocolateSizeCost)
            {
                button.interactable = false;
            }
        }
    }
}
