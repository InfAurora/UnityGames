using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float speed;
    private Transform playerPosition;
    private PlayerMovement player;
    public int health = 10;
    // Start is called before the first frame update
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
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

        if(other.CompareTag("Projectile") && health <= 0) {
            Destroy(gameObject);
            Destroy(other.gameObject);
        } else if(other.CompareTag("Projectile")) {
            Destroy(other.gameObject);
            health--;
        }
    }
}