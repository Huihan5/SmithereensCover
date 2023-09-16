using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManMovement : MonoBehaviour
{
    public bool hit = false;

    public float hitTime = 3f;
    public float hittedTime = 3f;

    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hit)
        {
            myAnim.SetBool("Hitted", true);
            hittedTime = 0;
            hit = false;
        }

        if (hittedTime <= hitTime)
        {
            hittedTime++;
        }

        if (hittedTime >= hitTime)
        {
            myAnim.SetBool("Hitted", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hit = true;
    }
}