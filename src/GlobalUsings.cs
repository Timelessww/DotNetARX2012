/// 系统引用
global using System;
global using System.Collections;
global using System.Collections.Generic;
global using System.IO;
global using System.Linq;
global using System.Text;
global using System.Reflection;
global using System.Text.RegularExpressions;
global using System.ComponentModel;
global using System.Runtime.InteropServices;
global using System.Diagnostics;
global using System.Xml;
global using System.Threading;
global using Exception = System.Exception;
#if !NET35
global using System.Data.OleDb;// 数据库  
#endif
global using Newtonsoft.Json;
global using Formatting = Newtonsoft.Json.Formatting;
global using Microsoft.Win32;
global using Registry = Microsoft.Win32.Registry;

global using System.Runtime.Serialization.Formatters.Binary;
global using System.Xml.Serialization;
global using System.Collections.ObjectModel;
global using System.Xml.Linq;
global using System.Net.Sockets;
global using System.Net;

global using SystemVariableChangedEventArgs = Autodesk.AutoCAD.ApplicationServices.SystemVariableChangedEventArgs;
global using SystemVariableChangingEventArgs = Autodesk.AutoCAD.ApplicationServices.SystemVariableChangingEventArgs;
global using System.Management;  // 在项目-》添加引用....里面引用System.Management

global using Microsoft.CSharp;// 动态编译

#if !HC2020
/// autocad 引用
global using Autodesk.AutoCAD.ApplicationServices;
global using Autodesk.AutoCAD.EditorInput;
global using Autodesk.AutoCAD.Colors;
global using Autodesk.AutoCAD.DatabaseServices;
global using Autodesk.AutoCAD.Geometry;
global using Autodesk.AutoCAD.Runtime;
global using Autodesk.AutoCAD.DatabaseServices.Filters;
global using Autodesk.AutoCAD.Customization; // 需要引用 AcCui.dll

global using Autodesk.AutoCAD.Interop;// com接口
global using Autodesk.AutoCAD.Interop.Common;// com接口
global using ToolbarDockStatus = Autodesk.AutoCAD.Interop.Common.AcToolbarDockStatus;

global using Autodesk.AutoCAD.GraphicsInterface; // jig的,引发其他重意义
global using Viewport = Autodesk.AutoCAD.DatabaseServices.Viewport;
global using Polyline = Autodesk.AutoCAD.DatabaseServices.Polyline;
global using Group = Autodesk.AutoCAD.DatabaseServices.Group;

// cui
global using StringCollection = System.Collections.Specialized.StringCollection;
#if !NET35
global using ObjectContexts = Autodesk.AutoCAD.Internal.ObjectContexts; 
#endif

global using Autodesk.AutoCAD.Windows;

// 打印机
global using Autodesk.AutoCAD.PlottingServices;
global using PlotType = Autodesk.AutoCAD.DatabaseServices.PlotType;

global using Acap = Autodesk.AutoCAD.ApplicationServices.Application;
global using Autodesk.AutoCAD.LayerManager;
global using LayerFilter = Autodesk.AutoCAD.LayerManager.LayerFilter;
global using AttributeCollection = Autodesk.AutoCAD.DatabaseServices.AttributeCollection;

#if !NET35
global using Autodesk.AutoCAD.BoundaryRepresentation;
global using BR_Face = Autodesk.AutoCAD.BoundaryRepresentation.Face;
global using BR_Edge = Autodesk.AutoCAD.BoundaryRepresentation.Edge;
#endif

global using DS_DwgFiler = Autodesk.AutoCAD.DatabaseServices.DwgFiler;
global using Acad_ErrorStatus = Autodesk.AutoCAD.Runtime.ErrorStatus;
global using ErrorStatus = Autodesk.AutoCAD.Runtime.ErrorStatus;
global using Vertex = Autodesk.AutoCAD.DatabaseServices.Vertex;

#else
// 浩辰的
// global using GrxCAD.ApplicationServices;
// global using GrxCAD.EditorInput;
// global using GrxCAD.Colors;
// global using GrxCAD.DatabaseServices;
// global using GrxCAD.Geometry;
// global using GrxCAD.Runtime;
// global using GrxCAD.DatabaseServices.Filters;
// global using Acap = GrxCAD.ApplicationServices.Application;

// global using GrxCAD.GraphicsInterface;
// global using GcadVbaLib; // gcax.tlb 浩辰的com接口
#endif
