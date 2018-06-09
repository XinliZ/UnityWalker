using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegTransformController : MonoBehaviour
{
    private Vector3 centerPosition;
    private float radius = 0.08f;

	// Use this for initialization
	void Start ()
    {
        centerPosition = this.transform.localPosition;
	}

    public void SetMovingAngle(float angle)
    {
        this.transform.localPosition = centerPosition + new Vector3(0, Mathf.Sin(Mathf.Deg2Rad * angle) * radius, Mathf.Cos(Mathf.Deg2Rad * angle) * radius);
    }
	
}
