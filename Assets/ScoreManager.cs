using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text Score;

    int scoreRed = 0;
    int scoreBlue = 0;

    int termNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        Score.text = termNumber.ToString() + "" + scoreRed.ToString() + "       ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
