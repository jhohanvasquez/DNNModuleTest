﻿/*
' Copyright (c) 2016 Ralph Williams
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System;
using System.Web.Caching;
using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Content;

namespace Jhohan.Modules.DNNModuleTest.Components
{
	[TableName("DNNModuleTest_Questions")]
	//setup the primary key for table
	[PrimaryKey("QuestionId", AutoIncrement = true)]
	//configure caching using PetaPoco
	[Cacheable("Questions", CacheItemPriority.Default, 20)]
	//scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
	[Scope("ModuleId")]
	public class Question
	{
		///<summary>
		/// The ID of your object with the name of the QuestionName
		///</summary>
		public int QuestionId { get; set; }
		///<summary>
		/// A string with the name of the QuestionName
		///</summary>
		public string QuestionName { get; set; }

		///<summary>
		/// A string with the description of the object
		///</summary>
		public string QuestionType { get; set; }

		///<summary>
		/// An integer with the user id of the assigned user for the object
		///</summary>
		public int AssignedUserId { get; set; }

		///<summary>
		/// The ModuleId of where the object was created and gets displayed
		///</summary>
		public int ModuleId { get; set; }

		///<summary>
		/// An integer for the user id of the user who created the object
		///</summary>
		public int CreatedByUserId { get; set; }

		///<summary>
		/// An integer for the user id of the user who last updated the object
		///</summary>
		public int LastModifiedByUserId { get; set; }

		///<summary>
		/// The date the object was created
		///</summary>
		public DateTime CreatedOnDate { get; set; }

		///<summary>
		/// The date the object was updated
		///</summary>
		public DateTime LastModifiedOnDate { get; set; }
	}
}
