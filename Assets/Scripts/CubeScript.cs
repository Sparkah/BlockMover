using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private int moveDistanceInt;
    private int speedInt;

    private float moveSlow = 0.1f;

    public void SetCubeParams(int moveDistance, int speed)
    {
        moveDistanceInt = moveDistance;
        speedInt = speed;
    }

    void FixedUpdate()
    {
        transform.position += new Vector3(0, 0, speedInt*moveSlow);
        if (transform.position.z > moveDistanceInt)
            Destroy(gameObject);
    }
}