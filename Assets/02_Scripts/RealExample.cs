using UnityEngine;

public class RealExample : MonoBehaviour
{
    // 마우스에 적용되는 힘
    public float force;
    // 방향키에 적용되는 힘
    public float arrowForce;

    private new Rigidbody rigidbody;
    MeshRenderer meshRenderer;
    Material material;

    void Awake()
    {

    }

    void OnEnable()
    {

    }

    void OnDisable()
    {

    }

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        //rigidbody.linearVelocity = new Vector3(2, 4, 0);
        //rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);

        // 연속적인 힘 적용
        // 무게적용 : ForceMode.Force
        // 무게무시 : ForceMode.Acceleration;
        // 순간적인힘
        // 무게적용 : ForceMode.Impulse;
        // 무게무시 : ForceMode.VelocityChange;

        meshRenderer = GetComponent<MeshRenderer>();
        //material = GetComponent<Material>();
        material = meshRenderer.material;
    }

    void FixedUpdate()
    {
        // 마우스로 힘적용
        //if (Input.GetMouseButtonDown(0) == true)
        //{
        //    rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);
        //}

        // 방향키로 힘적용
        float leftRight = 0;
        float upDown = 0;
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            leftRight = -arrowForce;
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            leftRight = arrowForce;
        }
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            upDown = arrowForce;
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            upDown = -arrowForce;
        }
        Vector3 forceVector = new Vector3(leftRight, 0, upDown);
        rigidbody.AddForce(forceVector, ForceMode.Impulse);

        // 회전 적용
        //rigidbody.AddTorque(Vector3.right, ForceMode.Acceleration);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.StartsWith("Sphere") == true)
        {
            Debug.Log("충돌 시작 = " + collision.gameObject.name);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Sphere") == true)
        {
            Debug.Log("충돌 중 = " + collision.gameObject.name);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Sphere") == true)
        {
            Debug.Log("충돌 종료 = " + collision.gameObject.name);
        }
    }

    void OnDestroy()
    {

    }



}
