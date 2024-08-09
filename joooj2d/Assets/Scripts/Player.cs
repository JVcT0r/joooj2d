using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float JumpForce;

    public float Speed;

    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += Movement * Time.deltaTime * Speed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rig.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
