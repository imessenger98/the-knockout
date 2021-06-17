using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class splashscreen : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Wait());
    }

 IEnumerator Wait()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(1);
    }
}
