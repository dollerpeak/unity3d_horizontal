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
        // position에 증감분을 적용
        //transform.Translate(new Vector3(0, 0, 0));
        //transform.Translate(new Vector3(0, 0.1f, 0));

        // position을 특정좌표로 이동
        //transform.position = new Vector3(0, 4, 0);

        Vector3 targetPosition = new Vector3(5, 2, 0);

        // 현재위치에서 타켓위치로 이동속도만큼 이동
        //transform.position = Vector3.MoveTowards(transform.position, targetPosition, 0.1f);

        // 빠르게 이동하다가 목적지에 다가오면 천천히
        //Vector3 velocity = Vector3.zero;
        //transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 0.1f);

        // Lerp 선형보간 : 빠르게, 천천히, 직선이동
        //transform.position = Vector3.Lerp(transform.position, targetPosition, 0.05f);

        // SLerp 구면선형보간 : 빠르게, 천천히, 포물선 이동
        //transform.position = Vector3.Slerp(transform.position, targetPosition, 0.05f);

        // 이동
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
