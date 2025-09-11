
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DeckManager", menuName = "Scriptable Objects/DeckManager")]
public class DeckManager : ScriptableObject
{
    public List<Card> deck ;
    private int randomNum;
    private bool _divisionStage;
    public List<List<Card>> players = new List<List<Card>>();
    private List<Card> tempCardList= new List<Card>();
    public void CreateDeck()
    {
        tempCardList = new List<Card>(deck);
       // deck.Clear();
       for (int i = 0; i < tempCardList.Count; i++)
       {
           int randomIndex = Random.Range(i, tempCardList.Count);
           // Swap i and randomIndex
           Card temp = tempCardList[i];
           tempCardList[i] = tempCardList[randomIndex];
           tempCardList[randomIndex] = temp;
       }
    }
    public void CardDivision()
    {
        players.Clear(); 
        for (int k = 0; k < 4; k++)
        {
            players.Add(new List<Card>());
        }
    
        for (int j = 0; j < tempCardList.Count; j++)
        {
            //round Robin
            int roundRobin = j % 4;
            players[roundRobin].Add(tempCardList[j]);
        }
        
    }

}
