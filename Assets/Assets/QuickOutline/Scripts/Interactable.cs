using UnityEngine;

[RequireComponent(typeof(Outline))]
public class Interactable : MonoBehaviour
{
    [SerializeField] private Outline outline;

    private void OnEnable()
    {  
        outline.OutlineWidth = 0;
    }

    public void OnHoverEnter()
    {
        outline.OutlineWidth = 10;
    }

    public void OnHoverExit()
    {
        outline.OutlineWidth = 0;
    }
}