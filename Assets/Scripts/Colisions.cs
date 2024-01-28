using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Colisions : MonoBehaviour
{
    [SerializeField] Score scoreText;
    //[SerializeField] Tails snake;

    [SerializeField] SpawnFood spawnFood;
    [SerializeField] GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            //Debug.Log("Food");
            scoreText.ScoreUp();
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            //snake.Grow();
            spawnFood.Comit();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Border"))
        {
            
            SceneManager.LoadScene(1);

        }
    }
}
