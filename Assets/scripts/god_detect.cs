using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class god_detect : MonoBehaviour
{
    static public bool godDetect;
    void Awake()
    {
        godDetect=false;
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.name=="Player"){
            godDetect=true;
        }
    }

    void Update()
    {
        
    }
}
