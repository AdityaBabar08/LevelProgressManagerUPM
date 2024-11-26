using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "XPConfig", menuName = "Configs/XPConfig")]
public class XPConfigSO : ScriptableObject
{
    [Header("XP Settings")]
    [SerializeField] private int[] xpThresholds;

    [Header("Performance Tracker Settings")]
    [SerializeField] private float strugglingTimeThreshold = 60f;
    [SerializeField] private int retryThreshold = 3;
    [SerializeField] private float excellingAccuracyThreshold = 0.8f;


    public int GetXPForNextLevel(int currentLevel)
    {
        if (currentLevel < xpThresholds.Length)
            return xpThresholds[currentLevel];
        return xpThresholds[xpThresholds.Length - 1];
    }

    public float GetStrugglingTimeThreshold()
    {
        return strugglingTimeThreshold;
    }

    public int GetRetryThreshold()
    {
        return retryThreshold;
    }

    public float GetExcellingAccuracyThreshold()
    {
        return excellingAccuracyThreshold;
    }
}
