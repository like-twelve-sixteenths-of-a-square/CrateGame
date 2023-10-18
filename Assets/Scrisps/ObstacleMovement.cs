using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    //Box freak's contact
    private BoxController boxContact;

    void Start()
    {
        //Contacts the box freak
        boxContact = GameObject.Find("BoxFreak").GetComponent<BoxController>();
        //Death, delayed
        Invoke("ObjectDie", 10);
    }

    void Update()
    {
        //Moves as long as the game is not over.
        if (boxContact.gameOver == false)
        {
            transform.Translate(Vector3.left * 5 * Time.deltaTime);
        }
    }

    void ObjectDie()
    {
        Destroy(gameObject);
    }
}
