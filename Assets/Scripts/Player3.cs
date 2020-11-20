using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player3 : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float x;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        transform.position += (Vector3)new Vector2(x * speed * Time.deltaTime, 0);
    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}