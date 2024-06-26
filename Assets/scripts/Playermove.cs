using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public Transform cameraTransform;
    
    public CharacterController characterController;

    public float moveSpeed = 5f;
    float ymoveSpeed,h,v;
    /*void Awake()
    {
        StartCoroutine("cameraRot");
    }
    IEnumerator cameraRot(){
        yield return new WaitForSeconds(0.5f);
        transform.rotation = Quaternion.Euler(-10f,-90f,0f);
    }*/
    void Update()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if(BlackMove.blackMoveOpen==false){
            h=0f;
            v=0f;
        }
        if(BlackMove.blackMoveOpen==true){
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
        }
        if(Input.GetKey(KeyCode.LeftShift)){
            moveSpeed = 6f;
        }
        else{
            moveSpeed = 4f;
        }

        Vector3 moveDirection = new Vector3(h, 0, v);
        ymoveSpeed= - 4f;
        moveDirection = cameraTransform.TransformDirection(moveDirection);
        
        moveDirection.y = ymoveSpeed;
        moveDirection *= moveSpeed;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}