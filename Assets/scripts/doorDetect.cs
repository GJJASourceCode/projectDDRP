using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorDetect : MonoBehaviour
{
    public static bool isDoorDetect;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.name== "Player"){
            isDoorDetect = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
