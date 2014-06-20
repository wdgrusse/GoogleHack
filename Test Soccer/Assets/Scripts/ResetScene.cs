using UnityEngine;
using System.Collections;

public class ResetScene : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Quad")
            Application.LoadLevel(1);
    }
}
