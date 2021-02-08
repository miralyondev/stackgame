using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundButton : MonoBehaviour
{
    public Button soundbtn;
    public Sprite soundon;
    public Sprite soundoff;
    bool isClicked = true;
    // Start is called before the first frame update
    void Start()
    {
        soundbtn.onClick.AddListener(BtnOnClick);
        soundbtn.image.sprite = soundon;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void BtnOnClick()
    {
        ChangeState();        
    }
    void ChangeState()
    {
        
        isClicked = !isClicked;
        if (isClicked)
        {
            FindObjectOfType<AudioManager>().Play("Succesful3");
            Debug.Log("its clicked");
            soundbtn.image.sprite = soundon;
            AudioManager.Instance.gameObject.GetComponent<AudioSource>().Play();
        }
        else
        {
            soundbtn.image.sprite = soundoff;
            AudioManager.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }
    }
}
