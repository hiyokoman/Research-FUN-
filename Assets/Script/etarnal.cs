using UnityEngine;
using System.Collections;

//はちの字
public class wave : MonoBehaviour {

	[SerializeField]
	float speed, r;
	float x, y;
	Vector3 startPosition;

	void Start ()
	{
		startPosition = transform.position;
	}

	void Update ()
	{
		x = r * Mathf.Cos(Time.time * speed);
		y = r * Mathf.Sin(2 * Time.time * speed)/3;
		transform.position = startPosition + new Vector3 (x, y, 0);
	}
}
