<Query Kind="Program">
  <NuGetReference>MarkdownLog</NuGetReference>
  <Namespace>MarkdownDeep</Namespace>
  <Namespace>MarkdownLog</Namespace>
</Query>

void Main()
{
	var booksFilePath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\Books.md");

	var currentlyReading = new[]
	{
		new { Title = "KnockoutJS Succinctly" },
	};

	var booksToRead = new[]
	{
		new { Title = "Driving Technical Change" },
		new { Title = "Becoming a better programmer" },
		new { Title = "The Goal - A Process of Ongoing Improvement" },
		new { Title = "Lean Software Development, An Agile Toolkit" },
		new { Title = "Agile Software Development: Principles, Patterns & Practices" },
		new { Title = "The Inmates Are Running The Asylum" },
		new { Title = "Zen and the Art of Motorcycle Maintenance" },
		new { Title = "Clean Code" },
		new { Title = "Clean Coder" },
		new { Title = "Domain-Driven Design: Tackling complexity in the heart of software" },
		new { Title = "Implementing Domain Driven Design" },
		new { Title = "Design Patterns: Elements of Reusable Object-Oriented Software" },
		new { Title = "The Mythical Man Month"},
		new { Title = "Refactoring: Improving the Design of Existing Code"},
		new { Title = "Growing Object-Oriented Software Guided by Tests"},
		new { Title = "The Passionate Programmer: Creating a Remarkable Career in Software Development"},
		new { Title = "Patterns of Enterprise Application Architecture"},
		new { Title = "Working Effectively with Legacy Code"},
		new { Title = "Concurrency in C#"},
		new { Title = "Managing Software Debt"},
		new { Title = "Brownfield Application Development in .NET"},
		new { Title = "Designing evolvable Web APIs with .NET"},
		new { Title = "Lean Software Development"},
		new { Title = "Lean from the trenches"},
		new { Title = "Kanban - Success evolutionary change for your technology business"},
		new { Title = "Refactoring to patterns"},
		new { Title = "Beautiful Code: Leading Programmers Explain How They Think"},
		new { Title = "Programming Pearls"},
		new { Title = "Introduction to Algorithms 3rd Edition"},
		new { Title = "Object Oriented Software Construction"},
	};
	
	var booksAlreadyRead = new[]
	{
		new { Title = "The Phoenix Project: A Novel about IT, DevOps and Helping Your Business Win", LastRead = DateTime.Parse("20 August 2016"), NotesTaken = false },
		new { Title = "The Nature Of Software Development", LastRead = DateTime.Parse("17 July 2016"), NotesTaken = true },
		new { Title = "How Google Works", LastRead = DateTime.Parse("27 June 2016"), NotesTaken = false },
		new { Title = "Rebels At Work", LastRead = DateTime.Parse("27 March 2016"), NotesTaken = true },
		new { Title = "The Pragmatic Programmer", LastRead = DateTime.Parse("30 November 2015"), NotesTaken = false },
		new { Title = "Software Estimation - Demystifying the black art", LastRead = DateTime.Parse("20 February 2016"), NotesTaken = true },
		new { Title = "ASP.NET Web API 2 - Building a REST service from start to finish", LastRead = DateTime.Parse("01 September 2015"), NotesTaken = false },
		new { Title = "Async In C#", LastRead = DateTime.Parse("10 January 2016"), NotesTaken = false },
		new { Title = "Kanban in Action", LastRead = DateTime.Parse("10 March 2015"), NotesTaken = false },
		new { Title = "Professional Test-Driven Development with C#", LastRead = DateTime.Parse("16 December 2014"), NotesTaken = false },
		new { Title = "ServiceStack Succintly", LastRead = DateTime.Parse("10 July 2015"), NotesTaken = false }
	};
	
	var booksMarkdown = new StringBuilder();
	booksMarkdown.Append(@"Currently Reading".ToMarkdownHeader());
	booksMarkdown.Append(currentlyReading.ToMarkdownTable().WithHeaders("Title", ""));
	booksMarkdown.Append(@"Books To Read".ToMarkdownHeader());
	booksMarkdown.Append(booksToRead.ToMarkdownTable().WithHeaders("Title", ""));
	booksMarkdown.Append(Environment.NewLine);
	booksMarkdown.Append(@"Books Already Read".ToMarkdownHeader());
	booksMarkdown.Append(booksAlreadyRead.OrderBy(ar => ar.LastRead)
		.ToMarkdownTable(c => c.Title, c => c.LastRead.ToLongDateString(), c => c.NotesTaken)
		.WithHeaders("Title", "Last Read", "Notes Taken"));
	File.WriteAllText(booksFilePath,booksMarkdown.ToString());
	Console.WriteLine(booksMarkdown.ToString());
}