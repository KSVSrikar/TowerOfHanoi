using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

	// Use this for initialization
	public GameObject DiskPrefab; 
	private Vector2 SpawnLoc;       //initial setup
	public int n;                    // number of disks per level
	private bool isthere;            // bool for panel toggle
	public GameObject panel;      
	public GameObject[] disks; 
	public PlayerControl script;      //To prevent Player Control script to start before level setup

	void Start () {
		panel.SetActive (true);
		isthere = true;
		script = GetComponent<PlayerControl> ();
		script.enabled = false;                  //To prevent Player Control script to start before level setup
	}
	
	// Update is called once per frame
	void Update () {
		disks = GameObject.FindGameObjectsWithTag ("Disks");
		if(isthere == false){
			panel.SetActive (false);
		}
		if(Input.GetKeyDown(KeyCode.Tab) == true){
			panel.SetActive (!isthere);
			isthere = !isthere;
		}
	}
	// all below functions except Spawner are button functions

	private void Spawner(){
		for (int i = 0; i < n; i++) {
			SpawnLoc = new Vector2 (-13, i - 3.5f);
			GameObject Disk = Instantiate (DiskPrefab, SpawnLoc, Quaternion.identity);
			Disk.transform.localScale = new Vector2 ((n-i) * 0.2f, 1);
		}
	}

	public void GameQuit(){
		Application.Quit ();
	}

	public void Level1(){
		script.enabled = false;
		GetComponent<PlayerControl> ().IfCopied = false;
		for (int i = 0; i < disks.Length; i++) {
			Destroy (disks[i]);
		}
		n = 3;
		Spawner ();
		isthere = false;
		script.enabled = true;
	}
	public void Level2(){
		script.enabled = false;
		GetComponent<PlayerControl> ().IfCopied = false;
		for (int i = 0; i < disks.Length; i++) {
			Destroy (disks[i]);
		}
		n = 4;
		Spawner ();
		isthere = false;
		script.enabled = true;
	}
	public void Level3(){
		script.enabled = false;
		GetComponent<PlayerControl> ().IfCopied = false;
		for (int i = 0; i < disks.Length; i++) {
			Destroy (disks[i]);
		}
		n = 5;
		Spawner ();
		isthere = false;
		script.enabled = true;
	}
	public void Level4(){
		script.enabled = false;
		GetComponent<PlayerControl> ().IfCopied = false;
		for (int i = 0; i < disks.Length; i++) {
			Destroy (disks[i]);
		}
		n = 6;
		Spawner ();
		isthere = false;
		script.enabled = true;
	}
	public void Level5(){
		script.enabled = false;
		GetComponent<PlayerControl> ().IfCopied = false;		
		for (int i = 0; i < disks.Length; i++) {
			Destroy (disks[i]);
		}
		n = 7;
		Spawner ();
		isthere = false;
		script.enabled = true;
	}
}
