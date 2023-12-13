using UnityEngine;

public class HideLightWithShift : MonoBehaviour
{
    public Light pointLight; // Riferimento alla Point Light da nascondere
    public ParticleSystem particles;
    private float shiftPressedTime = 0f;
    private bool isShiftPressed = false;
    private float sprintThreshold = 2f;

    void Update()
    {
        // Controlla se il tasto Shift è premuto
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            if (!isShiftPressed)
            {
                isShiftPressed = true;
                shiftPressedTime = Time.time;
            }
        }
        else
        {
            isShiftPressed = false;
        }

        // Nascondi la Point Light se il tasto Shift è stato premuto per più di 2 secondi
        if (isShiftPressed && Time.time - shiftPressedTime > sprintThreshold)
        {
            if (pointLight != null)
            {
                pointLight.enabled = false;
            }
            if (particles != null)
            {
                particles.Stop();
                particles.Clear();
            }
        }
    }
}
