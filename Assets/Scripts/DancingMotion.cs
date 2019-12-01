using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DancingMotion : MonoBehaviour
{
    Animator anim;                              //animator
    public AudioSource sound;                          //audio source

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();        //animator 불러옴
        sound = GetComponent<AudioSource>();    //audio source 불러옴
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)           //collider 감지
    {
        if (col.CompareTag("MainCamera"))       //카메라의 collider
        {
            anim.SetBool("isFar", false);       //dance animation is on
            sound.Play();                       //play music
        }
    }

    void OnTriggerExit(Collider col)            //collider 감지
    {
        if (col.CompareTag("MainCamera"))       //카메라의 collider
        {
            anim.SetBool("isFar", true);        //wave animation is on
            sound.Stop();                       //stop music

        }
    }
}
