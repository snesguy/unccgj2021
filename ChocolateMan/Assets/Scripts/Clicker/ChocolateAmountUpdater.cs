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

    IEnumerator startDuties()
    {
        Debug.Log("startingDuties");
        for (int i = StatsKeeper.chocoBuddyCount; i > 0; i--)
        {

            yield return new WaitForSeconds(0.2f);
            Debug.Log("Buddy" + i + "deployed");
            StartCoroutine("chocoBuddyDuties");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        if(ballSpawner != null)
        {
            StartCoroutine("startDuties");
        }
    }

    // Update is called once per frame
    void Update()
    {
        text.text = StatsKeeper.LongToText(StatsKeeper.chocolate);
    }
}
