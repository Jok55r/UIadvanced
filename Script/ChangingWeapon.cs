using UnityEngine;
using UnityEngine.UI;

public class ChangingWeapon : MonoBehaviour
{
    public bool havePistol = true;

    public GameObject pistol;
    public GameObject shotgun;

    public Image changeImage;
    public Sprite pistolIm;
    public Sprite shotgunIm;

    public void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll > 0)
        {
            pistol.SetActive(true);
            shotgun.SetActive(false);
            changeImage.sprite = pistolIm;

            /*Vector2 test = new Vector2(0f, 0f);
            Instantiate(pistol, test, Quaternion.identity);*/
        }
        else if (scroll < 0)
        {
            pistol.SetActive(false);
            shotgun.SetActive(true);
            changeImage.sprite = shotgunIm;

            /*Vector2 test = new Vector2(0f, 0f);
            Instantiate(shotgun, test, Quaternion.identity);*/
        }
    }
}