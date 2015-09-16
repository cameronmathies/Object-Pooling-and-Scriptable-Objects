using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseMyScripableObjectsClass : MonoBehaviour {

	public MyScripableObjectsClass myScripableObject;
	private List<Light> myLights;

	void Start () 
	{
		myLights = new List<Light>();
		//foreach (Vector3 spawn in MyScripableObjectsClass.spwanPonits)
		{
			GameObject myLight = new GameObject("Light");
			myLight.AddComponent <Light>();
		//	myLight.transform.position = spawn;
			myLight.GetComponent<Light>().enabled = false;
			if (myScripableObject.colorIsRandom) 
			{
				myLight.GetComponent<Light>().color = new Color (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));
			}
			else
			{
				myLight.GetComponent<Light>().color = myScripableObject.thisColor;
			}
			myLights.Add (myLight.GetComponent<Light>());
		}
	}
	void Update () 
	{
		if (Input.GetButtonDown ("Fire1")) {
			foreach (Light light in myLights) {
				light.enabled = !light.enabled;
			}
		}
	}
}
