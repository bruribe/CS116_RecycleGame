﻿using UnityEngine;
using System.Collections;

/*
 * ItemManager used for various objects for the game 
 *
*/

public class ItemManager : MonoBehaviour {
	public static ItemManager Instance;		
	public Sprite[] ItemImages;  //list of images

	// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
	// IS UNLOCKED // 
	//check Unlocked or not
	public bool isUnlocked(int ID){
		return PlayerPrefs.GetInt (ID.ToString(), 0) == 0 ? false : true;
	}

	// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
	// IS AWAKE // 
	void Awake(){
		Instance = this;
	}

	// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
	// IS Unlock // 
	//Unlock the item
	public void Unlock(int ID){
		PlayerPrefs.SetInt (ID.ToString(), 1);
	}

	// // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // 
	// GET SPRITE// 
	//Return the Sprite with the ID
	public Sprite GetItemImage(int ID){
		if (ID < 0 || ID > (ItemImages.Length - 1)) {
			Debug.LogError ("There are no item with this ID, please check the ID");
			return null;
		}
		return ItemImages [ID];
	}
}// end of ItemManager