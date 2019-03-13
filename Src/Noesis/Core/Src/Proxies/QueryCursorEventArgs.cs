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

public class QueryCursorEventArgs : MouseEventArgs {
  private HandleRef swigCPtr;

  internal QueryCursorEventArgs(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(QueryCursorEventArgs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~QueryCursorEventArgs() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_QueryCursorEventArgs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal static new void InvokeHandler(Delegate handler, IntPtr sender, IntPtr args) {
    QueryCursorEventHandler handler_ = (QueryCursorEventHandler)handler;
    if (handler_ != null) {
      handler_(Extend.GetProxy(sender, false), new QueryCursorEventArgs(args, false));
    }
  }

  public Cursor Cursor {
    set {
      NoesisGUI_PINVOKE.QueryCursorEventArgs_Cursor_set(swigCPtr, (int)value);
    } 
    get {
      Cursor ret = (Cursor)NoesisGUI_PINVOKE.QueryCursorEventArgs_Cursor_get(swigCPtr);
      return ret;
    } 
  }

  public QueryCursorEventArgs(object s, RoutedEvent e) : this(NoesisGUI_PINVOKE.new_QueryCursorEventArgs(Noesis.Extend.GetInstanceHandle(s), RoutedEvent.getCPtr(e)), true) {
  }

}

}
