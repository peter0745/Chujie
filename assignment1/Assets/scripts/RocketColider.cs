/*Name:Chujie Ye
 * Student No. 100930068
 * Control the decrease of health and the increase of points
 */
using UnityEngine;
using System.Collections;

public class RocketColider : MonoBehaviour {
	[SerializeField]
	GameObject explosion = null;
	// Use this to verify what kind of object is colided with the rocket
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "enemy") {
			Debug.Log ("Collision with " + other.gameObject.tag);
			EnemyController e = other.gameObject.GetComponent<EnemyController> ();
			AudioSource asrc = gameObject.GetComponent<AudioSource> ();
			if (asrc != null) {
				asrc.Play ();
			}
			if (e != null) {
				GameObject ex = Instantiate (explosion);
				ex.transform.position = e.transform.position;

			}
			e.Reset ();
			Player.Instance.Health--;
		}
		if (other.gameObject.tag == "boss") {
			Debug.Log ("Collision with " + other.gameObject.tag);
			BossController e = other.gameObject.GetComponent<BossController> ();
			AudioSource asrc = gameObject.GetComponent<AudioSource> ();
			if (asrc != null) {
				asrc.Play ();
			}
			if (e != null) {
				GameObject ex = Instantiate (explosion);
				ex.transform.position = e.transform.position;
			}
			e.Reset ();
			Player.Instance.Health-=2;
		}
		if (other.gameObject.tag == "point") {
			Debug.Log ("Collision with " + other.gameObject.tag);
			PointController e = other.gameObject.GetComponent<PointController> ();
			e.Reset ();
			Player.Instance.Points++;
		}
	}
}
