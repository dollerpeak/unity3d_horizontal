using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    Vector3 offSet;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offSet = transform.position -  player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offSet;
    }
}
