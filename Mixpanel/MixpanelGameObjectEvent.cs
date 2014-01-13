using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Mixpanel GameObject Event")]

	public class  MixpanelGameObjectEvent : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		[RequiredField]
		public FsmString GameObjectName;

		public FsmGameObject GameObjectValue;
		
		public override void Reset()
		{
			EventName = null;
			GameObjectName = "";
			GameObjectValue = null;
		}
		
		public override void OnEnter() {

			Mixpanel.SendEvent(EventName, new Dictionary<string, object> {
				{GameObjectName.ToString(), GameObjectValue.ToString()}
			});
			
			Finish();
			
		}
	}
}

