using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColor : MonoBehaviour
{
    public Color sampleColor; /// Just for debugging purposes.
    public float lerpDuration;
    public Color[] colors;

    void Awake()
    {
        
        StartCoroutine(LerpColors());
    }
    private void Update()
    {
        this.GetComponent<Camera>().backgroundColor = sampleColor;
    }
    private IEnumerator LerpColors()
    {
        if (colors.Length > 0)
        {
            /// Split the time between the color quantities.
            float dividedDuration = lerpDuration / colors.Length;

            for (int i = 0; i < colors.Length - 1; i++)
            {
                float t = 0.0f;

                while (t < (1.0f + Mathf.Epsilon))
                {
                    sampleColor = Color.Lerp(colors[i], colors[i + 1], t);
                    t += Time.deltaTime / dividedDuration;
                    yield return null;
                }

                // Since it is posible that t does not reach 1.0, force it at the end.
                sampleColor = Color.Lerp(colors[i], colors[i + 1], 1.0f);
            }

        }
        else yield return null; /// Do nothing if there are no colors.
    }
}

