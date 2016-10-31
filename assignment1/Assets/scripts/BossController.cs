/*Name:Chujie Ye
 * Student No. 100930068
 * Control the boss
 */
using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour {
	[SerializeField]
	private Vector2 speed = Vector2.zero;
	private Transform _transform;
	private Vector2 _currentPosition;
	// Use this for initialization
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
		if (_currentPosition.x >=12f) {
			Reset ();
		}

	}
	//recreat the boss when the boss is out of bound
	public void Reset()
	{
		float ypos = Random.Range (-3f, 3f);
		_currentPosition = new Vector2 (-25f,ypos);
		_transform.position = _currentPosition;
	}
}
