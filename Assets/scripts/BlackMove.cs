using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackMove : MonoBehaviour
{
    public static bool blackMoveOpen;
    public Image up, down;
    Vector3 upStart, upEnd, downStart, downEnd;
    void Awake()
    {
        blackMoveOpen=true;
        upStart = new Vector3(960f,810f,0f);
        upEnd = new Vector3(960f,1351f,0f);
        downStart = new Vector3(960f,270f,0f);
        downEnd = new Vector3(960f,-271f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(blackMoveOpen){
            up.transform.position = Vector3.Lerp(up.transform.position, upEnd, Time.deltaTime * 1.7f);
            down.transform.position = Vector3.Lerp(down.transform.position, downEnd, Time.deltaTime * 1.7f);
        }
        else{
            up.transform.position = Vector3.Lerp(up.transform.position, upStart, Time.deltaTime * 2f);
            down.transform.position = Vector3.Lerp(down.transform.position, downStart, Time.deltaTime * 2f);
        }
    }
}
