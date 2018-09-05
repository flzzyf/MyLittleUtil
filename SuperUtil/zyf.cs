using UnityEngine;

public class zyf
{
    public enum Type { tip, warning };

    static string[] type = { "����ʾ��", "�����桿" };

    static string[] color = { "green", "red" };

    public static void Out(string _msg, Type _type = Type.tip)
    {
        Debug.Log("<color=" + color[(int)_type] + ">" + type[(int)_type] + _msg + "</color>");
    }

    //��ȡʵ����Ϸ������Ļ�ߴ�
    public static Vector2 GetWorldScreenSize()
    {
        float leftBorder;
        float rightBorder;
        float topBorder;
        float downBorder;
        //the up right corner
        Vector3 cornerPos = Camera.main.ViewportToWorldPoint(new Vector3(1f, 1f, Mathf.Abs(Camera.main.transform.position.z)));

        leftBorder = Camera.main.transform.position.x - (cornerPos.x - Camera.main.transform.position.x);
        rightBorder = cornerPos.x;
        topBorder = cornerPos.y;
        downBorder = Camera.main.transform.position.y - (cornerPos.y - Camera.main.transform.position.y);

        float width = rightBorder - leftBorder;
        float height = topBorder - downBorder;

        return new Vector2(width, height);
    }

    //a��֮һ�����¼�
    public static bool IfItWins(int _a)
    {
        return Random.Range(0, _a) == 1;
    }

    public static Vector3 GetMouseWorldPoint()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            return hit.point;
        }

        return Vector3.zero;
    }
}