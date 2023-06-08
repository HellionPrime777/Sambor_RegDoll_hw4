using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friction : MonoBehaviour
{
    [SerializeField] private PhysicMaterial _default;
    [SerializeField] private PhysicMaterial _zero;
    [SerializeField] private Collider _leftFoot;
    [SerializeField] private Collider _rightFoot;

    public void SetDefaultFriction()
    {
        _rightFoot.material = _default;
        _leftFoot.material = _zero;
    }

    public void SetZeroFriction()
    {
       _rightFoot.material = _zero;
       _leftFoot.material = _default;
    }
}
