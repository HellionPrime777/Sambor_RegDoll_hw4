using System.Collections;
using UnityEngine;

public class ObstacleCircle : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private float _delay;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print(1);
            _meshRenderer.material.color = _color;
            StartCoroutine("Disable");
        }
    }

    private IEnumerator Disable()
    {
        yield return new WaitForSeconds(_delay);

        transform.gameObject.SetActive(false);
    }
}
