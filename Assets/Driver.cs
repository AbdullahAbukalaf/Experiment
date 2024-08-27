using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // speed at which the object moves
    [SerializeField] float moveSpeed = 0.01f;
    // rotation speed at which the object rotates
    [SerializeField] float rotateSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float steerSpeed = Input.GetAxis("Horizontal") * rotateSpeed;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Rotate(0, 0, -steerSpeed);
        transform.Translate(0 , moveAmount, 0);
    }
}
