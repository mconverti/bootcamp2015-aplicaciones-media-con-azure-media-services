﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VodWorkflow {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VodWorkflow.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;configuration version=&quot;2.0&quot;&gt;
        ///  &lt;input&gt;
        ///    &lt;metadata key=&quot;title&quot; value=&quot;GatesLetter.com viral video&quot; /&gt;
        ///    &lt;metadata key=&quot;description&quot; value=&quot;This is a viral video to promote the GatesLetter.com site&quot; /&gt;
        ///  &lt;/input&gt;
        ///  &lt;settings&gt;
        ///  &lt;/settings&gt;
        ///  &lt;features&gt;
        ///    &lt;feature name=&quot;ASR&quot;&gt;
        ///      &lt;settings&gt;
        ///        &lt;add key=&quot;Language&quot; value=&quot;English&quot;/&gt;
        ///        &lt;add key=&quot;CaptionFormats&quot; value=&quot;ttml;sami;webvtt&quot;/&gt;
        ///        &lt;add key=&quot;GenerateAIB&quot; value =&quot;true&quot; /&gt;
        ///      [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IndexerPreset {
            get {
                return ResourceManager.GetString("IndexerPreset", resourceCulture);
            }
        }
    }
}
