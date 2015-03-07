using UnityEngine;
using System.Collections;

public class FPSDebug : MonoBehaviour {

	int count = 0;
	int fps = 0;
	float time = 0f;

	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 60;
	}
	
	// Update is called once per frame
	void Update () {
		// FPS設定
		time += Time.deltaTime;
		count++;
		if(time >= 1.0f) {
			fps = count;
			count = 0;
			time = 0;
		}
	}

	void OnGUI() {
		GUI.Label(new Rect(20,20,100,100), "FPS:" + fps);
	}
}
