using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AnimationController : MonoBehaviour {
    
    private bool facingLeft = true;
    private Rigidbody2D rb;
    private Animator anim;
    private static readonly int Speed = Animator.StringToHash("speed");
    private static readonly int Jump = Animator.StringToHash("jump");


    // We initialize our two references in the Start method
    private void Start () {
        rb = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator> ();
    }

    // We use FixedUpdate to do all the animation work
    private void Update () {

        // Get the extent to which the player is currently pressing left or right
        float h = Input.GetAxis("Horizontal");
        bool jump = Input.GetKey(KeyCode.Space);

        anim.SetFloat(Speed, Mathf.Abs(h));
        anim.SetBool(Jump, jump);
        
        if (h < 0 && !facingLeft)
            ReverseImage ();
        else if (h > 0 && facingLeft)
            ReverseImage ();

    }

    private void ReverseImage()
    {
        Transform t = rb.transform;
        // Switch the value of the Boolean
        facingLeft = !facingLeft;

        // Get and store the local scale of the RigidBody2D
        Vector2 scale = t.localScale;

        // Flip it around the other way
        scale.x *= -1;
        t.localScale = scale;
    }
}