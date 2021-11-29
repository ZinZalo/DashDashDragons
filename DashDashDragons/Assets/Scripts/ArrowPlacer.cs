using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPlacer : MonoBehaviour
{
    private int currentArrow;
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
        currentArrow = gameManager.currentArrow;

    }

    private void OnMouseDown()
    {
        switch (currentArrow)
        {
            case 0:
                break;
            case 1:
                Instantiate(upArrowPrefab, transform.position, upArrowPrefab.transform.rotation);
                Destroy(this.gameObject);
                break;
            case 2:
                Instantiate(downArrowPrefab, transform.position, downArrowPrefab.transform.rotation);
                Destroy(this.gameObject);
                break;
            case 3:
                Instantiate(leftArrowPrefab, transform.position, leftArrowPrefab.transform.rotation);
                Destroy(this.gameObject);
                break;
            case 4:
                Instantiate(rightArrowPrefab, transform.position, rightArrowPrefab.transform.rotation);
                Destroy(this.gameObject);
                break;
        }
    }
}
