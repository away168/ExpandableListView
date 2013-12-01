using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ExpandableListViewExample {
	public class ExpandableDataAdapter : BaseExpandableListAdapter {

		readonly Activity Context;
		public ExpandableDataAdapter(Activity newContext, List<Data> newList) : base()
		{
			Context = newContext;
			DataList = newList;
		}

		protected List<Data> DataList { get; set; }

		public override View GetGroupView (int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
		{
			View header = convertView;
			if (header == null) {
				header = Context.LayoutInflater.Inflate (Resource.Layout.ListGroup, null);
			}
			header.FindViewById<TextView> (Resource.Id.DataHeader).Text = ((char)(65 + groupPosition)).ToString ();

			return header;
		}

		public override View GetChildView (int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
		{
			View row = convertView;
			if (row == null) {
				row = Context.LayoutInflater.Inflate (Resource.Layout.DataListItem, null);
			}
			string newId ="", newValue = "";
			GetChildViewHelper (groupPosition, childPosition, out newId, out newValue);
			row.FindViewById<TextView> (Resource.Id.DataId).Text = newId;
			row.FindViewById<TextView> (Resource.Id.DataValue).Text = newValue;

			return row;
			//throw new NotImplementedException ();
		}

		public override int GetChildrenCount (int groupPosition)
		{
			char letter = (char)(65 + groupPosition);
			List<Data> results = DataList.FindAll ((Data obj) => obj.Id [0].Equals (letter));
			return results.Count;
		}

		public override int GroupCount {
			get {
				return 26;
			}
		}

		private void GetChildViewHelper (int groupPosition, int childPosition, out string Id, out string Value)
		{
			char letter = (char)(65 + groupPosition);
			List<Data> results = DataList.FindAll ((Data obj) => obj.Id [0].Equals (letter));
			Id = results [childPosition].Id;
			Value = results [childPosition].Value;
		}

		#region implemented abstract members of BaseExpandableListAdapter

		public override Java.Lang.Object GetChild (int groupPosition, int childPosition)
		{
			throw new NotImplementedException ();
		}

		public override long GetChildId (int groupPosition, int childPosition)
		{
			return childPosition;
		}

		public override Java.Lang.Object GetGroup (int groupPosition)
		{
			throw new NotImplementedException ();
		}

		public override long GetGroupId (int groupPosition)
		{
			return groupPosition;
		}

		public override bool IsChildSelectable (int groupPosition, int childPosition)
		{
			throw new NotImplementedException ();
		}

		public override bool HasStableIds {
			get {
				return true;
			}
		}

		#endregion
	}
}

