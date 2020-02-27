using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderScript : MonoBehaviour
{
    //invader speed variable
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move to the right every frame
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    //collision function
    private void OnCollisionEnter2D(Collision2D collision)
    {

        //check to see if we collide with the wall
        if (collision.gameObject.tag == "Wall")
        {
            speed *= -1;
            
        }
    }
}
