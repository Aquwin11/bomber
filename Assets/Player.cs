using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed=6f;
    private float maxX =3.15f;
    private float minX = -3.15f;

    public Text total;
    public GameObject Endpanel;
    private Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
    public void movement()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 currentposition = transform.position;

        if (h > 0)
        {
             currentposition.x += speed * Time.deltaTime; 
        }
        else if (h < 0)
        {
             currentposition.x -= speed * Time.deltaTime;
        }
        if(currentposition.x > maxX)
        {
            currentposition.x = maxX;
        }
        else if(currentposition.x< minX )
        {
            currentposition.x = minX;
        }
        transform.position = currentposition;

    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag =="enemy")
        {
            Time.timeScale=0f;
            Endpanel.gameObject.SetActive(true);
        }
    }
    public void restart()
    {
        Application.LoadLevel(scene.name);
        Time.timeScale = 1f;
        Endpanel.gameObject.SetActive(false);
    }
}
