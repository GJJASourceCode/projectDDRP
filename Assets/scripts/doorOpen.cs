using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    void Awake()
    {
    }

    // Update is called once per frame -0.09247555 -0.268
    void Update()
    {
        Debug.Log(UpDetect.isUp);
        if(doorDetect.isDoorDetect&&(transform.position.z>=28.7f)){
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z-0.1f*Time.deltaTime);
        }
    }
}
