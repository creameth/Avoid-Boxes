using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed= 20.0f;
    private const float turnSpeed=45.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput=Input.GetAxis("Horizontal");
        verticalInput=Input.GetAxis("Vertical");
        //Move the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);
        transform.Rotate(Vector3.up,Time.deltaTime*turnSpeed*horizontalInput);
    }
}
