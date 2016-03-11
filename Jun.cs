using UnityEngine;
using System.Collections;

public class Jun : Character {

	public static Jun junInstance;
	private int level;
	private enum weapon{};

	void Awake(){

		//Initialise player components
		myBody = GetComponent<Rigidbody2D> (); 
		anim = GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void jump(){

	}

	public void attack(){

	}

	public void slide(){
	
	}

	// public void moveLeft(){}
	// public void moveRight(){}
	// Cannot read other behaviour from the UML diagram

}
