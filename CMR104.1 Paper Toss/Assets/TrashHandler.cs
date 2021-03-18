using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashHandler : MonoBehaviour
{
    public GameObject trashPrefab; //Ref to ball prefab 

    // Start is called before the first frame update
    void Start()
    {
        SpawnTrash();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnTrash()
    {
        Instantiate(trashPrefab, transform.position, trashPrefab.transform.rotation);
    }
}
