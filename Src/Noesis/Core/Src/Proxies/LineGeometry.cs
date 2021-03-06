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

public class LineGeometry : Geometry {
  internal new static LineGeometry CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new LineGeometry(cPtr, cMemoryOwn);
  }

  internal LineGeometry(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(LineGeometry obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public LineGeometry() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_LineGeometry__SWIG_0();
  }

  public LineGeometry(Point p1, Point p2) : this(NoesisGUI_PINVOKE.new_LineGeometry__SWIG_1(ref p1, ref p2), true) {
  }

  public override bool IsEmpty() {
    bool ret = NoesisGUI_PINVOKE.LineGeometry_IsEmpty(swigCPtr);
    return ret;
  }

  public static DependencyProperty EndPointProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.LineGeometry_EndPointProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty StartPointProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.LineGeometry_StartPointProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Point StartPoint {
    set {
      NoesisGUI_PINVOKE.LineGeometry_StartPoint_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.LineGeometry_StartPoint_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Point>(ret);
      }
      else {
        return new Point();
      }
    }

  }

  public Point EndPoint {
    set {
      NoesisGUI_PINVOKE.LineGeometry_EndPoint_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.LineGeometry_EndPoint_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Point>(ret);
      }
      else {
        return new Point();
      }
    }

  }

}

}

