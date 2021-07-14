﻿using System;
using System.Collections.Generic;
using Comet.Handlers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Hosting;

namespace Comet
{
	public static class AppHostBuilderExtensions
	{
		public static IAppHostBuilder UseCometHandlers(this IAppHostBuilder builder)
		{

			//AnimationManger.SetTicker(new iOSTicker());

			//Set Default Style
			var style = new Styles.Style();
			style.Apply();

			

			builder.ConfigureMauiHandlers((_, handlersCollection) => handlersCollection.AddHandlers(new Dictionary<Type, Type>
			{
				{ typeof(AbstractLayout), typeof(LayoutHandler) },
				{ typeof(ActivityIndicator), typeof(ActivityIndicatorHandler) },
				{ typeof(Button), typeof(ButtonHandler) },
				{ typeof(CheckBox), typeof(CheckBoxHandler) },
				{ typeof(CometWindow), typeof(WindowHandler) },
				{ typeof(DatePicker), typeof(DatePickerHandler) },
				{ typeof(Image) , typeof(ImageHandler) },
				//{ typeof(Picker), typeof(PickerHandler) },
				{ typeof(ProgressBar), typeof(ProgressBarHandler) },
				{ typeof(SearchBar), typeof(SearchBarHandler) },
				{ typeof(SecureField), typeof(EntryHandler) },
				{ typeof(Slider), typeof(SliderHandler) },
				{ typeof(Stepper), typeof(StepperHandler) },
				{ typeof(Spacer), typeof(SpacerHandler) },
				{ typeof(TabView), typeof(TabViewHandler) },
				{ typeof(TextEditor), typeof(EditorHandler) },
				{ typeof(TextField), typeof(EntryHandler) },
				{ typeof(Text), typeof(LabelHandler) },
				{ typeof(TimePicker), typeof(TimePickerHandler) },
				{ typeof(Toggle), typeof(SwitchHandler) },
#if __MOBILE__
				{ typeof(ListView),typeof(ListViewHandler) },
				{typeof(NavigationView), typeof (NavigationViewHandler)},
				{typeof(ScrollView), typeof(ScrollViewHandler) },
				{typeof(ShapeView), typeof(Comet.Handlers.ShapeViewHandler)},

#endif


#if __IOS__
				{typeof(View), typeof(CometViewHandler)},
#endif
			}));

			return builder;
		}

	}
}