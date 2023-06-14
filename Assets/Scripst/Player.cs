using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject GameOverobj;
    public float speed;

    public int score;
    public Text text;
    private void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * speed);
        }
    }

    private void gameOver()
    {
        GameOverobj.SetActive(true);
        Time.timeScale = 0;
    }

    public void resetGame()
    {
        SceneManager.LoadScene(0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Point")
        {
            score++;
            text.text = score.ToString();
        }
    }

}
