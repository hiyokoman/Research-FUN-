using UnityEngine;
using System.Collections.Generic;

public class a: MonoBehaviour {

	// Use this for initialization
	void Start () {
		List<int> list = new List<int> ();

		list.Add (1);
		list.Add (1);

		Debug.Log (list.Count);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
