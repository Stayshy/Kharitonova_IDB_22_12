using UnityEngine;

public class BounceObject : MonoBehaviour
{
    public float bounceForce = 500f;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Получаем направление отскока, вычисляемый как разница
            // векторов между позицией объекта и позицией столкновения.
            Vector3 direction = transform.position - collision.contacts[0].point;

            // Нормализуем направление отскока для единообразной силы.
            direction = direction.normalized;

            // Применяем силу отскока к объекту.
            rb.AddForce(direction * bounceForce);
        }
    }
}