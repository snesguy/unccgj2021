using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocoBall : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; 

     // Update is called once per frame
    void Update()
    {
        spriteRenderer.color = StatsKeeper.chocoColor;
    }
}
