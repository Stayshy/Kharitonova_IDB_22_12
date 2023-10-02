using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDuplicator : MonoBehaviour
{
    public GameObject spherePrefab;
    public Color[] colors;
    public Vector3 offset = new Vector3(1f, 0f, 0f);

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 10; i++)
            {
                DuplicateSphere(i);
            }
        }
    }

    private void DuplicateSphere(int index)
    {
        GameObject newSphere = Instantiate(spherePrefab, transform.position + offset * index, Quaternion.identity);
        Renderer sphereRenderer = newSphere.GetComponent<Renderer>();

        // Меняем цвет на случайный цвет из массива colors
        if (colors.Length > 0)
        {
            Color randomColor = colors[Random.Range(0, colors.Length)];
            sphereRenderer.material.color = randomColor;
        }
    }
}