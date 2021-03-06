﻿using System.Collections.Generic;
using System.Xml.Serialization;

//===================================================================================================================
// 'Vertex' Class Definition
// This script is to define the Edge class
// Do not attach this script in any GameObject
// It is only necessary to be on your resources folder
// The 'Vertex' class is used for the Provenance-Scripts
//===================================================================================================================
public class Vertex
{
    public string ID;       // Vertex' unique ID
    public string type; // Provenance Label for this vertex (Activity, Agent, Entity)
    public string label;    // A human-readable name for this vertex
    public string date; // Game time when the vertex is created

    [XmlArray("attributes")]
    [XmlArrayItem("attribute")]
    public List<Attribute> attributes;  // A List representing each vertex' attributes 
                                        // Each attribute must have a string (Name) and a Number (att_value)

    //================================================================================================================
    // Empty Vertex Constructor
    //================================================================================================================
    public Vertex()
    {
        ID = "";
        date = "";
        type = "";
        label = "";
        attributes = new List<Attribute>();
    }

    //================================================================================================================
    // Vertex Constructor
    //================================================================================================================
    public Vertex(string id_, string date_, string type_, string label_, List<Attribute> attribute_)
    {
        ID = id_;
        date = date_;
        type = type_;
        label = label_;

        attributes = new List<Attribute>();

        //Copy the attribute list
        for (int i = 0; i < attribute_.Count; i++)
        {
            attributes.Add(attribute_[i]);
        }
    }
}

//===================================================================================================================
// AttributeType Class Definition
// This script is to define the AttributeType type used for Vertex' Attributes
//===================================================================================================================
public class Attribute
{
    public string name;     // Name of the attribute (i.e. HitPoints)
    public string value;    // Value of the attribute (i.e. 100)

    //================================================================================================================
    // AttributeType Constructor
    //================================================================================================================
    public Attribute()
    {
        name = "";
        value = "";
    }

    //================================================================================================================
    // AttributeType Constructor
    //================================================================================================================
    public Attribute(string name_, string att_value_)
    {
        name = name_;
        value = att_value_;
    }
}