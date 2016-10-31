/*Name:Chujie Ye
 * Student No. 100930068
 * Enemy Controller
 */
using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	[SerializeField]
	private Vector2 speed = Vector2.zero;
	private Transform _transform;
	private Vector2 _currentPosition;
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		_currentPosition = _transform.position;
		Vector2 currSpeed = new Vector2 (speed.x, speed.y);
		_currentPosition -= currSpeed;
		_transform.position = _currentPosition;
		if (_currentPosition.x <=-7.7f) {
			Reset ();
		}

	}
	//recreate an enemy after they are are out of screen
	public void Reset()
	{
		float ypos = Random.Range (-4.2f, 4.2f);
		float xpos = Random.Range (7.3f, 8.3f);
		_currentPosition = new Vector2 (xpos,ypos);
		_transform.position = _currentPosition;
	}
}
