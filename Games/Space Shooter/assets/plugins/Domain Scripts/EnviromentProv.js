#pragma strict
public var prov : ExtractProvenance = null;

function Awake()
{
	// Load provenance pointers
	prov = GetComponent(ExtractProvenance); 
	if(prov == null)	{
		prov = GetComponentInParent(ExtractProvenance); 
	}
	prov_enviromentAgent();
}

// Spawning Agent
public function prov_enviromentAgent()
{
	prov.NewAgentVertex("Enviroment");
}

// Spawn Asteroid
public function prov_Spawn()
{
	prov.NewActivityVertex("Spawn");
	prov.GenerateInfluenceC("Spawn", this.GetInstanceID().ToString(), "Spawn", "1", 1);
}