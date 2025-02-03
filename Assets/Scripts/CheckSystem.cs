using System.Collections.Generic;
using UnityEngine;

public class CheckSystem : MonoBehaviour
{
    public GameObject player;

    public List<GameObject> CheckPoints;

    public Vector3 VectorPoint;

    public float EixoLimite;


    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < EixoLimite || Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position = VectorPoint;
            player.transform.eulerAngles = VectorPoint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Piso"))
        {

            VectorPoint = other.transform.position;
            Destroy(other.gameObject);
        }
    }

}
