using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishcontroller : MonoBehaviour
{
    public float movespeed=3f;
    public GameObject fishboom;
    int moveDir=1;
    bool alive = true;
    SpriteRenderer fish_renderer;
    // Start is called before the first frame update
    
    void Start()
    {
        fish_renderer=GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D theObj) {
        if(theObj.gameObject.name=="Bullet(Clone)"){
            Instantiate(fishboom,this.transform.position,Quaternion.identity);
            //alive = false;
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D theObj) {
        if(theObj.collider.name=="wall"){
            if(theObj.GetContact(0).normal.x!=0){
                moveDir*=-1;
                if(moveDir<0){
                    fish_renderer.flipX=false;
                }
                else if(moveDir>0){
                    fish_renderer.flipX=true;
                }
            }
        }
        else if(theObj.collider.tag=="Player"){
                theObj.collider.GetComponent<CharMovement>().girlDie();
        }
        /*else if(theObj.collider.name=="Bullet(Clone)"){
            Instantiate(fishboom,this.transform.position,Quaternion.identity);
            //alive = false;
            Destroy(this.gameObject);
        }*/
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(movespeed*moveDir,0,0)*Time.deltaTime);

    }
}
