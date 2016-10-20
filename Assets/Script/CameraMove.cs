using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	Vector3 _cameraPosition;

	[SerializeField]
	float speed;

	void Start()
	{
		_cameraPosition = transform.position;
	}

	private void CameraMoving(Vector3 targetPosition)
	{
		targetPosition.x +=  3.55f; //x座標の補正
		targetPosition.y += -3.22f; //y座標の補正
		transform.position = Vector3.Lerp(_cameraPosition, targetPosition, Time.deltaTime * speed);
	}
}
