using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    public float speed = 3;
    private Vector3 move;
    private float tempSpeed;
    public GameObject bulletA;
    public GameObject bulletB;
    public float delayTime = 1f;
    public float shotDelay = 3f;

    // Update is called once per frame
    private void Start()
    {
        tempSpeed = speed;
    }
    void Update()
    {
        moveVoid();
        reload();
        shootVoid();
    }
    private void moveVoid()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        move = new Vector3(inputX, inputY, 0);
        if (speed == 0) speed = tempSpeed;
        transform.position += move * speed * Time.deltaTime;

        Vector3 camPos = Camera.main.WorldToViewportPoint(transform.position);
        if (camPos.x < 0f) camPos.x = 0f;
        if (camPos.x > 0.7f) camPos.x = 0.7f;
        if (camPos.y < 0.1f) camPos.y = 0.1f;
        if (camPos.y > 0.9f) camPos.y = 0.9f;
        transform.position = Camera.main.ViewportToWorldPoint(camPos);
    }
    void reload()
    {
        shotDelay += Time.deltaTime;
    }
    private void shootVoid()
    {
        if (Input.GetKey(KeyCode.Space) && delayTime <= shotDelay)
        {
            GameObject bullet = Instantiate(bulletA, transform.position, transform.rotation);
            Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
            rigid.AddForce(Vector2.right * 300);
            shotDelay = 0f;
        }
        
    }
}
