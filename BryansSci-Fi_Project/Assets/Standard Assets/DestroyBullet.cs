using UnityEngine;
using System.Collections;

public class DestroyBullet : MonoBehaviour {

	public float life = 1.0f;
	
	// Update is called once per frame
	void Update () {
		life -= Time.deltaTime;
		
		if (life <= 0.0)
		{
			Destroy(gameObject);	
		}
	}
}
