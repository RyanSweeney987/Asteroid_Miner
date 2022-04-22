using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject fuelBar;
    public Gradient fuelBarGradient;
    public Text moneyText;
    public Text invText;

    private RectTransform fuelBarSize;
    private Image img;
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
        fuelBarSize = fuelBar.GetComponent<RectTransform>();
        img = fuelBar.GetComponent<Image>();
    }

    private void OnEnable()
    {
        GameManager.OnFuelUpdate += percent => UpdateFuel(percent);
        GameManager.OnMoneyUpdate += value => UpdateMoney(value);
        GameManager.OnInventoryUpdate += percent => UpdateInventory(percent);
    }

    private void OnDisable()
    {
        GameManager.OnFuelUpdate -= percent => UpdateFuel(percent);
        GameManager.OnMoneyUpdate -= value => UpdateMoney(value);
        GameManager.OnInventoryUpdate -= percent => UpdateInventory(percent);
    }

    private void UpdateFuel(float percent)
    {
        fuelBarSize.sizeDelta = new Vector2(percent, fuelBarSize.sizeDelta.y);
        img.color = fuelBarGradient.Evaluate(percent / 100);
    }

    private void UpdateMoney(float value)
    {
        moneyText.text = string.Format("{0:F2}", value);
    }

    private void UpdateInventory(float percent)
    {
        invText.text = string.Format("{0:F0}%", percent);
    }
}
