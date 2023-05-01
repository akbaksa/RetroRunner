using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyOnMouseDown_Rotate : MonoBehaviour
{
    public float angle = 360;
    float rotateAngle = 0;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        rotateAngle = angle;
    }
    //private void OnMouseUp()
    //{
    //    rotateAngle = 0;
    //}
    
    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(0, 0, rotateAngle / 50);
    }
}
