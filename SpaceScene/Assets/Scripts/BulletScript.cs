using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //bullet speed variable
    public float speed = 10;

    public GCScript gcscript;

    // Start is called before the first frame update
    void Start()
    {
        gcscript = GameObject.FindObjectOfType<GCScript>();
        Destroy(gameObject, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        //move in the up direction every frame
        transform.Translate(Vector2.up * speed, Space.World);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Invader")
        {

            gcscript.AddScore();
            Destroy(collision.gameObject);
            Destroy(gameObject);

            //Nothing will run after this point, I've destroyed myself

        }
    }
}
