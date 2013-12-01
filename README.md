ExpandableListView
==================

Sample Expandable Listview using Xamarin

Keypoints: 

Expandable Listviews have two components. 

Group
and
Child

For Group think "Header" of the Expandable ListView
For Child think "Items" under the header. 

Each require their own layout. And each require their own "GetCount" and "GetView" implementation. 

In this example, the header is simply the first letter of the items.
