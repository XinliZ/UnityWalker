using System.Collections;
using UnityEngine;

[RequireComponent(typeof(HingeJoint))]
public class LegJointController : MonoBehaviour
{
    private HingeJoint leg;
    private HingeJoint foreLeg;

	// Use this for initialization
	void Start () {
        leg = GetComponent<HingeJoint>();
        foreLeg = transform.GetChild(0).GetComponent<HingeJoint>();
	}

    public IEnumerator _MoveDown()
    {
        while (true)//this.leg.angle < 90)
        {
            this.leg.motor = new JointMotor() { force = 10010, targetVelocity = 40 };
            this.foreLeg.motor = new JointMotor() { force = 10000, targetVelocity = 0 };
            yield return -1;
        }
        Debug.Log("Finished moving down");
        this.leg.motor = new JointMotor() { force = 0, targetVelocity = 0 };
    }
	
}
