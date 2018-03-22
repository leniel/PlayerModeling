using UnityEngine;
using System.Collections;

public class Done_WeaponController : MonoBehaviour
{
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float delay;
	public EnemyProv prov = null;

	void Awake() {
		prov = GetComponent<EnemyProv>(); 
	}
	void Start ()
	{
		InvokeRepeating ("Fire", delay, fireRate);
	}

	void Fire ()
	{
		GameObject firedShot = (GameObject) Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		GetComponent<AudioSource>().Play();
		
		// Provenance Shoot
		prov.prov_Shoot(firedShot.GetComponent<Collider>().GetInstanceID());
	}
}
