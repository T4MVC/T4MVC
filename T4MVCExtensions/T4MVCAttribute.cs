using System;

namespace System.Web.Mvc {

  [AttributeUsage(AttributeTargets.Class)]
  public class T4MVCAttribute : Attribute {


    public T4MVCAttribute() : this(true) {
    }

    public T4MVCAttribute(bool process) {
      Process = process;
    }


    public bool Process { get; private set; }


  }
}
