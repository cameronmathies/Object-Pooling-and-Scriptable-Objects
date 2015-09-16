using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class RecordMotion : MonoBehaviour {

	List<RecordedFrame> frames = new List<RecordedFrame>();

	void Update ()
	{
		var currentFrame = new RecordedFrame(transform.position, transform.rotation);
		frames.Add (currentFrame);
		if (Input.GetKeyDown (KeyCode.S) && Input.GetKey(KeyCode.LeftShift)) {
			Save ();
		}
	}
	void Save ()
	{
		RecordedMotion motion = ScriptableObject.CreateInstance<RecordedMotion> ();
		motion.frames = frames;
		motion.currentFrameNumber = 1;
		AssetDatabase.CreateAsset(motion, "Assets/SavedMotionRecording.asset");
		AssetDatabase.SaveAssets ();
		EditorUtility.FocusProjectWindow ();
		Selection.activeObject = motion;
	}

}
