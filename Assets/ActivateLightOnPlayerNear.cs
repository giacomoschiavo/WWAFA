using UnityEngine;

public class ActivateLightOnPlayerNear : MonoBehaviour
{
    public GameObject FPSPlayer; // Riferimento al GameObject del giocatore in prima persona
    private Light pointLight; // Riferimento alla Point Light della lanterna
    private ParticleSystem particles; // Riferimento al Particle System della lanterna

    [SerializeField]
    private float activationDistance = 1f;
    private bool isPlayerNear = false;

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
        // Calcola la distanza tra il giocatore e questa lanterna
        float distanceToPlayer = Vector3.Distance(FPSPlayer.transform.position, transform.position);
        // Controlla se il giocatore è abbastanza vicino alla lanterna
        if (distanceToPlayer < activationDistance)
        {
            isPlayerNear = true;
        }
        else
        {
            isPlayerNear = false;
        }

        // Attiva o disattiva la Point Light e il Particle System in base alla vicinanza del giocatore
        if (isPlayerNear)
        {
            if (pointLight != null && pointLight.enabled == false)
            {
                pointLight.enabled = true;
            }

            if (particles != null)
            {
                particles.Play();
            }
        }
    }
}
