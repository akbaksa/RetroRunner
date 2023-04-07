using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOnMouseDown_Hide : MonoBehaviour
{
    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
    }
}
