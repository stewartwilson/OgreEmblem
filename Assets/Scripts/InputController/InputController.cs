using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour
{
    public float cursorSpeed;
    public bool canCursorMove;
    float nextCursorMoveAllowed;

    public GameObject cursor;

    public bool touching;

    public GameObject selectedObject;

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        bool enter = Input.GetKeyDown(KeyCode.Space);

        if(vertical > 0)
        {
            moveCursor(new Vector2(0,1));
        }
        if (vertical < 0)
        {
            moveCursor(new Vector2(0, -1));
        }
        if (horizontal > 0)
        {
            moveCursor(new Vector2(1, 0));
        }
        if (horizontal < 0)
        {
            moveCursor(new Vector2(-1, 0));
        }
        if (cursor.GetComponent<CursorController>().objectInTile != null)
        {
            selectedObject = cursor.GetComponent<CursorController>().objectInTile;
        }
        else
        {
            selectedObject = null;
        }

        if(selectedObject != null && enter)
        {
            selectObject(selectedObject);
        }
    }

    public virtual void moveCursor(Vector2 dir)
    {
        canCursorMove = false;

        if (Time.time < nextCursorMoveAllowed)
        {
            return;
        }
        nextCursorMoveAllowed = Time.time + cursorSpeed;
        cursor.transform.Translate(dir);
        canCursorMove = true;
    }

    private void selectObject(GameObject selected)
    {
        switch(selectedObject.tag)
        {
            case "PlayerUnit":

                break;
            case "EnemyUnit":

                break;

            default:
                print("No case found for select");
                break;
        }
    }
}
