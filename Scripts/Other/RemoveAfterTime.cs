using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAfterTime : MonoBehaviour {

	public float time;

	void Start () {
		Invoke("RemoveObject", time);
	}

	private void RemoveObject() {
		Destroy(gameObject);
	}
}
