using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yoshiScript : MonoBehaviour
{

    public KeyCode moveLeft;
    public KeyCode moveRight;
    public float speed = 10;

    private bool facingRight = true;
    private float horizontal;

    public Animator yoshiAnimator;
    private SpriteRenderer yoshiSpriteRenderer;
    

    // Start is called before the first frame update
    void Start()
    {
        yoshiSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontal = Input.GetAxis("Horizontal");

        yoshiAnimator.SetFloat("Speed", Mathf.Abs(horizontal));

        //flip();

        // Yoshi is moving to the left
        // if (Input.GetKeyDown(moveLeft)) {
        if (horizontal < 0 )
        { 
        transform.Translate(Vector3.left * speed * Time.deltaTime);
            facingRight = false;
        }

        //Yoshi is moving to the right
        // if (Input.GetKeyDown(moveRight))
        if (horizontal > 0)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            facingRight = true;
        }

        if (Input.GetAxis("Jump") > 0)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }


        if (facingRight)
        {
            yoshiSpriteRenderer.flipX = false;
        }
        else
        {
            yoshiSpriteRenderer.flipX = true;
        }
       
    }

    void flip()
    {
        //if he is moving left AND facing right, OR moving right AND facing left - FLIP
        if(horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 position = transform.localScale;
            position.x *= -1;
            transform.localScale = position;
        }

    }
}
