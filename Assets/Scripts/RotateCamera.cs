using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizantalnput = Input.GetAxis("Horizontal");
       transform.Rotate(Vector3.up,horizantalnput * rotationSpeed * Time.deltaTime); 
    }
}
