using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    public GameObject baseUI;

    private InputMaster controls;
    private bool isLanded = false;

    public delegate void BaseAction();
    public static event BaseAction OnSell;
    public static event BaseAction OnRefeul;
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
        controls = new InputMaster();
        controls.General.Sell.performed += ctx => { if (isLanded) OnSell?.Invoke(); };
        controls.General.Refuel.performed += ctx => { if (isLanded) OnRefeul?.Invoke(); };
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            baseUI.SetActive(true);
            isLanded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            baseUI.SetActive(false);
            isLanded = false;
        }
    }
}
