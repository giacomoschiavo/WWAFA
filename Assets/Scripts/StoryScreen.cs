using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoryScreen : MonoBehaviour
{
    private int storyNumber = 0;

    private string[] storyTitles = new string[]{
        "A Dark Pact",
        "Stories in the Night",
        "Watcher in the Night",
        "Tom's Watchful Eyes",
        "Echoes of Guilt"
    };

    private string[] storyTexts = new string[]{
        "My pen glides across these pages like a shadow in the dark. The family is scattered, separated for their well-being. I've entered into a dark pact with bad people, hoping to secure a better future for you. The empty rooms of the house are a reflection of my guilt. Every step in the darkness is a prayer that shields you from the monster I've unleashed.",
        "Today was not fun. Daddy is not here, and I miss him a lot. Me and mommy are in a tiny home. I remember when mommy and daddy used to read me stories before bed to keep the monster away when we all fell asleep. Now, it feels like the monster is hiding in the shadows.",
        "Nights are getting scarier. I feel like I'm being watched from the window when we all fall asleep. Many times, I've glimpsed a creature staring at me from outside. I long to be back with my husband; it's where I feel safest.",
        "Ink stains these pages as I write the twisted tale. The broken family was under constant watch, monitored by a man named Tom. After the father repaid the debt, I decided it was time to end it all. I enlisted Tom. He will execute the family when they reunite, and all have fallen asleep.",
        "In the shadows of ink, I inscribe my final confession. Having extinguished the family while they slumbered, I fled, only to meet the unyielding force of a speeding car. Plunged into a coma, my subconscious conjured a cavern where death hunts, blind yet attuned to the breath of the living, including mine. After all I've wrought upon that family, do I truly deserve survival?"
    };

    public GameObject storyCanvas;
    public TextMeshProUGUI storyTitle;
    public TextMeshProUGUI storyText;


    void Start()
    {
        storyCanvas.SetActive(false);
    }

    public void ShowStory()
    {
        // Mostra il canvas e imposta il testo
        storyCanvas.SetActive(true);
        storyTitle.text = storyTitles[storyNumber];
        storyText.text = storyTexts[storyNumber];
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void HideStory()
    {
        // Nascondi il canvas
        storyCanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        storyNumber++;
    }
}
