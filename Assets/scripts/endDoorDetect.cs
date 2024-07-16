using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endDoorDetect : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool endDoor_Detect;
    void Awake()
    {
        endDoor_Detect = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.name=="Player"){
            endDoor_Detect=true;
            BlackMove.blackMoveOpen=false;
        }
    }
    
}
