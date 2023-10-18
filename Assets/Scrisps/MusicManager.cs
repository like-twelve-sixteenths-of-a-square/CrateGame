using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    //You know the drill

    //Box control
    private BoxController boxContact;

    //Noise Maker
    public AudioSource audioSource;

    void Start()
    {
        boxContact = GameObject.Find("BoxFreak").GetComponent<BoxController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (boxContact.gameOver == true)
        {
            audioSource.Stop();
        }
    }
}
