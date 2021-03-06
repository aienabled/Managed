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

public class Decorator : FrameworkElement {
  internal new static Decorator CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Decorator(cPtr, cMemoryOwn);
  }

  internal Decorator(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Decorator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Decorator(bool logicalChild) : this(NoesisGUI_PINVOKE.new_Decorator__SWIG_0(logicalChild), true) {
  }

  public Decorator() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(Decorator)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_Decorator__SWIG_1();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public UIElement Child {
    set {
      NoesisGUI_PINVOKE.Decorator_Child_set(swigCPtr, UIElement.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Decorator_Child_get(swigCPtr);
      return (UIElement)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_Decorator(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

