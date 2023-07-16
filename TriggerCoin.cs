using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCoin : MonoBehaviour
{
    public GameObject coinSoundEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.name);
        //Destroy(this.gameObject);
        if(other.tag=="Player")
        {
            //Instantiate(coinSoundEffect,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
