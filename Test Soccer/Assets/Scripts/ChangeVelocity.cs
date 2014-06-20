using UnityEngine;
using System.Collections;

public class ChangeVelocity : MonoBehaviour
{
    public GameObject ball;
    public string xCod;
    public string yCod;
    private float xVal;
    private float yVal;


    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 220, 130), "Velocity");
        xCod = GUI.TextField(new Rect(15, 30, 200, 20), xCod, 25);
        yCod = GUI.TextField(new Rect(15, 60, 200, 20), yCod, 25);

        if (GUI.Button(new Rect(20, 80, 80, 20), "Reset"))
        {
            Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(20, 105, 80, 20), "Displace"))
        {
            // Try to parse
            if (float.TryParse(xCod, out xVal) && float.TryParse(yCod, out yVal))
                ball.rigidbody2D.velocity = new Vector2(float.Parse(xCod), float.Parse(yCod));
        }

    }
}
