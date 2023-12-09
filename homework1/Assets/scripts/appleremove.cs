using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class appleremove : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] public TMP_Text can;

    public void Awake()
    {
        health = 3;
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("elma"))
        {
            Destroy(other.gameObject);
            health--;
            can.SetText("can :" + health);
        }
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    print("a");
    //    if (collision.gameObject.CompareTag("elma"))
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
