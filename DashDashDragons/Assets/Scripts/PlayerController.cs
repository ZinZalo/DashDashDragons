using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //knight's movement speed
    public float moveSpeed = 1f;
    //object that tells where to move in the grid
    public Transform movePoint;
    //public Transform player;
    public GameObject player;
    //movement direction
    public Vector3 vectorMove;
    //variable to store rotation value
    public int rotationY;
    public float eulerRotationY;
    //raycast to detect objects between player and movePoint
    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        eulerRotationY = -1f;
        PlayerDirection();
        movePoint.parent = null;
        movePoint.position += vectorMove;

    }

    // Update is called once per frame
    void Update()
    {
        //moves player towards movePoint
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        //executed once player reaches movepoint
        if (Vector3.Distance(transform.position, movePoint.position) == 0f)
        {
            MovementRotation();
            PlayerDirection();
            movePoint.position += vectorMove;
            //uses raycast to check if theres a wall between player and movepoint. if true, then returns movepoint to player location
            if (Physics.Linecast(transform.position, movePoint.transform.position, out hit))
            {
                if (hit.transform.tag == "Obstacle")
                {
                    movePoint.position -= vectorMove;
                    rotationY = 1;
                    MovementRotation();
                    PlayerDirection();
                }
            }
        }
        Debug.Log(player.transform.rotation.eulerAngles.y);
    }

    void PlayerDirection()
    {
        switch (player.transform.rotation.eulerAngles.y)
        {
            case 0f:
                vectorMove.Set(-1, 0, 0);
                break;
            case 90f:
                vectorMove.Set(0, 0, 1);
                break;
            case 180f:
                vectorMove.Set(1, 0, 0);
                break;
            case 270f:
                vectorMove.Set(0, 0, -1);
                break;
        }
    }
    public void MovementRotation()
    {
        //Sets player's absolute rotation
        if (eulerRotationY != -1f)
        {
            if (eulerRotationY == 180)
            {
                player.transform.rotation = new Quaternion(0, 1, 0, 0);
            }
            if (eulerRotationY != 180)
            {
                player.transform.eulerAngles = new Vector3(0, eulerRotationY, 0);
            }
            eulerRotationY = -1f;
            rotationY = 0;
        }
        //Sets player's relative rotation
        if (rotationY != 0) {
            player.transform.Rotate(0f, 90f, 0f);
            rotationY = 0;
        }

    }
}
