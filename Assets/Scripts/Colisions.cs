using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Colisions : MonoBehaviour
{
    [SerializeField] Score scoreText;

    [SerializeField] SpawnFood spawnFood;
    [SerializeField] GameManager gameManager;

    Move moving;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            //Debug.Log("Food");
            scoreText.ScoreUp();
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            spawnFood.Comit();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Border"))
        {
            //Debug.Log("GameOver");
            moving.Stop();
            SceneManager.LoadScene(1);

        }
    }
}
