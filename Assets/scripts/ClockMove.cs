using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockMove : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 0, 45); // 각 축에 대한 회전 속도 설정

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime을 곱하여 프레임 속도에 관계없이 일정한 속도로 회전하도록 합니다.
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
