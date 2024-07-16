using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gojyo_move : MonoBehaviour
{
    public static int state;
    public GameObject normalgojyo, smilegojyo, readygojyo, player, deadBody;
    public Image shoot;
    //bool a1 = false;
    bool a1,a2,a3;
    void Awake()
    {
        state = 0;
        a1 = false;
        a2 = true;
        a3 = true;
    }


    IEnumerator state2(){
        normalgojyo.SetActive(false);
        smilegojyo.SetActive(true);
        yield return new WaitForSeconds(1f);
        transform.position = new Vector3(transform.position.x,transform.position.y,player.transform.position.z-3);
        player.transform.rotation = Quaternion.Euler(0f,-180f,0f);
        yield return new WaitForSeconds(0.6f);
        smilegojyo.SetActive(false);
        readygojyo.SetActive(true);
        yield return new WaitForSeconds(14f);
        readygojyo.SetActive(false);
        shoot.gameObject.SetActive(true);
        yield return new WaitForSeconds(6f);
        shoot.gameObject.SetActive(false);
        state = 1;
        deadBody.SetActive(true);
        yield return new WaitForSeconds(3f);
        DownDetect.isDown = true;

    }
    // Update is called once per frame
    void Update()
    {
        if(state==1){
            player.transform.rotation = Quaternion.Euler(0f,0f,0f);
            player.transform.position = new Vector3(0,4.0f,48);
        }
        if(gojyo_detect.gojyoDetect==true&&a2){
            a1 = true;
            a2 = false;
        }
        if(a1){
            if(transform.position.x<=0){
                a1=false;
                StartCoroutine(state2());
            }
            else{
                transform.position = new Vector3(transform.position.x-1*Time.deltaTime, transform.position.y,transform.position.z);
            }
        }
            

        
    }
}
