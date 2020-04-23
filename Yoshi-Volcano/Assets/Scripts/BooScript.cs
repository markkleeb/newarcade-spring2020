using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BooScript : MonoBehaviour
{

    public GameObject player;
    public float speed = 1.0f;
    

    
    void Update()
    {
        float interpolation = speed * Time.deltaTime;
        Vector3 position = this.transform.position;

        position.y = Mathf.Lerp(this.transform.position.y, player.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, player.transform.position.x, interpolation);

        this.transform.position = position;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("TitleScreen");
        }

    }


}
