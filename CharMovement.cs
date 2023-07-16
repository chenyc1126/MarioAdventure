using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    Rigidbody2D girl_Rigidbody2D;
    BoxCollider2D girl_boxcollier2D;
    public GameObject girldie;
    float moveSpeed=3.5f;
    float jumpForce=5f;
    Vector2 moveDirection;
    Animator girl_Animator;
    SpriteRenderer girl_renderer;
    public GameObject Bullet;
    bool alive;
    
    // Start is called before the first frame update
    void Start()
    {
        
        girl_Rigidbody2D= transform.GetComponent <Rigidbody2D>(); 
        GetComponent <Transform>().localPosition=new Vector3(0,0,0);
        girl_Animator=GetComponent<Animator>();
        girl_renderer=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right"))
        {
            girl_Rigidbody2D.velocity=new Vector2(3,0);
        }else if(Input.GetKey("left"))
        {
            girl_Rigidbody2D.velocity=new Vector2(-3,0);
        }
        if(Input.GetKeyUp("right")||Input.GetKeyUp("left"))
        {
            girl_Rigidbody2D.velocity=Vector2.zero;
        }
        if(Input.GetKey("right")||Input.GetKey("left"))
        {
            girl_Animator.SetBool("WalkSwitch",true);
        }
        else if(Input.GetKeyDown("space")){
            girl_Animator.SetBool("JumpSwitch",true);
        }
        else{
            girl_Animator.SetBool("WalkSwitch",false);
            girl_Animator.SetBool("JumpSwitch",false);
        }
        if(Input.GetKey("right"))
        {
            moveDirection.x=moveSpeed;
            girl_renderer.flipX=true;
        }
        else if(Input.GetKey("left"))
        {
            moveDirection.x=-moveSpeed;
            girl_renderer.flipX=false;
        }
        if(Input.GetKeyUp("right")||Input.GetKeyUp("left"))
        {     
            moveDirection=Vector2.zero;
        }
            moveDirection.y=girl_Rigidbody2D.velocity.y;
        if(Input.GetKeyDown("space"))
        {
            moveDirection.y=jumpForce;
        }
        if(Input.GetKeyDown(KeyCode.A)){
            Instantiate(Bullet,this.transform.position,Quaternion.identity);
            Debug.Log(gameObject);
        }
        girl_Rigidbody2D.velocity=moveDirection;
    }
    public void girlDie()
    {
        //ma_Animator.SetBool("alive",false);
        Debug.Log("die");
        Destroy(girl_boxcollier2D);
        girl_Rigidbody2D.velocity=Vector2.zero;
        girl_Rigidbody2D.AddForce(Vector2.up*200f);
        Instantiate(girldie,this.transform.position,Quaternion.identity);
        Destroy(this.gameObject);
        //alive=false;
        //Instantiate(se_marioDie,transform.position,Quaternion.identity);
    }
}
