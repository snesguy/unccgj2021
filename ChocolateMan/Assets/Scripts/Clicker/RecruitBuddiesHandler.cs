using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecruitBuddiesHandler : MonoBehaviour

{
    private Button button;


    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if(StatsKeeper.chocolateInTank >= 1)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    public void ComeTogethering()
    {
        if (StatsKeeper.chocolateInTank >= 1)
        {
            SceneManager.LoadScene(2);
        }
    }
}
