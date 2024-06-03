using UnityEngine;
using System.Xml;
using System.IO;

public class XmlExample : MonoBehaviour
{
    void Start()
    {
        XmlDocument xmlDoc = new XmlDocument();

        // Создание нового XML документа
        XmlNode rootNode = xmlDoc.CreateElement("Player");
        xmlDoc.AppendChild(rootNode);

        XmlNode userNode = xmlDoc.CreateElement("Name");
        userNode.InnerText = "John";
        rootNode.AppendChild(userNode);

        XmlNode scoreNode = xmlDoc.CreateElement("Score");
        scoreNode.InnerText = "100";
        rootNode.AppendChild(scoreNode);

        // Запись в файл
        xmlDoc.Save(Application.dataPath + "/player.xml");

        // Чтение из файла
        XmlDocument loadedXml = new XmlDocument();
        loadedXml.Load(Application.dataPath + "/player.xml");

        string loadedName = loadedXml.SelectSingleNode("Player/Name").InnerText;
        string loadedScore = loadedXml.SelectSingleNode("Player/Score").InnerText;

        Debug.Log(loadedName);
        Debug.Log(loadedScore);
    }
}