using UnityEngine;
using UnityEngine.SceneManagement; // ضروري للتحكم بالمشاهد

public class moveto : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene("play"); // تحميل المشهد المطلوب
    }
}
