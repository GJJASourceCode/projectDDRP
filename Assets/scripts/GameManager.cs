using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        Debug.Log("Awake");
        map[0] = "normal";
        map[1] = "gojyo";
        map[2] = "water";
        map[3] = "ict";
        map[4] = "door";
        map[5] = "uniform";
        map[6] = "clock";
        map[7] = "lightOff";
        map[8] = "upAndDown";
        map[9] = "coilHead";
        map[10] = "ullook";
        map[11] = "samsik";
        map[12] = "ghost";
        map[13] = "bigHall";
        map[14] = "fireWall";
        map[15] = "waterZil";
        map[16] = "banana";
        map[17] = "twerk";
        map[18] = "shark";
        map[19] = "source";
        map[20] = "god";


        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        
    }
    IEnumerator nextScene(){
        yield return new WaitForSeconds(2f);
        sceneNum = willScene;
        Debug.Log(willScene);
        Debug.Log(flore);
        SceneManager.LoadScene(map[willScene]);

    }
    void Update(){
        Debug.Log(flore);
        if(UpDetect.isUp){
            UpDetect.isUp=false;
            BlackMove.blackMoveOpen=false;
            if(sceneNum!=0){
                if(flore!=2){
                    flore-=1;
                }
            }
            else{
                flore = 7;
            }
            int fake = Random.Range(0,10);
                    if(fake>=0&&fake<=5){
                        //willScene = Random.Range(1,25);
                        willScene = Random.Range(1,20);
                    }
                    else {
                        willScene = 0;
                    }
                    StartCoroutine("nextScene");
        }
        if(DownDetect.isDown){
            DownDetect.isDown=false;
            BlackMove.blackMoveOpen=false;
            if(flore!=2){
                if(sceneNum!=0){
                    flore =7;
            }
            else{
                if(flore==0){
                    flore = 6;
                }
                else{
                    flore -=1;
                }
                
            }
            int fake = Random.Range(0,2);
                    if(fake==0){
                        //willScene = Random.Range(1,25);
                        willScene = 1;
                    }
                    else {
                        willScene = 0;
                    }
                    StartCoroutine("nextScene");
            }
            else{
                if(sceneNum!=0){
                    flore = 7;
                    int fake = Random.Range(0,2);
                    if(fake==0){
                        //willScene = Random.Range(1,25);
                        willScene = 1;
                    }
                    else {
                        willScene = 0;
                    }
                    StartCoroutine("nextScene");
                }
                else{
                    //clear룸 이동
                }
                
            }
            
        }
    }
    public int willScene;
    public int sceneNum;
    public static int flore; 
    public string[] map = new string[25];
}
