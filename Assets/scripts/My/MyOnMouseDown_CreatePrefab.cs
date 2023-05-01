using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOnMouseDown_CreatePrefab : MonoBehaviour
{
    public GameObject newPrefab; // 만드는 프리팹 : Inspector에 지정

        // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward);
            pos.z = -5; // 앞쪽에 표시
            // 새로운 프리팹을 만들어 그 위치로 이동한.
            GameObject newGameObject = Instantiate(newPrefab) as GameObject;
            newGameObject.transform.position = pos;
        }
        
    }
}
