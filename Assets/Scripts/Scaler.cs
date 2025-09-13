using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale += Vector3.one * (_scaleSpeed * Time.deltaTime);
    }
}
