using UnityEngine;

public class SkybokRotate : MonoBehaviour
{
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 1.2f);
    }
}
