using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAgent : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed;
    
    void Update()
    {
        Vector2 directionToPlayer = player.transform.position - transform.position;
        if(directionToPlayer.magnitude > 0.1f)
        {
            directionToPlayer.Normalize();
            directionToPlayer *= speed * Time.deltaTime;
            transform.position += (Vector3)directionToPlayer;
        }
    }
}
