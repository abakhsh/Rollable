using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using System;

public class NewEditorTest {

	[Test]
	public void LateUpdate_updatesCameraTransformationPosition() {
		var player = new GameObject ();

		player.transform.position = new Vector3 (1.0f, 1.0f, 1.0f);

		var cameraController = player.AddComponent<CameraController>();

		Debug.Log("finished allocating Camera controller...");

		cameraController.player = player;
		cameraController.transform.position = new Vector3 (3.0f, 3.0f, 3.0f);
		cameraController.Start ();
		cameraController.LateUpdate ();

		Assert.AreEqual (cameraController.transform.position, new Vector3 (3.0f, 3.0f, 3.0f));
	}
}
