using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverUI;

    // Start is called before the first frame update
    void Start()
    {
        gameoverUI.SetActive(false);
    }

    public void GameOver()
    {
        gameoverUI.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
