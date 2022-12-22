using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class EnemyAI : MonoBehaviour {
    private NavMeshAgent _navMeshAgent;
    private Transform goalTransform;

    private void Start() {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        goalTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update() {
        transform.LookAt(goalTransform);
        _navMeshAgent.SetDestination(goalTransform.position);
    }
}
