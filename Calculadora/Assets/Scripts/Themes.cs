using UnityEngine;
using UnityEngine.UI;

//This example outputs Sliders that control the red green and blue elements of a sprite's color
//Attach this to a GameObject and attach a SpriteRenderer component

public class Themes : MonoBehaviour
{
//    [SerializeField] private Color cyanBackground = Color.cyan;
    [SerializeField] private Color blackBackground;
    [SerializeField] private Color redBackground;
    [SerializeField] private Color yellowBackground;
    [SerializeField] private Color greenBackground;
    [SerializeField] private Color cyanBackground;
    [SerializeField] private Color blueBackground;
    [SerializeField] private Color magentaBackground;
    [SerializeField] private Color whiteBackground;
    

    //ui component
    [SerializeField] private SpriteRenderer m_SpriteRenderer;

    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();

        blackBackground = new Color(0.2f,0.2f, 0.2f,0.5f);
        redBackground = new Color(0.8f, 0.0f, 0.0f, 0.5f);
        yellowBackground = new Color(0.8f, 0.8f, 0.0f, 0.5f);
        greenBackground = new Color(0.0f, 0.8f, 0.0f, 0.5f);
        cyanBackground = new Color(0.0f, 0.8f, 0.8f, 0.5f);
        blueBackground = new Color(0.0f, 0.0f, 0.8f, 0.5f);
        magentaBackground = new Color(0.8f, 0.0f, 0.8f, 0.5f);
        whiteBackground = new Color(0.8f, 0.8f, 0.8f, 0.5f);

        m_SpriteRenderer.color = blackBackground;
    }

    public void ChoiceTheme()
    {
        if (m_SpriteRenderer.color == blackBackground)
        {
            m_SpriteRenderer.color = redBackground;
        }
        else if (m_SpriteRenderer.color == redBackground)
        {
            m_SpriteRenderer.color = yellowBackground;
        }
        else if (m_SpriteRenderer.color == yellowBackground)
        {
            m_SpriteRenderer.color = greenBackground;
        }
        else if (m_SpriteRenderer.color == greenBackground)
        {
            m_SpriteRenderer.color = cyanBackground;
        }
        else if (m_SpriteRenderer.color == cyanBackground)
        {
            m_SpriteRenderer.color = blueBackground;
        }
        else if (m_SpriteRenderer.color == blueBackground)
        {
            m_SpriteRenderer.color = magentaBackground;
        }
        else if (m_SpriteRenderer.color == magentaBackground)
        {
            m_SpriteRenderer.color = whiteBackground;
        }
        else{
            m_SpriteRenderer.color = blackBackground;
        }
    }
}