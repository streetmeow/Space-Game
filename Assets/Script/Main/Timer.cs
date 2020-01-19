using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float tm = 0f;
    // Start is called before the first frame update
    void Start()
    {
        tm = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        tm += Time.deltaTime;
        if (tm > 90)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
