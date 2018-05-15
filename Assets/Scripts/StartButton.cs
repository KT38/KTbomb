using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

  /// ボタンをクリックした時の処理
  public void OnClick() {
    SceneManager.LoadScene ("GameScene");
  }
}
