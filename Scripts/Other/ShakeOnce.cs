﻿using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class ShakeOnce : MonoBehaviour {

	void Start () {
		CameraShake.ShakeOnce(0.4f, 1.4f);
		AudioManager.Play("SmallExplosion");
	}
}
