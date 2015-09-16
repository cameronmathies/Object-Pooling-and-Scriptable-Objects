using UnityEngine;
using System.Collections;

[System.Serializable]
public class MyScripableObjectsClass : ScriptableObject {

	public string objectName = "New MyScripableObject";
	public bool colorIsRandom = false;
	public Color thisColor = Color.white;
	public Vector3[] spwanPonits;
}