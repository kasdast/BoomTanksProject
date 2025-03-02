using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControl : MonoBehaviour
{
    public TankMover tankMover;
    public AimTurret aimTurret;
    public Turret shoot;

    private void Awake()
    {
        if (tankMover == null)
            tankMover = GetComponentInChildren<TankMover>();
        if (aimTurret == null)
            aimTurret = GetComponentInChildren<AimTurret>();
        if (shoot == null)
            shoot = GetComponentInChildren<Turret>();
    }

    public void HandleShoot()
    {
        shoot.Shoot();
    }

    public void HandleMoveBody(Vector2 movementVector)
    {
        tankMover.Move(movementVector);
    }

    public void HandleTurretMovement(Vector2 pointerPosition)
    {
        aimTurret.Aim(pointerPosition);
    }
}
