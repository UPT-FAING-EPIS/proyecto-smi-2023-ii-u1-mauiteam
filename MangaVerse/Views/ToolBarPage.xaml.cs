// namespace MangaVerse.Views
// {
//     public partial class ToolBarPage : ContentPage
//     {
//         public ToolBarPage()
//         {
//             InitializeComponent();
//             this.BindingContext = new ToolBarViewModel();
//         }
//         public class ToolBarViewModel : BaseViewModel
//         {
//             public Command Opcion1Command { get; }
//             public Command Opcion2Command { get; }

//             public ToolBarViewModel()
//             {
//                 Opcion1Command = new Command(ExecuteOpcion1);
//                 Opcion2Command = new Command(ExecuteOpcion2);
//             }

//             private void ExecuteOpcion1()
//             {
//                 // Lógica para la Opción 1
//             }

//             private void ExecuteOpcion2()
//             {
//                 // Lógica para la Opción 2
//             }
//         }
//     }
// }