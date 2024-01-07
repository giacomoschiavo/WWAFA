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

    private string[] subTitles = new string[]{
        "Father's letter",
        "Daughter's diary",
        "Wife's letter",
        "Boss' journal",
        "Tom's journal"
    };


    private static string fatherStory = "My dear family,\n\n" +
        "My pen glides across these pages like a shadow in the dark. The family is scattered, separated for their well-being.\n" + 
        "I've entered into a dark pact with bad people, hoping to secure a better future for you. The empty rooms of the house are a reflection of my guilt. Every step in the darkness is a prayer that shields you from the monster I've unleashed.\n" +
        "In this silent space, my thoughts reach out to you, my dearest wife and daughter. These words carry the weight of a promise to reunite, to rebuild what has been shattered. But beware, for in the shadows lurks a monster, unleashed not by demons, but by choices made in desperation.\n" +
        "May these written words guide you through the labyrinth of our lives, where every turn reveals a fragment of our shared history.\n\n" +
        "With love and regret,\n" +
        "Your Father.\n\n";

    private static string daughterStory = "Dear diary,\n\n" +
        "Today wasn't fun. Daddy's not here, and I miss him lots. Mommy and I are in a tiny home.\n" +
        "I remember when Mommy and Daddy used to read me stories before bed to keep the monster away when we all fell asleep. \nNow, it feels like the monster is hiding in the shadows. Going to bed is scary now.\n\n" +
        "See you tomorrow.\n\n";

    private static string wifeStory = "My dear,\n\n" +
        "Nights are getting scarier. I feel like I'm being watched from the window when we all fall asleep.\n" + 
        "The shadows in the room seem to morph into a haunting presence, an ominous figure that lingers in the darkness.\nMany times, I've glimpsed this creature, dark and haunting, staring at me from outside. Its eyes pierce through the night, and the air is thick with an unsettling tension.\n" +
        "I long to be back with my husband; it's where I feel safest. Going to bed is frightening now, as if the room itself is a canvas for my deepest fears.\n\n" +
        "With yearning,\n" +
        "Your Wife.\n\n";

    private static string bossStory = "Ink stains these pages as I write the twisted tale. The broken family was under constant watch, monitored by a man named Tom.\n"+ 
        "After the father repaid the debt, I decided it was time to end it all. I enlisted Tom, a shadow with a hunger for despair. He will execute the family when they reunite, and all have fallen asleep.\n"+ 
        "The pieces on the chessboard move with cold intent, orchestrated to perfection. As I sit in my solitary armchair, I witness the unfolding tragedy, each move a step closer to the checkmate of their lives.\n" +
        "All these letters and diaries now reside in my own journal, a chronicle of the darkness I've unleashed.\n\n" +
        "With cold intent,\n" +
        "The Boss.\n\n";

    private static string tomStory = "Hi, Tom,\n" +
        "it's me, or should I say, it's you.\nI'm your subconscious.\n" + 
        "In the shadows of ink, I inscribe my final confession. Having extinguished the family while they slumbered, you fled, only to meet the unyielding force of a speeding car.\nPlunged into a coma, I conjured a cavern where death hunts, blind yet attuned to the breath of the living, including yours.\n\nAfter all you've wrought upon that family, do you truly deserve survival?\nThe echoes of their fading dreams reverberate through the cavern, a haunting reminder of your deeds.\n\n"+
        "Do you truly deserve to live?";
    private string[] storyTexts = new string[]{
        fatherStory,
        daughterStory,
        wifeStory,
        bossStory,
        tomStory
    };

    private string[] imagesPath = new string[]{
        "Photos/father",
        "Photos/daughter",
        "Photos/wife",
        "Photos/bossportrait",
        "Photos/tom"
    };

    public GameObject storyCanvas;
    public TextMeshProUGUI storyTitle;

    public TextMeshProUGUI storySubTitle;
    public TextMeshProUGUI storyText;

    public Image storyImage;

    private static Sprite fatherSprite;
    private static Sprite daughterSprite;
    private static Sprite wifeSprite;
    private static Sprite bossSprite;
    private static Sprite tomSprite;

    private static Sprite[] storySprites;

    void Start()
    {
        storyCanvas.SetActive(false);
        fatherSprite = Resources.Load<Sprite>(imagesPath[0]);
        daughterSprite = Resources.Load<Sprite>(imagesPath[1]);
        wifeSprite = Resources.Load<Sprite>(imagesPath[2]);
        bossSprite = Resources.Load<Sprite>(imagesPath[3]);
        tomSprite = Resources.Load<Sprite>(imagesPath[4]);

        storySprites = new Sprite[]{
            fatherSprite,
            daughterSprite,
            wifeSprite,
            bossSprite,
            tomSprite
        };

    }

    public void ShowStory()
    {
        // Mostra il canvas e imposta il testo
        storyCanvas.SetActive(true);
        storyTitle.text = storyTitles[storyNumber];
        storyText.text = "\n" + storyTexts[storyNumber];
        storySubTitle.text = subTitles[storyNumber];
        storyImage.sprite = storySprites[storyNumber];
        // reset scroll view position
        storyText.GetComponentInParent<ScrollRect>().verticalNormalizedPosition = 1f;
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
        PlayerPrefs.SetInt("collectedObjects", storyNumber);
    }
}
