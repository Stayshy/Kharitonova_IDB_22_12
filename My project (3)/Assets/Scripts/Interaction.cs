using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
	public Text indicator;

	void Update()
	{
		RaycastHit hit;
		if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
		{
			if (hit.collider.tag == "Item")
			{
				//indicator.text = "ֽאזלט ֵ";
				indicator.enabled = true;
				if (Input.GetKeyDown(KeyCode.E))
				{
					hit.collider.GetComponent<Item>().Interaction();
				}
			}
			else
			{
				indicator.enabled = false;
				//indicator.text = ".";
			}
		}
		else
		{
			indicator.enabled = false;
			//indicator.text = ".";
		}
	}
}
