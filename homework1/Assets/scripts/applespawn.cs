using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applespawn : MonoBehaviour
{
    public GameObject elma;
    public Transform[] spawnpoints;
    public void Update()
    {
        int index = Random.Range(0, spawnpoints.Length);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(elma, spawnpoints[index].position, spawnpoints[index].rotation);
        }
    }
}
