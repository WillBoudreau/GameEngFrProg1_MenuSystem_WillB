using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public InteractableOBJ Interactable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       DetermineInteractable();
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        Interactable = other.GetComponent<InteractableOBJ>();
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Interactable = null;
    }
    void DetermineInteractable()
    {

    }
    void ExecuteInteractable()
    {

    }
}
