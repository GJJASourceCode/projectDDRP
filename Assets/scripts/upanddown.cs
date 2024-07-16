using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upanddown : MonoBehaviour
{
    public GameObject player, map;
    float location;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    {   location = (player.transform.position.z +2.5f)*6;
        if(player.transform.position.z<=57.5f&&player.transform.position.z>=-2.5f){
            map.transform.rotation = Quaternion.Euler(0f,0f,location);
        }
    }
}
