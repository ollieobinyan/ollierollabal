using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //how to make a varibale in c#:
    public CharacterController controller; //a var that holds the character's chatacter conteoller componet
    
    public float movespeed = 5f;

    private Vector3 moveDirection = Vector3.zero;




    // Start is called before the first frame update
    void Start()
    {
       controller = GetComponent<CharacterController>(); //Assign controller to character controller
    }

    // Update is called once per frame
    void Update() //update every game tick (seconds)
    {
        //Player movement input
        float horizontalInput = Input.GetAxis("Horizontal");//left and right input from the player
        float verticalInput = Input.GetAxis("Vertical");//forward and backward input from the player

        //calculate the player movement direction
        Vector3 movement = new Vector3(horizontalInput,0,verticalInput);

        //move player based on the input
        controller.Move(movement * movespeed * Time.deltaTime);
    
        
    }
}
