using UnityEngine;

public class Edge : MonoBehaviour
{
    public string ID;               // Edge's Unique ID
    public string type;         // Provenance type for this edge
    public string label;            // A human-readable label for this edge (i.e. damage, hit points)
    public string value;            // Value of this edge (i.e. +4)
    public string sourceID;     // Vertex Source of this edge
    public string targetID;     // Vertex Target of this edge

    //================================================================================================================
    // Empty Edge Constructor
    //================================================================================================================
    public Edge()
    {
        this.ID = "";
        this.type = "";
        this.label = "";
        this.value = "";
        this.sourceID = "";
        this.targetID = "";
    }

    //================================================================================================================
    // Edge Constructor
    //================================================================================================================
    public Edge(string id_, string label_, string type_, string edge_value_, string sourceID_, string targetID_)
    {
        this.ID = id_;
        this.type = type_;
        this.label = label_;
        this.value = edge_value_;
        this.sourceID = sourceID_;
        this.targetID = targetID_;
    }
}