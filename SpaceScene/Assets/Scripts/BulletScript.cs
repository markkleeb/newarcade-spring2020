using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //bullet speed variable
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //move in the up direction every frame
        transform.Translate(Vector2.up * speed, Space.World);

    }
}
