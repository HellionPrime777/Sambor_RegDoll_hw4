using UnityEngine;

public class CopyMove : MonoBehaviour
{
    [SerializeField] private Transform _targetJoint;

    private ConfigurableJoint _joint;
    private Quaternion _initialRotation;

    private void Start()
    {
        _joint = GetComponent<ConfigurableJoint>();
        _initialRotation = _targetJoint.rotation;
    }

    private void FixedUpdate()
    {
        _joint.targetRotation = _targetJoint.localRotation * _initialRotation;
    }
}
