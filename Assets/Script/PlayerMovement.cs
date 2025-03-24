using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform[] playePositions;

    private Rigidbody playerRB;


    private int playerIndex = 1; //Left to Right 2 1 0

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        //Vector3 movement = new Vector3(0, 0, Input.GetAxis("Horizontal")) * moveSpeed * Time.deltaTime;
        //playerRB.MovePosition(playerRB.position + movement);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (playerIndex != 0)
            {
                playerIndex--;
            }

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (playerIndex != 2)
            {
                playerIndex++;
            }

        }


        switch (playerIndex)
        {
            case 0:
                playerRB.MovePosition(playePositions[0].position * moveSpeed);
                break;
            case 1:
                playerRB.MovePosition(playePositions[1].position * moveSpeed);

                break;
            case 2:
                playerRB.MovePosition(playePositions[2].position * moveSpeed);

                break;
        }

    }





}
