using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokemon : MonoBehaviour
{
    Rigidbody2D ma_Rigidbody2D;
    float moveSpeed=3.5f;
    float jumpForce=5f;
    Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        ma_Rigidbody2D= transform.GetComponent <Rigidbody2D>(); 
        GetComponent <Transform>().localPosition=new Vector3(0,0,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right"))
        {
            ma_Rigidbody2D.velocity=new Vector2(3,0);
        }else if(Input.GetKey("left"))
        {
            ma_Rigidbody2D.velocity=new Vector2(-3,0);
        }
        if(Input.GetKeyUp("right")||Input.GetKeyUp("left"))
        {
            ma_Rigidbody2D.velocity=Vector2.zero;
        }
        if(Input.GetKeyDown("space"))
        {
            ma_Rigidbody2D.velocity=Vector2.up*3;
        }
        if(Input.GetKey("right"))
        {
            moveDirection.x=moveSpeed;
        }else if(Input.GetKey("left"))
        {
            moveDirection.x=-moveSpeed;
        }
        if(Input.GetKeyUp("right")||Input.GetKeyUp("left"))
        {     
            moveDirection=Vector2.zero;
        }
            moveDirection.y=ma_Rigidbody2D.velocity.y;
        if(Input.GetKeyDown("space"))
            {
            moveDirection.y=jumpForce;
        }
        ma_Rigidbody2D.velocity=moveDirection;
    }
}
