using UnityEngine;


public class BulletScript: MonoBehaviour
{
    public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.5f);
        Destroy(gameObject, 0.1f);
    }

    private float nextActionTime = 0.0f;
    public float period = 5f;

    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            Destroy(gameObject, 1f);
        }
    }
}
