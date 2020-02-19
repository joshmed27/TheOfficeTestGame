using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    // Movement Speed of Player
    public float mvtSpeed;
    private float camMomentum;

    // FixedUpdate is called once per frame
    void FixedUpdate()
        
    {
        //If forward movement key "w" is pressed then Vector2 is adjusted in the upwards direction else if "s" is pressed it is adjusted in the negative
        if (Input.GetKey("w") && !Input.GetKey("s"))
        {
            transform.position += transform.TransformDirection(Vector2.up) * Time.deltaTime * mvtSpeed;
        }
        else if (!Input.GetKey("w") && Input.GetKey("s"))
        {
            transform.position -= transform.TransformDirection(Vector2.up) * Time.deltaTime * mvtSpeed;
        }

        //If forward movement key "a" is pressed then Vector2 is adjusted in the left direction else if "d" is pressed it is adjusted in the negative
        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector2.left) * Time.deltaTime * mvtSpeed;
        }
        else if (!Input.GetKey("a") && Input.GetKey("d"))
        {
            transform.position -= transform.TransformDirection(Vector2.left) * Time.deltaTime * mvtSpeed;
        }
    }
}
