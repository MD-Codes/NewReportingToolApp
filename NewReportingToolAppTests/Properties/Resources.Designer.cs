﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewReportingToolAppTests.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NewReportingToolAppTests.Properties.Resources", typeof(Resources).Assembly);
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
        ///&lt;ArrayOfIPartyAffiliation&gt;
        ///	&lt;IPartyAffiliation&gt;
        ///		&lt;UserId&gt;10001&lt;/UserId&gt;
        ///		&lt;PartyName&gt;Independent MP&lt;/PartyName&gt;
        ///	&lt;/IPartyAffiliation&gt;
        ///&lt;/ArrayOfIPartyAffiliation&gt;.
        /// </summary>
        internal static string XMLFile1 {
            get {
                return ResourceManager.GetString("XMLFile1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;publicwhip&gt;
        ///	&lt;regmem personid=&quot;uk.org.publicwhip/person/10001&quot; membername=&quot;Diane Abbott&quot; date=&quot;2021-12-13&quot;&gt;
        ///		&lt;category type=&quot;1&quot; name=&quot;Employment and earnings&quot;&gt;
        ///			&lt;record&gt;
        ///				&lt;item&gt;Payments from the Guardian, Kings Place, 90 York Way, London N1 9GU, for articles:&lt;/item&gt;
        ///				&lt;item&gt;24 July 2020, received £100. Hours: 1 hr. (Registered 02 February 2021)&lt;/item&gt;
        ///				&lt;item&gt;19 October 2020, received £258.80. Hours: 1 hr 30 mins. (Registered 02 February 2021)&lt;/item&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string XMLFile2 {
            get {
                return ResourceManager.GetString("XMLFile2", resourceCulture);
            }
        }
    }
}
