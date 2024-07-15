using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WallMove : MonoBehaviour
{
    public float duration = 2.0f;  // 이동 시간
    public float distance = -3.0f; // y축으로 이동할 거리

    void Start()
    {
        StartCoroutine(MoveDown());
    }

    IEnumerator MoveDown()
    {
        yield return new WaitForSeconds(6.0f);
        Vector3 startPosition = transform.position;  // 초기 위치
        Vector3 endPosition = startPosition + new Vector3(0, distance, 0);  // 목표 위치

        float elapsedTime = 0;

        while (elapsedTime < duration)
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;  // 다음 프레임까지 대기
        }

        // 이동이 완료된 후 정확히 목표 위치로 설정
        transform.position = endPosition;
    }
}

