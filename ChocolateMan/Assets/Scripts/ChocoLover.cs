using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocoLover : MonoBehaviour
{

    private float infectiousRate = 0.01f;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    void OnCollisionStay2D(Collision2D collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Chocolate")
        {
            SpriteRenderer otherSpriteRenderer = collisionInfo.gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.color = Color.Lerp(spriteRenderer.color, otherSpriteRenderer.color, infectiousRate * Time.deltaTime);
        }
    }
}
