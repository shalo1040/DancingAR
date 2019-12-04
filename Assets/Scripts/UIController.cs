using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    bool isSoundOn;
    bool isToggleOn;
    Button soundBtn;
    public GameObject view;
    public Sprite []soundImg;
    public Toggle toggle;

    void Awake()
    {
        soundBtn = GameObject.Find("soundBtn").GetComponent<Button>();      //스피커 버튼
        view = GameObject.Find("Canvas/InstructionView");                   //안내창
        isSoundOn = true;                                                   //소리 유무 저장
    }

    public void OnCloseBtn()                       //닫기 버튼이 눌리면
    {    
        view.SetActive(false);                      //안내 창 닫는다
    }

    public void OnBackBtn()                        //뒤로가기 버튼이 눌리면
    {
        SceneManager.LoadScene(0);                  //Scene01로 돌아간다
    }
    
    public void OnSoundBtn()                       //소리 끄기/켜기
    {
        if (isSoundOn)                             //소리가 나는 상태였으면
        {
            DancingMotion.sound.volume = 0;         //음악 소리 제거하고
            soundBtn.image.sprite = soundImg[1];    //음소거 이미지로 바꾸고
            isSoundOn = false;                      //isSoundOn 상태를 false로 바꾼다.
        }
        else                                        //음소거 상태였으면
        {
            DancingMotion.sound.volume = 1;         //음악 재생하고
            soundBtn.image.sprite = soundImg[0];    //스피커 이미지로 바꾸고
            isSoundOn = true;                       //isSoundOn 상태를 true로 바꾼다.
        }
    }

    public void OnARBtn()
    {
        SceneManager.LoadScene(1);                  //AR 화면으로 넘어간다
    }
}
