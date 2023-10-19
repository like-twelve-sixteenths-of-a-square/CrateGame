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
    public ParticleSystem boxFire;

    //Audio Variables
    private AudioSource crateAudio;
    public AudioClip crateDeath;
    public AudioClip jumpFlapNoise;

    void Start()
    {
        //Just to be safe
        gameOver = false;

        //Gets this box freak's body
        boxBod = GetComponent<Rigidbody>();
        //Gets this box freak's animator
        animator = GetComponent<Animator>();
        //Gets this box freak's audio source
        crateAudio = GetComponent<AudioSource>();
    }
    void Update()
    {
        //Makes the box freak "flap" while busting it down
        if (Input.GetKeyDown(KeyCode.Space) && gameOver == false)
        {
            boxBod.AddForce(Vector3.up * boingForce, ForceMode.Impulse);
            crateAudio.PlayOneShot(jumpFlapNoise);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") && gameOver == false)
        {
            gameOver = true;
            animator.SetBool("gameOver", true);
            crateAudio.PlayOneShot(crateDeath);
            Debug.Log("L Bozo");
            Invoke("SetOnFire", 3);
        }
    }

    void SetOnFire()
    {
        boxFire.Play();
    }
}
