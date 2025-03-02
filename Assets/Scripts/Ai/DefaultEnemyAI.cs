using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultEnemyAI : MonoBehaviour
{
    [SerializeField]
    private AIBehaviour shootBehaviour, patrolBehaviour;

    [SerializeField]
    private TankControl tank;
    [SerializeField]
    private AIDetector detector;

    private void Awake()
    {
        detector = GetComponentInChildren<AIDetector>();
        tank = GetComponentInChildren<TankControl>();
    }

    private void Update()
    {
        if (detector.TargetVisible)
        {
            shootBehaviour.PerformAction(tank, detector);
        }
        else
        {
            patrolBehaviour.PerformAction(tank, detector);
        }
    }
}