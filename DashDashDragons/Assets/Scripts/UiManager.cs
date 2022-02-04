using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject nextLevel;
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
        upArrowText.text = upArrowAmount.ToString();
    }
    private void DownArrowCheck()
    {
        if (downArrowAmount <= 0)
        {
            downArrowButton.interactable = false;
        }
        downArrowText.text = downArrowAmount.ToString();
    }
    private void LeftArrowCheck()
    {
        if (leftArrowAmount <= 0)
        {
            leftArrowButton.interactable = false;
        }
        leftArrowText.text = leftArrowAmount.ToString();
    }
    private void RightArrowCheck()
    {
        if (rightArrowAmount <= 0)
        {
            rightArrowButton.interactable = false;
        }
        rightArrowText.text = rightArrowAmount.ToString();
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
        //TODO: once all levels are finished this code will move to the next level
        nextLevel.gameObject.SetActive(true);
    }
    public void LoadLevel1()
    {
        gameManager.LoadLevel1();
    }

    public void LoadLevel2()
    {
        gameManager.LoadLevel2();
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
}
