using UnityEngine;
using System.Collections;

public class CameraBehavior : MonoBehaviour {

	public GameObject player;

	void Start() {
	}

	void LateUpdate() {
		Vector3 translate = new Vector3(	Camera.main.transform.position.x,
											player.transform.position.y,
											0.0f) - Camera.main.transform.position;
		translate *= Time.deltaTime;
		translate.z = 0.0f;
		Camera.main.transform.Translate(translate);
	}
}
