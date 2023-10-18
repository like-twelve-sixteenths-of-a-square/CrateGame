using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    //Spawner Delay Variables
    public float initialDelay;
    public float maxDelay;
    public float minDelay;

    //WallHeightVaribles
    public float maxHeight;
    public float minHeight;

    //What're we spawning today, boys?
    public GameObject crateWall;
    public GameObject particles;

    //Also contact the player (boxfreak)
    private BoxController boxContact;

    void Start()
    {
        //Make sure you have them contacted
        boxContact = GameObject.Find("BoxFreak").GetComponent<BoxController>();

        //Invokes the spawner code to run
        InvokeRepeating("SpawnBox", initialDelay, Random.Range(minDelay, maxDelay));
    }

    void SpawnBox()
    {
        //The spawner code. Spawns boxes at a random interval until the game is over.
        if (boxContact.gameOver == false)
        {
            Instantiate(crateWall, transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0), transform.rotation);
            Instantiate(particles, transform.position + new Vector3(0, 0, 1), transform.rotation);
        }
    }
}
