using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {
	private float time = 60;

	void Start () {
		//初期値60を表示
		//float型からint型へCastし、String型に変換して表示
		GetComponent<Text>().text = ((int)time).ToString();
	}

	void Update (){
		//1秒に1ずつ減らしていく
		time -= Time.deltaTime;
		//マイナスは表示しない
		if (time < 0) SceneManager.LoadScene ("Result");
		GetComponent<Text> ().text = ((int)time).ToString ();
		if (time <= 5) GetComponent<Text> ().color = new Color(255f / 255f, 0f / 255f, 0f / 255f);
	}
}
