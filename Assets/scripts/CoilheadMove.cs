using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoilheadMove : MonoBehaviour
{
    public Transform player;
    public Camera playerCamera; 
   

    public float moveSpeed = 3f;
    private bool isPlayerLooking = false;
    private bool isTrigger = false;
    private float fixedYPosition = 3.028f; 

    void Update()
    {

        DetectPlayerView();

        if (isPlayerLooking)
        {
            return;
        }
        MoveTowardsPlayer();
    }
    void OnTriggerEnter(Collider col){
        if(col.gameObject.name== "Player"){
            DownDetect.isDown = true;
        }
    }
    void DetectPlayerView()
    {
        if (playerCamera == null)
        {
            Debug.LogError("Player camera reference is not set in CoilheadMove.");
            return;
        }

        Vector3 viewportPoint = playerCamera.WorldToViewportPoint(transform.position);

        
        isPlayerLooking = viewportPoint.x >= 0 && viewportPoint.x <= 1 &&
                          viewportPoint.y >= 0 && viewportPoint.y <= 1 &&
                          viewportPoint.z > 0; 
    }

    void MoveTowardsPlayer()
    {
        if (player == null)
        {
            Debug.LogError("Player reference is not set in CoilheadMove.");
            return;
        }

        
        Vector3 targetPosition = player.position;
        targetPosition.y = fixedYPosition; 

        Vector3 direction = targetPosition - transform.position;

        
        direction.y = 0;

        
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }
}
