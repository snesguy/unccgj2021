using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject chocolate;

    private GameObject[] ballPool = new GameObject[1000];
    private int ballPoolIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBall()
    {
        GameObject gameObject;
        if(ballPool[ballPoolIndex] != null)
        {
            gameObject = ballPool[ballPoolIndex];
            gameObject.SetActive(false);
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            gameObject.transform.position = transform.position;
            gameObject.SetActive(true);
        }
        else
        {
            gameObject = Instantiate(chocolate, transform.position, Quaternion.identity);
            ballPool[ballPoolIndex] = gameObject;
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-1.0f, 1.0f), 0.0f);
        ballPoolIndex++;
        if(ballPoolIndex == ballPool.Length)
        {
            ballPoolIndex = 0;
        }
    }
}
