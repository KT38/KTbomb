using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountKT : MonoBehaviour {
	public UnityEngine.UI.Text scoreLabel;

	// Update is called once per frame
	void Update () {
		int count = GameObject.FindGameObjectsWithTag ("KT").Length;
		scoreLabel.text = count.ToString ();
	}
}
