using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int collectedObjects = 0;
    private int objectsToPick = 5;
    private const string saveKey = "collectedObjects";
    void Start()
    {
        collectedObjects = PlayerPrefs.GetInt(saveKey, 0);
    }


    private void onDestroy()
    {
        PlayerPrefs.SetInt(saveKey, collectedObjects);
        PlayerPrefs.Save();
    }

    void Update()
    {
        // Controlla se tutti gli oggetti sono stati raccolti
        if (collectedObjects >= objectsToPick)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        // Carica la scena del Game Over
        SceneManager.LoadScene("GameOverScene");
    }

}
