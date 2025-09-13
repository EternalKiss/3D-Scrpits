using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        float rotation = 1;

        transform.Rotate(rotation * _rotationSpeed * Time.deltaTime * Vector3.up);
    }
}
