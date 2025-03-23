using UnityEngine;
using UnityEngine.UI;
public class Example : MonoBehaviour
{
    public Sprite newSprite;
    private Image image;
    void Start()
    {
        // SpriteRendererコンポーネントを取得します
        image = GetComponent<Image>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 画像を切り替えます
            image.sprite = newSprite;
        }
    }
}