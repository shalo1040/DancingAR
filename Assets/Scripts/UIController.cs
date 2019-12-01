using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    bool isSoundOn;
    Button soundBtn;
    GameObject view;
    public Sprite []soundImg;
    DancingMotion dm;

    // Start is called before the first frame update
    void Start()
    {
        dm = new DancingMotion();
        soundBtn = GameObject.Find("soundBtn").GetComponent<Button>();
        view = GameObject.Find("InstructionView");
        isSoundOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCloseBtn()                       //닫기 버튼이 눌리면
    {
        view.SetActive(false);                      //안내 창 닫는다
    }

    public void OnBackBtn()                        //뒤로가기 버튼이 눌리면
    {
        SceneManager.LoadScene(0);                  //Scene01로 돌아간다
    }

    public void OnARBtn()                           
    {   
        SceneManager.LoadScene(1);                  //AR 화면으로 넘어간다
    }

    public void OnSoundBtn()                       //소리 끄기/켜기
    {
        if (isSoundOn)                             //소리가 나는 상태였으면
        {
            //dm.sound.Stop();                           //음악 멈추고
            soundBtn.image.sprite = soundImg[1];                      //음소거 이미지로 바꾸고
            isSoundOn = false;                      //isSoundOn 상태를 false로 바꾼다.
        }
        else                                        //음소거 상태였으면
        {
            //dm.sound.Play();                           //음악 재생하고
            soundBtn.image.sprite = soundImg[0];                      //스피커 이미지로 바꾸고
            isSoundOn = true;                       //isSoundOn 상태를 true로 바꾼다.
        }
    }
}
