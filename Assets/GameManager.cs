using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int collectedObjects = 0;
    private int objectsToPick = 5;
    private const string saveKey = "collectedObjects";

    public TextMeshProUGUI collectText;

    public GameObject endingRock;
    public GameObject endingArrows;

    public TextMeshProUGUI diariesPickedText;
    void Start()
    {
        // collectedObjects = PlayerPrefs.GetInt(saveKey, 0);
    }

    void Update()
    {
        diariesPickedText.text = collectedObjects.ToString() + "/5";
        // Controlla se tutti gli oggetti sono stati raccolti
        if(collectedObjects == objectsToPick)
        {
            // Se si, carica la scena del Game Over
            endingRock.SetActive(false);
            endingArrows.SetActive(true);
            collectText.gameObject.SetActive(true); 
            collectText.text = "Find the way out!";
        }
    }
}
