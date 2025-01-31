using UnityEngine;

public class Carmovement : MonoBehaviour
{
    // velocida
    private Vector3 MoveForce;
    // acelera��o
    public float MoveSpeed = 100;

    public float MaxSpeed = 15;

    public float Drag = 1;

    public float steerAngle = 20;

    public float Traction = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        MoveForce += transform.forward * MoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position += MoveForce * Time.deltaTime;

        float steerInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerInput * MoveForce.magnitude * steerAngle * Time.deltaTime);

        MoveForce *= Drag;
        MoveForce = Vector3.ClampMagnitude(MoveForce, MaxSpeed);

        Debug.DrawRay(transform.position, MoveForce.normalized * 10);
        Debug.DrawRay(transform.position, transform.forward * 10, Color.blue);

        MoveForce = Vector3.Lerp(MoveForce.normalized, transform.forward, Traction * Time.deltaTime) * MoveForce.magnitude;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            MaxSpeed = 25;
            MoveForce += transform.forward * MoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            MaxSpeed = 15; // Volta ao valor padr�o quando solta o Shift
        }




    }

}
