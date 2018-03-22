#pragma strict
public var prov : ExtractProvenance = null;
//public var hp : Health;
public var enemyType : String;

function Awake()
{
	// Load provenance pointers
	//hp = GetComponent(Health);
	
	prov = GetComponent(ExtractProvenance); 
	if(prov == null)	{
		prov = GetComponentInParent(ExtractProvenance); 
	}
	prov_Enemy();
	
}

//==========================================================
// Configurable
//==========================================================
// Enemy Attributes
public function Prov_GetEnemyAttributes()
{ 
	//prov.AddAttribute("Health", "");
}


//==========================================================
// Enemy
//==========================================================
// Enemy Agent
public function prov_Enemy()
{
	Prov_GetEnemyAttributes();
	prov.NewAgentVertex(enemyType);
	prov.NewActivityVertex("Spawned", this.gameObject);
	prov.HasInfluence("Spawn");
}

// Enemy Attack action
public function prov_Shoot(id : int)
{
	Prov_GetEnemyAttributes();
	prov.NewActivityVertex("Attacking", this.gameObject);
	prov.GenerateInfluenceC("DamagePlayer", id.ToString(), "Health", "-1", 1);
}

// Enemy Collision action
public function prov_Collide(id : int)
{
	Prov_GetEnemyAttributes();
	prov.NewActivityVertex("Collided", this.gameObject);
	prov.GenerateInfluenceC("Damage", id.ToString(), "Health", "-1", 1);
}

// <INTERFACE> Enemy Death action
public function prov_Death(id : int, scoreValue : int)
{
	Debug.Log("Hitted by ID: " + id.ToString());
	Prov_GetEnemyAttributes();
	prov.NewActivityVertex("Destroyed", this.gameObject);
	prov.HasInfluence_ID(id.ToString());
	prov.GenerateInfluenceC("Score", "Score", "Score", scoreValue.ToString(), 1);
}


	