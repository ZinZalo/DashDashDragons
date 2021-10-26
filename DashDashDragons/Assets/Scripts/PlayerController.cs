using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //knight's movement speed
    public float moveSpeed = 1f;
    //object that tells where to move in the grid
    public Transform movePoint;
    public Transform player;
    //movement direction
    public Vector3 vectorMove;
    //variable to store rotation value
    public float rotationY;
    public float eulerRotationY;

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
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, movePoint.position) == 0f)
        {
            MovementRotation();
            PlayerDirection();
            movePoint.position += vectorMove;
        }
    }

    void PlayerDirection()
    {
        //sets knight's movement direction based on it's rotation
       
        if (player.eulerAngles.y == 0f)
        {
            vectorMove.Set(-1, 0, 0);
        }
        else if (player.eulerAngles.y == 90f)
        {
            vectorMove.Set(0, 0, 1);
        }
        else if (player.eulerAngles.y == 180f)
        {
            vectorMove.Set(1, 0, 0);
        }
        else if (player.eulerAngles.y == 270f)
        {
            vectorMove.Set(0, 0, -1);
        }
    }
    public void MovementRotation()
    {
        if (eulerRotationY != -1f)
        {
            player.transform.rotation = Quaternion.Euler(0, eulerRotationY, 0);
            eulerRotationY = -1f;
            rotationY = 0f;
        }
        if (rotationY != 0f) {
            player.transform.Rotate(0f, rotationY, 0f);
            rotationY = 0f;
        }

    }
}
