﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleScript : MonoBehaviour
{
   

    
    void Update()
    {

        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("YoshiVolcano");
        }

    }
}
