using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public Text scoreText;
    private void Start()
    {
        
        scoreText.text = ("High Score : "+PlayerPrefs.GetInt("score").ToString());
        
    }
    public void ToGame()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<AudioManager>().Play("Succesful3");
    }
}
