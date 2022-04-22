using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    public Pickup pickup;
    public GameObject explosion;

    public delegate void CollectAction(float value);
    public static event CollectAction OnOreCollected;
    public static event CollectAction OnFuelCollected;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            switch(pickup.type)
            {
                case PickupType.Fuel:
                    OnFuelCollected?.Invoke(pickup.value);
                    break;
                case PickupType.Ore:
                    OnOreCollected?.Invoke(pickup.value);
                    break;
                case PickupType.Ship:
                    break;
            }

            GameObject exp = Instantiate(explosion);
            exp.transform.position = transform.position;

            Destroy(gameObject);
        }
    }
}
