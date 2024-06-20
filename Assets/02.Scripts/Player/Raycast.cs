using UnityEngine;

public class Raycast : MonoBehaviour
{
    private bool isHuman = false;
    [SerializeField] private LayerMask whatisHuman;
    private float ray = 0.7f;
    private Vector2 _size = new Vector2(1f, 1f);
    [SerializeField] private GameObject taxtUi;
    private GameObject scanObject;

    private void Awake()
    {
        taxtUi.SetActive(false);
    }

    private void OnDrawGizmos()
    {
        gizmo();
    }

    private void Update()
    {
        CheackHuman();

        if (Input.GetKeyDown(KeyCode.F) && scanObject != null)
        {
           TextManager.Intance.Action(scanObject);
        }
    }
    private void CheackHuman()
    {
        isHuman = Physics2D.BoxCast(transform.position, _size, 0,transform.position ,ray, whatisHuman);
    }

    private void FixedUpdate()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(transform.position, _size, 0, transform.position, ray, whatisHuman);

        if(raycastHit.collider != null)
        {
            scanObject = raycastHit.collider.gameObject;
        }
        else
        {
            scanObject = null; 
        }
    }
    private void gizmo()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * ray);
    }
}
