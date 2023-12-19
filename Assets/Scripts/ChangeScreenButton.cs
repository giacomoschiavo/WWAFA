using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScreenButton : MonoBehaviour
{
    public string sceneName = "GameScene"; // Sostituisci con il nome reale della tua scena di gioco

    public void ChangeGameScene()
    {
        // Carica la scena del gioco quando il pulsante viene premuto
        SceneManager.LoadScene(sceneName);
    }
}