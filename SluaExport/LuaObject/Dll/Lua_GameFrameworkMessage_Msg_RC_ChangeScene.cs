﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_GameFrameworkMessage_Msg_RC_ChangeScene : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			GameFrameworkMessage.Msg_RC_ChangeScene o;
			o=new GameFrameworkMessage.Msg_RC_ChangeScene();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_target_scene_id(IntPtr l) {
		try {
			GameFrameworkMessage.Msg_RC_ChangeScene self=(GameFrameworkMessage.Msg_RC_ChangeScene)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.target_scene_id);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_target_scene_id(IntPtr l) {
		try {
			GameFrameworkMessage.Msg_RC_ChangeScene self=(GameFrameworkMessage.Msg_RC_ChangeScene)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.target_scene_id=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"GameFrameworkMessage.Msg_RC_ChangeScene");
		addMember(l,"target_scene_id",get_target_scene_id,set_target_scene_id,true);
		createTypeMetatable(l,constructor, typeof(GameFrameworkMessage.Msg_RC_ChangeScene));
	}
}
