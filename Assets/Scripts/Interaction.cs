using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    Vector3 pos3d;
    GameObject view;

    // Start is called before the first frame update
    void Start()
    {
        view = GameObject.Find("Message");

        view.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetTouch(0).phase == TouchPhase.Began)         //사용자 터치 감지
        {
            pos3d = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if(Physics.Raycast(raycast, out hit))
            {
                if (hit.collider.gameObject.name == "Finn")
                {
                    StartCoroutine(ShowMessage(2));
                }
            }
        }
    }

    IEnumerator ShowMessage(float time)
    {
        view.SetActive(true);
        yield return new WaitForSeconds(time);
        view.SetActive(false);
    }
}
