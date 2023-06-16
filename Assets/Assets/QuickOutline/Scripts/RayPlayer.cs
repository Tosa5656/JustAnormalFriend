using UnityEngine;

public class RayPlayer : MonoBehaviour
{
    [SerializeField] private float _rayDistance;
    [SerializeField] private GameObject text;
    
    private Interactable _previousInteractable;

    private void Start()
    {
        text.SetActive(false);
    }

    private void Update()
    {
        if (!Physics.Raycast(transform.position, transform.forward, out var hit, _rayDistance))
        {
            _previousInteractable?.OnHoverExit();
            text.SetActive(false);
            return;
        }

        if (!hit.transform.gameObject.TryGetComponent<Interactable>(out var interactable))
        {
            _previousInteractable?.OnHoverExit();
            text.SetActive(false);
            return;
        }

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if(hit.collider.gameObject.GetComponent<DoorOpen>() && Input.GetMouseButtonDown(0))
            {
                hit.collider.GetComponent<DoorOpen>().Open();
            }
            if(hit.collider.gameObject.GetComponent<Svet>() && Input.GetMouseButtonDown(0))
            {
                hit.collider.gameObject.GetComponent<Svet>().SvetChange();
            }
            if(hit.collider.gameObject.GetComponent<SvetL>() && Input.GetMouseButtonDown(0))
            {
                hit.collider.gameObject.GetComponent<SvetL>().SvetChang();
            }
            if(hit.collider.gameObject.GetComponent<Kran>() && Input.GetMouseButtonDown(0))
            {
                hit.collider.gameObject.GetComponent<Kran>().OpenL();
                text.SetActive(false);
            }
            if(hit.collider.gameObject.GetComponent<Kran>())
            {
                text.SetActive(true);
            }
        }

        interactable.OnHoverEnter();
        _previousInteractable = interactable;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, transform.forward * _rayDistance);
    }
}