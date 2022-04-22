using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public float maxFuel = 100f;
    public float currentFuel = 5f;
    public float currentMoney = 0f;
    public float currentInventory = 0f;
    public float maxInventory = 1000f;

    private float oreValue = 1.8f;
    private float fuelValue = 0.7f;
    private InputMaster controls;

    public delegate void ValueUpdate(float value);
    public static event ValueUpdate OnMoneyUpdate;
    public static event ValueUpdate OnFuelUpdate;
    public static event ValueUpdate OnInventoryUpdate;

    private void Awake()
    {
        controls = new InputMaster();
        controls.General.ExitGame.performed += ctx => EndGame();
    }

    private void OnEnable()
    {
        controls.General.Enable();

        PickupController.OnFuelCollected += value => AddFuel(value);
        PickupController.OnOreCollected += value => AddOre(value);
        PlayerController.OnRocketThrust += value => RemoveFuel(value);
        BaseController.OnRefeul += () => Refuel();
        BaseController.OnSell += () => Sell();

    }

    private void OnDisable()
    {
        controls.General.Disable();

        PickupController.OnFuelCollected -= value => AddFuel(value);
        PickupController.OnOreCollected -= value => AddOre(value);
        PlayerController.OnRocketThrust -= value => RemoveFuel(value);
    }

    private void Sell()
    {
        AddFunds(currentInventory * oreValue);
        EmptyOre();
    }

    private void Refuel()
    {
        float amount = (maxFuel - currentFuel);
        if(currentMoney - (amount * fuelValue) <= 0f)
        {
            amount = currentMoney / fuelValue; 
        }
        RemoveFunds(amount * fuelValue);
        AddFuel(amount);
    }

    private void AddFuel(float amount)
    {
        currentFuel = currentFuel + amount > maxFuel ? maxFuel : currentFuel + amount;
        OnFuelUpdate?.Invoke(currentFuel / maxFuel * 100);
    }

    private void AddOre(float amount)
    {
        currentInventory = currentInventory + amount > maxInventory ? maxInventory : currentInventory + amount;
        OnInventoryUpdate?.Invoke(currentInventory / maxInventory * 100);
    }
    private void AddFunds(float amount)
    {
        currentMoney += amount;
        OnMoneyUpdate?.Invoke(currentMoney);
    }

    private void RemoveFuel(float amount)
    {
        currentFuel = currentFuel - amount < 0f ? 0f : currentFuel - amount;
        //Debug.Log("Updateing Fuel: " + currentFuel);

        if (currentFuel == 0f)
        {
            EndGame();
        }

        OnFuelUpdate?.Invoke(currentFuel / maxFuel * 100);
    }

    private void EmptyOre()
    {
        currentInventory = 0f;
        OnInventoryUpdate?.Invoke(0f);
    }

    private void RemoveFunds(float amount)
    {
        currentMoney = currentMoney - amount < 0f ? 0f : currentMoney - amount;
        OnMoneyUpdate?.Invoke(currentMoney);
    }

    private void EndGame()
    {
#if UNITY_EDITOR
        if (EditorApplication.isPlaying)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
#else
        Application.Quit();
#endif
    }
}
