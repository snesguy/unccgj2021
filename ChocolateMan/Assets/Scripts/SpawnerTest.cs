using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTest : MonoBehaviour
{

    public GameObject chocolate;

    public int cooldown;
    private int curCooldown = 0;

    public float xSpawnDist;
    public float xInititalVelocity;
    public float yInitialVelocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("space") && curCooldown <= 0)
        {
            var obj = Instantiate(chocolate, transform.position + (this.transform.forward * xSpawnDist), Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = this.transform.forward * xInititalVelocity;
            curCooldown = cooldown;
        }
        if(curCooldown > 0)
            curCooldown--;
    }
}
