using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocoLover : MonoBehaviour
{

    public DialogueText dialogueText;
    private float infectiousRate = 0.01f;

    public float infection;
    public int infectionLevel;
    private float textChangeDelay = 3.0f;
    private float curTextChangeDelay;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
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
        }
        else if(infection >= 1.2f && infectionLevel == 3)
        {
            infectionLevel++;
                
        }
        if(curTextChangeDelay <= 0)
        {
            if(dialogueText != null)
            {
                dialogueText.setText(infectionLevel, infection);
                curTextChangeDelay = textChangeDelay;
            }
        }
        else
        {
            curTextChangeDelay -= Time.deltaTime;
        }
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