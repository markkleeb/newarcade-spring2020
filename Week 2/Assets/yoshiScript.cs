using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yoshiScript : MonoBehaviour
{

    public KeyCode moveLeft;
    public KeyCode moveRight;
    public float speed = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(moveLeft)) {
        if (Input.GetAxis("Horizontal") < 0 )
        { 
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        // if (Input.GetKeyDown(moveRight))
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetAxis("Jump") > 0)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

       
    }
}
