using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public List<Piece> pieces;
    void Start()
    {
        // get pieces
        for (int i = 0; i < this.transform.childCount; i++)
        {
            GameObject sprite = this.transform.GetChild(i).gameObject;

            Piece piece = new Piece(sprite, sprite.transform.position);
            this.pieces.Add(piece);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0 ; i < this.pieces.Count(); i++)
        {
            Debug.DrawLine(this.pieces[i].currentPosition, this.pieces[i].originalposition);
        }
    }
}

public class Piece
{
    public GameObject sprite;
    public Vector2 originalposition;
    public Vector2 currentPosition;
    public Piece(GameObject sprite, Vector2 position)
    {
        this.sprite = sprite;
        this.originalposition = position;
        this.currentPosition = sprite.transform.position;
    }
}
