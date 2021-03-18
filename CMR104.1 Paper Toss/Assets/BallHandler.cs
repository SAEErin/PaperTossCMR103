using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour
{
    public GameObject ballPrefab; // ref to prefab
    public GameManager gameManager;
   

    private void Start()
    {
        
    }

    // if something enters this trigger, reset it's position
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("has hit collider");
        RespawnBall();
        Destroy(gameObject);

    }

    private void RespawnBall()
    {
        Debug.Log("Respawn Ball");

        for (int i = 0; i < 3; i++)
        {
            Instantiate(ballPrefab, new Vector3(i/2 + 22, 0.71f, -5), Quaternion.identity);
        }
    }
    

}
