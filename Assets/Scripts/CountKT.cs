using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountKT : MonoBehaviour {
	public UnityEngine.UI.Text scoreLabel;
	public static int count = 0;

	// Update is called once per frame
	void Update () {
		count = GameObject.FindGameObjectsWithTag ("KT").Length;
		scoreLabel.text = count.ToString ();
	}
}
