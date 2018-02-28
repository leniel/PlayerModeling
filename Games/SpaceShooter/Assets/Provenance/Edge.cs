using UnityEngine;

public class Edge
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
        ID = "";
        type = "";
        label = "";
        value = "";
        sourceID = "";
        targetID = "";
    }

    //================================================================================================================
    // Edge Constructor
    //================================================================================================================
    public Edge(string id_, string label_, string type_, string edge_value_, string sourceID_, string targetID_)
    {
        ID = id_;
        type = type_;
        label = label_;
        value = edge_value_;
        sourceID = sourceID_;
        targetID = targetID_;
    }
}