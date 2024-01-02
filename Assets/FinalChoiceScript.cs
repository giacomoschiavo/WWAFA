using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalChoiceScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Triggered2");
            // deactivate player camera
            // other.gameObject.GetComponentInChildren<Camera>().enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            // Carica la scena del Game Over
            SceneManager.LoadScene("GameOverScene");

        }
    }
}
