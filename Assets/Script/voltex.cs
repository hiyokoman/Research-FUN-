using UnityEngine;
using System.Collections;

//インボリュート曲線
public class voltex : MonoBehaviour {

	Vector3 startPosition;
	[SerializeField]
	float r, speed;
	float x, y;

	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		x = r * (Mathf.Cos(speed * Time.time) + (speed * Time.time) * Mathf.Sin(speed * Time.time)); 
		y = r * (Mathf.Sin (speed * Time.time) - (speed * Time.time) * Mathf.Cos (speed * Time.time));

		transform.position = transform.position + new Vector3 (x, y, 0);
	}
}
