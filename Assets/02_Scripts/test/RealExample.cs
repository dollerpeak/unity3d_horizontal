using UnityEngine;

public class RealExample : MonoBehaviour
{
    // ���콺�� ����Ǵ� ��
    public float force;
    // ����Ű�� ����Ǵ� ��
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

        // �������� �� ����
        // �������� : ForceMode.Force
        // ���Թ��� : ForceMode.Acceleration;
        // ����������
        // �������� : ForceMode.Impulse;
        // ���Թ��� : ForceMode.VelocityChange;

        meshRenderer = GetComponent<MeshRenderer>();
        //material = GetComponent<Material>();
        material = meshRenderer.material;
    }

    void FixedUpdate()
    {
        // ���콺�� ������
        //if (Input.GetMouseButtonDown(0) == true)
        //{
        //    rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);
        //}

        // ����Ű�� ������
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

        // ȸ�� ����
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
            //Debug.Log("�浹 ���� = " + collision.gameObject.name);            
            //material.color = Color.red;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Sphere") == true)
        {
            //Debug.Log("�浹 �� = " + collision.gameObject.name);
            //material.color = Color.red;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Sphere") == true)
        {
            //Debug.Log("�浹 ���� = " + collision.gameObject.name);
            //material.color = Color.red;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Cube")
        {
            //Debug.Log("Trigger, �浹 ���� = " + collider.gameObject.name);
            //transform.Translate(new Vector3(0, 0.1f, 0));
        }
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.name == "Cube")
        {
            //Debug.Log("Trigger, �浹 �� = " + collider.gameObject.name);
            //transform.Translate(new Vector3(0, 0.1f, 0));
            rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Cube")
        {
            //Debug.Log("Trigger, �浹 ���� = " + collider.gameObject.name);
        }
    }

    void OnDestroy()
    {

    }


    public void jump()
    {
        rigidbody.AddForce(Vector3.up*10, ForceMode.Impulse);
    }


}
