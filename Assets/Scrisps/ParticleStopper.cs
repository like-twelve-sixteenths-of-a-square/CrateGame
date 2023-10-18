using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleStopper : MonoBehaviour
{
    //Contact Box Script
    private BoxController boxContact;

    //Particle system script ajaslkjasdlkjafdslkjafs
    public ParticleSystem boxParticles;

    void Start()
    {
        //Establish Connection
        boxContact = GameObject.Find("BoxFreak").GetComponent<BoxController>();
    }

    void Update()
    {
        //If the game is over, no more particles in the most simple way possible
        if (boxContact.gameOver == true)
        {
            boxParticles.Stop();
        }
    }
}
