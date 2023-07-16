using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcode : MonoBehaviour
{
    
    SpriteRenderer Bullet;
    SpriteRenderer ma_renderer;
    // Start is called before the first frame update
    void Start()
    {
        ma_renderer=GetComponent<SpriteRenderer>();
        Bullet=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.parent = null;

        //每一偵子彈向上飛行
        this.transform.position += new Vector3(0.02f, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.name=="wall")
        Destroy(this.gameObject);
        if(collision.name=="fish")
        Destroy(this.gameObject);
    }
}
