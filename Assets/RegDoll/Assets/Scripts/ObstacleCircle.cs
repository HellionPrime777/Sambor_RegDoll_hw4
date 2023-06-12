using System.Collections;
using UnityEngine;

public class ObstacleCircle : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private float _delay;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            _meshRenderer.material.color = _color;
            StartCoroutine("Disable");
        }
    }

    private IEnumerable Disable()
    {
        yield return new WaitForSeconds(_delay);

        transform.gameObject.SetActive(false);
    }
}
