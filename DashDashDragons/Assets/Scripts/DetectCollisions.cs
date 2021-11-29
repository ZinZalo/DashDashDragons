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
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            playerController.rotationY = 90f;
            //player.transform.Rotate(0f, 90f, 0f);
        }
        if (other.gameObject.tag == "ArrowRight")
        {   
            playerController.eulerRotationY = 90f;   
        }
        if (other.gameObject.tag == "ArrowLeft")
        {
            playerController.eulerRotationY = 270f;
        }
        if (other.gameObject.tag == "ArrowUp")
        {
            playerController.eulerRotationY = 0f;
        }
        if (other.gameObject.tag == "ArrowDown")
        {
            playerController.eulerRotationY = 180f;
        }
        if (other.gameObject.tag == "Enemy")
        {
            if (player.tag != "Enemy")
            {
                GetComponent<PlayerController>().enabled = false;
            }
        }
        if (other.gameObject.tag == "Finish")
        {
            if (player.tag != "Enemy")
            {
                gameManager.LevelExit();
                Debug.Log("FINISH!");
            }
        }
    }
}
