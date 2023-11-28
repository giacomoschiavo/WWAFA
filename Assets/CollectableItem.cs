using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        bool isActionKeyActive = FindObjectOfType<SC_FPSController>().IsActionKeyActive;

        // print other tag
        if (other.CompareTag("Player") && isActionKeyActive)
        {
            Debug.Log(other.CompareTag("Player"));
            FindObjectOfType<GameManager>().collectedObjects++;
            Destroy(gameObject);
        }
    }
}
