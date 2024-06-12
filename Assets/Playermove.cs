using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public Transform cameraTransform;
    
    public CharacterController characterController;

    public float moveSpeed = 5f;
    float ymoveSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(h, 0, v);
        ymoveSpeed= - 4f;
        moveDirection = cameraTransform.TransformDirection(moveDirection);
        
        moveDirection.y = ymoveSpeed;
        moveDirection *= moveSpeed;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}