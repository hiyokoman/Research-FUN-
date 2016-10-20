using UnityEngine;
using System.Collections;

//えん
public class circle : MonoBehaviour {

	[SerializeField]
	float speed, r;
	float x, y;
	Vector3 startPosition;

	void Start()
	{
		startPosition = transform.position;
	}

	void Update()
	{
		x = r * Mathf.Sin(Time.time * speed);
		y = r * Mathf.Cos(Time.time * speed);

		transform.position = startPosition + new Vector3(x, y, 0);
	}
}
