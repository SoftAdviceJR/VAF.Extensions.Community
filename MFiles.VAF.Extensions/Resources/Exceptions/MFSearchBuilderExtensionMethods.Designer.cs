﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MFiles.VAF.Extensions.Resources.Exceptions {
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
    internal class MFSearchBuilderExtensionMethods {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MFSearchBuilderExtensionMethods() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MFiles.VAF.Extensions.Resources.Exceptions.MFSearchBuilderExtensionMethods", typeof(MFSearchBuilderExtensionMethods).Assembly);
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
        ///   Looks up a localized string similar to Could not resolve the identifier with alias/GUID {0} in the current vault..
        /// </summary>
        internal static string CannotResolveAlias_NotFound {
            get {
                return ResourceManager.GetString("CannotResolveAlias_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The search builder or vault reference is null, so the identifier with alias/GUID {0} cannot be resolved..
        /// </summary>
        internal static string CannotResolveAlias_VaultReferenceNull {
            get {
                return ResourceManager.GetString("CannotResolveAlias_VaultReferenceNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value ({0}) should contain a two-digit month number (e.g. &apos;03&apos;)..
        /// </summary>
        internal static string DataFunctionCallMonthInvalid {
            get {
                return ResourceManager.GetString("DataFunctionCallMonthInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The month value ({0}) should be between 1 and 12, inclusive..
        /// </summary>
        internal static string DataFunctionCallMonthOutOfRange {
            get {
                return ResourceManager.GetString("DataFunctionCallMonthOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When using a DataFunctionCall, the provided value cannot be null..
        /// </summary>
        internal static string DataFunctionCallValueNull {
            get {
                return ResourceManager.GetString("DataFunctionCallValueNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value ({0}) is not of the expected format (YYYY-MM)..
        /// </summary>
        internal static string DataFunctionCallYearAndMonthInvalid {
            get {
                return ResourceManager.GetString("DataFunctionCallYearAndMonthInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The year must be four digits..
        /// </summary>
        internal static string DataFunctionCallYearInvalid {
            get {
                return ResourceManager.GetString("DataFunctionCallYearInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The size parameter must be zero or larger..
        /// </summary>
        internal static string FileSize_Negative {
            get {
                return ResourceManager.GetString("FileSize_Negative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Handled data types cannot be empty..
        /// </summary>
        internal static string HandledDataTypesCannotBeEmpty {
            get {
                return ResourceManager.GetString("HandledDataTypesCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An indirection level references an object type with ID {0}, but this object type could not be found..
        /// </summary>
        internal static string IndirectionLevelPointsToInvalidObjectType {
            get {
                return ResourceManager.GetString("IndirectionLevelPointsToInvalidObjectType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An indirection level references an value list with ID {0}, but this list does not refer to an object type (cannot be used with value lists)..
        /// </summary>
        internal static string IndirectionLevelPointsToValueList {
            get {
                return ResourceManager.GetString("IndirectionLevelPointsToValueList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An indirection level references a property definition with ID {0}, but this property definition could not be found..
        /// </summary>
        internal static string IndirectionLevelPropertyNotFound {
            get {
                return ResourceManager.GetString("IndirectionLevelPropertyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The indirection level for property {0} does not reference a lookup-style property definition (actual type: {1})..
        /// </summary>
        internal static string IndirectionLevelPropertyNotOfExpectedType {
            get {
                return ResourceManager.GetString("IndirectionLevelPropertyNotOfExpectedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The condition type {0} is not supported for object Ids..
        /// </summary>
        internal static string ObjectIDs_ConditionTypeInvalid {
            get {
                return ResourceManager.GetString("ObjectIDs_ConditionTypeInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object Id must be greater than 0..
        /// </summary>
        internal static string ObjectIDs_ObjectIDMustBeGreaterThanZero {
            get {
                return ResourceManager.GetString("ObjectIDs_ObjectIDMustBeGreaterThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The segment index must be zero or larger..
        /// </summary>
        internal static string ObjectIDs_SegmentIndexMustBeZeroOrLarger {
            get {
                return ResourceManager.GetString("ObjectIDs_SegmentIndexMustBeZeroOrLarger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The segment size must be one or larger..
        /// </summary>
        internal static string ObjectIDs_SegmentSizeMustBeOneOrLarger {
            get {
                return ResourceManager.GetString("ObjectIDs_SegmentSizeMustBeOneOrLarger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The lookup collection does not contain any items..
        /// </summary>
        internal static string OneOf_CollectionEmpty {
            get {
                return ResourceManager.GetString("OneOf_CollectionEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The condition type {0} is not supported for permission-based search conditions..
        /// </summary>
        internal static string Permissions_ConditionTypeInvalid {
            get {
                return ResourceManager.GetString("Permissions_ConditionTypeInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The search builder&apos;s conditions are null..
        /// </summary>
        internal static string SearchConditionsNull {
            get {
                return ResourceManager.GetString("SearchConditionsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The end segment must be greater than zero..
        /// </summary>
        internal static string SegmentedSearch_EndSegmentMustBeGreaterThanZero {
            get {
                return ResourceManager.GetString("SegmentedSearch_EndSegmentMustBeGreaterThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The search timeout must be greater than zero, or zero to indicate an indefinite timeout..
        /// </summary>
        internal static string SegmentedSearch_SearchTimeoutMustBeZeroOrLarger {
            get {
                return ResourceManager.GetString("SegmentedSearch_SearchTimeoutMustBeZeroOrLarger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The segment size must be greater than zero..
        /// </summary>
        internal static string SegmentedSearch_SegmentSizeMustBeGreaterThanZero {
            get {
                return ResourceManager.GetString("SegmentedSearch_SegmentSizeMustBeGreaterThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The starting segment must be zero or larger..
        /// </summary>
        internal static string SegmentedSearch_StartSegmentMustBeZeroOrLarger {
            get {
                return ResourceManager.GetString("SegmentedSearch_StartSegmentMustBeZeroOrLarger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The vault&apos;s ObjectSearchOperations reference is null..
        /// </summary>
        internal static string VaultObjectSearchOperationsReferenceNull {
            get {
                return ResourceManager.GetString("VaultObjectSearchOperationsReferenceNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The search builder&apos;s vault reference is null..
        /// </summary>
        internal static string VaultReferenceNull {
            get {
                return ResourceManager.GetString("VaultReferenceNull", resourceCulture);
            }
        }
    }
}