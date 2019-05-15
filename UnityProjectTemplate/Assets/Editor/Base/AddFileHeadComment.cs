using UnityEditor;
using UnityEngine;
using System.IO;

/**
 * 每个项目都需要添加的头文件,项目创建时需要确定Company   
 */
public class AddFileHeadComment : UnityEditor.AssetModificationProcessor
{
    /// <summary>
    /// 获取当前文件信息
    /// </summary>
    /// <param name="newFileMeta"></param>
    public static void OnWillCreateAsset(string newFileMeta)
    {
        string newFilePath = newFileMeta.Replace(".meta", "");
        string fileExt = Path.GetExtension(newFilePath);
        if (fileExt != ".cs")
        {
            return;
        }

        string realPath = Application.dataPath.Replace("Assets", "") + newFilePath;
        string scriptContent = File.ReadAllText(realPath);
        
        // 获取信息设置注释
        scriptContent = scriptContent.Replace("#SCRIPTFULLNAME#", Path.GetFileName(newFilePath));
        scriptContent = scriptContent.Replace("#COMPANY#", PlayerSettings.companyName);
        scriptContent = scriptContent.Replace("#AUTHOR#", "yic");
        scriptContent = scriptContent.Replace("#UNITYVERSION#", Application.unityVersion);
        scriptContent = scriptContent.Replace("#DATE#", System.DateTime.Now.ToString("yyyy-MM-dd"));

        File.WriteAllText(realPath, scriptContent);
    }

}