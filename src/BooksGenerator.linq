<Query Kind="Program">
  <NuGetReference>MarkdownLog</NuGetReference>
  <Namespace>MarkdownDeep</Namespace>
  <Namespace>MarkdownLog</Namespace>
</Query>

void Main()
{
	var booksFilePath = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), @"..\Books.md");;

	var currentlyReading = new[]
	{
		new { Title = "Refactoring at Scale" }
	};

	var booksToRead = new[]
	{
		new { Title = "Patterns Of Distributed Systems" },
		new { Title = "Enterprise Integration Patterns" },
		new { Title = "Modern Software Engineering" },
		new { Title = "Fundamentals of Software Architecture: An Engineering Approach" },
		new { Title	= "Building Event-Driven Microservices" },
		new { Title = "Software Architecture: The Hard Parts" },
		new { Title = "Patterns of Enterprise Application Architecture" },
		new { Title = "Foundations of Scalable Systems" },
		new { Title = "Continuous Delivery" },
		new { Title = "Working Effectively with Legacy Code" },
		new { Title = "Refactoring" },
		new { Title = "A Philosophy of Software Design 2nd Edition" },
		new { Title = "Test-Driven Development By Example" },
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
		new { Title = "ServiceStack Succinctly", LastRead = DateTime.Parse("10 July 2015"), NotesTaken = false },
		new { Title = "The Imposter's Handbook", LastRead = DateTime.Parse("27 January 2018"), NotesTaken = false },
		new { Title = "Software Requirements (3rd Edition)", LastRead = DateTime.Parse("06 April 2018"), NotesTaken = true },
		new { Title = "Architecting Modern Web Applications With ASP.NET Core and Microsoft Azure", LastRead = DateTime.Parse("09 May 2018"), NotesTaken = false },
		new { Title = "RabbitMQ Succinctly", LastRead = DateTime.Parse("30 August 2018"), NotesTaken = false },
		new { Title = "Git Pocket Guide", LastRead = DateTime.Parse("25 September 2018"), NotesTaken = false },
		new { Title = "It Doesn't Have To Be Crazy At Work", LastRead = DateTime.Parse("26 January 2019"), NotesTaken = false },
		new { Title = "Domain-Driven Design: Tackling complexity in the heart of software", LastRead = DateTime.Parse("9 June 2019"), NotesTaken = true},
		new { Title = "Domain-Driven Design - The First 15 Years", LastRead = DateTime.Parse("28 December 2019"), NotesTaken = false },
		new { Title = "The Phoenix Project: A Novel about IT, DevOps and Helping Your Business Win", LastRead = DateTime.Parse("08 January 2020"), NotesTaken = false },
		new { Title = "The Unicorn Project: A Novel About Developers, Digital Disruption, and Thriving in the Age of Data", LastRead = DateTime.Parse("21 January 2020"), NotesTaken = false },
		new { Title = "The Goal - A Process of Ongoing Improvement", LastRead = DateTime.Parse("24 February 2020"), NotesTaken = true },
		new { Title = "CQRS - The Example", LastRead = DateTime.Parse("01 March 2020"), NotesTaken = false},
		new { Title = "Versioning In An Event Sourced System", LastRead = DateTime.Parse("28 March 2020"), NotesTaken = false },
		new { Title = "The Art Of Readable Code", LastRead = DateTime.Parse("09 May 2020"), NotesTaken = true },
		new { Title = "Hands-On Domain-Driven Design With .NET Core", LastRead = DateTime.Parse("31 May 2020"), NotesTaken = false },
		new { Title = "Impact Mapping", LastRead = DateTime.Parse("31 May 2020"), NotesTaken = false },
		new { Title = "Functional Programming In C# (Manning)", LastRead = DateTime.Parse("23 July 2020"), NotesTaken = true },
		new { Title = "Pragmatic Thinking & Learning", LastRead = DateTime.Parse("10 September 2020"), NotesTaken = true },
		new { Title = "Release It!: Design and Deploy Production-Ready Software 2nd Edition", LastRead = DateTime.Parse("05 April 2021"), NotesTaken = false },
		new { Title = "Exploring CQRS and Event Sourcing (CQRS Journey Guide)", LastRead = DateTime.Parse("25 April 2021"), NotesTaken = false  },
		new { Title = "Building Microservices", LastRead = DateTime.Parse("22 May 2021"), NotesTaken = false  },
		new { Title = "Monolith To Microservices", LastRead = DateTime.Parse("16 June 2021"), NotesTaken = false },
		new { Title = "We need to talk about Scrum", LastRead = DateTime.Parse("18 June 2021"), NotesTaken = false },
		new { Title = "Tidy First?", LastRead = DateTime.Parse("05 December 2023"), NotesTaken = false },
		new { Title = "Understanding the Four Rules of Simple Design", LastRead = DateTime.Parse("10 February 2024"), NotesTaken = false },
		new { Title = "Accelerate: Building and Scaling High Performing Technology Organizations", LastRead = DateTime.Parse("2 March 2024"), NotesTaken = false },
		new { Title = "Designing Data-Intensive Applications", LastRead = DateTime.Parse("4 April 2024"), NotesTaken = true },
		new { Title = "Code That Fits In Your Head", LastRead = DateTime.Parse("9 May 2024"), NotesTaken = true },
		new { Title = "Team Topologies", LastRead = DateTime.Parse("7 June 2024"), NotesTaken = false },
		new { Title = "Domain-Driven Design Distilled", LastRead = DateTime.Parse("15 July 2024"), NotesTaken = true },
		new { Title = "Implementing Domain Driven Design", LastRead = DateTime.Parse("14 November 2024"), NotesTaken = true },
		new { Title = "The Software Engineer's Guidebook", LastRead = DateTime.Parse("23 April 2025"), NotesTaken = false },
		new { Title = "Domain Modeling Made Functional", LastRead = DateTime.Parse("09 May 2025"), NotesTaken = false  },
		new { Title = "User Story Mapping", LastRead = DateTime.Parse("02 October 2025"), NotesTaken = false }
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