using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocoLover : MonoBehaviour
{
    private static string[][] dialogue = {
        new string[]{"I don't like chocolate", "Vegetables are good", "I am at peace", "I study"},
        new string[]{"Chocolate is ok?", "I feel different?", "What is this on my face?", "I feel a change slowing coming in me"},
        new string[]{"I hunger but why?", "I need it", "He is coming", "I don't study", "I want chocolate", "When will he come?"},
        new string[]{"I love it", "I need more on me", "Is it CHOCOLATE time?", "More!", "I don't need water"},
        new string[]{"CHOCOLATE", "COVER ME IN CHOCOLATE", "WHERE IS HE!?"},
        new string[]{"DSHALKFAS", "TE CHOCOLATE WIL COM ON Us aL!", "SPRED TE LUV","CHOCOLATEMAN COMES"},
        new string[]{"WE'RE COMING TOGETHER!"}
    };

    private AudioSource audioSource;

    public List<AudioClip> audioClips0;
    public List<AudioClip> audioClips1;
    public List<AudioClip> audioClips2;
    public List<AudioClip> audioClips3;
    public List<AudioClip> audioClips4;
    public List<AudioClip> audioClips5;
    public List<AudioClip> audioClips6;
    
    public string getText(int infectionLevel, float infection)
    {
        if(infectionLevel >= dialogue.Length)
            infectionLevel = dialogue.Length - 1;
        curxIndex = infectionLevel;
        curyIndex = Random.Range(0, dialogue[infectionLevel].Length);
        return dialogue[curxIndex][curyIndex];
    }

    public AudioClip GetAudioClip()
    {
        List<AudioClip> clips = null;
        switch(curxIndex)
        {
            case 0:
            clips = audioClips0;
            break;
            case 1:
            clips = audioClips1;
            break;
            case 2:
            clips = audioClips2;
            break;
            case 3:
            clips = audioClips3;
            break;
            case 4:
            clips = audioClips4;
            break;
            case 5:
            clips = audioClips5;
            break;
            case 6:
            clips = audioClips6;
            break;
        }
        if(clips == null)
            return null;
        return clips[curyIndex];
    }

    public GameObject chocolate;
    public DialogueText dialogueText;
    private float infectiousRate = 0.01f;

    public float infection;
    public int infectionLevel;
    private float textChangeDelay = 3.0f;
    private float curTextChangeDelay;
    private SpriteRenderer spriteRenderer;
    private bool buddy = false;
    public bool canBuddy = true;
    public int curxIndex;
    public int curyIndex;

    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.audioSource = GetComponent<AudioSource>();
        if(dialogueText != null)
            dialogueText.setText(infectionLevel, infection);
        curTextChangeDelay = textChangeDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if(infection >= 0.1f && infectionLevel == 0)
        {
            infectionLevel++;
        }
        else if(infection >= 0.35f && infectionLevel == 1)
        {
            infectionLevel++;
        }
        else if(infection >= 0.7f && infectionLevel == 2)
        {
            infectionLevel++;
            if(!buddy && canBuddy)
            {
                buddy = true;
                StatsKeeper.chocoBuddyCount++;
            }
        }
        else if(infection >= 1.2f && infectionLevel == 3)
        {
            infectionLevel++;
        }
        else if(infection >= 2.1f && infectionLevel == 4)
        {
            infectionLevel++;
        }
        else if(infection >= 4.5f && infectionLevel == 5)
        {
            infectionLevel++;
        }
        else if(infection >= 5)
        {
            Explode();
        }
        if(curTextChangeDelay <= 0)
        {
            if(dialogueText != null)
            {
                dialogueText.setText(infectionLevel, infection);
                curTextChangeDelay = textChangeDelay;
                AudioClip clip = GetAudioClip();
                if(clip != null && audioSource != null)
                {
                    audioSource.clip = clip;
                    audioSource.Play();
                }
            }
        }
        else
        {
            curTextChangeDelay -= Time.deltaTime;
        }
    }

    void Explode()
    {
        for(int i = 0; i < 20; i++)
        {
            var obj = Instantiate(chocolate, transform.position, Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-18.5f, 18.5f), Random.Range(-25.0f, 25.0f));
        }
        StatsKeeper.chocolate += 500;
        if(buddy)
        {
            StatsKeeper.chocoBuddyCount--;
            buddy = false;
        }
        Destroy(this.gameObject);
    }

    void OnCollisionStay2D(Collision2D collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Chocolate")
        {
            SpriteRenderer otherSpriteRenderer = collisionInfo.gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.color = Color.Lerp(spriteRenderer.color, otherSpriteRenderer.color, infectiousRate * Time.deltaTime);
            infection += infectiousRate * Time.deltaTime;
        }
    }
}
