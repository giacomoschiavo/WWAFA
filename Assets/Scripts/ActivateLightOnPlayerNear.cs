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

    private bool inRange = false;

    void Start()
    {
        // In Start, find the Point Light and Particle System in FPSPlayer
        if (FPSPlayer != null)
        {
            pointLight = FPSPlayer.GetComponentInChildren<Light>();
            particles = FPSPlayer.GetComponentInChildren<ParticleSystem>();
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            pointLight.enabled = true;
            particles.Play();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && !pointLight.enabled)
        {
            inRange = true;
            interactionText.text = interactionMessage;
            interactionText.gameObject.SetActive(true); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionText.gameObject.SetActive(false); 
            inRange = false;
        }
    }

}
