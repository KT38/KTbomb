using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultKTCount : MonoBehaviour {
	public UnityEngine.UI.Text ResultCount;

	// Update is called once per frame
	void Update () {
		int resultcount = CountKT.count;
		ResultCount.text = "Score:" + resultcount.ToString ();
	}
}
