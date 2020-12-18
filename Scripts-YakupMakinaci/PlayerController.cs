using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 500;
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody; } }
    void FixedUpdate()
    {
        PlayerMove();
    }
    private void PlayerMove()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Rigidbody.velocity = input * moveSpeed * Time.fixedDeltaTime; //Hız ile yönlendirme
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Etkileşim");
        IInteractable myInteract = other.GetComponent<IInteractable>();
        if (myInteract != null)
        {
            other.GetComponent<IInteractable>().Interact();
        }
    }
}
