using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class EnemyAI : MonoBehaviour {
    private NavMeshAgent _navMeshAgent;
    [SerializeField] private Transform goalTransform;

    private void Start() {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        transform.LookAt(goalTransform);
        _navMeshAgent.SetDestination(goalTransform.position);
    }
}
