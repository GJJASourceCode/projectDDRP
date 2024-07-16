using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manmove_x : MonoBehaviour
{
    Rigidbody rigid;
    public float speed;
    float zAxis;
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = Vector3.zero;
        if(transform.position.z<=18){
            zAxis = transform.position.z + (speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, transform.position.y, zAxis);
        }
    }
}
