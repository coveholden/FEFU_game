using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ObjectMove : MonoBehaviour
{
    public float s;
    //public int ran = 0;
    //public GameObject panel;
    private void Start()
    {
        s = 0.13f;
        // script = a.getComponent<PlayerControl>();
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - s, transform.position.y, 0);

        if (transform.position.x <= -35.5f)
        {
            Destroy(gameObject);
            //ran++;
        }
        //if (ran == 13)
        //{
        //    s += s * 0.5f;
        //    ran = 0;
        //}



    }

}


