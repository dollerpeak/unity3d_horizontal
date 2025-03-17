using UnityEngine;

public class Sphere : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Material material;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        material = meshRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            material.color = Color.white;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            material.color = Color.white;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            material.color = Color.black;
        }
    }
}
