using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker4StrockController : MonoBehaviour
{
    public LegJointController legL0;
    public LegJointController legR0;
    public LegJointController legL1;
    public LegJointController legR1;

    // Use this for initialization
    void Start () {
        StartCoroutine(_startProcedure());
	}

    private IEnumerator _startProcedure()
    {
        yield return new WaitForSeconds(1);

        var c0 = StartCoroutine(legL0._MoveDown());
        var c1 = StartCoroutine(legR0._MoveDown());
        var c2 = StartCoroutine(legL1._MoveDown());
        var c3 = StartCoroutine(legR1._MoveDown());
        yield return c0;
        yield return c1;
        yield return c2;
        yield return c3;
    }
}
