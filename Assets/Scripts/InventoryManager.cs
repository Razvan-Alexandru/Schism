using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public float LIGHT_CAP_SEC;
    public float lightTime;

    public int lightPercentage => 100 * (int)(lightTime/LIGHT_CAP_SEC); 

    public int PUZZLE_OBJECTIVE = 10;
    public int BATTERY_CAP = 5;
    public int batteries = 0;
    public int manuscripts = 0;

    void Start()
    {
        lightTime = LIGHT_CAP_SEC;
    }

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddToInventory(string tag)
    {
        Debug.Log("Picked up "+ tag);

        switch (tag)
        {
            case "Battery":
            if (batteries < BATTERY_CAP) batteries++; 

            break;

            case "Manuscript":
            if (manuscripts < PUZZLE_OBJECTIVE) manuscripts++;

            break;
        }
    }

    public void ConsumeBattery()
    {
        if (batteries > 0) 
        {
            Debug.Log("Consume battery");
            lightTime = LIGHT_CAP_SEC;
            batteries--;
        } else 
        {
            lightTime = 0;
        }
    }

    public void TickOffBattery()
    {
        lightTime -= Time.deltaTime;

        if (lightTime < 0)
        {
            ConsumeBattery();
        }
    }


    public bool HasBatteryLeft()
    {
        return batteries > 0 || lightTime > 0;
    }
    

}
