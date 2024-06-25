using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDetect : MonoBehaviour
{
    static public bool isUp;
    void Awake()
    {
        isUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.name== "Player"){
            isUp = true;
        }
    }
}
