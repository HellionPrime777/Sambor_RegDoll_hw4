using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCircle : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private MeshRenderer _meshRenderer;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            _meshRenderer.material.color = _color;
        }
    }
}
