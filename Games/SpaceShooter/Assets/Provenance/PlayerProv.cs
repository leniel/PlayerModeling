using UnityEngine;

public class PlayerProv : MonoBehaviour
{
    public ExtractProvenance prov;
    //public Health hp;

    void Awake()
    {
        // Load provenance pointers
        //hp = GetComponent<Health>();

        prov = GetComponent<ExtractProvenance>();

        if (prov == null)
        {
            prov = GetComponentInParent<ExtractProvenance>();
        }

        Prov_Player();

        InvokeRepeating("Prov_Fly", 2, 2);
    }

    //==========================================================
    // Configurable
    //==========================================================

    // Player attributes
    public void Prov_GetPlayerAttributes()
    {
        prov.AddAttribute("Score", "10");
    }

    //==========================================================
    // Player
    //==========================================================

    // Player agent
    public void Prov_Player()
    {
        Prov_GetPlayerAttributes();

        prov.NewAgentVertex("Player");
    }

    // Player Walk action
    //public function Prov_Walk()
    //{
    //	Prov_GetPlayerAttributes();
    //	prov.NewActivityVertex("Walking");
    //	prov.HasInfluence("Player");
    //}

    // Player Jump action
    //public function Prov_Jump()
    //{
    //	Prov_GetPlayerAttributes();
    //	prov.NewActivityVertex("Jump");
    //	prov.HasInfluence("Player");
    //}

    // Player Interact action
    public void Prov_Interact()
    {
        Prov_GetPlayerAttributes();
        prov.NewActivityVertex("Interacted");
        prov.HasInfluence("Player");
    }

    // Player Interact action
    //public function Prov_Regenerate( float regValue  )
    //{
    //	prov.GenerateInfluenceC("Player", this.GetInstanceID().ToString(), "Health (Player)", regValue.ToString(), 1);
    //}

    // Player attack action
    public void Prov_Attack()
    {
        Prov_GetPlayerAttributes();
        prov.NewActivityVertex("Shooting");
        prov.HasInfluence("Player");
    }

    // Player took damage
    //function Prov_TakeDamage( GameObject enemy ,   float damageAmount  )
    //{
    //	EnemyProv enemyProv = enemy.GetComponent<EnemyProv>(); 

    //	if(enemyProv == null)
    //	{
    //		enemyProv = enemy.GetComponentInParent(EnemyProv); 
    //	}

    //	string infID = enemyProv.Prov_Attack(damageAmount);
    //	this.Prov_TakeDamage(infID);
    //}

    // Player took damage
    //public function Prov_TakeDamage( string infID  )
    //{
    //	Prov_GetPlayerAttributes();
    //	prov.NewActivityVertex("Being Hit");
    //	// Check Influence
    //	prov.HasInfluence_ID(infID);
    //}

    // Player took damage
    //public function Prov_TakeDamage()
    //{
    //	Prov_GetPlayerAttributes();
    //	prov.NewActivityVertex("Being Hit");
    //	// Check Influence
    //	prov.HasInfluence("PlayerDamage");
    //}

    //Player Death action
    public void Prov_Death()
    {
        Prov_GetPlayerAttributes();

        prov.NewActivityVertex("Dead");

        prov.GenerateInfluenceC("Player", GetInstanceID().ToString(), "Respawned", "-1", 1);

        ExportProv export = new ExportProv();
        export.Prov_Export();
    }

    // Player Death action
    //public function Prov_Respawn()
    //{	
    //	Prov_GetPlayerAttributes();
    //	prov.NewActivityVertex("Respawn");
    //	prov.HasInfluence("Player");
    //	//Prov_Export();
    //}
}