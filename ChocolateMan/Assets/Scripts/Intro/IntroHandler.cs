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

    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    public int state = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.textText = GetComponent<Text>();
        this.textText.text = text1;
        Camera.main.backgroundColor = Color.red;
        audioSource1.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(state == 0 && !audioSource1.isPlaying)
        {
            timer += Time.deltaTime;
            audioSource2.Play();
            state++;
        }
        else if(state == 1 && audioSource2.isPlaying)
        {
            Color orig = respectfulText.color;
            respectfulText.color = new Color(orig.r, orig.g, orig.b, Mathf.Lerp(orig.a, 1.0f, 2.0f * Time.deltaTime));
        }
        else if(state == 1 && !audioSource2.isPlaying)
        {
            if(Input.GetKeyDown("f"))
            {
                respectPayed = true;
                this.textText.text = text2;
                respectfulText.text = "Respect Payed";
                audioSource3.Play();
                state++;
            }
        }
        else if(state == 2 && audioSource3.isPlaying)
        {
            Camera.main.backgroundColor = Color.Lerp(Camera.main.backgroundColor, Color.green, 2.5f * Time.deltaTime);
        }
        else if(state == 2 && !audioSource3.isPlaying)
        {
            timer += Time.deltaTime;
            audioSource4.Play();
            state++;
        }
        else if(state == 3 && audioSource4.isPlaying)
        {
            Color orig = respectfulText.color;
            respectfulText.color = new Color(orig.r, orig.g, orig.b, Mathf.Lerp(orig.a, 0, 1.0f * Time.deltaTime));
        }
        else if(state == 3 && !audioSource4.isPlaying)
        {
            SceneManager.LoadScene(1);
        }
    }
}
