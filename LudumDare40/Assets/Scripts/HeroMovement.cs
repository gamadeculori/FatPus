﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour {
    public float moveSpeed, moveSpeedy;
    Transform character;
    float vertical;
    // Use this for initialization
    void Start ()
    {
        CameraMovement.moveSpeed = moveSpeed;
        character = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        character.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        vertical = Input.GetAxis("Vertical");

        if (vertical > 0f)
        {
            character.Translate(Vector2.up * Time.deltaTime * moveSpeedy);
        }

        if (vertical < 0f)
        {
            character.Translate(Vector2.down * Time.deltaTime * moveSpeedy);
        }
    }
}
