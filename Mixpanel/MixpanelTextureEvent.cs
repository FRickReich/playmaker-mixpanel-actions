using UnityEngine;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions {
	
	[ActionCategory("Mixpanel")]
	[Tooltip("Mixpanel Texture Event")]

	public class  MixpanelTextureEvent : FsmStateAction {

		[RequiredField]
		public string EventName;
		
		[RequiredField]
		public FsmString TextureName;

		public FsmTexture TextureValue;
		
		public override void Reset()
		{
			EventName = null;
			TextureName = "";
			TextureValue = null;
		}
		
		public override void OnEnter() {

			Mixpanel.SendEvent(EventName, new Dictionary<string, object> {
				{TextureName.ToString(), TextureValue.ToString()}
			});
			
			Finish();
			
		}
	}
}

