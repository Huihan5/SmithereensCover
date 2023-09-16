using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleMovement : MonoBehaviour
{
    public int health = 10;

    public Sprite health9;
    public Sprite health8;
    public Sprite health7;
    public Sprite health6;
    public Sprite health5;
    public Sprite health4;
    public Sprite health3;
    public Sprite health2;
    public Sprite health1;

    SpriteRenderer myRend;

    public GameObject socreManager;

    public float damageCoolDown = 5;
    public float currentdamageCoolDown = 3;

    // Start is called before the first frame update
    void Start()
    {
        myRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Destroy(gameObject);
        }

        if(currentdamageCoolDown <= damageCoolDown)
        {
            currentdamageCoolDown += Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (currentdamageCoolDown >= damageCoolDown)
        {
            health--;
            currentdamageCoolDown = 0;
        }

        ScoreManager.instance.AddPointRed();

        //activate the lines after implementing the images

        //if(health == 9)
        //{
        //    myRend.sprite = health9;
        //}
        //else if (health == 8)
        //{
        //    myRend.sprite = health8;
        //}
        //else if (health == 7)
        //{
        //    myRend.sprite = health7;
        //}
        //else if (health == 6)
        //{
        //    myRend.sprite = health6;
        //}
        //else if (health == 5)
        //{
        //    myRend.sprite = health5;
        //}
        //else if (health == 4)
        //{
        //    myRend.sprite = health4;
        //}
        //else if (health == 3)
        //{
        //    myRend.sprite = health3;
        //}
        //else if (health == 2)
        //{
        //    myRend.sprite = health2;
        //}
        //else if (health == 1)
        //{
        //    myRend.sprite = health1;
        //}
    }
}
