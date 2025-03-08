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
        // 현재값에서 증감 분
        //transform.Translate(new Vector3(0, 0, 0));
        //transform.Translate(new Vector3(0, 0.1f, 0));

        float left = 0.0f;
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            left = -0.1f;
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            left = 0.1f;
        }

        float right = 0.0f;
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            right = -0.1f;
        }
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            right = 0.1f;
        }
        //transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0));
        transform.Translate(new Vector3(left, right, 0));
    }

    void LateUpdate()
    {

    }

    void OnDestroy()
    {

    }
}
