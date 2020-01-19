using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MyHealth : MonoBehaviour
{
    public int hp = 1;
    
    // Start is called before the first frame update
    public void Damage()
    {
        hp -= 1;
        if (hp <= 0)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            SoundManagerBig.instance.PlaySound();
            StartCoroutine(SceneChange());
            
        }
    }
    
    public IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("Over");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyProjectile")
        {
            Damage();
            
        }


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

}
