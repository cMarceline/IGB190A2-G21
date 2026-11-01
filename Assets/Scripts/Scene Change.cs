using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTransition : MonoBehaviour
{
    public string nextScene;
    public Unit[] mustBeDefaeated;
    private void OnTriggerEnter(Collider other)
    {
        if (mustBeDefaeated.Length > 0)
        {
            foreach (Unit unit in mustBeDefaeated)
            {
                if (unit != null)
                {
                    return;
                }
            }
        }

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Main");
        }
    }
}