using UnityEngine;
using System.Collections;

public class Anim_Levitate : MonoBehaviour {
	public Vector2 time;
	public Vector2 direction;
	public bool isLocal=false;

	// Use this for initialization
	void Start () {
		Vector3 targetPosition=transform.position;
		targetPosition.x+=direction.x;
		targetPosition.y+=direction.y;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
