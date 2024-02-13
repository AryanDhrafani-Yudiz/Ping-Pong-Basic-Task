using UnityEngine;

public class MovementPlat : MonoBehaviour
{
    [SerializeField] private float speedToMovePlat;
    [SerializeField] private float unitsToMove;
    float direction = 1.0f;
    Vector3 current_position;
    private void Start()
    {
        current_position = this.transform.position;
    }
    void Update()
    {
        transform.Translate(0, direction * speedToMovePlat * Time.deltaTime * 1, 0);
        if (transform.position.y > current_position.y + unitsToMove)
        {
            direction = -1;
        }
        if (transform.position.y < current_position.y - unitsToMove)
        {
            direction = 1;
        }
    }
}
