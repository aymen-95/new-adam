using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    void Awake()
    {
        // تأكد أن هناك فقط نسخة واحدة
        if (FindObjectsOfType<SceneLoader>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        // إنشاء العنصر الأساسي للمشهد
        GameObject main = new GameObject("SceneRoot");
        main.AddComponent<MainSceneInitializer>();
    }
}
