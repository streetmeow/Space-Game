using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOne : MonoBehaviour
{
    Vector3 pos;
    public GameObject enemyShip;
    public float delta = 5.0f;
    public float speed = 2.0f;
    public float delayTime = 5.0f;
    public float makeTime = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = pos;
        vec.y += delta * Mathf.Sin(Time.time * speed * -1.7f);
        transform.position = vec;
        Reload(); Create();
    }
    void Reload()
    {
        makeTime += Time.deltaTime;
    }
    void Create()
    {
        if (delayTime <= makeTime)
        {
            Quaternion rotation = Quaternion.identity;
            rotation.eulerAngles = new Vector3(0, 0, 90f);
            Instantiate(enemyShip, transform.position, rotation);
            makeTime = 0;
        }
    }
}
