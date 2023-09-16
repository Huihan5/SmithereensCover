using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ShooterMovement : MonoBehaviour
{
    public bool red;

    public GameObject bullet;

    public float shootTime = 1;
    public float coolDown = 5;
    public float holdingTimeRed = 0f;
    public float holdingTimeBlue = 0f;

    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(coolDown <= 5)
        {
            coolDown += Time.deltaTime;
        }

        if(shootTime >= 0)
        {
            //myAnim.SetBool("Shooting", true);
            shootTime -= Time.deltaTime;
        }
        else
        {
            //myAnim.SetBool("Shooting", false);
        }

        //shootfire
        if (coolDown >= 5)
        {
            //holding
            if(Input.GetKeyDown(KeyCode.D) && red)
            {
                holdingTimeRed++;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow) && !red)
            {
                holdingTimeBlue++;
            }

            //shot
            if (Input.GetKeyUp(KeyCode.D) && red)
            {
                shootRed();
                holdingTimeRed = 0;
                Debug.Log("shootRed");
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow) && !red)
            {
                shootBlue();
                holdingTimeBlue = 0;
                Debug.Log("shootBlue");
            }
        }
    }

    void shootRed()
    {
        shootTime = 1;

        Vector3 bulletPos = transform.position + new Vector3(3, 3, 0);

        var Bullet = Instantiate(bullet, bulletPos, Quaternion.identity);

        //Bullet.bulletSpeed *= holdingTimeRed;

        coolDown = 0;
    }

    void shootBlue()
    {
        shootTime = 1;

        Vector3 bulletPos = transform.position + new Vector3(3, 3, 0);

        var Bullet = Instantiate(bullet, bulletPos, Quaternion.identity);

        coolDown = 0;
    }
}
