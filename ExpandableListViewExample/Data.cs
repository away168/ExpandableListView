using System;
using System.Collections.Generic;

/// <summary>
/// Publicly Available Webservices : 
/// Weather
/// source: http://graphical.weather.gov/xml/rest.php
/// Bureau of Labor and Statistics 
/// source: http://www.bls.gov/developers/
/// 
/// Earthquake data: 
/// sources: http://comcat.cr.usgs.gov/fdsnws/event/1/
/// </summary>

namespace ExpandableListViewExample {
	public class Data {
	
		public Data ()
		{
		}

		public static List<Data> SampleData()
		{
			var newDataList = new List<Data>();
			newDataList.Add (new Data ("Alabama", "Montegomery"));
			newDataList.Add (new Data ("Alaska", "Juneau"));
			newDataList.Add (new Data ("Arizona", "Pheonix"));
			newDataList.Add (new Data ("Arkansas", "Little Rock"));
			newDataList.Add (new Data ("California", "Sacramento"));
			newDataList.Add (new Data ("Colorado", "Denver"));
			newDataList.Add (new Data ("Connecticut", "Hartford"));
			newDataList.Add (new Data ("Delaware", "Dover"));
			newDataList.Add (new Data ("Florida", "Tallahassee"));
			newDataList.Add (new Data ("Georgia", "Atlanta"));
			newDataList.Add (new Data ("Hawaii", "Honolulu"));
			newDataList.Add (new Data ("Idaho", "Boise"));
			newDataList.Add (new Data ("Illinois", "Springfield"));
			newDataList.Add (new Data ("Indiana", "Indianapolis"));
			newDataList.Add (new Data ("Iowa", "Des Moines"));
			newDataList.Add (new Data ("Kansas", "Topeka"));

			newDataList.Add (new Data ("Kentucky", "Frankfort"));
			newDataList.Add (new Data ("Louisiana", "Baton Rouge"));
			newDataList.Add (new Data ("Maine", "Augusta"));
			newDataList.Add (new Data ("Maryland", "Annapolis"));
			newDataList.Add (new Data ("Massachusetts", "Boston"));

			newDataList.Add (new Data ("Michigan", "Lansing"));
			newDataList.Add (new Data ("Minnesota", "Saint Paul"));
			newDataList.Add (new Data ("Mississippi", "Jackson"));
			newDataList.Add (new Data ("Missouri", "Jefferson City"));
			newDataList.Add (new Data ("Montana", "Helena"));
			newDataList.Add (new Data ("Nebraska", "Lincoln"));
			newDataList.Add (new Data ("Nevada", "Carson City"));
			newDataList.Add (new Data ("New Hampshire", "Concord"));
			newDataList.Add (new Data ("New Jersey", "Trenton"));
			newDataList.Add (new Data ("New Mexico", "Santa Fe"));
			newDataList.Add (new Data ("New York", "Albany"));
			newDataList.Add (new Data ("North Calorina", "Raleigh"));
			newDataList.Add (new Data ("North Dakota", "Bismarck"));
			newDataList.Add (new Data ("Ohio", "Columbus"));
			newDataList.Add (new Data ("Oklahoma", "Oklahoma City"));
			newDataList.Add (new Data ("Oregon", "Salem"));
			newDataList.Add (new Data ("Pennsylvania", "Harrisburg"));
			newDataList.Add (new Data ("Rhode Island", "Providence"));
			newDataList.Add (new Data ("South Carolina", "Columbia"));
			newDataList.Add (new Data ("South Dakota", "Pierre"));
			newDataList.Add (new Data ("Tennessee", "Nashville"));
			newDataList.Add (new Data ("Texas", "Austin"));
			newDataList.Add (new Data ("Utah", "Salt Lake City"));
			newDataList.Add (new Data ("Vermont", "Montpelier"));
			newDataList.Add (new Data ("Virginia", "Richmond"));
			newDataList.Add (new Data ("Washington", "Olympia"));
			newDataList.Add (new Data ("West Virginia", "Charleston"));
			newDataList.Add (new Data ("Wisconsin", "Madison"));
			newDataList.Add (new Data ("Wyoming", "Cheyenne"));
			return newDataList;
		}

		public Data (string newId = "Temporary Id", string newValue = "Temporary Data")
		{
			Id = newId;
			Value = newValue;
		}

		public string Id { get; set; }
		public string Value { get; set; }
	}
}

