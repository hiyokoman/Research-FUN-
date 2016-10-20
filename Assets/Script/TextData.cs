using UnityEngine;
using System.Collections;

public class TextData : MonoBehaviour {
	
	string text;

	public string GetGestureText(string gestureType)
	{
		switch (gestureType)
		{
			case "ななめ":
				text = "using UnityEngine;\nusing System.Collections;\n\n" +
					"//ななめ\n" +
					"public class Naname : MonoBehaviour {\n\n\t" +
					"[SerializeField]\n\t" +
					"float speed, r;\n\t" +
					"float x, y;\n\t" +
					"Vector3 startPosition;\n\n\t" +
					"void Start()\n\t" +
					"{\n\t\t" +
					"startPosition = transform.position;\n\t" +
					"}\n\n\t" +
					"void Update()\n\t" +
					"{\n\t\t" +
					"x = r * Mathf.Sin(Time.time * speed);\n\t\t" +
					"y = r * Mathf.Sin(Time.time * speed);\n\n\t\t" +
					"transform.position = startPosition + new Vector3(x, y, 0);\n\t" +
					"}\n" +
					"}";
				break;

			case "たて":
				text = "using UnityEngine;\nusing System.Collections;\n\n" +
					"//たて\n" +
					"public class move: MonoBehaviour {\n\n\t" +
					"[SerializeField]\n\t" +
					"float speed, r;\n\t" +
					"float y;\n\t" +
					"Vector3 startPosition;\n\n\t" +
					"void Start()\n\t" +
					"{\n\t\t" +
					"startPosition = transform.position;\n\t" +
					"}\n\n\t" +
					"void Update()\n\t" +
					"{\n\t\t" +
					"y = r * Mathf.Sin(Time.time * speed);\n\t\t" +
					"transform.position = startPosition + new Vector3(0, y, 0);\n\t" +
					"}\n" +
					"}";
				break;

			case "よこ":
				text = "using UnityEngine;\n" +
					"using System.Collections;\n\n" +
					"//よこ\npublic class move: MonoBehaviour {\n\n\t" +
					"[SerializeField]\n\t" +
					"float speed, r;\n\t" +
					"float x;\n\t" +
					"Vector3 startPosition;\n\n\t" +
					"void Start()\n\t" +
					"{\n\t\t" +
					"startPosition = transform.position;\n\t" +
					"}\n\n\t" +
					"void Update()\n\t" +
					"{\n\t\t" +
					"x = r * Mathf.Sin(Time.time * speed);\n\t\t" +
					"transform.position = startPosition + new Vector3(0, x, 0);\n\t" +
					"}\n" +
					"}";
				break;
			
			case "えん":
				text = "using UnityEngine;\nusing System.Collections;\n\n" +
					"//えん\npublic class circle : MonoBehaviour {\n\n\t" +
					"[SerializeField]\n\t" +
					"float speed, r;\n\t" +
					"float x, y;\n\t" +
					"Vector3 startPosition;\n\n\t" +
					"void Start()\n\t" +
					"{\n\t\t" +
					"startPosition = transform.position;\n\t" +
					"}\n\n\t" +
					"void Update()\n\t" +
					"{\n\t\t" +
					"x = r * Mathf.Sin(Time.time * speed);\n\t\t" +
					"y = r * Mathf.Cos(Time.time * speed);\n\n\t\t" +
					"transform.position = startPosition + new Vector3(x, y, 0);\n\t" +
					"}\n" +
					"}";
				break;
			
			case "はちのじ":
				text = "using UnityEngine;\n" +
					"using System.Collections;\n\n" +
					"//はちの字\n" +
					"public class etarnal : MonoBehaviour {\n\n\t" +
					"[SerializeField]\n\t" +
					"float speed, r;\n\t" +
					"float x, y;\n\t" +
					"Vector3 startPosition;\n\n\t" +
					"void Start ()\n\t" +
					"{\n\t\t" +
					"startPosition = transform.position;\n\t" +
					"}\n\n\t" +
					"void Update ()\n\t" +
					"{\n\t\t" +
					"x = r * Mathf.Cos(Time.time * speed);\n\t\t" +
					"y = r * Mathf.Sin(2 * Time.time * speed)/3;\n\t\t" +
					"transform.position = startPosition + new Vector3 (x, y, 0);\n\t" +
					"}\n" +
					"}";
				break;
		}
		return text;
	}
}
