// ********************************************************
//   Copyright (c) Undersoft. All Rights Reserved.
//   Licensed under the MIT License. 
//   author: Dariusz Hanc
//   email: dh@undersoft.pl
//   application: Undersoft.AMS.Service.Application.Hybrid
// ********************************************************



namespace Undersoft.AMS.Service.Application.Hybrid
{
    public partial class App : Microsoft.Maui.Controls.Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}