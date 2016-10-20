using UnityEngine;
using System.Collections;

//たて
public class move: MonoBehaviour {

	[SerializeField]
	float speed, r;
	float y;
	Vector3 startPosition;

	void Start()
	{
		startPosition = transform.position;
	}

	void Update()
	{
		y = r * Mathf.Sin(Time.time * speed);
		transform.position = startPosition + new Vector3(0, y, 0);
	}
}