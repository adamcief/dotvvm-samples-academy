﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotvvmAcademy.Lessons {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class GenericTexts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal GenericTexts() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotvvmAcademy.Lessons.GenericTexts", typeof(GenericTexts).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The class {0} was not found!.
        /// </summary>
        public static string ClassNotFound {
            get {
                return ResourceManager.GetString("ClassNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to You need to add empty parenthesis after the {0} method..
        /// </summary>
        public static string CommandDoesNotHaveParenthesis {
            get {
                return ResourceManager.GetString("CommandDoesNotHaveParenthesis", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The command methods in the viewmodel must be public and must have the correct signature!.
        /// </summary>
        public static string CommandMethodError {
            get {
                return ResourceManager.GetString("CommandMethodError", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The {0} method doesn&apos;t exist!.
        /// </summary>
        public static string MethodNotFound {
            get {
                return ResourceManager.GetString("MethodNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to You must call the {0} in the command binding!.
        /// </summary>
        public static string MethodWasNotCalled {
            get {
                return ResourceManager.GetString("MethodWasNotCalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to The {0} property was not found or doesn&apos;t have a correct type!.
        /// </summary>
        public static string PropertyNotFound {
            get {
                return ResourceManager.GetString("PropertyNotFound", resourceCulture);
            }
        }
    }
}