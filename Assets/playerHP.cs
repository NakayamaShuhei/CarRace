using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHP : MonoBehaviour
{
    public int hp = 5;
    private Slider _slider;
    public GameObject slider;

    // Start is called before the first frame update
    void Start()
    {
        _slider = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = hp;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            hp -= 1;
        }
        if (hp <= 0)
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name);
        }
    }
}
