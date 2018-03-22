using UnityEngine;
using System.Collections;

public class Done_DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private Done_GameController gameController;

	public EnemyProv enemy;

	void Awake() {
		enemy = this.GetComponent<EnemyProv>(); 
	}

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <Done_GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Boundary" || other.tag == "Enemy")
		{
			return;
		}

		if (explosion != null)
		{
			Instantiate(explosion, transform.position, transform.rotation);
		}

		if (other.tag == "Player")
		{
			if(enemy != null) {
				enemy.prov_Collide (this.GetInstanceID());
			}
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			gameController.GameOver(this.GetComponent<Collider>().GetInstanceID());
		}
		// Provenance Death
		if (enemy != null) {
			enemy.prov_Death (other.GetInstanceID (), scoreValue);
		}
		gameController.AddScore(scoreValue);
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}