/*Name:Chujie Ye
 * Student No. 100930068
 * Control the rocket's movement
 */
using UnityEngine;
using System.Collections;

public class RocketController : MonoBehaviour {
	[SerializeField]
	private float speed;
	[SerializeField]
	private float speed2;
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _playerInput;
	private float _playerInput2;
	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		_playerInput = Input.GetAxis ("Vertical");
		_playerInput2 = Input.GetAxis ("Horizontal");
		_currentPosition = _transform.position;
		//move right
		if (_playerInput > 0) {
			_currentPosition += new Vector2 (0, speed);
		}
		//move left
		if (_playerInput < 0) {
			_currentPosition -= new Vector2 (0, speed);
		}
		if (_playerInput2 > 0) {
			_currentPosition += new Vector2 (speed2, 0);
		}
		//move left
		if (_playerInput2 < 0) {
			_currentPosition -= new Vector2 (speed2, 0);
		}
		//fix bounds
		checkBounds ();
		_transform.position = _currentPosition;
	}
	//avoid the rocket fly over the bound
	private void checkBounds()
	{
		if (_currentPosition.y < -4.3f) {
			_currentPosition.y = -4.3f;
		}
		if (_currentPosition.y > 3.8f) {
			_currentPosition.y = 3.8f;
		}
		if (_currentPosition.x < -5.8f) {
			_currentPosition.x = -5.8f;
		}
		if (_currentPosition.x > 5.0f) {
			_currentPosition.x = 5.0f;
		}
	}
}
