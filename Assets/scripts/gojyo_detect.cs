using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gojyo_detect : MonoBehaviour
{
    static public bool gojyoDetect;
    void Awake()
    {
        gojyoDetect=false;
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.name=="Player"){
            gojyoDetect=true;
        }
    }

    void Update()
    {
        
    }
}
