using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Move : MonoBehaviour
{
    Vector3 pos;
    public float delta = 3.0f;
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = pos;
        vec.y += delta * Mathf.Sin(Time.time * speed);
        transform.position = vec;
    }
}
