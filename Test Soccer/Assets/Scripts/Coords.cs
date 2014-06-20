using UnityEngine;
using System.Collections;

public class Coords : MonoBehaviour
{
    public Transform ball;
    public GUIText x;
    public GUIText y;
    public string xCod;
    public string yCod;

    private bool canGo = false;

    void Update()
    {
        if (canGo)
        {
            ball.position = Vector2.Lerp(ball.position, new Vector3(float.Parse(xCod), float.Parse(yCod), ball.position.z), 5 * Time.deltaTime);
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 220, 130), "Displacement");
        xCod = GUI.TextField(new Rect(15, 25, 200, 20), xCod, 25);
        yCod = GUI.TextField(new Rect(15, 55, 200, 20), yCod, 25);

        if (GUI.Button(new Rect(20, 75, 80, 20), "Displace"))
        {
            canGo = true;
        }
    }
}
