﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class QPFrameworkDownloadModuleMgrWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(QP.Framework.DownloadModuleMgr);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DownLoadForCS", _m_DownLoadForCS);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DownLoad", _m_DownLoad);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DownLoadHandler", _m_DownLoadHandler);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					QP.Framework.DownloadModuleMgr gen_ret = new QP.Framework.DownloadModuleMgr();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to QP.Framework.DownloadModuleMgr constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DownLoadForCS(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                QP.Framework.DownloadModuleMgr gen_to_be_invoked = (QP.Framework.DownloadModuleMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _module = LuaAPI.lua_tostring(L, 2);
                    QP.Framework.DownloadModuleTable _CSTable = (QP.Framework.DownloadModuleTable)translator.GetObject(L, 3, typeof(QP.Framework.DownloadModuleTable));
                    
                    gen_to_be_invoked.DownLoadForCS( _module, _CSTable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DownLoad(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                QP.Framework.DownloadModuleMgr gen_to_be_invoked = (QP.Framework.DownloadModuleMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _module = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.DownLoad( _module );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DownLoadHandler(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                QP.Framework.DownloadModuleMgr gen_to_be_invoked = (QP.Framework.DownloadModuleMgr)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _module = LuaAPI.lua_tostring(L, 2);
                    QP.Framework.DownloadModuleTable _table = (QP.Framework.DownloadModuleTable)translator.GetObject(L, 3, typeof(QP.Framework.DownloadModuleTable));
                    
                    gen_to_be_invoked.DownLoadHandler( _module, _table );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, QP.Framework.DownloadModuleMgr.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
