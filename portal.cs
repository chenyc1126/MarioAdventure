using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal : MonoBehaviour
{
     [Header ("連結到場景")]
    public string targetScene;
    void OnTriggerEnter2D(Collider2D theCollider) 
    {
        if(theCollider.CompareTag("Player"))
        {
            Debug.Log("trigger");
            SceneManager.LoadScene(targetScene);
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
