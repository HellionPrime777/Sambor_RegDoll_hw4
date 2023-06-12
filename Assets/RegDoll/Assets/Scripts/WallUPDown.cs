using System.Collections;

using UnityEngine;

public class WallUPDown : MonoBehaviour
{
    [SerializeField] private float maxHeight = 5f; 
    [SerializeField] private float minHeight = 0f;
    [SerializeField] private float moveSpeed = 2f; 

    [SerializeField] private bool isMovingUp = false; 
    [SerializeField] private bool isMovingDown = false; 

    private void Start()
    {
        transform.position = new Vector3(transform.position.x, minHeight, transform.position.z);
        StartCoroutine(MoveWallRoutine());
    }

    private IEnumerator MoveWallRoutine()
    {
        while (true)
        {
            isMovingUp = true;
            yield return new WaitForSeconds(2f); 
            isMovingUp = false;

            isMovingDown = true;
            yield return new WaitForSeconds(2f);
            isMovingDown = false;
        }
    }

    private void Update()
    {
        if (isMovingUp)
        {
            MoveWall(Vector3.up);
        }
        else if (isMovingDown)
        {
            MoveWall(Vector3.down);
        }
    }

    private void MoveWall(Vector3 direction)
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minHeight, maxHeight), transform.position.z);
    }
}
