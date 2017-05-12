<Query Kind="Program">
  <NuGetReference>MarkdownLog</NuGetReference>
  <Namespace>MarkdownDeep</Namespace>
  <Namespace>MarkdownLog</Namespace>
</Query>

void Main()
{
	var booksFilePath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\Books.md");

	var currentlyReading = new BookToRead[]
	{
		new BookToRead { Title = "Domain-Driven Design Distilled" },
	};

	var booksToRead = new BookToRead[]
	{
		new BookToRead { Title = "Introducing Event Storming" },
		new BookToRead { Title = "Domain-Driven Design: Tackling complexity in the heart of software" },
		new BookToRead { Title = "Implementing Domain Driven Design" },
		new BookToRead { Title = "Dependency Injection In .NET" },
		new BookToRead { Title = "Pro ASP.NET Core MVC" },
		new BookToRead { Title = "C# 6 and .NET Core 1.0 Modern Cross Platform Development" },
		new BookToRead { Title = "Professional C# 6 and .NET Core 1.0" },
		new BookToRead { Title = "ASP.NET Core And Angular 2" },
		new BookToRead { Title = "AngularJS Succinctly" },
		new BookToRead { Title = "Beginning SOLID Principles And Design Patterns For ASP.NET Developers" },
		new BookToRead { Title = "Driving Technical Change" },
		new BookToRead { Title = "Becoming a better programmer" },
		new BookToRead { Title = "The Goal - A Process of Ongoing Improvement" },
		new BookToRead { Title = "Lean Software Development, An Agile Toolkit" },
		new BookToRead { Title = "Agile Software Development: Principles, Patterns & Practices" },
		new BookToRead { Title = "The Inmates Are Running The Asylum" },
		new BookToRead { Title = "Zen and the Art of Motorcycle Maintenance" },
		new BookToRead { Title = "Clean Code" },
		new BookToRead { Title = "Clean Coder" },
		new BookToRead { Title = "Design Patterns: Elements of Reusable Object-Oriented Software" },
		new BookToRead { Title = "The Mythical Man Month"},
		new BookToRead { Title = "Refactoring: Improving the Design of Existing Code"},
		new BookToRead { Title = "Growing Object-Oriented Software Guided by Tests"},
		new BookToRead { Title = "The Passionate Programmer: Creating a Remarkable Career in Software Development"},
		new BookToRead { Title = "Patterns of Enterprise Application Architecture"},
		new BookToRead { Title = "Working Effectively with Legacy Code"},
		new BookToRead { Title = "Concurrency in C#"},
		new BookToRead { Title = "Managing Software Debt"},
		new BookToRead { Title = "Brownfield Application Development in .NET"},
		new BookToRead { Title = "Designing evolvable Web APIs with .NET"},
		new BookToRead { Title = "Lean Software Development"},
		new BookToRead { Title = "Lean from the trenches"},
		new BookToRead { Title = "Kanban - Success evolutionary change for your technology business"},
		new BookToRead { Title = "Refactoring to patterns"},
		new BookToRead { Title = "Beautiful Code: Leading Programmers Explain How They Think"},
		new BookToRead { Title = "Programming Pearls"},
		new BookToRead { Title = "Introduction to Algorithms 3rd Edition"},
		new BookToRead { Title = "Object Oriented Software Construction"},
	};
	
	var booksAlreadyRead = new BookRead[]
	{
		new BookRead { Title = "Domain Driven Design Quickly", LastRead = DateTime.Parse("15 February 2017"), NotesTaken = false },
		new BookRead { Title = "KnockoutJS Succinctly", LastRead = DateTime.Parse("26 August 2016"), NotesTaken = false },
		new BookRead { Title = "The Phoenix Project: A Novel about IT, DevOps and Helping Your Business Win", LastRead = DateTime.Parse("20 August 2016"), NotesTaken = false },
		new BookRead { Title = "The Nature Of Software Development", LastRead = DateTime.Parse("17 July 2016"), NotesTaken = true },
		new BookRead { Title = "How Google Works", LastRead = DateTime.Parse("27 June 2016"), NotesTaken = false },
		new BookRead { Title = "Rebels At Work", LastRead = DateTime.Parse("27 March 2016"), NotesTaken = true },
		new BookRead { Title = "The Pragmatic Programmer", LastRead = DateTime.Parse("30 November 2015"), NotesTaken = false },
		new BookRead { Title = "Software Estimation - Demystifying the black art", LastRead = DateTime.Parse("20 February 2016"), NotesTaken = true },
		new BookRead { Title = "ASP.NET Web API 2 - Building a REST service from start to finish", LastRead = DateTime.Parse("01 September 2015"), NotesTaken = false },
		new BookRead { Title = "Async In C#", LastRead = DateTime.Parse("10 January 2016"), NotesTaken = false },
		new BookRead { Title = "Kanban in Action", LastRead = DateTime.Parse("10 March 2015"), NotesTaken = false },
		new BookRead { Title = "Professional Test-Driven Development with C#", LastRead = DateTime.Parse("16 December 2014"), NotesTaken = false },
		new BookRead { Title = "ServiceStack Succintly", LastRead = DateTime.Parse("10 July 2015"), NotesTaken = false }
	};

	var booksMarkdown = new StringBuilder();
	booksMarkdown.Append(@"Currently Reading".ToMarkdownHeader());
	booksMarkdown.Append(currentlyReading.ToMarkdownTable().WithHeaders("Title", ""));
	booksMarkdown.Append(@"Books To Read".ToMarkdownHeader());
	booksMarkdown.Append(booksToRead.ToMarkdownTable().WithHeaders("Title", ""));
	booksMarkdown.Append(Environment.NewLine);
	booksMarkdown.Append(@"Books Already Read".ToMarkdownHeader());
	booksMarkdown.Append(booksAlreadyRead.OrderBy(ar => ar.LastRead)
		.ToMarkdownTable(c => c.Title, c => c.LastRead.ToLongDateString(), c => c.NotesTaken == true ? "Yes" : "No")
		.WithHeaders("Title", "Last Read", "Notes Taken"));
	var markdownText = booksMarkdown.ToString();

	// Strip any leading spaces/tabs from each line of the string.
	// This is required to ensure that GutHub will render the tables correctly.
	var newMarkdownTextBuilder = new StringBuilder();
	using (var reader = new StringReader(markdownText))
	{
		var line = string.Empty;
		do
		{
			line = reader.ReadLine();
			if (line != null)
			{
				newMarkdownTextBuilder.AppendLine(line.Trim());
			}
		} while(line!=null);
	}
	
	File.WriteAllText(booksFilePath,newMarkdownTextBuilder.ToString());
	Console.WriteLine("Writing output file to {0}", booksFilePath);
	Console.WriteLine(newMarkdownTextBuilder.ToString());
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