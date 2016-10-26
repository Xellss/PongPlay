using System.Collections;
using UnityEngine;

public class ItemGetBigger : MonoBehaviour
{
    [SerializeField]
    private Vector3 scale = new Vector3(1, 1, 1);

    //  private float timeDelay = 3;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ball")
        {
            collision.transform.localScale += scale;

            StartCoroutine(delay(collision));

            gameObject.SetActive(false);
        }
    }


    IEnumerator delay(Collision collision)
    {
        yield return new WaitForSeconds(3f);

        collision.transform.localScale -= scale;
        Destroy(gameObject);
    }

}
