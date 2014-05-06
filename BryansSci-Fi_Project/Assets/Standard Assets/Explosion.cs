using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	
	public float lifetime;
	public GameObject explosion;
	
	void OnTriggerEnter(Collider theEnterer)
	{
		if (theEnterer.tag == "Bullet")
		{
			

			Instantiate(explosion, transform.position, transform.rotation);
			//Destroy(gameObject, lifetime);

			Destroy( theEnterer );
			Destroy(explosion, lifetime);
		}
	}
}
