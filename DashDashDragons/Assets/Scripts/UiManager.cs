using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject nextLevel;
    public GameObject gameEndButton;
    public GameObject gameEndText;
    public GameObject keyIndicator;
    public GameObject playButton;
    private int upArrowAmount;
    private int downArrowAmount;
    private int leftArrowAmount;
    private int rightArrowAmount;
    public Button upArrowButton;
    public Button downArrowButton;
    public Button leftArrowButton;
    public Button rightArrowButton;
    public TextMeshProUGUI upArrowText;
    public TextMeshProUGUI downArrowText;
    public TextMeshProUGUI leftArrowText;
    public TextMeshProUGUI rightArrowText;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        upArrowAmount = gameManager.upArrowAmount;
        downArrowAmount = gameManager.downArrowAmount;
        leftArrowAmount = gameManager.leftArrowAmount;
        rightArrowAmount = gameManager.rightArrowAmount;
        UpArrowCheck();
        DownArrowCheck();
        LeftArrowCheck();
        RightArrowCheck();
    }

    private void UpArrowCheck()
    {
        if (upArrowAmount <= 0)
        {
            upArrowButton.interactable = false;
        }
        if (upArrowAmount <= 100)
        {
            upArrowText.text = upArrowAmount.ToString();
        }
    }
    private void DownArrowCheck()
    {
        if (downArrowAmount <= 0)
        {
            downArrowButton.interactable = false;
        }
        if (downArrowAmount <= 100)
        {
            downArrowText.text = downArrowAmount.ToString();
        }
    }
    private void LeftArrowCheck()
    {
        if (leftArrowAmount <= 0)
        {
            leftArrowButton.interactable = false;
        }
        if (leftArrowAmount <= 100)
        {
            leftArrowText.text = leftArrowAmount.ToString();
        }
    }
    private void RightArrowCheck()
    {
        if (rightArrowAmount <= 0)
        {
            rightArrowButton.interactable = false;
        }
        if (rightArrowAmount <= 100)
        {
            rightArrowText.text = rightArrowAmount.ToString();
        }
    }
    public void Play()
    {
        gameManager.Play();
    }

    public void Stop()
    {
        gameManager.Stop();
    }
    public void Restart()
    {
        gameManager.Restart();
    }
    public void LevelExit()
    {
        nextLevel.gameObject.SetActive(true);
        playButton.gameObject.SetActive(false);
    }
    public void FinalExit()
    {
        gameEndButton.gameObject.SetActive(true);
        gameEndText.gameObject.SetActive(true);
        playButton.gameObject.SetActive(false);
    }
    public void LoadLevel1()
    {
        gameManager.LoadLevel1();
    }
    public void LoadLevel2()
    {
        gameManager.LoadLevel2();
    }
    public void LoadLevel3()
    {
        gameManager.LoadLevelA();
    }
    public void LoadLevel4()
    {
        gameManager.LoadLevelB();
    }
    public void LoadLevel5()
    {
        gameManager.LoadLevelR();
    }
    public void LoadLevel6()
    {
        gameManager.LoadLevelS();
    }
    public void LoadLevel7()
    {
        gameManager.LoadLevelAl();
    }
    public void LoadLevel8()
    {
        gameManager.LoadLevelM();
    }
    public void LoadLevel9()
    {
        gameManager.LoadLevelC();
    }
    public void LoadLevel10()
    {
        gameManager.LoadLevelE();
    }

    public void LoadTitle()
    {
        gameManager.LoadTitle();
    }

    public void Quit()
    {
        gameManager.Quit();
    }

    public void SelectUpArrow()
    {
        gameManager.SelectUpArrow();
    }

    public void SelectDownArrow()
    {
        gameManager.SelectDownArrow();
    }

    public void SelectLeftArrow()
    {
        gameManager.SelectLeftArrow();
    }

    public void SelectRightArrow()
    {
        gameManager.SelectRightArrow();
    }

    public void KeyIndicatorActive()
    {
        keyIndicator.SetActive(true);
    }
}
