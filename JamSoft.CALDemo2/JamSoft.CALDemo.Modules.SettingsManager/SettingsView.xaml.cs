﻿#region File Header

// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo2
// Project Name : JamSoft.CALDemo.Modules.SettingsManager
// File Name    : SettingsView.xaml.cs
// Created     : 03/07/2015 22:47
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.SettingsManager
{
    using JamSoft.CALDemo.Modules.SettingsManager.Core;
    using JamSoft.CALDemo.Modules.SkinManager.Core;

    /// <summary>
    ///     Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : ISettingsView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsView"/> class.
        /// </summary>
        public SettingsView()
        {
            InitializeComponent();
        }

        /// <summary>Sets the model.</summary>
        /// <value>The model.</value>
        public ISettingsManagerPresentationModel Model
        {
            set
            {
                DataContext = value;
            }
        }

        /// <summary>Sets the skin picker model.</summary>
        /// <value>The skin picker model.</value>
        public ISkinManager SkinPickerModel
        {
            set
            {
                CmbSkinPicker.DataContext = value;
            }
        }
    }
}