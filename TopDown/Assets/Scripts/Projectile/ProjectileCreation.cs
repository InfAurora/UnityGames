﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCreation : MonoBehaviour {

    public GameObject shot;
    private Transform playerPosition;

    // Start is called before the first frame update
    void Start() {
        playerPosition = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(0)) {
            Instantiate(shot, playerPosition.position, Quaternion.identity);
        }
    }
}