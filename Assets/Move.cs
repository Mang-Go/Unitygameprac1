using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    Rigidbody2D rb; //변수선언
    public float jumpPower;

    int jumpCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //변수 초기화

        jumpCount = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (jumpCount<2)
            {
                GetComponent<AudioSource>().Play();
                rb.velocity = Vector2.up * jumpPower;
                jumpCount++;
            }
            
        }
        
    } 
    void OnCollisionEnter2D(Collision2D collision) {
        if (Score.score>Score.bestScore)
        {
            Score.bestScore= Score.score;
        }
        if (collision.gameObject.tag=="Wood")
        {
            SceneManager.LoadScene("GameOverScene");
        }
        jumpCount = 0;
    }
}

