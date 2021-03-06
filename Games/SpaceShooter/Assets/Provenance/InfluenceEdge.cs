﻿/// <summary>
/// 'InfluenceEdge' Class Definition
/// This script is to define the influenceEdge class
/// Do not attach this script in any GameObject
/// It is only necessary to be on your resources folder
/// The 'InfluenceEdge' class is used for the Provenance-Scripts
/// </summary>
public class InfluenceEdge
{
    public string tag;          // This is the influence tag, which is used to designate actions that can be affected by it
                                // or to group up various influences for the influence-check process
    public string ID;               // This is the influence's ID and is used to single out an influence from a 'type' group
    public string source;           // This contains the vertex ID that generated the influence
    public string type;         // This is the name of the influence Edge
    public string infValue;     // This is the value of the influence Edge
    public bool consumable; // This controls if the influence has a limit of usages
    public int quantity;            // This is how many times this influence can still be used
    public string missableID;       // This is used for missable influences
    public float expirationTime;

    //================================================================================================================
    // Empty Influence Constructor
    //================================================================================================================
    public InfluenceEdge()
    {
        tag = "";
        ID = "";
        source = "";
        type = "";
        infValue = "";
        consumable = false;
        quantity = 1;
        missableID = null;
        expirationTime = -1;
    }
    /*
    //================================================================================================================
    // Influence Constructor
    //================================================================================================================
    void  InfluenceEdge ( string tag_ ,   string ID_ ,   string source_ ,   string type_ ,   string infValue_ ,   bool consumable_ ,    int quantity_  ){
        this.tag = tag_;
        this.ID = ID_;
        this.source = source_;
        this.type = type_;
        this.infValue = infValue_;
        this.consumable = consumable_;
        this.quantity = quantity_;
        this.missableID = null;
        this.timeStamp = -1;
        this.duration = -1;
    }
    */
    //================================================================================================================
    // Influence Constructor
    //================================================================================================================
    public InfluenceEdge(string tag_, string ID_, string source_, string type_, string infValue_, bool consumable_, int quantity_, float expirationTime_)
    {
        tag = tag_;
        ID = ID_;
        source = source_;
        type = type_;
        infValue = infValue_;
        consumable = consumable_;
        quantity = quantity_;
        missableID = null;
        expirationTime = expirationTime_;
    }

    //================================================================================================================
    // Missable Influence Constructor
    //================================================================================================================
    public InfluenceEdge(string tag_, string ID_, string source_, string type_, string infValue_, bool consumable_, int quantity_, string _missableID, float expirationTime_)
    {
        tag = tag_;
        ID = ID_;
        source = source_;
        type = type_;
        infValue = infValue_;
        consumable = consumable_;
        quantity = quantity_;
        missableID = _missableID;
        expirationTime = expirationTime_;
    }
}