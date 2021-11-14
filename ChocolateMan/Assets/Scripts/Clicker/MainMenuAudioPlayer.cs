using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAudioPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    private float cooldown;
    public AudioClip chocoganda;
    public AudioClip chocoSong;
    public int randGen = 0;
    public AudioClip clip;


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
                clip = null;

                randGen = Random.Range(0, 100);

                if (randGen > 40)
                {
                    clip = chocoSong;
                } else
                {
                    clip = chocoganda;
                }

                cooldown = Random.Range(1.0f, 5.0f);
                audioSource.clip = clip;
                audioSource.Play();
            }
            else
            {
                cooldown -= Time.deltaTime;
            }
        }
    }
}
