using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Bullet : EnemyBullet
{
   
    private Vector2 leftUp = new Vector2(-1f, 0.5f);
    private Vector2 leftDown = new Vector2(-1f, -0.5f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    protected override void shootVoid()
    {
        if (delayTime <= shotDelay)
        {
            GameObject bullet1 = Instantiate(bulletA, transform.position, transform.rotation);
            GameObject bullet2 = Instantiate(bulletA, transform.position, transform.rotation);
            GameObject bullet3 = Instantiate(bulletA, transform.position, transform.rotation);
            Rigidbody2D rigid1 = bullet1.GetComponent<Rigidbody2D>();
            Rigidbody2D rigid2 = bullet2.GetComponent<Rigidbody2D>();
            Rigidbody2D rigid3 = bullet3.GetComponent<Rigidbody2D>();
            rigid1.AddForce(Vector2.left * speed);
            rigid2.AddForce(leftDown * speed);
            rigid3.AddForce(leftUp * speed);
            shotDelay = 0;
        }

    }
   

}
