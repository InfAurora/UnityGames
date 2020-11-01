using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private Rigidbody2D rigidBody;
    public int health = 10;
    Vector2 moveVelocity;
    // Start is called before the first frame update
    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

    private void FixedUpdate() {
        rigidBody.MovePosition(rigidBody.position + moveVelocity * Time.fixedDeltaTime);
    }
}