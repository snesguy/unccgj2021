using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSideScroller : MonoBehaviour
{

    public float xVelocity;
    public float jumpVelocity;
    public float friction;
    private Rigidbody2D rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("w"))
         {
            rigidbody.velocity = rigidbody.velocity + new Vector2(0.0f, jumpVelocity);
         }
         if(Input.GetKey("a"))
         {
            rigidbody.AddForce(Vector2.left * xVelocity, ForceMode2D.Impulse);
         }
         if(Input.GetKey("d"))
         {
            rigidbody.AddForce(Vector2.right * xVelocity, ForceMode2D.Impulse);
         }
         rigidbody.velocity = rigidbody.velocity * new Vector2(friction, 1.0f);
    }
}
