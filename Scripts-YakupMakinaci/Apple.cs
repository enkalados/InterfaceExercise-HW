using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("Elma yendi, can yenilendi");
    }
}
