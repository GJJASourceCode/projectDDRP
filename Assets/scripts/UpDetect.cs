using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownDetect : MonoBehaviour
{
    static public bool isDown;
    void Awake()
    {
        isDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.name== "Player"){
            isDown = true;
        }
    }
}
