using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        this.rig = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        this.Move();
        this.Jump();
    }

    void Move()
    {
        Vector3 moviment = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += moviment * Time.deltaTime * speed;
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump")){
            rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}
