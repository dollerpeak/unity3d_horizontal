using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    [Header("GameManager")]
    public GameManager gameManager;
    
    int itemCount;
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

        if (transform.position.y <= -5.0f)
        {
            ReStart();
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

            gameManager.setUiNowItemCount(itemCount);
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.tag == "Finish")
        {
            if (gameManager.GetStageItemCount() == itemCount)
            {
                //다음스테이지
                SceneManager.LoadScene("rollaball_next");
            }
            else
            {
                //재시작
                SceneManager.LoadScene(gameManager.GetSceneName());
            }
        }
    }

    void ReStart()
    {
        SceneManager.LoadScene(gameManager.GetSceneName());
    }

}
