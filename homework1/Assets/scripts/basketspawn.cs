using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class basketspawn : MonoBehaviour
{
    public GameObject sepet;
    public GameObject elma;
    public Transform[] spawnpoints;
    public TMP_Text skoryazý;
    public int skor;
    private void OnTriggerEnter(Collider other)
    {
        int index = Random.Range(0, spawnpoints.Length);
        if(other.CompareTag("elma"))
        {
            skor++;
            print("a");
            Destroy(sepet);
            print("b");
            Instantiate(sepet, spawnpoints[index].position, spawnpoints[index].rotation);
            Destroy(other.gameObject);
            print("c");
            skoryazý.SetText("skor : " + skor);
        }
    }
}
