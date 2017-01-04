using UnityEngine;
using System.Collections;

public class TowerController : MonoBehaviour {
	public int speed;
	public Rigidbody rg;

	// Use this for initialization
	void Start () {
		speed = speed + 5;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
