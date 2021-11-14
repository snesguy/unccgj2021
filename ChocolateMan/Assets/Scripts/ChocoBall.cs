using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocoBall : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; 

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale *= StatsKeeper.chocolateSize;
    }

     // Update is called once per frame
    void Update()
    {
        spriteRenderer.color = StatsKeeper.chocoColor;
        if(transform.position.x < -50)
        {
            Destroy(this.gameObject);
        }
    }
}
