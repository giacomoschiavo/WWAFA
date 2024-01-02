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

    public GameObject endingRock;
    void Start()
    {
        collectedObjects = PlayerPrefs.GetInt(saveKey, 0);
    }

    void Update()
    {
        // Controlla se tutti gli oggetti sono stati raccolti
        int collectedObjects = PlayerPrefs.GetInt(saveKey, 0);
        if(collectedObjects == objectsToPick)
        {
            // Se si, carica la scena del Game Over
            endingRock.SetActive(false);
        }
    }
}
