using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ExpandableListViewExample {
	[Activity (Label = "ExpandableListViewExample", MainLauncher = true)]
	public class MainActivity : Activity {

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

//			var listView = FindViewById<ListView> (Resource.Id.myListView);
//			listView.Adapter = new DataAdapter (this, Data.SampleData ());
//
//			listView.ItemClick += (sender, e) => {
//				Console.WriteLine(e.Position.ToString());
//			};

			var listView = FindViewById<ExpandableListView> (Resource.Id.myExpandableListview);
			listView.SetAdapter (new ExpandableDataAdapter (this, Data.SampleData ()));

		}
	}
}


