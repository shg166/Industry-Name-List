using System;
using System.Reflection;
using UnityEngine;
using ColossalFramework.UI;
using ICities;

namespace JP_IndustryNameList
{
	public class JP_IndustryNameList : IUserMod
	{

		public string Name
		{
			get { return "JP Industry Name List (CNL) v1.0"; }
		}

		public string Description
		{
			get { return "Custom Name Listsを使って、DLC Industriesの産業エリア名を変更します"; }
		}

	}
}
