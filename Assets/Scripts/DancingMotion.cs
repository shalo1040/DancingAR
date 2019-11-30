using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DancingMotion : MonoBehaviour
{
    Animator anim;
    bool isFar;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();        //animator 불러옴
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isFar", isFar);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("MainCamera"))
        {
            isFar = false;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("MainCamera"))
        {
            isFar = true;
        }
    }
}
