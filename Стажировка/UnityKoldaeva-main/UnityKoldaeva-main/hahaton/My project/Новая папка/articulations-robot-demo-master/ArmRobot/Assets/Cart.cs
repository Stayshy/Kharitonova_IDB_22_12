using UnityEngine;

public class CartMover : MonoBehaviour
{
    public Vector3 delta = new Vector3(5f, 3.74f, 0f);
    public float speed = 0.1f;

    private bool isMoving = false;

    void Start()
    {
        isMoving = true;
    }

    void Update()
    {
        if (isMoving)
        {
            Vector3 moveDelta = delta * speed * Time.deltaTime;

            transform.Translate(moveDelta);


            if (Mathf.Abs(transform.position.x - (transform.position.x + moveDelta.x)) >= Mathf.Abs(delta.x) &&
                Mathf.Abs(transform.position.y - (transform.position.y + moveDelta.y)) >= Mathf.Abs(delta.y))
            {
                speed = 0;
                isMoving = false;
            }
        }
    }
}