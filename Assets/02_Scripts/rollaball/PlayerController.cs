using System;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class player : MonoBehaviour
{
    public int itemCount = 0;

    //float moveForce = 2;
    float moveForce = 0.1f;
    Boolean flagJump = false;
    float jumpForce = 7;

    Rigidbody rigidBody;
    AudioSource audioSource;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal") * moveForce;
        float vertical = Input.GetAxisRaw("Vertical") * moveForce;

        //rigidBody.AddForce(new Vector3(horizontal, 0f, vertical), ForceMode.Acceleration);
        rigidBody.AddForce(new Vector3(horizontal, 0f, vertical), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true && flagJump == false)
        {
            //Debug.Log("jump");
            flagJump = true;
            rigidBody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            flagJump = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            itemCount += 1;

            audioSource.Play();
            other.gameObject.SetActive(false);
        }
    }
    
}
