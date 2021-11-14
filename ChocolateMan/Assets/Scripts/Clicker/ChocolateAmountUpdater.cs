using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChocolateAmountUpdater : MonoBehaviour
{
    private Text text;
    public BallSpawner ballSpawner;

    IEnumerator chocoBuddyDuties()
    {
        while (true)
        {
            yield return new WaitForSeconds(StatsKeeper.chocoBuddyWorkRate);
            ballSpawner.SpawnBall();
            StatsKeeper.MoreChocolateBuddy();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        StartCoroutine("chocoBuddyDuties");
    }

    // Update is called once per frame
    void Update()
    {
        text.text = StatsKeeper.LongToText(StatsKeeper.chocolate);
    }
}
