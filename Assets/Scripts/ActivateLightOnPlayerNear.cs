using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActivateLightOnPlayerNear : MonoBehaviour
{
    public GameObject FPSPlayer; // Reference to the FPS player GameObject
    public TextMeshProUGUI interactionText;

    // [SerializeField]

    private Light pointLight;
    private ParticleSystem particles;


    private string interactionMessage = "Press E to activate the lantern";

    void Start()
    {
        // In Start, find the Point Light and Particle System in FPSPlayer
        if (FPSPlayer != null)
        {
            pointLight = FPSPlayer.GetComponentInChildren<Light>();
            particles = FPSPlayer.GetComponentInChildren<ParticleSystem>();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && !pointLight.enabled)
        {
            interactionText.text = interactionMessage;
            interactionText.gameObject.SetActive(true); 

            if (Input.GetKeyDown(KeyCode.E)) {
                pointLight.enabled = true;
                particles.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionText.gameObject.SetActive(false); 
        }
    }

}
