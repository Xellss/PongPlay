using System.Collections;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private Rigidbody rb = null;

    [SerializeField]
    private int force = 500;

    [SerializeField]
    private Vector3 scale = new Vector3(1, 1, 1);

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        int random = Random.Range(0, 2);

        if (random == 1)
            rb.AddForce(force, 0, 0);
        else
            rb.AddForce(-force, 0, 0);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ItemBigger")
        {
            Destroy(collision.gameObject);
            transform.localScale += scale;
            StartCoroutine(scaleDelay());
        }

        if (collision.collider.tag == "ItemNewBall")
        {
            Instantiate(gameObject);
            Destroy(collision.gameObject);
        }
    }


    private IEnumerator scaleDelay()
    {
        yield return new WaitForSeconds(3f);
        transform.localScale -= scale;
    }
}
