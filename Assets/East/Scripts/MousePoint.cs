using UnityEngine;

public class MousePoint : MonoBehaviour
{
    public RectTransform m_parent;
    public Camera ui_camera; // Renamed from m_uiCamera
    public GameObject m_effect; // Make sure this is a UI element with RectTransform component
    public Canvas m_canvas;

    void Update()
    {
        if ( Input.GetMouseButtonDown(0) )
        {
            Vector3 worldPos;
            RectTransformUtility.ScreenPointToWorldPointInRectangle(m_parent, Input.mousePosition, ui_camera, out worldPos);

            // Set the z value to 100
            worldPos.z = 100f;

            // Check if m_effect has RectTransform component
            RectTransform effectRectTransform = m_effect.GetComponent<RectTransform>();
            if ( effectRectTransform != null )
            {
                // Convert the world position to local position of the canvas
                Vector2 anchoredPos;
                RectTransformUtility.ScreenPointToLocalPointInRectangle(m_parent, worldPos, m_canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : ui_camera, out anchoredPos);
                effectRectTransform.anchoredPosition = anchoredPos;
            }
            else
            {
                // If m_effect is not a UI element, move it using transform.position
                m_effect.transform.position = worldPos;
            }
        }
    }
}
