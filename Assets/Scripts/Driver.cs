using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // speed at which the object moves
    [SerializeField] float moveSpeed = 32f;
    // rotation speed at which the object rotates
    [SerializeField] float rotateSpeed = 290f;
    [SerializeField] float slowDownSpeed =10f;
    [SerializeField] float boostSpeed = 50f;

    // Start is called before the first frame update
    

    // Update is called once per frame
    public void Update()
    {
        float steerSpeed = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerSpeed);
        transform.Translate(0 , moveAmount, 0);
    }

    public void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("SlowDown"))
        {
            Debug.Log("SlowDown");
            moveSpeed = slowDownSpeed;
            StartCoroutine(resetMoveSpeed());
        }
        if(other.CompareTag("Boost"))
        {
            Debug.Log("Boost");
            moveSpeed = boostSpeed;
            StartCoroutine(resetMoveSpeed());
        }
    }

    private IEnumerator resetMoveSpeed(){
        Debug.Log("MoveSpeed reset");
        yield return new WaitForSeconds(2.5f);
        moveSpeed = 32f;
    }

}
