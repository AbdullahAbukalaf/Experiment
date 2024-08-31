using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // speed at which the object moves
    [SerializeField] float moveSpeed = 18f;
    // rotation speed at which the object rotates
    [SerializeField] float rotateSpeed = 300f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float steerSpeed = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerSpeed);
        transform.Translate(0 , moveAmount, 0);
    }
}
