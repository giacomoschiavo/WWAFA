using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public string gameSceneName = "NomeDellaTuaScenaDelGioco"; // Sostituisci con il nome reale della tua scena di gioco

    private void Start()
    {
        // Collega il metodo all'evento di clic del pulsante
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        // Carica la scena del gioco quando il pulsante viene premuto
        SceneManager.LoadScene(gameSceneName);
    }
}