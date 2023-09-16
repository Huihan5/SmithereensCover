using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    public float bulletSpeed = 5;
    public Rigidbody2D myBody;

    bool toRight = true;
    //bool toLeft = false;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();

        //direction of bullets
        if (transform.position.x < 0)
        {
            myBody.velocity = transform.right * bulletSpeed;
            toRight = true;

            Debug.Log("bullet");
        }
        else if (transform.position.x > 0)
        {
            myBody.velocity = -transform.right * bulletSpeed;
            toRight = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //moving forward
        if (toRight)
        {
            transform.position += new Vector3(5 * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position += new Vector3(-5 * Time.deltaTime, 0, 0);
        }

        if(transform.position.y < 0)
        {
            transform.position += new Vector3(0, 1*Time.deltaTime, 0);
        }
        else
        {
            transform.position += new Vector3(0, -1*Time.deltaTime, 0);
        }


        //self-destroy
        if(-500 > transform.position.x || transform.position.x > 500)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Castle")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Cart")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
