using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KTController : MonoBehaviour {
	public GameObject Prefab;
	public Vector3 clickPosition;
	public GameObject MainCamera;
	public float forwardSpeed = 400;
	public float upSpeed = 500;
	public float rlSpeed = 0;
	private Rigidbody rb;
	private Vector3 prefabPosition;
	private Quaternion prefabRotation;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		prefabPosition[0] = MainCamera.transform.position.x * 1.2f;
		prefabPosition[1] = 5;
		prefabPosition[2] = MainCamera.transform.position.z * 1.2f;

		prefabRotation = MainCamera.transform.rotation;
		prefabRotation.x = 0;
		prefabRotation.z = 0;

		if (Input.GetMouseButtonDown(1)) {
			clickPosition = Input.mousePosition;
			if (clickPosition.y > Screen.height * 0.4 && clickPosition.x >= 0 && clickPosition.x <= Screen.width) {
				rlSpeed = 240 * (clickPosition.x / Screen.width) - 120;
				upSpeed = 270 * ((clickPosition.y - Screen.height * 0.4f) / (Screen.height - Screen.height * 0.4f)) + 230;
				Debug.Log(upSpeed);
				GameObject KTs = Instantiate(Prefab, prefabPosition, prefabRotation)as GameObject;
				Vector3 force;
				force = (KTs.transform.forward * forwardSpeed) + (KTs.transform.up * upSpeed) + (KTs.transform.right * rlSpeed);
				KTs.GetComponent<Rigidbody>().AddForce (force);
			}
    }
	}
	void OnCollisionEnter(Collision collision) {
    //衝突判定
    if (collision.gameObject.tag == "Plane") {
      //相手のタグがBallならば、自分を消す
      Object.Destroy(this.gameObject);
    }
  }
}
