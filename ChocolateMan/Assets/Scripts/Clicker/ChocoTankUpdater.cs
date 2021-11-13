using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChocoTankUpdater : MonoBehaviour
{

    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = StatsKeeper.LongToText(StatsKeeper.chocolateInTank) + "/" + StatsKeeper.LongToText(StatsKeeper.maxTankCapacity);
    }
}
