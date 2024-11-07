using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void ShowInteraction(string tag)
    {
        //Debug.Log("Looking at " + tag);

        switch (tag)
        {
            case "Battery":
            
            break;

            case "Artifact":

            break;
        }
    }

    public void RemoveInteraction()
    {
        // Debug.Log("Looked away");
    }

    

}
