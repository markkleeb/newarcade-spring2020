using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCScript : MonoBehaviour
{
    //Grab the ship object
    public GameObject ship;

    //Grab the invader object
    public GameObject invader;

    // Start is called before the first frame update
    void Start()
    {

        //draw 10 invaders across
        for (int i = -5; i < 5; i++)
        {
            //draw 3 rows down
            for (int j = 2; j < 5; j++)
            {
                Instantiate(invader, new Vector2(i, j), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //if we press spacebar, create a new ship object
            Instantiate(ship, new Vector2(0, -3), Quaternion.identity);
            
        }
        
    }
}
