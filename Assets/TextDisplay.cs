using UnityEngine;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    public TextMeshProUGUI textToShow; // نص يتم عرضه في المشهد الثاني

    void Start()
    {
        if (PlayerPrefs.HasKey("TrackedText"))
        {
            textToShow.text = PlayerPrefs.GetString("TrackedText");
        }
    }
}
