using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disco : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Color target;
    private float timer;
    private float timeToTarget;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        NewTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            spriteRenderer.color = Color.Lerp(spriteRenderer.color, target, Time.deltaTime / timeToTarget);
        }
        else
        {
            NewTarget();
        }
        
    }

    public void NewTarget()
    {
        timeToTarget = Random.Range(0.25f, 1.0f);
            timer = timeToTarget;
            target = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
    }
}
