using UnityEngine;
using TMPro;

public class MainMenuScore : MonoBehaviour
{
    public TextMeshProUGUI lastScoreText;

    void Start()
    {
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);
        lastScoreText.text = "Last Score: " + lastScore.ToString();
    }
}