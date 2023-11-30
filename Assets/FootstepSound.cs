using UnityEngine;


public class FootstepSound : MonoBehaviour
{
    public AudioClip footstepSound;
    public float footstepInterval = 0.5f; // Intervallo tra i suoni dei passi
    private float nextFootstepTime;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // Aggiungi un AudioSource se non è già presente
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        // Controlla se il personaggio sta camminando
        if (IsWalking() && Time.time > nextFootstepTime)
        {
            PlayFootstepSound();
            nextFootstepTime = Time.time + footstepInterval;
        }
    }

    bool IsWalking()
    {
        // Implementa la logica per determinare se il personaggio sta camminando
        // Ad esempio, potresti usare il componente CharacterController, il Rigidbody, ecc.
        // Restituisci true quando il personaggio sta camminando, altrimenti false.

        return true; // Modifica questa logica in base alle tue esigenze.
    }

    void PlayFootstepSound()
    {
        // Riproduci il suono dei passi
        audioSource.PlayOneShot(footstepSound);
    }
}
