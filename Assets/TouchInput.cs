using UnityEngine;

public class TouchInput : MonoBehaviour {

	void Update()
    {
#if UNITY_IPHONE || UNITY_ANDROID || UNITY_EDITOR
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Click(Input.GetTouch(0).position);
        }
#endif
#if UNITY_EDITOR || UNITY_EDITOR_WIN || UNITY_STANDALONE
        if (Input.GetMouseButtonDown(0))
        {
            Click(Input.mousePosition);
        }
#endif
    }

    void Click(Vector2 position)
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
        if (hit != null && hit.collider != null)
        {
            Debug.Log("I'm hitting " + hit.collider.name);
        }
    }
}
