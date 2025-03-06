using UnityEngine;
using TMPro;

public class TextTracker : MonoBehaviour
{
    public TextMeshProUGUI textToTrack; // نص يتم تتبعه

    void Start()
    {
        // تحميل النص المحفوظ إذا كان موجودًا
        if (PlayerPrefs.HasKey("TrackedText"))
        {
            textToTrack.text = PlayerPrefs.GetString("TrackedText");
        }
    }

    public void SaveText()
    {
        PlayerPrefs.SetString("TrackedText", textToTrack.text);
        PlayerPrefs.Save(); // تأكيد الحفظ
    }
}
