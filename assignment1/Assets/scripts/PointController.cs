/*Name:Chujie Ye
 * Student No. 100930068
 * Control the gift 
 */
using UnityEngine;
using System.Collections;

public class PointController : MonoBehaviour {
	[SerializeField]
	private float speed;
	float speedRange;
	private Transform _transform;
	private Vector2 _currentPosition;
	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset();
	}

	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;

		_currentPosition -= new Vector2 (speed, speedRange);
		_transform.position = _currentPosition;

		if (_currentPosition.y <= -4) {
			Reset ();
		}
   //Recreat the gifts when gifts disappare in the screen
	}
	public void Reset(){
		speedRange = Random.Range (0.05f,0.3f);
		float ypos = Random.Range (4.03f, 5.70f);
		float xpos = Random.Range (-3f, 6.3f);
		_currentPosition = new Vector2 (xpos,ypos);
		_transform.position = _currentPosition;
	}
}
