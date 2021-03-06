﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NPCController : MonoBehaviour {

	private ClockController clock;
	private DateTime time;
	private TimeSpan move;
	public List<List<Pair<String, TimeSpan>>> schedule;
	public List<Pair<String, TimeSpan>> daySchedule;
	public GameObject dest;

	private StorageContainer inventory;

	//load dialogue
	public Queue<Pair<String, int>> DialogueList;

	public String NPCname;
	public Pair<String, int> dialogue;

	public int affinity;


	// Use this for initialization
	void Start () {
		time = clock.GetDate();
		daySchedule = schedule[time.DayOfYear];
		dest = GameObject.Find(daySchedule[0].first);
		move = daySchedule[0].second;
		daySchedule.RemoveAt(0);

		//assumed initialization
		//inventory.load(NPCname);
	}
	
	// Update is called once per frame
	void Update () {
		if(move < clock.GetTime()){
			dest = GameObject.Find(daySchedule[0].first);
			move = daySchedule[0].second;
			daySchedule.RemoveAt(0);
		}
		//if (dist to dest >1);
		MoveToDest();
	}

	private void MoveToDest(){
		dest = dest;
	}

	public int GetAffinity(){
		return affinity;
	}
	public int UpdateAffinity(int i){
		affinity += i;
		return affinity;
	}

	public String GetDialogue(){
		dialogue = DialogueList.Dequeue();
		DialogueList.Enqueue(dialogue);
		if(affinity >= dialogue.second){
			return dialogue.first;
		}
		return "";
	}

//	public int Sell(int payment, Item item){
//		if (payment >= item.cost ){
//			inventory.RemoveItem(item.name)
//			return item.cost;
//		}
//	}
	//OnDestroy() save inventory
}

[Serializable]
public class Pair<P1, P2>{
	public P1 first { get; private set;}
	public P2 second { get; private set;}

	internal Pair(P1 First, P2 Second){ 
	first = First;
	second = Second;
	}
}
public static class Pair
{
	private static Pair<P1, P2> New<P1, P2>(P1 first, P2 second){
		var pair = new Pair<P1,P2>(first, second);
		return pair;
	}
}
