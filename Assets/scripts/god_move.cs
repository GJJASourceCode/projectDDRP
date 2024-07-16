using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class god_move : MonoBehaviour
{
    public GameObject sleepgod, normalgod ,smilegod, player, press;
    //bool a1 = false;
    bool a1,a2,a3;
    int stack;
    public static bool aaaa;
    public static float angle;
    Vector3 players;
    void Awake()
    {
        a1 = false;
        a2 = true;
        a3 = false;
        aaaa = false;
        stack=0;
    }


    /*IEnumerator state2(){
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

    }*/
    // Update is called once per frame
    IEnumerator godMovement(){
        yield return 0;
    }
    IEnumerator eyeOpen(){
        yield return new WaitForSeconds(1.0f);
        sleepgod.SetActive(false);
        normalgod.SetActive(true);
        a3=true;
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.name=="Player"&&a3){
            a3=false;
            StartCoroutine(pay());
            
            aaaa=true;
        }
    }
    IEnumerator pay(){
        normalgod.SetActive(false);
        smilegod.SetActive(true);
        press.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        if(stack<9){
            DownDetect.isDown = true;
        }
        stack = 0;
        smilegod.SetActive(false);
        press.SetActive(false);
        sleepgod.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        sleepgod.SetActive(false);
        normalgod.SetActive(true);
        a3=true;
    }
    void Update()
    {
        angle = Mathf.Atan2(player.transform.position.z-transform.position.z,player.transform.position.x-transform.position.x);
        if(god_detect.godDetect&&a2){
            a1 = true;
            a2 = false;
        }
        if(a1){
            if(transform.position.x<=0){
                StartCoroutine(eyeOpen());
                a1=false;
            }
            else{
                Debug.Log("앙");
                transform.position = new Vector3(transform.position.x-5*Time.deltaTime, transform.position.y,transform.position.z);
            }
        }
        if(a3){
           transform.rotation = Quaternion.Euler(0f,90f-angle*Mathf.Rad2Deg,0f);
           transform.position = new Vector3(transform.position.x + Mathf.Cos(angle)*10f*Time.deltaTime,transform.position.y,transform.position.z + Mathf.Sin(angle)*10f*Time.deltaTime);
        }
        if(aaaa){
            if(Input.GetKeyDown("x")){
                stack++;
            }
            if(stack>=10){
                aaaa=false;
                smilegod.SetActive(false);
                press.SetActive(false);
                sleepgod.SetActive(true);
            }
        }
        //Debug.Log("위치 : "+players + " ,방향 : " + player.transform.rotation);
        
    }
}
