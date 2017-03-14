using CnControls;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour {
    
    public float speed;             
	private Rigidbody2D rb2d;
    private Vector2 movementVector;
    [SerializeField]
    private float jumpTime = 1f;
    public float jumpTimeLeft;

	public GameObject bur;

	Animator ani;

	void Start()
	{	
		ani = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D> ();
	}
	void LateUpdate(){
		if (movementVector.x < 0.15f && movementVector.x > -0.15f) {
			ani.SetBool ("ImStand", true);
		} else {
			ani.SetBool ("ImStand", false);
		}
	}
	void FixedUpdate()
	{	

        movementVector = new Vector3(CnInputManager.GetAxis("Horizontal"), CnInputManager.GetAxis("Vertical"),0f);
        if (movementVector.sqrMagnitude < 0.00001f)
        {
            if (jumpTimeLeft > 0)
            {
                jumpTimeLeft -= Time.deltaTime;
            }
            return;
        }

        if(movementVector.x >= 0.3f || movementVector.x <= -0.3f)
        {
            rb2d.velocity = new Vector2(movementVector.x * 2, rb2d.velocity.y);
        }
        if (movementVector.x < 0f)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (movementVector.x > 0f)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (jumpTimeLeft > 0)
        {
            jumpTimeLeft -= Time.deltaTime;
        }
		if (movementVector.y < -0.65f)
		{
            
			ani.SetTrigger ("AttackUnder");
		}
		if (movementVector.y > 0.75f)
		{
            //if (BurMachine.hasBlock)
                ani.SetTrigger ("UpAttack");
		}

	}

    public void Jump()
    {

        if (jumpTimeLeft <= 0)
        {
            jumpTimeLeft = jumpTime;
            rb2d.velocity = Vector2.up * 5;
        }
    }
}

