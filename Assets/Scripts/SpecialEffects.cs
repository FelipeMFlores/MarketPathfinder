using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialEffects : MonoBehaviour
{
    private static SpecialEffects instance;
    public ParticleSystem explosionEffect;
    public GameObject trailsPrefab;

    void Awake()
    {
        // Assigning the value of instance to this script
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Ensuring the prefabs are all activated
        if (explosionEffect == null)
            Debug.LogError("Missing Explosion Effect");
        if (trailsPrefab == null)
            Debug.LogError("Missing Trails Prefab");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


        // Explosion Effect
    public static ParticleSystem MakeExplosion(Vector3 position)
    {
        // If this script is disabled, log an error
        if (instance == null)
        {
            Debug.LogError("There is no SpecialEffects Script in the scene");
            return null;
        }

        // Creates the Explosion Effect at the given position
        ParticleSystem effect =
            Instantiate(instance.explosionEffect) as ParticleSystem;
        effect.transform.position = position;
        // Destroys the Explosion Effect after Effect has completed        
        Destroy(effect.gameObject, effect.duration);

        return effect;    
    }

    //  Trail Effect
    public static GameObject MakeTrail(Vector3 position)
    {
        // If this script is disabled, log an error
        if (instance == null)
        {
            Debug.LogError("There is no SpecialEffects Script in the scene");
            return null;
        }
        //Creates a new trail at the set position
        GameObject trail = Instantiate(instance.trailsPrefab) as GameObject;       
        trail.transform.position = position;
        return trail;
    }
}
