//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HolaMundo.Xama {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class MainPage : ContentPage {
        
        private Entry MyText;
        
        private Label Result;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(MainPage));
            MyText = this.FindByName<Entry>("MyText");
            Result = this.FindByName<Label>("Result");
        }
    }
}
