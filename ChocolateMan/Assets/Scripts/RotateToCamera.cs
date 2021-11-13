using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(
                                                            mouse.x, 
                                                            mouse.y,
                                                            this.transform.position.y));
        Vector3 forward = mouseWorld - this.transform.position;
        //forward = forward.normalized;
        this.transform.rotation = Quaternion.LookRotation(forward, new Vector3(0.0f, 0.0f, 1.0f));
    }
}
