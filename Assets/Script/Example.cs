using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
	public float speed;

	private Transform target;

	void Awake()
	{
		transform.position = new Vector3(0.0f, 1f, 0.0f);

		var cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		cylinder.transform.localScale = new Vector3(0.15f, 1.0f, 0.15f);

		target = cylinder.transform;
		target.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 1, Random.Range(-10.0f, 10.0f));

	}

	void Update()
	{
		var step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);

		if (Vector3.Distance(transform.position, target.position) < 0.001f)
		{
			target.position = new Vector3(Random.Range(-10.0f, 10.0f), 1, Random.Range(-10.0f, 10.0f));
		}
	}
}
