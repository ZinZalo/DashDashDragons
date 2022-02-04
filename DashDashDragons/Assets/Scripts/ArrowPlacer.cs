using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPlacer : MonoBehaviour
{
    private int currentArrow;
    private int upArrowAmount;
    private int downArrowAmount;
    private int leftArrowAmount;
    private int rightArrowAmount;
    private GameManager gameManager;
    public GameObject upArrowPrefab;
    public GameObject downArrowPrefab;
    public GameObject leftArrowPrefab;
    public GameObject rightArrowPrefab;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //get currentArrow from gameManager
        currentArrow = gameManager.currentArrow;
        //get arrow amounts
        upArrowAmount = gameManager.upArrowAmount;
        downArrowAmount = gameManager.downArrowAmount;
        leftArrowAmount = gameManager.leftArrowAmount;
        rightArrowAmount = gameManager.rightArrowAmount;

    }

    //Creates arrow block on click
    private void OnMouseDown()
    {
        switch (currentArrow)
        {
            case 0:
                break;
            case 1:
                if (upArrowAmount > 0)
                {
                    Instantiate(upArrowPrefab, transform.position, upArrowPrefab.transform.rotation);
                    Destroy(this.gameObject);
                    gameManager.upArrowAmount--;
                    gameManager.currentArrow = 0;
                }
                break;
            case 2:
                if (downArrowAmount > 0)
                {
                    Instantiate(downArrowPrefab, transform.position, downArrowPrefab.transform.rotation);
                    Destroy(this.gameObject);
                    gameManager.downArrowAmount--;
                    gameManager.currentArrow = 0;
                }
                break;
            case 3:
                if (leftArrowAmount > 0)
                {
                    Instantiate(leftArrowPrefab, transform.position, leftArrowPrefab.transform.rotation);
                    Destroy(this.gameObject);
                    gameManager.leftArrowAmount--;
                    gameManager.currentArrow = 0;
                }
                break;
            case 4:
                if (rightArrowAmount > 0)
                {
                    Instantiate(rightArrowPrefab, transform.position, rightArrowPrefab.transform.rotation);
                    Destroy(this.gameObject);
                    gameManager.rightArrowAmount--;
                    gameManager.currentArrow = 0;
                }
                break;
        }
    }
}