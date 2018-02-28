using UnityEngine;
using System.Collections;

public class ExportCollider : MonoBehaviour
{

    public string xmlName;
    public bool countLaps = false;
    private bool exported = false;
    private int lap = 0;

    void OnTriggerEnter(Collider other)
    {
        if (!exported)
        {
            exported = true;
            // Provenance
            Prov_Export();
        }
    }

    void OnTriggerExit(Collider other)
    {
        exported = false;
    }

    void Prov_Export()
    {
        GameObject ProvObj = GameObject.Find("Provenance");

        ProvenanceController provController = ProvObj.GetComponent<ProvenanceController>();

        if (!countLaps)
        {
            provController.Save(xmlName);
        }
        else
        {
            provController.Save(xmlName + lap);

            lap++;
        }
    }
}