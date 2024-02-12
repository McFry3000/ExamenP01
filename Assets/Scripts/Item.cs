using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.EventSystems;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;

[CreateAssetMenu(menuName = "Scriptable object/Item")]

public class Item : ScriptableObject
{

    [Header("Only Gameplay")]
    public TileBase tile;
    public ItemType type;
    public Actiontype actionType;
    public Vector2Int range = new Vector2Int(5, 4);


    [Header("Only UI")]
    public bool stackable = true;

    [Header("Both")]
    public Sprite image;

    [Header("Texto con TextMeshPro")]
    public TextMeshProUGUI Nuevo;

}

public enum ItemType
{
    BuildingBlock,
    Tool
}


public enum Actiontype
{
    Dig,
    Mine
}




