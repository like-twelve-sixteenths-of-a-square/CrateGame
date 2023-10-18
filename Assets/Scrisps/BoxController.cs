using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    //Movement Variables
    public float boingForce;

    //Control Variables
    private Rigidbody boxBod;
    private Animator animator;
    public bool gameOver;

    void Start()
    {
        //Just to be safe
        gameOver = false;

        //Gets this box freak's body
        boxBod = GetComponent<Rigidbody>();
        //Gets this box freak's animator
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        //Makes the box freak "flap" while busting it down
        if (Input.GetKeyDown(KeyCode.Space) && gameOver == false)
        {
            boxBod.AddForce(Vector3.up * boingForce, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            animator.SetBool("gameOver", true);
        }
    }
}
