﻿using System;
using System.Linq;
using System.Windows.Input;
using Uno.Toolkit.Samples.Entities;
using Uno.Toolkit.Samples.ViewModels;
using Uno.Toolkit.UI;

#if IS_WINUI
using Microsoft.UI.Xaml.Controls;
#else
using Windows.UI.Xaml.Controls;
#endif

namespace Uno.Toolkit.Samples.Content.Controls
{
	[SamplePage(SampleCategory.Behaviors, nameof(InputExtensions), SourceSdk.UnoToolkit)]
	public sealed partial class InputExtensionsSamplePage : Page
	{
		public InputExtensionsSamplePage()
		{
			this.InitializeComponent();
		}
	}
}
