using UnityEngine;
using UnityEngine.UI;

public class StoryScreen : MonoBehaviour
{
    public GameObject storyCanvas;

    void Start()
    {
        // Nascondi il canvas all'inizio
        storyCanvas.SetActive(false);
    }

    public void ShowStory()
    {
        // Mostra il canvas e imposta il testo
        storyCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void HideStory()
    {
        // Nascondi il canvas
        storyCanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
