using UnityEngine;

public class MoveExample : MonoBehaviour
{
    

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
        
    }

    void FixedUpdate()
    {

    }

    void Update()
    {
        // position�� �������� ����
        //transform.Translate(new Vector3(0, 0, 0));
        //transform.Translate(new Vector3(0, 0.1f, 0));

        // position�� Ư����ǥ�� �̵�
        //transform.position = new Vector3(0, 4, 0);

        Vector3 targetPosition = new Vector3(5, 2, 0);

        // ������ġ���� Ÿ����ġ�� �̵��ӵ���ŭ �̵�
        //transform.position = Vector3.MoveTowards(transform.position, targetPosition, 0.1f);

        // ������ �̵��ϴٰ� �������� �ٰ����� õõ��
        //Vector3 velocity = Vector3.zero;
        //transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 0.1f);

        // Lerp �������� : ������, õõ��, �����̵�
        //transform.position = Vector3.Lerp(transform.position, targetPosition, 0.05f);

        // SLerp ���鼱������ : ������, õõ��, ������ �̵�
        //transform.position = Vector3.Slerp(transform.position, targetPosition, 0.05f);

        // �̵�
        //transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0));
        //float leftRight = 0.0f;
        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    leftRight = -0.1f;
        //}
        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    leftRight = 0.1f;
        //}
        //float upDown = 0.0f;
        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    upDown = -0.1f;
        //}
        //if (Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    upDown = 0.1f;
        //}        
        //transform.Translate(new Vector3(leftRight, upDown, 0));

        Debug.Log("Time.deltaTime = " + Time.deltaTime);
        //Debug.Log("position = " + transform.position);
        //Debug.Log("localPosition = " + transform.localPosition);
    }

    void LateUpdate()
    {

    }

    void OnDestroy()
    {

    }
}
