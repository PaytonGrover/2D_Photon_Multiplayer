using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float x;
    private Rigidbody2D rigidbody;

    private PhotonView photonView;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        photonView = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            x = Input.GetAxis("Horizontal");
            transform.position += (Vector3) new Vector2(x * speed * Time.deltaTime, 0);
        }
       
        if (photonView.IsMine)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    }
}
