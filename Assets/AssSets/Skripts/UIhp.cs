using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIhp : MonoBehaviour
{
    public int Zdorovoe = 100;
    public int BulletHurt = 50;
    public int PalkaHurt = 35;
    public int FistHurt = 20;
    public int AptechkaHurt = 20;
    public int SawWingHurt = 20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            if (Zdorovoe < 0)
            {
                SceneManager.LoadScene("Menu");
            }
            
        

    }
        void OnGUI()
        {
        GUI.Box(new Rect(10, 10, 200, 50), "Health: " + Zdorovoe);
        }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "Bullet")
        {
            Zdorovoe = Zdorovoe - BulletHurt;
            Destroy(other.gameObject);

        }
        if (other.gameObject.tag == "Palka")
        {
            Zdorovoe = Zdorovoe - PalkaHurt;

        }
        if (other.gameObject.tag == "Fist")
        {
            Zdorovoe -= FistHurt;
        }
        if (other.gameObject.tag == "Aptechka")
        {
            Zdorovoe += AptechkaHurt;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "SawWing")
        {
            Zdorovoe -= SawWingHurt;
           
        }


    }

}
    
