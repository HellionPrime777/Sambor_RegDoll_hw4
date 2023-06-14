using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Rigidbody _player;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _disableTime;
    [SerializeField] private float _zeroSpring;
    [SerializeField] private float _defaultSpring;
    [SerializeField] private List<ConfigurableJoint> _configurableJoints;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _player.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            StartCoroutine("DisableJoints");
            _audio.Play();
        }
    }


    private IEnumerator DisableJoints()
    {
        SetPositionSpring(_zeroSpring);
        yield return new WaitForSeconds(_disableTime);
        SetPositionSpring(_defaultSpring);
    }
    private void SetPositionSpring(float springValue)
    {
        foreach (var joint in _configurableJoints)
        {
            var jointAngularXDrive = joint.angularXDrive;
            var jointAngularYZDrive = joint.angularYZDrive;

            jointAngularXDrive.positionSpring = springValue;
            jointAngularYZDrive.positionSpring = springValue;

            joint.angularXDrive = jointAngularXDrive;
            joint.angularYZDrive = jointAngularYZDrive;

        }
    }
}
