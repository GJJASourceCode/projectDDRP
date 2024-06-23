using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        map[0] = "normal";
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
    void Update(){
        if(UpDetect.isUp){
            UpDetect.isUp=false;
            BlackMove.blackMoveOpen=false;
            if(sceneNum==0){
                if(flore!=2){
                    flore-=1;
                    int fake = Random.Range(0,2);
                    if(fake==1){
                        int willScene = Random.Range(1,25);
                    }
                }
            }
        }
    }
    public int sceneNum;
    public int flore; 
    public string[] map = new string[25];
}
