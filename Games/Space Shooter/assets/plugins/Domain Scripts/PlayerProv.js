#pragma strict
public var prov : ExtractProvenance = null;
public var provenaceGameObjectName : String = "Provenance";
//public var hp : Health;

function Awake()
{
	// Load provenance pointers
	//hp = GetComponent(Health);
	prov = GetComponent(ExtractProvenance); 
	if(prov == null)	{
		prov = GetComponentInParent(ExtractProvenance); 
	}
	prov_Player();
	
	//InvokeRepeating("Prov_Walk", 2, 2);
}

//==========================================================
// Configurable
//==========================================================

// Player attributes
public function Prov_GetPlayerAttributes(score : int)
{
	prov.AddAttribute("Score", score.ToString());
}

//==========================================================
// Player
//==========================================================

// Player agent
public function prov_Player()
{
	//Prov_GetPlayerAttributes();
	prov.NewAgentVertex("Player");
}


// Player Fire action
public function prov_Shoot(id : int)
{
	//Prov_GetPlayerAttributes();
	prov.NewActivityVertex("Shooting");
	Debug.Log("Shot ID: " + id.ToString());
	prov.GenerateInfluenceC("EnemyDamage", id.ToString(), "Health", "-1", 1);
}

//Player Death action
public function prov_Death(id : int)
{	
	//Prov_GetPlayerAttributes();
	prov.NewActivityVertex("Dead");
	prov.HasInfluence_ID(id.ToString());
	prov_Export();
}

// Player Score update
public function prov_Score(score : int)
{	
	Prov_GetPlayerAttributes(score);
	prov.NewActivityVertex("Scored");
	prov.HasInfluence("Score");
}

function prov_Export()
{
	Debug.Log (provenaceGameObjectName);
	var ProvObj : GameObject = GameObject.Find(provenaceGameObjectName);
	var prov : ProvenanceController = ProvObj.GetComponent(ProvenanceController); 
	prov.Save("Space Shooter");
}