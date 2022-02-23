using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Allowed")
         {
             Debug.Log("Your game oBJECT IS ALLOWED");

         }
         else if (collision.gameObject.tag == "Not Allowed")
         {
             Debug.Log("Your game object is not ALLOWED");

         } 
        Debug.Log("You won the Game");
    }
}
