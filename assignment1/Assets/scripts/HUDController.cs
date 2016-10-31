/*Name:Chujie Ye
 * Student No. 100930068
 * Control the button and labels of the screen
 */
using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class HUDController : MonoBehaviour {
	[SerializeField]
	Text pointLbl = null;
	[SerializeField]
	Text healthLbl = null;
	[SerializeField]
	GameObject player =null;
	[SerializeField]
	Button restartBtn = null;
	[SerializeField]
	Text gameOverLbl = null;
	//update the points when the rocket collide with the points
	public void UpdatePoints()
	{
		pointLbl.text = "Points: " + Player.Instance.Points;
	}
	//update the health when the rocket collide with the enemys and boss
	public void UpdateHealth()
	{
		healthLbl.text = "Health: " + Player.Instance.Health;
	}
	// Use this for initialization
	void Start () {
		Player.Instance.hud = this;
		Restart ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//called when the game is over
	public void GameOver()
	{
		pointLbl.gameObject.SetActive (false);
		player.SetActive (false);
		gameOverLbl.gameObject.SetActive (true);
		gameOverLbl.text = "Points: " + Player.Instance.Points;
		restartBtn.gameObject.SetActive (true);
	}
	//called when the restart button is press
	public void Restart()
	{
		pointLbl.gameObject.SetActive (true);
		player.SetActive (true);
		Player.Instance.Points = 0;
		Player.Instance.Health = 10;
		gameOverLbl.gameObject.SetActive (false);
		restartBtn.gameObject.SetActive (false);
	}
}
 