using UnityEngine;
using System.Collections;


public class Patrol : MonoBehaviour {

	public Transform[] points;
	public Transform target;
	private int destPoint = 0;
	private UnityEngine.AI.NavMeshAgent agent;
	private RaycastHit hit;
	private bool patrolling = true;

	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

		// Disabling auto-braking allows for continuous movement
		// between points (ie, the agent doesn't slow down as it
		// approaches a destination point).
		agent.autoBraking = true; // But we choose not to disable it.

		GotoNextPoint();
	}


	void GotoNextPoint() {
		// Returns if no points have been set up
		if (points.Length == 0)
			return;

		// Set the agent to go to the currently selected destination.
		agent.destination = points[destPoint].position;

		// Choose the next point in the array as the destination,
		// cycling to the start if necessary.
		destPoint = Random.Range(0, 9);
	}


	void Update () {
		Vector3 direction = target.transform.position - gameObject.transform.position + new Vector3 (0, 0.5f, 0);

		if (Physics.Raycast (transform.position, direction, out hit, 20) && hit.transform == target.transform) {
			if (patrolling) {
				patrolling = false;
			}
			agent.destination = target.position;
		} else if (!patrolling) {
			patrolling = true;
			GotoNextPoint ();
		} else if (!agent.pathPending && agent.remainingDistance < 0.1f) {
			GotoNextPoint();
		}
	}
}