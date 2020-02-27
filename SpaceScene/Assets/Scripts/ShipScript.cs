using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    //ship speed
    public float speed = 10;
    //initialize a bullet object
    public GameObject bullet;
    //create an audio source
    private AudioSource laser;

    //horizontal variable to store our input values
    private float horizontal;

   

    // Start is called before the first frame update
    void Start()
    {
        //Audio Source is a component, so we need to call GetComponent
        laser = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check for inputs, set equal to a vector
        horizontal = Input.GetAxisRaw("Horizontal");

        //move ship along the X axis according to speed
        transform.Translate(new Vector2(horizontal * speed * Time.deltaTime, 0));


        //If we press spacebar, initialize a bullet object and play laser sound
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.Euler(0,0,90));
            laser.Play();
        }

    

    }

 
}
