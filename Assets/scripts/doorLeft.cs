using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorLeft : MonoBehaviour
{
    // Start is called before the first frame update
    float yaix;
    void Awake()
    {
        yaix= 0f;
    }

    // Update is called once per frame
    void Update()
    {
        while(transform.rotation.y<=160&&endDoorDetect.endDoor_Detect){
            transform.rotation = Quaternion.Euler(0,80f,0f);
        }
    }
}
