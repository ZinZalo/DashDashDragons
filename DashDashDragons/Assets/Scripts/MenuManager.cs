using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelSelectMenu;
    public GameObject aboutMenu;
    public GameObject difficultyToggle;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowLevelSelect()
    {
        mainMenu.gameObject.SetActive(false);
        levelSelectMenu.gameObject.SetActive(true);
    }
    public void HideLevelSelect()
    {
        mainMenu.gameObject.SetActive(true);
        levelSelectMenu.gameObject.SetActive(false);
    }
    public void ShowAbout()
    {
        mainMenu.gameObject.SetActive(false);
        difficultyToggle.gameObject.SetActive(false);
        aboutMenu.gameObject.SetActive(true);
    }
    public void HideAbout()
    {
        mainMenu.gameObject.SetActive(true);
        difficultyToggle.gameObject.SetActive(true);
        aboutMenu.gameObject.SetActive(false);
    }
    public void SetDifficulty()
    {
        gameManager.SetDifficulty();
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2", LoadSceneMode.Single);
    }
    public void LoadLevelA()
    {
        SceneManager.LoadScene("Level A", LoadSceneMode.Single);
    }
    public void LoadLevelB()
    {
        SceneManager.LoadScene("Level B", LoadSceneMode.Single);
    }
    public void LoadLevelC()
    {
        SceneManager.LoadScene("Level C", LoadSceneMode.Single);
    }
}
