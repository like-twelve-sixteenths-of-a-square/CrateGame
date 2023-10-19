using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    private GameObject scoreMaster;
    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.Find("PointMaster").GetComponent<ScoreTally>().score++;
        }
    }
}