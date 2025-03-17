using UnityEngine;

public class VragHP : MonoBehaviour
{
    public int Zdorovoe = 100;
    public int BulletHurt = 50;
    public int PalkaHurt = 35;
    public int FistHurt = 20;
    public int AptechkaHurt = 20;
    public GameObject HurMa;
    public AudioClip Musica;
    void Update()
    {
        if (Zdorovoe < 0)
        {
            Destroy(this.gameObject);
            Instantiate(HurMa, this.transform.position, this.transform.rotation);
        }

    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bullet")
        {
            Zdorovoe -= BulletHurt;
            Destroy(other.gameObject);
            
        }
        if (other.gameObject.tag == "Palka")
        {
            Zdorovoe -= PalkaHurt;
            GetComponent<AudioSource> ().PlayOneShot(Musica);
        }
        if (other.gameObject.tag == "Fist")
        {
            Zdorovoe -= FistHurt;
        }
        if (other.gameObject.tag == "Aptechka")
        {
            Zdorovoe += AptechkaHurt;
        }
        
    }
}
