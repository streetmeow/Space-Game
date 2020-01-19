using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject bulletA;
    public float speed = 300;
    public float delayTime = 1f;
    public float shotDelay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected void Update()
    {
        shootVoid();
        reload();
    }
    protected void reload()
    {
        shotDelay += Time.deltaTime;
    }
    protected virtual void shootVoid()
    {
        if (delayTime <= shotDelay)
        {
            GameObject bullet = Instantiate(bulletA, transform.position, transform.rotation);
            Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
            rigid.AddForce(Vector2.left * speed);
            shotDelay = 0;
        }

    }
    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            SoundManager.instance.PlaySound();
        }
    }
}
