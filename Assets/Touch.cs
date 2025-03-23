using UnityEngine;

public class Touch : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        float dx = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        float dz = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        transform.position = new Vector3(
            transform.position.x + dx, transform.position.y, transform.position.z + dz
        );
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "HandDataRight" +
            "HandDataLeft")//Ghost-LeftHand
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
