using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;

public class GravityController : MonoBehaviour
{
    public float radius = 50f;
    public bool isGlobal = true;
    public float attractionMass = 1f;

    private List<Attractable> attractables = new List<Attractable>();

	// Start is called before the first frame update
	void Start()
    {
        attractables = GameObject.FindObjectsOfType<Attractable>().ToList();
        Debug.Log(attractables.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        foreach (Attractable elem in attractables)
        {
            if(isGlobal)
            {
                elem.rb.AddForce(Attract(elem.transform.position, elem.rb.mass));
            }
            else if(true)
            {
                elem.rb.AddForce(Attract(elem.transform.position, elem.rb.mass));
            }
        }
    }

    private Vector2 Attract(Vector2 position, float mass)
    {
        // Get the direction from the players ship to the centre of gravity
        // The difference of position and the centre of gravity results in an outwards direction, for normal
        // attraction you swap the order
        Vector2 direction = position - new Vector2(transform.position.x, transform.position.y);
        // Distance from the centre of gravity
        float distFromCenter = direction.sqrMagnitude;
        // The distance from the radius, radius is a fixed distance so we get the difference between that and 
        // the distance from the centre of gravity
        float distFromRad = Mathf.Sqrt((radius * radius) - distFromCenter);
        // The new direction with appropriate distance
        Vector2 dir = direction.normalized * distFromRad;
        // The final distance used for the force calculation
        float distance = dir.sqrMagnitude;

        if(distance < 1f)
        {
            return Vector2.zero;
        }

        float forceMagnetude = (mass * attractionMass) / distance;
		return direction.normalized * forceMagnetude;
    }

    public void RemoveFromList(Attractable attractable)
    {
        attractables.Remove(attractable);
    }

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(transform.position, radius);
	}
}
