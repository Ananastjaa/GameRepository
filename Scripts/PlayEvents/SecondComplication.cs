using UnityEngine;

public class SecondComplication : MonoBehaviour
{
    public static void Complicate()
    {
        Player.instance.rb.gravityScale = 2f; //1.8
        Platform.JumpForce += 3.8f; //3.5
    }
}
