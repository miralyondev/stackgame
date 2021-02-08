using UnityEngine;

public class ApplicationQuit : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
