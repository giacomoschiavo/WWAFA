using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectableItem : MonoBehaviour
{
    
    private bool isInRange = false;
    public TextMeshProUGUI interactionText;
    public StoryScreen storyScreenManager;

    private string interactionMessage = "Press E to read the story";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = true;
            interactionText.text = interactionMessage;
            interactionText.gameObject.SetActive(true); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = false;
            interactionText.gameObject.SetActive(false); 
        }
    }

    private void Update()
    {
        // Controlla se il giocatore è nell'area e ha premuto il tasto "E"
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            PickObject();
            storyScreenManager.ShowStory();
            interactionText.gameObject.SetActive(false); 
        }
    }

    private void PickObject()
    {
        // Incrementa il contatore nel GameManager o esegui altre azioni di raccolta
        FindObjectOfType<GameManager>().collectedObjects++;

        // Distruggi l'oggetto
        Destroy(gameObject);
    }

    public void HideStory()
    {
        
        // Chiama HideStory nell'oggetto StoryScreen
        storyScreenManager.HideStory();
    }
}
