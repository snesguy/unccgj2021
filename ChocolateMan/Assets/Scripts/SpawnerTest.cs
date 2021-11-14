using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnerTest : MonoBehaviour
{

    public GameObject chocolate;

    public float cooldown;
    public float curCooldown = 0;

    public float xSpawnDist;

    // Start is called before the first frame update
    void Start()
    {
        cooldown = 1.0f / StatsKeeper.chocolatePerSecond;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space") && curCooldown <= 0 && StatsKeeper.chocolateInTank > 0)
        {
            var obj = Instantiate(chocolate, transform.position + (this.transform.up * xSpawnDist), Quaternion.identity);
            obj.transform.localScale *= StatsKeeper.chocolateSize;
            obj.GetComponent<Rigidbody2D>().velocity = this.transform.up * StatsKeeper.firingVelocity;
            curCooldown = cooldown;
            StatsKeeper.chocolateInTank--;
            if(StatsKeeper.chocolateInTank == 0)
            {
                SceneManager.LoadScene(1);
            }
        }
        if(curCooldown > 0)
            curCooldown -= Time.deltaTime;
    }
}
