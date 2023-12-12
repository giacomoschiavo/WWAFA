using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActivateLightOnPlayerNear : MonoBehaviour
{
    public GameObject FPSPlayer; // Reference to the FPS player GameObject
    public TextMeshProUGUI interactionText;

    // [SerializeField]
    private float activationDistance = 1f; // Activation distance parameter

    private Light pointLight;
    private ParticleSystem particles;

    private bool activeLantern = false;

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

    void Update()
    {
        if (pointLight == null || particles == null)
        {
            Debug.LogError("Point Light or Particle System not found in FPSPlayer.");
            return;
        }

        float distanceToPlayer = Vector3.Distance(FPSPlayer.transform.position, transform.position);

        if (distanceToPlayer < activationDistance) {
            activeLantern = true;
        }

        if (activeLantern && !pointLight.enabled)
        {
            interactionText.text = interactionMessage;
            interactionText.gameObject.SetActive(true); 
            if (Input.GetKeyDown(KeyCode.E)) {
                pointLight.enabled = true;
                particles.Play();
            }
        } 
        if (activeLantern && distanceToPlayer > activationDistance) {
            interactionText.gameObject.SetActive(false);
            activeLantern = false;
        }
        
    }
}
