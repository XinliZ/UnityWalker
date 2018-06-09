using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerByTransform : MonoBehaviour
{
    public LegTransformController legL0;
    public LegTransformController legL1;
    public LegTransformController legL2;
    public LegTransformController legR0;
    public LegTransformController legR1;
    public LegTransformController legR2;

    private float anglePerFrame = 1.6f;

	// Use this for initialization
	void Start () {
        StartCoroutine(_StarProcedure());
	}

    private IEnumerator _StarProcedure()
    {
        yield return _StandUp();

        yield return _Walk();
    }

    private IEnumerator _Walk()
    {
        float angle0 = 0f;
        float angle1 = 180f;
        while (true)
        {
            legL0.SetMovingAngle(angle0);
            legR1.SetMovingAngle(angle0);
            legL2.SetMovingAngle(angle0);
            legR0.SetMovingAngle(angle1);
            legL1.SetMovingAngle(angle1);
            legR2.SetMovingAngle(angle1);

            angle0 += anglePerFrame;
            angle1 += anglePerFrame;
            yield return -1;
        }
    }

    private IEnumerator _StandUp()
    {
        for (float i = 0; i < 90; i += 0.5f)
        {
            legL0.transform.localRotation = Quaternion.Euler(i, 0, 0);
            legL1.transform.localRotation = Quaternion.Euler(i, 0, 0);
            legL2.transform.localRotation = Quaternion.Euler(i, 0, 0);
            legR0.transform.localRotation = Quaternion.Euler(i, 0, 0);
            legR1.transform.localRotation = Quaternion.Euler(i, 0, 0);
            legR2.transform.localRotation = Quaternion.Euler(i, 0, 0);
            yield return -1;
        }
    }
}
