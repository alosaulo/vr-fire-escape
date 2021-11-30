using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject panelWin;
    public GameObject panelLose;

    public static GameManager _instance;
    private void Awake()
    {
        _instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Win() {
        panelWin.SetActive(true);
    }

    public void GameOver() {
        panelLose.SetActive(false);
    }

    public void RestartScene(int sceneNum) {
        SceneManager.LoadScene(sceneNum);
    }

}
