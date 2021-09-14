using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private variables
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //lower case t refers to a component of the current object (playercontroller). Upper case T is a seperate class
        //Input gets us the input manager then getaxis gets us axis referred to in the brackets
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
