using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMaters : MonoBehaviour
{
    public GameObject Mater;
    public GameObject materSpawner;
    public Vector3 materSpawnLoc;

    // Start is called before the first frame update
    void Start()
    {
        materSpawnLoc = materSpawner.transform.position;
    }

    public void SpawnMaterFunction()
    {
        Debug.Log("Spawned a tomato!");
        Instantiate(Mater, materSpawnLoc, Quaternion.identity);
    }
}
