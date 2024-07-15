using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkMove : MonoBehaviour
{
    Rigidbody rigid;
    public float speed;
    float yAxis;
    int state;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
         
        StartCoroutine(stop());
        
        
    }
IEnumerator surprise()
            {
                for (int i = 0; i<= 500; i++)
                {
                Debug.Log("앙");
                yAxis = transform.position.y + (speed * Time.deltaTime);
                transform.position = new Vector3(transform.position.x, yAxis, transform.position.z);
                
                }
                yield return new WaitForSeconds(0.5f);
                for (int i = 0; i<= 500; i++)
                {
                Debug.Log("앙");
                yAxis = transform.position.y + (speed * Time.deltaTime);
                transform.position = new Vector3(transform.position.x, -yAxis, transform.position.z);
                
                }
                yield return 0;
            }
IEnumerator stop()
            {
                for (int i = 0;i<=20; i++)
                {
                
                yield return new WaitForSeconds(2.0f);
                state=1;
                yield return new WaitForSeconds(0.3f);
                state=2;
                yield return new WaitForSeconds(0.3f);
                state=0;
                }
            }

    // Update is called once per frame
    void Update()
    {
        if(state==1){
            transform.position = new Vector3(transform.position.x, transform.position.y +speed * Time.deltaTime, transform.position.z);
        }
        if(state==2){
            transform.position = new Vector3(transform.position.x, transform.position.y -speed * Time.deltaTime, transform.position.z);
        }
        rigid.velocity = Vector3.zero;
    }
}
