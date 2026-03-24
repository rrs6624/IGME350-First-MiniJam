using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject gameObject;
    public Camera mainCamera;

    public Transform topLimit;
    public Transform leftLimit;
    public Transform rightLimit;
    public Transform bottomLimit;

    private float maxY;
    private float minY;
    private float maxX;
    private float minX;

    private float defaultSize = 100f;
    private float expandedSize = 60f;
    private float cameraHeight;

    // Start is called before the first frame update
    void Start()
    {
        minY = gameObject.transform.position.y;
        maxY = topLimit.position.y;
        minX = leftLimit.position.x;
        maxX = rightLimit.position.x;

        // Set the camera to the default size initially
        mainCamera.orthographicSize = defaultSize;
        cameraHeight = mainCamera.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the new position for the camera based on player movement
        Vector3 newPosition = transform.position;

        // Clamp the x position of the camera within the set limits
        newPosition.x = Mathf.Clamp(gameObject.transform.position.x, minX, maxX);

        // Recalculate the camera height after zoom adjustment
        cameraHeight = mainCamera.orthographicSize;

        // Get the Y position clamped within the vertical limits
        float clampedY = Mathf.Clamp(gameObject.transform.position.y, minY, maxY);

        newPosition.y = clampedY; // Follow the player
        
        // Update the camera position
        transform.position = newPosition;
    }
}
