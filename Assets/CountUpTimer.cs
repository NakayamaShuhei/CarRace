using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountUpTimer : MonoBehaviour
{
    public static float time;

    void Start()
    {
        time = 0f;
    }

    void Update()
    {
        if(Goal.goal == false)
        {
            time += Time.deltaTime;
            float t = Mathf.FloorToInt(time);
            Text uitext = GetComponent<Text>();
            uitext.text = "Timer:" + t;
        }
    }
}
