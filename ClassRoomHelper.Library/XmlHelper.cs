using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace System.Xml.Serialization
{
	/// <summary>
	/// XML序列化、反序列化辅助类
	/// </summary>
	public static class XmlHelper
	{
		#region 类简介
		/********************************************************************************************************
         *                                             Introduction                                             *
         *                                      Helper Name ==> XmlHelper                                       *
         *                                           Author ==> Hiiragi - Chunfeng 2016                         *
         *                             Last Update DateTime ==> 2016/07/04 16:08:26                             *
         * ---------------------------------------------------------------------------------------------------- *
         * Remark:                                                                                              *
         *   Null.                                                                                              *
         ********************************************************************************************************/
		#endregion

		#region 将指定对象序列化为XML文档 + public static XmlDocument ObjectToXML(object obj)
		/// <summary>
		/// 将指定对象序列化为XML文档
		/// </summary>
		/// <param name="obj">待序列化对象</param>
		public static XmlDocument ObjectToXML(object obj)
		{
			XmlDocument xmlDoc = new XmlDocument();

			using (MemoryStream ms = new MemoryStream())
			{
				XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
				xmlSerializer.Serialize(ms, obj);

				ms.Seek(0, SeekOrigin.Begin);
				xmlDoc.Load(ms);
			}

			return xmlDoc;
		}
		#endregion

		#region 将指定对象序列化为XML文档 + public static void ObjectToXML(object obj, string path)
		/// <summary>
		/// 将指定对象序列化为XML文档
		/// </summary>
		/// <param name="obj">待序列化对象</param>
		/// <param name="path">XML文档保存路径</param>
		public static void ObjectToXML(object obj, string path)
		{
			using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
			{
				XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
				xmlSerializer.Serialize(fs, obj);
			}
		}
		#endregion

		#region 将XML文档反序列化为指定对象类型 + public static T XMLToObejct<T>(string path)
		/// <summary>
		/// 将XML文档反序列化为指定对象类型
		/// </summary>
		/// <typeparam name="T">目标对象类型</typeparam>
		/// <param name="path">XML文档路径</param>
		/// <returns>目标对象</returns>
		public static T XMLToObejct<T>(string path)
		{
			if (!File.Exists(path)) return default(T);

			try
			{
				T t;
				using (XmlReader xmlReader = XmlReader.Create(path))
				{
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
					t = (T)xmlSerializer.Deserialize(xmlReader);
				}
				return t;
			}
			catch (Exception)
			{
				return default(T);
			}
		}
		#endregion

		#region 将XML文档反序列化为指定对象类型 + public static T XMLToObejct<T>(XmlReader xmlReader)
		/// <summary>
		/// 将XML文档反序列化为指定对象类型
		/// </summary>
		/// <typeparam name="T">目标对象类型</typeparam>
		/// <param name="xmlReader">XML读取器</param>
		/// <returns>目标对象</returns>
		public static T XMLToObejct<T>(XmlReader xmlReader)
		{
			if (xmlReader == null) return default(T);

			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
				T t = (T)xmlSerializer.Deserialize(xmlReader);
				return t;
			}
			catch (Exception)
			{
				return default(T);
			}
		}
		#endregion

		#region 将XML文档反序列化为指定对象类型 + public static T XMLToObejct<T>(XmlDocument xmlDocument)
		/// <summary>
		/// 将XML文档反序列化为指定对象类型
		/// </summary>
		/// <typeparam name="T">目标对象类型</typeparam>
		/// <param name="xmlDocument">XML文档对象</param>
		/// <returns>目标对象</returns>
		public static T XMLToObejct<T>(XmlDocument xmlDocument)
		{
			if (xmlDocument == null) return default(T);

			StringReader sr = new StringReader(xmlDocument.OuterXml);
			XmlReader xmlReader = XmlReader.Create(sr);
			T t = XMLToObejct<T>(xmlReader);

			return t;
		}
		#endregion

		#region 将XML文档转为XML读取器 + public static XmlReader XmlDocumentToXmlReader(XmlDocument xmlDocument)
		/// <summary>
		/// 将XML文档转为XML读取器
		/// </summary>
		/// <param name="xmlDocument">XML文档</param>
		/// <returns>XML读取器</returns>
		public static XmlReader XmlDocumentToXmlReader(XmlDocument xmlDocument)
		{
			XmlReader xmlReader;

			using (MemoryStream ms = new MemoryStream())
			{
				xmlDocument.Save(ms);

				ms.Seek(0, SeekOrigin.Begin);
				xmlReader = XmlReader.Create(ms);
			}

			return xmlReader;
		}
		#endregion
	}
}