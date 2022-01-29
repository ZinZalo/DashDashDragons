using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject player;
    public PlayerController playerController;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        //find gamemanager in scene
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Obstacle":
                playerController.rotationY = 1;
                break;
            case "ArrowRight":
                playerController.eulerRotationY = 90f;
                break;
            case "ArrowLeft":
                playerController.eulerRotationY = 270f;
                break;
            case "ArrowUp":
                playerController.eulerRotationY = 0f;
                break;
            case "ArrowDown":
                playerController.eulerRotationY = 180;
                break;
            case "Enemy":
                if (player.tag != "Enemy")
                {
                    GetComponent<PlayerController>().enabled = false;
                }
                break;
            case "Finish":
                if (player.tag != "Enemy")
                {
                    gameManager.LevelExit();
                    Debug.Log("FINISH!");
                }
                break;
        }
    }
}
