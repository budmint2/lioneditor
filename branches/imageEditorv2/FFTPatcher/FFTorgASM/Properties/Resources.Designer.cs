﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FFTorgASM.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FFTorgASM.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;Patches&gt;
        ///  &lt;Patch name=&quot;Death Sentence - Ignore Cancel:Dead&quot;&gt;
        ///    &lt;Location file=&quot;BATTLE_BIN&quot;
        ///              offset=&quot;11c240&quot;&gt;
        ///      10 00 42 30
        ///      05 00 40 14
        ///      20 00 02 34
        ///      28 00 00 a6
        ///    &lt;/Location&gt;
        ///  &lt;/Patch&gt;
        ///
        ///  &lt;Patch name=&quot;Increase Jump damage by 3/2 regardless of weapon&quot;&gt;
        ///    &lt;Location file=&quot;BATTLE_BIN&quot;
        ///              offset=&quot;11eec2&quot;&gt;
        ///      63
        ///    &lt;/Location&gt;
        ///  &lt;/Patch&gt;
        ///
        ///  &lt;Patch name=&quot;No starting items&quot;&gt;
        ///    &lt;Location file=&quot;SCUS_ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultHacks {
            get {
                return ResourceManager.GetString("DefaultHacks", resourceCulture);
            }
        }
    }
}
