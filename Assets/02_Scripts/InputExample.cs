using UnityEngine;

public class InputExample : MonoBehaviour
{
     
    void Update()
    {
        // 키는 down, stay, up 3가지 형태

        // 어떤 키라도
        if (Input.anyKeyDown == true)
        {
            Debug.Log("Input.anyKeyDown, 아무키나 누를때");
        }
        if (Input.anyKey == true)
        {
            Debug.Log("Input.anyKey, 아무키나 누르고 있을때");
        }

        // 키보드 엔터키
        if (Input.GetKeyDown(KeyCode.Return) == true)
        {
            Debug.Log("키보드 엔터 누를때");
        }
        if (Input.GetKey(KeyCode.Return) == true)
        {
            Debug.Log("키보드 엔터 누르고 있을때");
        }
        if (Input.GetKeyUp(KeyCode.Return) == true)
        {
            Debug.Log("키보드 엔터 뗄때");
        }

        // 마우스 0:왼쪽, 1:오른쪽, 2:중간(휠)
        if (Input.GetMouseButtonDown(0) == true)
        {
            Debug.Log("마우스 왼쪽 누를때");
        }
        if (Input.GetMouseButton(0) == true)
        {
            Debug.Log("마우스 왼쪽 누르고 있을때");
        }
        if (Input.GetMouseButtonUp(0) == true)
        {
            Debug.Log("마우스 왼쪽 뗄때");
        }

        // Edit > Project Setting > Input Manager
        if (Input.GetButtonDown("Horizontal") == true)
        {
            Debug.Log("셋팅된값 누를때, Input.GetAxis: " + Input.GetAxis("Horizontal"));
            Debug.Log("셋팅된값 누를때, Input.GetAxisRaw: " + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Horizontal") == true)
        {
            Debug.Log("셋팅된값 누르고 있을때");
        }
        if (Input.GetButtonUp("Horizontal") == true)
        {
            Debug.Log("셋팅된값 뗄때");
        }

    }
}
