using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform _pevil;

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        _pevil.Rotate(0f, -horizontal, 0f);

        if (Input.GetKey(KeyCode.W))
        {
            _animator.enabled = true;
        }
        else
        {
            _animator.enabled = false;
        }
    }
}
