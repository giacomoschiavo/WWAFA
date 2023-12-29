using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] tutorialScreens;
    private int currentScreenIndex = 0;

    void Start()
    {
        foreach (var screen in tutorialScreens)
        {
            screen.SetActive(false);
        }
        tutorialScreens[0].SetActive(true);
    }

    public void NextScreen()
    {
        tutorialScreens[currentScreenIndex].SetActive(false);
        // Passa alla schermata successiva
        currentScreenIndex++;

        // Se abbiamo raggiunto la fine del tutorial, torna alla schermata iniziale
        if (currentScreenIndex >= tutorialScreens.Length)
        {
            currentScreenIndex = 0;
        }

        tutorialScreens[currentScreenIndex].SetActive(true);
    }
}
