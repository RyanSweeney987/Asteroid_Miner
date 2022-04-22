using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractable : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D rb;
    private GravityController gCon;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gCon = GameObject.FindObjectOfType<GravityController>();
    }

    private void OnDestroy()
    {
        gCon.RemoveFromList(this);
    }
}
