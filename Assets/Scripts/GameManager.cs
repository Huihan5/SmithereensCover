using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public bool gameover;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameover)
        {
            //termNumber++;
            //scoreRed = 0;
            //scoreBlue = 0;
            gameover = false;
        }
    }
}
