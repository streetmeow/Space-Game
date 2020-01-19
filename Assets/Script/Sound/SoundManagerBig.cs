using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerBig : MonoBehaviour
{
 
    public AudioClip soundExplosion;
    AudioSource myAudio;
    public static SoundManagerBig instance;
    private void Awake()
    {
        if (SoundManagerBig.instance == null)
        {
            SoundManagerBig.instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }
    public void PlaySound()
    {
        myAudio.PlayOneShot(soundExplosion);
    }
    // Update is called once per frame
    void Update()
    {

   }


}
