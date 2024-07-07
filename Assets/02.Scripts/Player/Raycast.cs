using UnityEngine;

public class Raycast : MonoBehaviour
{
    private bool isHuman = false;
    [SerializeField] private LayerMask whatisHuman;
    private float ray = 0.7f;
    private Vector2 _size = new Vector2(1f, 1f);
    [SerializeField] private GameObject taxtUi;
    private GameObject scanObject;
    private PlayerRub run;
    public bool skip;
    public static Raycast Intance;

        private void Awake()
   {
        taxtUi.SetActive(false);
        run = GetComponent<PlayerRub>();
        if (Intance == null)
        {
            Intance = this;
        }
        else
            Destroy(gameObject);
    }

    private void OnDrawGizmos()
    {
        gizmo();
    }

    private void Update()
    {
        CheackHuman();

        if (Input.GetKeyDown(KeyCode.F) && !run.isRun && TextEffect.Intance.isEffting&&!TextManager.Intance.isChoosing)
        {
            TextManager.Intance.Action(scanObject);
        }
        //else if(Input.GetKeyDown(KeyCode.Space) && scanObject != null)
        //{
        //    skip = true;
        //    TextManager.Intance.TalkPanel.SetActive(false);
        //}
        //else if(Input.GetKeyDown(KeyCode.Space) && scanObject == null)
        //{
        //    skip = false;
        //}
        RaycastHit2D raycastHit = Physics2D.BoxCast(transform.position, _size, 0, transform.position, ray, whatisHuman);

        if(raycastHit.collider != null)
        {
            scanObject = raycastHit.collider.gameObject;
        }
        else
        {
            TextManager.Intance.TalkPanel.SetActive(false);
            TextManager.Intance.isAction = false;
        }
      
    }
    private void CheackHuman()
    {
        isHuman = Physics2D.BoxCast(transform.position, _size, 0,transform.position ,ray, whatisHuman);
    }
    private void gizmo()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * ray);
    }
}
