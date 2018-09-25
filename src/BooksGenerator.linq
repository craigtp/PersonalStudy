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
		new { Title = "The Imposter's Handbook"}
	};

	var booksToRead = new[]
	{
		new { Title = "Domain-Driven Design: Tackling complexity in the heart of software" },
		new { Title = "Patterns, Principles and Practices of Domain Driven Design" },
		new { Title = "Implementing Domain Driven Design" },
		new { Title = "Pro ASP.NET Core MVC 2" },
		new { Title = "Modern API Design with ASP.NET Core 2" },
		new { Title = "ASP.NET Core In Action" },
		new { Title = ".NET Core In Action" },
		new { Title = "Entity Framework Core In Action" },
		new { Title = "Introduction to Algorithms 3rd Edition"},
		new { Title = "Structure And Interpretation of Computer Programs"},
		new { Title = "Clean Code: A Handbook of Agile Software Craftsmanship" },
		new { Title = "Refactoring: Improving the Design of Existing Code" },
		new { Title = "Test Driven Development By Example" },
		new { Title = "Working Effectively With Legacy Code" },
		new { Title = "Agile Principles, Patterns, and Practices in C#" },
		new { Title = "Design Patterns: Elements of Reusable Object-Oriented Software" },
		new { Title = "Patterns Of Enterprise Application Architecture" },
		new { Title = "Peopleware: Productive Projects and Teams (3rd Edition)" },
		new { Title = "The Mythical Man-Month: Essays on Software Engineering (Anniversary Edition)"},
		new { Title = "Growing Object-Oriented Software Guided by Tests"},
		new { Title = "Release It!: Design and Deploy Production-Ready Software 2nd Edition" },
		new { Title = "Dependency Injection In .NET" },
		new { Title = "Refactoring to patterns"},
		new { Title = "AngularJS Succinctly" },
		new { Title = "The Goal - A Process of Ongoing Improvement" },
		new { Title = "The Clean Coder" },
		new { Title = "The Passionate Programmer: Creating a Remarkable Career in Software Development"},
		new { Title = "Concurrency in C#"},
		new { Title = "Beautiful Code: Leading Programmers Explain How They Think"},
		new { Title = "Programming Pearls (2nd Edition)"},
		new { Title = "Object Oriented Software Construction"},
		new { Title = "The Passionate Programmer: Creating a Remarkable Career in Software Development"},
		new { Title = "Introducing Event Storming" },
		new { Title = "Code: The Hidden Language of Computer Hardware and Software" },
		new { Title = "Don't Make Me Think, Revisited: A Common Sense Approach to Web Usability (3rd Edition)" },
		new { Title = "Practices of an Agile Developer: Working in the Real World" },
		new { Title = "Continuous Delivery: Reliable Software Releases through Build, Test, and Deployment Automation" },
		new { Title = "Debugging: The 9 Indispensable Rules for Finding Even the Most Elusive Software and Hardware Problems" },
		new { Title = "Succeeding With Agile: Software Development Using Scrum" },
		new { Title = "Enterprise Integration Patterns: Designing. Building. and Deploying Messaging Solutions" },
		new { Title = "Pattern-Oriented Software Architecture, Vol. 2, Patterns for Concurrent and Networked Objects" },
		new { Title = "Code Complete: A Practical Handbook of Software Construction (2nd Edition)" },
		new { Title = "The Pragmatic Programmer: From Journeyman to Master" },
	};
	
	var booksAlreadyRead = new[]
	{
		new { Title = "Broken Agile", LastRead = DateTime.Parse("6 December 2017"), NotesTaken = false },
		new { Title = "Agile Software Development Succinctly", LastRead = DateTime.Parse("3 December 2017"), NotesTaken = false },
		new { Title = "Domain-Driven Design Distilled", LastRead = DateTime.Parse("19 November 2017"), NotesTaken = true },
		new { Title = "Remote: Office Not Required", LastRead = DateTime.Parse("13 July 2017"), NotesTaken = false },
		new { Title = "Domain Driven Design Quickly", LastRead = DateTime.Parse("15 February 2017"), NotesTaken = false },
		new { Title = "KnockoutJS Succinctly", LastRead = DateTime.Parse("26 August 2016"), NotesTaken = false },
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
		new { Title = "ServiceStack Succintly", LastRead = DateTime.Parse("10 July 2015"), NotesTaken = false },
		new { Title = "The Imposter's Handbook", LastRead = DateTime.Parse("27 January 2018"), NotesTaken = false },
		new { Title = "Software Requirements (3rd Edition)", LastRead = DateTime.Parse("06 April 2018"), NotesTaken = true },
		new { Title = "Architecting Modern Web Aplications With ASP.NET Core and Microsoft Azure", LastRead = DateTime.Parse("09 May 2018"), NotesTaken = false },
		new { Title = "RabbitMQ Succinctly", LastRead = DateTime.Parse("30 August 2018"), NotesTaken = false },
		new { Title = "Git Pocket Guide", LastRead = DateTime.Parse("25 September 2018"), NotesTaken = false }
	};

	var booksMarkdown = new StringBuilder();
	booksMarkdown.Append(@"Currently Reading".ToMarkdownHeader());
	booksMarkdown.Append(currentlyReading.ToMarkdownTable().WithHeaders("Title", ""));
	booksMarkdown.Append(Environment.NewLine);
	booksMarkdown.Append(@"Books To Read".ToMarkdownHeader());
	booksMarkdown.Append(booksToRead.ToMarkdownTable().WithHeaders("Title", ""));
	booksMarkdown.Append(Environment.NewLine);
	booksMarkdown.Append(@"Books Already Read".ToMarkdownHeader());
	booksMarkdown.Append(booksAlreadyRead.OrderBy(ar => ar.LastRead)
		.ToMarkdownTable(c => c.Title, c => c.LastRead.ToLongDateString(), c => c.NotesTaken == true ? "Yes" : "No")
		.WithHeaders("Title", "Last Read", "Notes Taken"));
	var markdownText = booksMarkdown.ToString();

	// Strip any leading spaces/tabs from each line of the string.
	// This is required to ensure that GitHub will render the Markdown tables correctly.
	// By default, the MarkdownLog library will indent the rendered tables, this causes GitHub
	// to render the Markdown tables as plain text, rather than a prettified table.
	var newMarkdownTextBuilder = new StringBuilder();
	using (var reader = new StringReader(markdownText))
	{
		string line;
		do
		{
			line = reader.ReadLine();
			if (line == null) continue;
			newMarkdownTextBuilder.AppendLine(line.Trim());
		} while (line != null);
	}
	markdownText = newMarkdownTextBuilder.ToString();

	File.WriteAllText(booksFilePath,markdownText);
	Console.WriteLine("Writing output file to {0}", booksFilePath);
	Console.WriteLine(markdownText);
}

public class BookToRead
{
	public string Title { get; set;}
}

public class BookRead
{
	public string Title { get; set; }
	public DateTime LastRead { get; set; }
	public bool NotesTaken { get; set; }
}