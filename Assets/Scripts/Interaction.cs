using System.Collections;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    Vector3 pos3d;
    GameObject view;

    // Start is called before the first frame update
    void Start()
    {
        view = GameObject.Find("Message");                  //버튼을 클릭하라는 메시지를 담은 창

        view.SetActive(false);                              //시작할 때는 창이 나오지 않음
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetTouch(0).phase == TouchPhase.Began)         //사용자 터치 감지
        {
            pos3d = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);         //사용자의 터지 위치 정보
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);     //ray의 시작점과 방향 알아낸다
            RaycastHit hit;

            if(Physics.Raycast(raycast, out hit))                           //ray가 어느 collider와 부딪혔고
            {
                if (hit.collider.gameObject.name == "Finn")                 //터치한 물체의 collider가 Finn이라면
                {
                    StartCoroutine(ShowMessage(4));                         //4초 동안 메시지 보여준다.
                }
            }
        }
    }

    IEnumerator ShowMessage(float time)
    {
        view.SetActive(true);                           //메시지 창 true
        yield return new WaitForSeconds(time);          //time 초 동안 기다림
        view.SetActive(false);                          //메시지 창 false
    }
}
