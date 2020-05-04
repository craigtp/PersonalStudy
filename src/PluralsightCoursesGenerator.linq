<Query Kind="Program">
  <NuGetReference>MarkdownLog</NuGetReference>
  <Namespace>MarkdownDeep</Namespace>
  <Namespace>MarkdownLog</Namespace>
</Query>

void Main()
{
	var coursesFilePath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\PluralsightCourses.md");

	var currentlyWatching = new []
	{
		new { Title = "GORM - An Object Relational Mapper for Go" },
	};

	var coursesToWatch = new[]
	{
		new { Title = "Creating Web Applications with Go" },
		new { Title = "Building Better Go Web Apps with the Gorilla Toolkit" },
		new { Title = "Scaling Go Applications Horizontally" },
		new { Title = "Building Distributed Applications with Go" },
		new { Title = "CQRS Theory and Practice" },
		new { Title = "CQRS In Practice" },
		new { Title = "Domain-Driven Design in Practice" },
		new { Title = "Refactoring from Anemic Domain Model Towards a Rich One" },
		new { Title = "Scaling applications with Microservices and NServiceBus 6" },
		new { Title = "Designing a Microsoft Azure Messaging Architecture" },
		new { Title = "Azure Event Hubs for .NET Developers Fundamentals" },
		new { Title = "Microservices Architectural Design Patterns Playbook" },
		new { Title = "Understanding the Difference Between Microsoft Azure and Amazon AWS" },
		new { Title = "Real World Big Data in Azure" },
		new { Title = "Microsoft Azure Architecture for AWS Architects" },
		new { Title = "Docker Deep Dive" },
		new { Title = "Docker Swarm - Native Docker Clustering" },
		new { Title = "Getting Started with Docker" },
		new { Title = "Getting Started with Docker on Windows" },
		new { Title = "Monitoring Containerized Application Health with Docker" },
		new { Title = "Getting Started with Kubernetes" },
		new { Title = "Azure Kubernetes Service AKS  The Big Picture" },
		new { Title = "Introduction to F#" },
		new { Title = "A Functional Architecture with F#" },
		new { Title = "F# Functional Data Structures" },
		new { Title = "F# Jumpstart" },
		new { Title = "Accessing Data with F# Type Providers" },
		new { Title = "Building Distributed Systems with Akka.NET Clustering" },
		new { Title = "Implementing Logging and Dependency Injection in Akka.NET" },
		new { Title = "Improving Message Throughput in Akka NET" },
		new { Title = "Go Fundamentals" },
		new { Title = "Object-Oriented Programming With Go" },
		new { Title = "Building Distributed Applications With Go" },
		new { Title = "Scaling Go Applications Horizontally" },
		new { Title = "Concurrent Programming with Go" },
		new { Title = "Creating Web Applications with Go" },
		new { Title = "Scaling Applications with Microservices, MassTransit, and RabbitMQ" },
	};
	
	var coursesAlreadyWatched = new[]
	{
		new { Title = "Getting Started with Entity Framework 5", LastWatched = DateTime.Parse("01 January 2018")},
		new { Title = "Algorithms and Data Structures - Part 1", LastWatched = DateTime.Parse("01 January 2018")},
		new { Title = "Algorithms and Data Structures - Part 2", LastWatched = DateTime.Parse("01 January 2018")},
		new { Title = "Visual Studio Code Can Do That - Play-By-Play", LastWatched = DateTime.Parse("01 January 2018")},
		new { Title = "Functional Programming with C#", LastWatched = DateTime.Parse("01 January 2018")},
		new { Title = "Specification Pattern in C#", LastWatched = DateTime.Parse("01 January 2018")},
		new { Title = "Clean Architecture - Patterns, Practices, and Principles", LastWatched = DateTime.Parse("19 July 2018")},
		new { Title = "Modern Software Architecture Domain Models, CQRS, and Event Sourcing", LastWatched = DateTime.Parse("24 July 2018")},
		new { Title = "Microservices Architecture", LastWatched = DateTime.Parse("24 July 2018")},
		new { Title = "Patterns for Building Distributed Systems for The Enterprise", LastWatched = DateTime.Parse("27 July 2018")},
		new { Title = "React.JS - Getting Started", LastWatched = DateTime.Parse("09 November 2018")},
		new { Title = "Building Applications with React and Redux in ES6", LastWatched = DateTime.Parse("22 November 2018")},
		new { Title = "Building Applications with React and Flux", LastWatched = DateTime.Parse("16 December 2018") },
		new { Title = "Getting Started with Azure Event Hubs with C#", LastWatched = DateTime.Parse("5 January 2019") },
		new { Title = "Azure Functions Fundamentals",LastWatched = DateTime.Parse("7 January 2019") },
		new { Title = "Domain Driven Design Fundamentals", LastWatched = DateTime.Parse("3 February 2019") },
		new { Title = "Terraform - Getting Started", LastWatched = DateTime.Parse("17 February 2019") },
		new { Title = "Building Concurrent Applications with the Actor Model in Akka.NET", LastWatched = DateTime.Parse("3 December 2019") },
		new { Title = "Go: Getting Started", LastWatched = DateTime.Parse("07 April 2020") },
		new { Title = "Go: The Big Picture", LastWatched = DateTime.Parse("07 April 2020") },
		new { Title = "The Go CLI Playbook", LastWatched = DateTime.Parse("20 April 2020") },
		new { Title = "Creating Custom DataTypes With Go", LastWatched = DateTime.Parse("23 April 2020") },
		new { Title = "Advanced Branching And Looping In Go", LastWatched = DateTime.Parse("24 April 2020") },
		new { Title = "Deep Dive Into Go Packages", LastWatched = DateTime.Parse("26 April 2020") },
		new { Title = "Deep Dive Into Go Functions", LastWatched = DateTime.Parse("26 April 2020") },
		new { Title = "Concurrent Programming With Go", LastWatched = DateTime.Parse("27 April 2020") },
		new { Title = "Creating Well-Tested Application In Go", LastWatched = DateTime.Parse("28 April 2020") },
		new { Title = "Exploring Go Modules", LastWatched = DateTime.Parse("30 April 2020") },
		new { Title = "Debugging Go Applications With Delve", LastWatched = DateTime.Parse("30 April 2020") },
		new { Title = "Gin: A Website Application Framework In Go", LastWatched = DateTime.Parse("02 May 2020")  },
		new { Title = "Object-oriented Programming with Go", LastWatched = DateTime.Parse("03 May 2020")   },
	};

	var coursesMarkdown = new StringBuilder();
	coursesMarkdown.Append(@"Currently Watching".ToMarkdownHeader());
	coursesMarkdown.Append(currentlyWatching.ToMarkdownTable().WithHeaders("Title", ""));
	coursesMarkdown.Append(Environment.NewLine);
	coursesMarkdown.Append(@"Courses To Watch".ToMarkdownHeader());
	coursesMarkdown.Append(coursesToWatch.ToMarkdownTable().WithHeaders("Title", ""));
	coursesMarkdown.Append(Environment.NewLine);
	coursesMarkdown.Append(@"Courses Already Watched".ToMarkdownHeader());
	coursesMarkdown.Append(coursesAlreadyWatched.OrderBy(ar => ar.LastWatched)
		.ToMarkdownTable(c => c.Title, c => c.LastWatched.ToLongDateString())
		.WithHeaders("Title", "Last Watched"));
	var markdownText = coursesMarkdown.ToString();

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

	File.WriteAllText(coursesFilePath,markdownText);
	Console.WriteLine("Writing output file to {0}", coursesFilePath);
	Console.WriteLine(markdownText);
}