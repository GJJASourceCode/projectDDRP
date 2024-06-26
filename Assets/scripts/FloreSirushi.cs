using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloreSirushi : MonoBehaviour
{
    public Material f1,f2,f3,f4,f5,f6,f7;
    public MeshRenderer rend;
    int floreNum;
    void Awake()
    {
        rend = GetComponent<MeshRenderer>();
        Debug.Log("활성");
        
    }

    // Update is called once per frame
    void Update()
    {
        
            floreNum = GameManager.flore;
            switch(floreNum){
            case 1:
            rend.material = f1;
            break;
            case 2:
            rend.material = f2;
            break;
            case 3:
            rend.material = f3;
            break;
            case 4:
            rend.material = f4;
            break;
            case 5:
            rend.material = f5;
            break;
            case 6:
            rend.material = f6;
            break;
            case 7:
            rend.material = f7;
            break;
            default:
            rend.material = f7;
            break;
        }
        
        
    }
}
