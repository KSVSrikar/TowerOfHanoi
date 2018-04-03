using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	private GameObject tempdisk = null;     //Disk to move per turn
	//private GameObject[] disks0;
	private GameObject[] disks1;             //3 stacks 
	private GameObject[] disks2;
	private GameObject[] disks3;
	public AudioSource victory; 
	public TextMesh Error;

	private int topofstack1;                //tops of the respective stacks
	private int topofstack2;
	private int topofstack3;

	private bool IsFirstPress;               //to hold movable disk in buffer
	public bool IfCopied = false;           //bool to enable level shifts and populate 
	private bool IsVictory;         //victory check

	// Use this for initialization
	void Start () {
		disks1 = new GameObject[10];
		disks2 = new GameObject[10];
		disks3 = new GameObject[10];
		IsFirstPress = true;
		Error.text = "";
	}

	// Update is called once per frame
void Update () {
		if (IfCopied == false) {
			disks1 = GetComponent<Manager>().disks;           //Logic to Initialize level IfCopied stays true after first 
			topofstack1 = disks1.Length - 1;                  //update frame till level change
			topofstack2 =  - 1;
			topofstack3 =  - 1;
			Error.text = "";
			IsVictory = false;
			IfCopied = true;
		}
		if(Input.GetKeyDown(KeyCode.A)==true){
			if (IsFirstPress == true) {
				if (topofstack1 == -1) {
					Error.text = "EMPTY ROD!";
					//Debug.LogError ("Empty Rod!");
				}
				else {
					tempdisk = disks1 [topofstack1--];
					tempdisk.SetActive(false);
					Error.text = "";
					IsFirstPress = false;
				}
			}
			else{
				if (topofstack1 == -1 || tempdisk.transform.localScale.x < disks1 [topofstack1].transform.localScale.x) {
					disks1 [++topofstack1] = tempdisk; 
					tempdisk.SetActive (true);
					Error.text = "";
					tempdisk.transform.position = new Vector2 (-13, topofstack1 - 3.5f);
					IsFirstPress = true;
				}
				else
					Error.text = "INVALID MOVE!";
					//Debug.LogError("Invalid Move");
			}
		}
		if(Input.GetKeyDown(KeyCode.S)==true){
			if (IsFirstPress == true) {
				if (topofstack2 == -1) {
					Error.text = "EMPTY ROD!";
					//Debug.LogError ("Empty Rod!");
				}
				else{
					tempdisk = disks2 [topofstack2--];
					tempdisk.SetActive(false);
					Error.text = "";
					IsFirstPress = false;
				}
			}
			else{
				if (topofstack2 == -1 || tempdisk.transform.localScale.x < disks2 [topofstack2].transform.localScale.x) {
					disks2 [++topofstack2] = tempdisk; 
					tempdisk.SetActive (true);
					Error.text = "";
					tempdisk.transform.position = new Vector2 (0, topofstack2 - 3.5f);
					IsFirstPress = true;
				}
				else
					Error.text = "INVALID MOVE!";
					//Debug.LogError("Invalid Move");
			}
		}
		if(Input.GetKeyDown(KeyCode.D)==true){
			if (IsFirstPress == true) {
				if (topofstack3 == -1) {
					Error.text = "EMPTY ROD!";
					//Debug.LogError ("Empty Rod!");
				}
				else{
					tempdisk = disks3 [topofstack3--];
					tempdisk.SetActive(false);
					Error.text = "";
					IsFirstPress = false;
				}
			}
			else{
				if (topofstack3 == -1 || tempdisk.transform.localScale.x < disks3 [topofstack3].transform.localScale.x) {
					disks3 [++topofstack3] = tempdisk; 
					tempdisk.SetActive (true);
					Error.text = "";
					tempdisk.transform.position = new Vector2 (13, topofstack3 - 3.5f);
					IsFirstPress = true;
				}
				else
					Error.text = "INVALID MOVE!";
					//Debug.LogError("Invalid Move");
			}
		}
		if(topofstack1 == -1 && topofstack2 == -1 && topofstack3 == GetComponent<Manager>().n - 1 &&IsVictory == false){
			victory.Play ();
			Error.text = "Congrats!! YOU WIN!";
			IsVictory = true;
		}
	}
}
	

