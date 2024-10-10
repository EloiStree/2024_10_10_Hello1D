using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello1DMono : MonoBehaviour
{

    public string m_display = "___________";
    public char[] m_gameState = new char[10];

    public int m_playerPosition = 5;

    public void Refresh()
    {
        for (int i = 0; i < m_gameState.Length; i++)
        {
            m_gameState[i] = '_';
        }
        m_playerPosition= Mathf.Clamp(m_playerPosition, 0, m_gameState.Length - 1);
        m_gameState[m_playerPosition] = 'X';
        m_display = string.Join("", m_gameState);
    }
    public void OnValidate()
    {
        Refresh();
    }
    

}
