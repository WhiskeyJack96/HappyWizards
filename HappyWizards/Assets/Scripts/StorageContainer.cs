using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StorageContainer : MonoBehaviour {

	public int Capacity;
	public int len = 0;
	public List<String> storage;
	
	public bool AddItem(String item){
		if(len <= Capacity){
			storage.Add(item);
			len++;
			return true;
		}
		return false;
	}

	public bool RemoveItem(String item){
		if (storage.Contains(item)){
			storage.Remove(item);
			return true;
		}
		else{
			return false;
		}
	}

	public List<String> getStorage(){
		return storage;
	}
	public void setStorage(List<String> stor){
		if(stor.Count <= Capacity ){
			storage = stor;
			len = storage.Count;
		}
		 
	}

	public void Save(){
		//save
	}

	public void Load(){
		//load
	}


}
