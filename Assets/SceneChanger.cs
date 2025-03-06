using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public TextTracker textTracker; // سكربت تتبع النص

    public void ChangeScene(string sceneName)
    {
        textTracker.SaveText(); // حفظ النص قبل تغيير المشهد
        SceneManager.LoadScene(sceneName); // الانتقال إلى المشهد التالي
    }
}
