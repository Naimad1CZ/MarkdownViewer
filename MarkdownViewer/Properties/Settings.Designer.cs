﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarkdownViewer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{{{RESOURCES_DIRECTORY}}}\\HTML_TEMPLATE.html")]
        public string HtmlTemplateFilePath {
            get {
                return ((string)(this["HtmlTemplateFilePath"]));
            }
            set {
                this["HtmlTemplateFilePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{{{RESOURCES_DIRECTORY}}}\\MarkdownGuide.html")]
        public string MarkdownGuideFile {
            get {
                return ((string)(this["MarkdownGuideFile"]));
            }
            set {
                this["MarkdownGuideFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://nextstepwebs.github.io/simplemde-markdown-editor/markdown-guide")]
        public string MarkDownGuideURL {
            get {
                return ((string)(this["MarkDownGuideURL"]));
            }
            set {
                this["MarkDownGuideURL"] = value;
            }
        }
    }
}
