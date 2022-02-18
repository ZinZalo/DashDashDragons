using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> characters;
    //currentArrow stores the currently selected arrow as a variable.
    //0: Nothing
    //1: Up
    //2: Down
    //3: Left
    //4: Right
    public int currentArrow;
    public int upArrowAmount;
    public int downArrowAmount;
    public int leftArrowAmount;
    public int rightArrowAmount;
    static bool isEasy = false;
    public bool haveKey = false;
    public bool isFinalLevel = false;
    private UiManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UiManager>();
        Stop();
        currentArrow = 0;
        if (isEasy == true)
        {
            upArrowAmount = downArrowAmount = leftArrowAmount = rightArrowAmount = 999;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        Time.timeScale = 1;
    }

    public void Stop()
    {
        Time.timeScale = 0;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void SetDifficulty()
    {
        switch (isEasy)
        {
            case true:
                isEasy = false;
                break;
            case false:
                isEasy = true;
                break;
        }
    }

    public void LevelExit()
    {
        Stop();
        switch (isFinalLevel)
        {
            case true:
                uiManager.FinalExit();
                break;
            case false:
                uiManager.LevelExit();
                break;
        }
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
    public void LoadLevelAl()
    {
        SceneManager.LoadScene("Level Al", LoadSceneMode.Single);
    }
    public void LoadLevelB()
    {
        SceneManager.LoadScene("Level B", LoadSceneMode.Single);
    }
    public void LoadLevelC()
    {
        SceneManager.LoadScene("Level C", LoadSceneMode.Single);
    }
    public void LoadLevelE()
    {
        SceneManager.LoadScene("Level E", LoadSceneMode.Single);
    }
    public void LoadLevelM()
    {
        SceneManager.LoadScene("Level M", LoadSceneMode.Single);
    }
    public void LoadLevelR()
    {
        SceneManager.LoadScene("Level R", LoadSceneMode.Single);
    }
    public void LoadLevelS()
    {
        SceneManager.LoadScene("Level S", LoadSceneMode.Single);
    }
    public void LoadTitle()
    {
        SceneManager.LoadScene("Main Title", LoadSceneMode.Single);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void SelectUpArrow()
    {
        currentArrow = 1;
    }

    public void SelectDownArrow()
    {
        currentArrow = 2;
    }

    public void SelectLeftArrow()
    {
        currentArrow = 3;
    }

    public void SelectRightArrow()
    {
        currentArrow = 4;
    }

    public void KeyGetter()
    {
        haveKey = true;
        uiManager.KeyIndicatorActive();
    }
}
