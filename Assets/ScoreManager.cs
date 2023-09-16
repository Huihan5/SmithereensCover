using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI Score;

    int scoreRed = 0;
    int scoreBlue = 0;

    int termNumber = 1;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Score.text = termNumber.ToString() + "       " + scoreRed.ToString() + "       " + scoreBlue.ToString() + "       " + termNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPointRed()
    {
        scoreRed += 3;
        Score.text = termNumber.ToString() + "       " + scoreRed.ToString() + "       " + scoreBlue.ToString() + "       " + termNumber.ToString();
    }
}
