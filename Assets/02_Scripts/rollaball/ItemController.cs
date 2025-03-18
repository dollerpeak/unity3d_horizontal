using UnityEngine;

public class item : MonoBehaviour
{
    float rotateForce = 180;

    void Update()
    {
        transform.Rotate(Vector3.up * rotateForce * Time.deltaTime, Space.World);
    }


}
