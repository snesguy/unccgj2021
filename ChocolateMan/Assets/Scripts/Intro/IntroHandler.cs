using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroHandler : MonoBehaviour
{
    private string text1 = "Chocolate was abundant and everything was great at the school until the administration ruined it for everyone. No More Chocolate. The students were in an uproar but what could they do? As the ban dragged on, people started studying and staying awake in class. People even started to forget how good chocolate tastes.";
    private string text2 = "Separately, Chocolateman, Apprentice of Sandman wasn't allowed to use sand yet but he wasn't dissappointed. Since he was young, he's always loved chocolate but his parents never let him have it, As he grew older, he wanted it more and more until he became the Chocolateman he is today. After hearing about the chocolate ban at a school, he laughed maniacally because he knew exactly what the school needed and he was coming. Soon no one in the school will be able to live without chocolate.";
    private Text textText;
    public Text respectfulText;
    public float timer = 0.0f;
    private bool respectPayed;

    // Start is called before the first frame update
    void Start()
    {
        this.textText = GetComponent<Text>();
        this.textText.text = text1;
        Camera.main.backgroundColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timer > 25)
        {
            SceneManager.LoadScene(1);
        }
        else if(timer > 12 && respectPayed)
        {
            timer += Time.deltaTime;
            Color orig = respectfulText.color;
            respectfulText.color = new Color(orig.r, orig.g, orig.b, Mathf.Lerp(orig.a, 0, 1.0f * Time.deltaTime));
            Camera.main.backgroundColor = Color.Lerp(Camera.main.backgroundColor, Color.green, 3.5f * Time.deltaTime);
            
        }
        else if(timer > 12)
        {
            if(Input.GetKeyDown("f"))
            {
                respectPayed = true;
                this.textText.text = text2;
                respectfulText.text = "Respect Payed";
            }
        }
        else if(timer > 10)
        {
            timer += Time.deltaTime;
            Color orig = respectfulText.color;
            respectfulText.color = new Color(orig.r, orig.g, orig.b, Mathf.Lerp(orig.a, 1.0f, 2.0f * Time.deltaTime));
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
