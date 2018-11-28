using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {

    public List<CardAsset> cards = new List<CardAsset>();
    //public List<CardAsset> cards = PlayerManagement.getCard();


    void Awake()
    {
        //Debug.Log("size is " + cards.Count);
        cards.Shuffle();
    }
	
}
