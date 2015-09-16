using UnityEngine;
using System.Collections;
using UnityEditor;

public class MakemyScripableObject {

	[MenuItem("Assets/Create/My Scriptable Object")]
	public static void CreateMyAsset()
	{
		MyScripableObjectsClass asset = ScriptableObject.CreateInstance<MyScripableObjectsClass>();

		AssetDatabase.CreateAsset(asset, "Assets/NewScripableObject.asset");
		AssetDatabase.SaveAssets();

		EditorUtility.FocusProjectWindow();

		Selection.activeObject = asset;
	}
}
