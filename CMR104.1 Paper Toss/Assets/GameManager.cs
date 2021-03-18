using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform throwingArea; //Reference to throwing area
    public Transform trashRespawnArea; //Area that the trash can spawn in
    public Transform fanRespawnArea; //Area that the Fan can spawn in
    public Transform ballRespawnArea; //Area that the Ball can respawn to

    public Vector3 ballMoveArea; //Size of ball move area

    public GameObject trashPrefab;
    public GameObject ballPrefab;
    public GameObject fanPrefab;

    public int Score;
    public TrashHandler trashHandler; //Ref to trash handler
    public BallHandler ballHandler; //Ref to ball handler
    public FanHandler fanHandler; //Ref to ball handler

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Returns a random position within our move area/
    /// </summary>
    /// <returns></returns>

    
}
