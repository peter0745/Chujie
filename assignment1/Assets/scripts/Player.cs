/*Name:Chujie Ye
 * Student No. 100930068
 * Store the data of the player
 */
using UnityEngine;
using System.Collections;

public class Player {
	private static Player instance = null;
	public HUDController hud = null;
	private int points = 0;
	private int health = 10;
	public static Player Instance{

		get{ 
			if (instance == null) {
				instance = new Player ();
			}
			return instance;
		}
	}
	public int Points{
		get{ 
			return points;
		}
		set{ 
			points = value;
			hud.UpdatePoints ();
		}
	}
	public int Health {
		get { 
			return health;
		}
		set { 
			health = value;
			hud.UpdateHealth ();
			if (health <= 0) {
				hud.GameOver ();
			}
		}
	}
}
