using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubik : MonoBehaviour
{
    public GameObject cube;
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnMouseUp()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}
