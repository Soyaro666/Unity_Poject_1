using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorsorControl : MonoBehaviour
{
    [System.Serializable]
    public class TheCursor
    {
        public string tag;
        public Texture2D cursorTexture;
    }

    public List <TheCursor> cursorList = new List<TheCursor>();

    // Start is called before the first frame update
    void Start()
    {
        SetCursorTexture(cursorList[0].cursorTexture);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 1000))
        {
            for(int i = 0; i < cursorList.Count; i++)
            {
                if(hit.collider.tag == cursorList[i].tag)
                {
                    SetCursorTexture(cursorList[i].cursorTexture);
                    return;
                }
            }
        }
        SetCursorTexture(cursorList[0].cursorTexture);
    }

    void SetCursorTexture(Texture2D texture)
    {
        Cursor.SetCursor(texture, Vector2.zero, CursorMode.Auto);
    }
}
