using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAudioPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    private float cooldown;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            if(cooldown <= 0)
            {
                cooldown = Random.Range(1.0f, 15.0f);
                audioSource.Play();
            }
            else
            {
                cooldown -= Time.deltaTime;
            }
        }
    }
}
