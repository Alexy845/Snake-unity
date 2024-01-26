using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject panelGameOver;
    [SerializeField] Text finalCount;
    // Start is called before the first frame update
    void Start()
    {
        panelGameOver.SetActive(false);
    }
    
    public void GameOver(int count)
    {
        panelGameOver.SetActive(true);
        finalCount.text = count.ToString();
    }
    public void ChangeScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentScene);
    }
}
