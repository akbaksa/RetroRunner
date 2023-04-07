using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOnCollision_Hide : MonoBehaviour
{
    public string targetObjectName; // 목표 오브젝트 이름: Inspector에 지정
    public string hideObjectName; // 지울 오브젝트 이름

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            GameObject hideObject = GameObject.Find(hideObjectName);
            hideObject.SetActive(false);
        }
    }
}
