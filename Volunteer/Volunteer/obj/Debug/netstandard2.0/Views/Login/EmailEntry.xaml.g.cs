//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Volunteer.Views.Login.EmailEntry.xaml", "Views/Login/EmailEntry.xaml", typeof(global::Volunteer.Views.Login.EmailEntry))]

namespace Volunteer.Views.Login {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Login\\EmailEntry.xaml")]
    public partial class EmailEntry : global::Xamarin.Forms.ContentView {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Volunteer.Controls.BorderlessEntry Email;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label ValidationLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(EmailEntry));
            Email = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Volunteer.Controls.BorderlessEntry>(this, "Email");
            ValidationLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "ValidationLabel");
        }
    }
}
