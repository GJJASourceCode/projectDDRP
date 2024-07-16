using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClick : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isClick;
    void Awake()
    {
        isClick = false;
    }

    // Update is called once per frame
    public void ButtonPress(){
        isClick=true;
    }
    void Update()
    {
        
    }
}
