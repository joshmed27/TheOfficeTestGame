using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Movement Speed of Player
    public float mvtSpeed;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //If forward movement key "w" is pressed then Vector3 is adjusted in the upwards direction
        if(Input.GetKey("w"))
        {
            transform.position += transform.TransformDirection(Vector3.up) * Time.deltaTime * mvtSpeed;
        }
        //If forward movement key "s" is pressed then Vector3 is adjusted in the upwards direction
        else if (Input.GetKey("s"))
        {
            transform.position -= transform.TransformDirection(Vector3.up) * Time.deltaTime * mvtSpeed;
        }
        //If forward movement key "a" and not "d" is pressed then Vector3 is adjusted in the upwards direction
        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * mvtSpeed;
        } else if (!Input.GetKey("a") && Input.GetKey("d"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * mvtSpeed;
        }
    }
}
