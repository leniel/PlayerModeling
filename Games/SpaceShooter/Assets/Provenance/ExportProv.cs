using UnityEngine;
using System.Collections;

public class ExportProv : MonoBehaviour
{
    private bool exported = false;
    public string provenaceGameObjectName = "Provenance";
    public string xmlExportName = "";

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (!exported)
        {
            exported = true;

            // Provenance
            Prov_Export();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        exported = false;
    }

    public void Prov_Export()
    {
        Debug.Log(provenaceGameObjectName);

        GameObject ProvObj = GameObject.Find(provenaceGameObjectName);

        ProvenanceController prov = ProvObj.GetComponent<ProvenanceController>();

        prov.Save(xmlExportName);
    }
}