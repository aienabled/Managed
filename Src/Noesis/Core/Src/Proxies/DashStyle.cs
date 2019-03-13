//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class DashStyle : Animatable {
  internal new static DashStyle CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new DashStyle(cPtr, cMemoryOwn);
  }

  internal DashStyle(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(DashStyle obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public DashStyle() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_DashStyle();
  }

  public static DependencyProperty DashesProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DashStyle_DashesProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty OffsetProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.DashStyle_OffsetProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public string Dashes {
    set {
      NoesisGUI_PINVOKE.DashStyle_Dashes_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.DashStyle_Dashes_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public float Offset {
    set {
      NoesisGUI_PINVOKE.DashStyle_Offset_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.DashStyle_Offset_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.DashStyle_GetStaticType();
    return ret;
  }

}

}
