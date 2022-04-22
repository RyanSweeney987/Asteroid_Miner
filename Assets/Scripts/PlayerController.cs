using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public float fuelConsumptionRate = 5f;
    public float thrust = 5f;
    public float maxVelocity = 5f;
    public float rotationSpeed = 5f;
    public float maxRotationRate = 5f;
    [Min(0.001f)]
    public float stabiliseRate = 0.5f;
    public SpriteRenderer flame;
    public ParticleSystem flameParticles;

	private Rigidbody2D rb;
    private InputMaster controls;

    public delegate void PlayerAction(float value);
    public static event PlayerAction OnRocketThrust;

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controls.Ship.Thrust.phase == InputActionPhase.Started)
        {
            OnThrust();
        }
        if(controls.Ship.Rotate.phase == InputActionPhase.Started)
        {
            OnRoll(controls.Ship.Rotate.ReadValue<float>());
        }
        if(controls.Ship.Stabilise.phase == InputActionPhase.Started)
        {
            OnStabilise();
        }
    }

	private void FixedUpdate()
	{
        if (rb.velocity.magnitude > maxVelocity)
        {
            rb.velocity = rb.velocity.normalized * maxVelocity;
        }

        //Debug.Log(rb.inertia);
        //if (rb.inertia) 
	}

    private void Awake()
    {
        controls = new InputMaster();
        controls.Ship.Thrust.performed += ctx => OnToggleThrustFlame();
        controls.Ship.Thrust.canceled += ctx => OnToggleThrustFlame();
        //controls.Ship.Rotate.performed += ctx => OnRoll(ctx.ReadValue<float>());
        //controls.Ship.Stabilise.performed += ctx => OnStabilise();
        //controls.Ship.Hook.performed += ctx => OnUseHook();
    }

    private void OnEnable()
    {
        controls.Ship.Enable();
    }

    private void OnDisable()
    {
        controls.Ship.Disable();
    }

    public void OnThrust()
	{
        float radianAngle = transform.rotation.eulerAngles.z * Mathf.PI / 180f;
        Vector2 angle = new Vector2(Mathf.Cos(radianAngle), Mathf.Sin(radianAngle));
        rb.AddForce(angle.normalized * thrust * Time.deltaTime * 60f);

        OnRocketThrust?.Invoke(fuelConsumptionRate * Time.deltaTime);
    }

    private void OnToggleThrustFlame()
    {
        var emission = flameParticles.emission;
        if(emission.enabled)
        {
            emission.enabled = false;
        } else
        {
            emission.enabled = true;
        }

        flame.enabled = !flame.enabled;
    }

    public void OnStabilise()
	{
        float lerpPercent = 1f - Mathf.Exp((Mathf.Log(1f - 0.99f) / stabiliseRate) * Time.deltaTime);
        float xVel = rb.velocity.x;
        float yVel = rb.velocity.y;
        float xVelLerp = Mathf.Lerp(xVel, 0f, lerpPercent);
        float yVelLerp = Mathf.Lerp(yVel, 0f, lerpPercent);
        rb.velocity = new Vector2(xVelLerp, yVelLerp);

        float aVel = rb.angularVelocity;
        float aVelLerp = Mathf.Lerp(aVel, 0f, lerpPercent);
        rb.angularVelocity = aVelLerp;
    }

    public void OnRoll(float direction)
	{
        rb.AddTorque(direction * rotationSpeed * Time.deltaTime * 60);
    }

    public void OnUseHook()
	{

	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        Debug.Log(other.tag);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.otherCollider.tag);
        Debug.Log(collision.relativeVelocity);
    }
}