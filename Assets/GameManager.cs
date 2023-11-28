using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int collectedObjects = 0;
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

}
