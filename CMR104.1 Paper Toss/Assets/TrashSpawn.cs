using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawn : MonoBehaviour
{
    public GameObject trashPrefab;
   


    // Start is called before the first frame update
    void Start()
    {
        SpawnTrash();


    }


    private void SpawnTrash()
    {
        if (trashPrefab = null)
        {
            Instantiate(trashPrefab, transform.position, trashPrefab.transform.rotation);
        }
        else
        {
            return;
        }
    }



}
