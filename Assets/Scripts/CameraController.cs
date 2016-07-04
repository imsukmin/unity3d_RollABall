﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offest;

	// Use this for initialization
	void Start () {
        offest = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offest;
	}
}
