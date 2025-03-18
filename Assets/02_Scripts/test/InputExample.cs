using UnityEngine;

public class InputExample : MonoBehaviour
{
     
    void Update()
    {
        // Ű�� down, stay, up 3���� ����

        // � Ű��
        if (Input.anyKeyDown == true)
        {
            Debug.Log("Input.anyKeyDown, �ƹ�Ű�� ������");
        }
        if (Input.anyKey == true)
        {
            Debug.Log("Input.anyKey, �ƹ�Ű�� ������ ������");
        }

        // Ű���� ����Ű
        if (Input.GetKeyDown(KeyCode.Return) == true)
        {
            Debug.Log("Ű���� ���� ������");
        }
        if (Input.GetKey(KeyCode.Return) == true)
        {
            Debug.Log("Ű���� ���� ������ ������");
        }
        if (Input.GetKeyUp(KeyCode.Return) == true)
        {
            Debug.Log("Ű���� ���� ����");
        }

        // ���콺 0:����, 1:������, 2:�߰�(��)
        if (Input.GetMouseButtonDown(0) == true)
        {
            Debug.Log("���콺 ���� ������");
        }
        if (Input.GetMouseButton(0) == true)
        {
            Debug.Log("���콺 ���� ������ ������");
        }
        if (Input.GetMouseButtonUp(0) == true)
        {
            Debug.Log("���콺 ���� ����");
        }

        // Edit > Project Setting > Input Manager
        if (Input.GetButtonDown("Horizontal") == true)
        {
            Debug.Log("���õȰ� ������, Input.GetAxis: " + Input.GetAxis("Horizontal"));
            Debug.Log("���õȰ� ������, Input.GetAxisRaw: " + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Horizontal") == true)
        {
            Debug.Log("���õȰ� ������ ������");
        }
        if (Input.GetButtonUp("Horizontal") == true)
        {
            Debug.Log("���õȰ� ����");
        }

    }
}
