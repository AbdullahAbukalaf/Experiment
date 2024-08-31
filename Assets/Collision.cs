using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // This method is called when the collider is colliding with another object
   public void OnCollisionEnter2D(Collision2D other) {
    Debug.Log("lol you just crashed the car");
   }

   // This method is called when the collider is triggering something
    public void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("You crossed the line");
    }
}
