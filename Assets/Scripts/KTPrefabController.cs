using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KTPrefabController : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision collision) {
    //衝突判定
    if (collision.gameObject.tag == "Plane") {
      //相手のタグがBallならば、自分を消す
      DestroyObject(this.gameObject);
    }
  }
}
