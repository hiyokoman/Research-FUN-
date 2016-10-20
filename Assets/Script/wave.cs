using UnityEngine;
using System.Collections;

//波
public class etarnal : MonoBehaviour {

	[SerializeField]
	float speed, r;
	float x, y;
	Vector3 startPosition;

	void Start () {
		startPosition = transform.position;
	}

	void Update () {
		x += 0.1f;
		y = r * Mathf.Sin(Time.time * speed);
		transform.position = startPosition + new Vector3 (x, y, 0);
	}
}