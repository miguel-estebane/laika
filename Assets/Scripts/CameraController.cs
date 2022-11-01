using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float CamaraH = 10;
    public float CamaraV = 10;

    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal -= CamaraH * Input.GetAxis ("Mouse Y");
        vertical += CamaraV * Input.GetAxis ("Mouse X");

        transform.eulerAngles = new Vector3(horizontal,vertical, 0.0f);
    }
}
