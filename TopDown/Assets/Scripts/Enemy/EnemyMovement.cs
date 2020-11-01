using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float speed;
    private Transform playerPosition;
    private PlayerMovement player;
    // Start is called before the first frame update
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
        transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, speed * Time.deltaTime);
    }

    // player loses health on contact with enemy
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")) {
            player.health -= 1;
            Debug.Log(player.health);
            Destroy(gameObject);
        }
    }
}