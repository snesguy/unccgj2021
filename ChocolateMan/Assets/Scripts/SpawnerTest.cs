using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTest : MonoBehaviour
{

    public GameObject chocolate;

    public float cooldown;
    private float curCooldown = 0;

    public float xSpawnDist;

    // Start is called before the first frame update
    void Start()
    {
        cooldown = 60.0f / StatsKeeper.chocolatePerSecond;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("space") && curCooldown <= 0 && StatsKeeper.chocolateInTank > 0)
        {
            var obj = Instantiate(chocolate, transform.position + (this.transform.up * xSpawnDist), Quaternion.identity);
            obj.GetComponent<Rigidbody2D>().velocity = this.transform.up * StatsKeeper.firingVelocity;
            curCooldown = cooldown;
            StatsKeeper.chocolateInTank--;
        }
        if(curCooldown > 0)
            curCooldown -= Time.deltaTime;
    }
}
