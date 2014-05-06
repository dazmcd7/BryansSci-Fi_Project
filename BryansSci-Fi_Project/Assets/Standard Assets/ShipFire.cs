using UnityEngine;
using System.Collections;

public class ShipFire : MonoBehaviour {
	
	public GameObject bullet;
	public float bulletSpeed = 1.0f;
	public float fireRate = 1.0f;
	public float fireRadius = 5.0f;

	float timeShot = 0.25f;
	public GameObject enemyGameObject;

	//public AudioClip FireSound;
	/*
	// Use this for initialization
	void Start ()
	{
		InvokeRepeating("SpawnBullet",fireRate,fireRate);
	}
	
	void SpawnBullet()
	{
		GameObject target = null;
		
		foreach(Collider col in Physics.OverlapSphere(transform.position, fireRadius))
		{
			if(col.tag == "follower")
			{
				target = col.gameObject;
				break;
			}
		}
		
		if(target != null) //fire rocket
		{
			GameObject newBullet = Instantiate(bullet,transform.position,bullet.transform.rotation) as GameObject;
			newBullet.rigidbody.AddForce((target.transform.position - transform.position).normalized*bulletSpeed,ForceMode.VelocityChange);
			//audio.PlayOneShot(FireSound);
		}
	}
	*/
	public void Update()
	{
		float range = 200.0f;
		timeShot += Time.deltaTime;
		float fov = Mathf.PI / 4.0f;
		// Can I see the enemy?
		
		if ((enemyGameObject.transform.position - transform.position).magnitude < range)
		
		{
			float angle;
			Vector3 toEnemy = (enemyGameObject.transform.position - transform.position);
			toEnemy.Normalize();
			angle = (float) Mathf.Acos(Vector3.Dot(toEnemy, transform.forward));
			if (angle < fov)
			{
				if (timeShot > 0.25f)
				{
					GameObject newBullet = Instantiate(bullet,transform.position,bullet.transform.rotation) as GameObject;
					newBullet.rigidbody.AddForce((enemyGameObject.transform.position - transform.position).normalized*bulletSpeed,ForceMode.VelocityChange);
					timeShot = 0.0f;
				}
			}
		}
	}
}