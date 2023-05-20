using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject SpawnItem;
    public Transform[] spawnPoints = new Transform[5];
    [SerializeField] private int spawnCount;

    public void objectSpawn()
    {
        GameObject instanceObject = GameObject.Instantiate(SpawnItem, spawnPoints[spawnCount].transform.position, Quaternion.identity);
        Debug.Log(spawnPoints[spawnCount].name);

    }
    void Start()
    {
        spawnCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (spawnCount < spawnPoints.Length)
        {
            objectSpawn();
            spawnCount++;
        }
    }
}
