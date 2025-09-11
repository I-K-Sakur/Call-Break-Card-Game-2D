using UnityEngine;
using System.Collections.Generic;
public class Player : MonoBehaviour
{
    [SerializeField] private string playerName;
    [SerializeField] private int score;
    private List<Card> hand;
    private int tricksWon;
    private int call;
    [SerializeField]private DeckManager deckManager;
    [SerializeField] private int _playerNumber;

    private float posValueX=-8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        if (deckManager != null)
        {
            hand = deckManager.players[_playerNumber];
            AllCards();
        }
    }

    public void AllCards()
    {
        float spacing = 1.8f;
        for (int i = 0; i < hand.Count; i++)
        {
            Vector2 pos = new Vector2(transform.position.x+posValueX+(i*spacing), transform.position.y-2.8f);
            Instantiate(hand[i].gameObject, pos, Quaternion.identity);
        }
    }

}
