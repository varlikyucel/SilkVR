using UnityEngine;

public class SingleActiveChild : MonoBehaviour
{
    // Make the array public to assign it from the Unity Editor
    public GameObject[] children;

    // Call this method to activate a child and deactivate others
    public void ActivateChild(GameObject childToActivate)
    {
        foreach (GameObject child in children)
        {
            if (child == childToActivate)
            {
                child.SetActive(true);
            }
            else
            {
                child.SetActive(false);
            }
        }
    }
}
