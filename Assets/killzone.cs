using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // استدعاء مكتبة التحكم بالمشاهد

public class KillZone : MonoBehaviour
{
    public string sceneName; // اسم المشهد الذي سيتم الانتقال إليه

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // التحقق من أن الجسم المصطدم هو اللاعب
        {
            SceneManager.LoadScene(sceneName); // تحميل المشهد المحدد
        }
    }
}
