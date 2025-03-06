using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
    public float forceAmount = 500f;
    public float liftForce = 10f;
    private Rigidbody2D rb;

    public int ScoreCount = 0;
    public TextMeshProUGUI scoreShow;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        scoreShow.text = ScoreCount.ToString();
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                Collider2D hitCollider = Physics2D.OverlapPoint(touchPosition);

                if (hitCollider != null && hitCollider.gameObject == gameObject)
                {
                    Vector2 direction = (Vector2)transform.position - touchPosition;
                    direction.Normalize();
                    rb.AddForce(direction * forceAmount);
                    forceAmount += 70;
                    ScoreCount++;
                }
            }
        }
    }

    void FixedUpdate()
    {
        rb.velocity *= 0.98f;
        rb.AddForce(Vector2.up * liftForce);
    }

    // إضافة جديدة: حفظ النتيجة عند تدمير الكائن
    void OnDestroy()
    {
        PlayerPrefs.SetInt("LastScore", ScoreCount);
        PlayerPrefs.Save();
    }

    // إضافة جديدة (اختيارية): يمكن استدعاؤها عند نهاية اللعبة
    public void GameOver()
    {
        PlayerPrefs.SetInt("LastScore", ScoreCount);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainMenu"); // تأكد من إضافة using UnityEngine.SceneManagement;
    }
}