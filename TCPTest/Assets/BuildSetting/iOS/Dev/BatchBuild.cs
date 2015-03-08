using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEditor;

/// <summary>
/// バッチモードでビルドを行うクラス.
/// </summary>
public class BatchBuild {

	private static string CompanyName = "";
	private static string ProductName = "";
	private static string BundleVersion = "";
	private static string KeyStorePath = "";
	private static string KeyStorePass = "";
	private static string KeyAliasName = "";
	private static string KeyAliasPass = "";

	private static string BuidlePathiOS = "";
	private static string BuildPathAndroid = "Bin/Android/Project/Dev";


	/// <summary>
	/// ビルドするシーンを取得
	/// </summary>
	/// <returns>The scenes.</returns>
	public static string[] GetScenes() {
		List<string> scenes = new List<string> ();

		// 
		// TODO
		// 

		return scenes.ToArray ();
	}

	public static void BatchBuildiOS() {


	}

	public static void BatchBuildAndroid() {

		// 
		// TODO keystore系の設定
		//

		string[] scenes = GetScenes ();
		// (development かつ Eclipse出力設定)
		string errorMsg = BuildPipeline.BuildPlayer(scenes, 
		                                            BuildPathAndroid, 
		                                            BuildTarget.Android,
		                                            BuildOptions.Development | BuildOptions.AcceptExternalModificationsToPlayer
		                                            );
		if(string.IsNullOrEmpty(errorMsg)) {
			Debug.Log("BatchBuildAndroid success!");
		}
		else {
			Debug.Log("BatchBuildAndroid failed..");
		}
	}


}
