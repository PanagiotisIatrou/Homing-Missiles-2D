using UnityEngine;

public class HomingMissile : MonoBehaviour
{

	private GameObject TargetGO;
	private float turnSpeed = 3f;
	private float speed = 3f;

	private bool noTargets = false;

	private void Start()
	{
		updateTarget();
	}

	// Locks the nearest target
	private void updateTarget()
	{
		Target[] targets = FindObjectsOfType<Target>();
		if (targets.Length == 0)
		{
			noTargets = true;
			return;
		}
		for (int i = 0; i < targets.Length; i++)
		{
			if (TargetGO == null)
			{
				TargetGO = targets[i].gameObject;
				continue;
			}

			if (Vector3.Distance(transform.position, targets[i].transform.position) < Vector3.Distance(transform.position, TargetGO.transform.position))
				TargetGO = targets[i].gameObject;

		}
	}

	private void Update()
	{
		if (noTargets)
			return;

		// Move and rotate missile
		transform.position += transform.right * speed * Time.deltaTime;
		Vector3 direction = (TargetGO.transform.position - transform.position).normalized;
		Vector3 dir = TargetGO.transform.position - transform.position; float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * turnSpeed);
	}

}
