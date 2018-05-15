using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KTController : MonoBehaviour {
	public GameObject Prefab;
	public Vector3 clickPosition;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
		rb.useGravity = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1)) {
			clickPosition = Input.mousePosition;
			if (clickPosition.y > Screen.height * 0.39 && clickPosition.x >= 0 && clickPosition.x <= Screen.width) {
				Debug.Log(clickPosition);
				clickPosition.z = 10f;
				// clickPosition.y = clickPosition.y + 30;
				Instantiate(Prefab, Camera.main.ScreenToWorldPoint(clickPosition), Prefab.transform.rotation);
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
