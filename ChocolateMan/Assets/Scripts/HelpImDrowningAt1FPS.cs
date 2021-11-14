using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpImDrowningAt1FPS : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
