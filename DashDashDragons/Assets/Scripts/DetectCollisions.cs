using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject player;
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        
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
        if (other.gameObject.tag == "Arrow")
        {
            playerController.rotationY = -90f;
            //player.transform.Rotate(0f, -90f, 0f);
        }
        if (other.gameObject.tag == "Enemy")
        {
            GetComponent<PlayerController>().enabled = false;
        }

    }
}
