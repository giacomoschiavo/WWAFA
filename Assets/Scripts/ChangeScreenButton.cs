using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScreenButton : MonoBehaviour
{
    public string sceneName = "TutorialScene"; 

    public void ChangeGameScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}