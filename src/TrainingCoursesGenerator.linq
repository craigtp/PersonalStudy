<Query Kind="Program">
  <NuGetReference>MarkdownLog</NuGetReference>
  <Namespace>MarkdownDeep</Namespace>
  <Namespace>MarkdownLog</Namespace>
</Query>

void Main()
{
	var coursesFilePath = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), @"..\TrainingCourses.md");

	var currentlyWatching = new []
	{
		new { Vendor = "Dometrain", Title = "From Zero to Hero Docker For Developers" },
	};

	var coursesToWatch = new[]
	{
		new { Vendor = "Dometrain", Title = "From Zero to Hero Kubernetes For Developers" },
		new { Vendor = "Dometrain", Title = "Deep Dive Clean Architecture in .NET" },
		new { Vendor = "Dometrain", Title = "Deep Dive Domain-Driven Design" },
		new { Vendor = "Dometrain", Title = "Deep Dive Microservices Architecture" },
		new { Vendor = "Dometrain", Title = "Deep Dive Modular Monoliths in .NET" },
		new { Vendor = "Dometrain", Title = "From Zero to Hero Event-Driven Architecture" },
		new { Vendor = "Dometrain", Title = "From Zero to Hero Refactoring for C# Developers" },
		new { Vendor = "Dometrain", Title = "Getting Started Clean Architecture in .NET" },
		new { Vendor = "Dometrain", Title = "Getting Started Domain-Driven Design" },
		new { Vendor = "Dometrain", Title = "Getting Started Messaging in .NET with MassTransit" },
		new { Vendor = "Dometrain", Title = "Getting Started Microservices Architecture" },
		new { Vendor = "Dometrain", Title = "Getting Started Modular Monoliths in .NET" },
		new { Vendor = "Dometrain", Title = "Getting Started Solution Architecture" },
		new { Vendor = "Pearson", Title = "Strategic Monoliths and Microservices" },
		new { Vendor = "Pluralsight", Title = "GORM - An Object Relational Mapper for Go" },
		new { Vendor = "Pluralsight", Title = "Go Fundamentals" },
		new { Vendor = "Pluralsight", Title = "Creating Web Applications with Go" },
		new { Vendor = "Pluralsight", Title = "Building Better Go Web Apps with the Gorilla Toolkit" },
		new { Vendor = "Pluralsight", Title = "Scaling Go Applications Horizontally" },
		new { Vendor = "Pluralsight", Title = "Building Distributed Applications with Go" },
		new { Vendor = "Pluralsight", Title = "CQRS Theory and Practice" },
		new { Vendor = "Pluralsight", Title = "CQRS In Practice" },
		new { Vendor = "Pluralsight", Title = "Domain-Driven Design in Practice" },
		new { Vendor = "Pluralsight", Title = "Refactoring from Anemic Domain Model Towards a Rich One" },
		new { Vendor = "Pluralsight", Title = "Scaling applications with Microservices and NServiceBus 6" },
		new { Vendor = "Pluralsight", Title = "Designing a Microsoft Azure Messaging Architecture" },
		new { Vendor = "Pluralsight", Title = "Azure Event Hubs for .NET Developers Fundamentals" },
		new { Vendor = "Pluralsight", Title = "Microservices Architectural Design Patterns Playbook" },
		new { Vendor = "Pluralsight", Title = "Understanding the Difference Between Microsoft Azure and Amazon AWS" },
		new { Vendor = "Pluralsight", Title = "Real World Big Data in Azure" },
		new { Vendor = "Pluralsight", Title = "Microsoft Azure Architecture for AWS Architects" },
		new { Vendor = "Pluralsight", Title = "Docker Deep Dive" },
		new { Vendor = "Pluralsight", Title = "Docker Swarm - Native Docker Clustering" },
		new { Vendor = "Pluralsight", Title = "Getting Started with Docker" },
		new { Vendor = "Pluralsight", Title = "Getting Started with Docker on Windows" },
		new { Vendor = "Pluralsight", Title = "Monitoring Containerized Application Health with Docker" },
		new { Vendor = "Pluralsight", Title = "Getting Started with Kubernetes" },
		new { Vendor = "Pluralsight", Title = "Azure Kubernetes Service AKS  The Big Picture" },
		new { Vendor = "Pluralsight", Title = "Introduction to F#" },
		new { Vendor = "Pluralsight", Title = "A Functional Architecture with F#" },
		new { Vendor = "Pluralsight", Title = "F# Functional Data Structures" },
		new { Vendor = "Pluralsight", Title = "F# Jumpstart" },
		new { Vendor = "Pluralsight", Title = "Accessing Data with F# Type Providers" },
		new { Vendor = "Pluralsight", Title = "Building Distributed Systems with Akka.NET Clustering" },
		new { Vendor = "Pluralsight", Title = "Implementing Logging and Dependency Injection in Akka.NET" },
		new { Vendor = "Pluralsight", Title = "Improving Message Throughput in Akka NET" },
		new { Vendor = "Pluralsight", Title = "Scaling Applications with Microservices, MassTransit, and RabbitMQ" },
	};
	
	var coursesAlreadyWatched = new[]
	{
		new { Vendor = "Pluralsight", Title = "Getting Started with Entity Framework 5", LastWatched = DateTime.Parse("01 January 2018")},
		new { Vendor = "Pluralsight", Title = "Algorithms and Data Structures - Part 1", LastWatched = DateTime.Parse("01 January 2018")},
		new { Vendor = "Pluralsight", Title = "Algorithms and Data Structures - Part 2", LastWatched = DateTime.Parse("01 January 2018")},
		new { Vendor = "Pluralsight", Title = "Visual Studio Code Can Do That - Play-By-Play", LastWatched = DateTime.Parse("01 January 2018")},
		new { Vendor = "Pluralsight", Title = "Functional Programming with C#", LastWatched = DateTime.Parse("01 January 2018")},
		new { Vendor = "Pluralsight", Title = "Specification Pattern in C#", LastWatched = DateTime.Parse("01 January 2018")},
		new { Vendor = "Pluralsight", Title = "Clean Architecture - Patterns, Practices, and Principles", LastWatched = DateTime.Parse("19 July 2018")},
		new { Vendor = "Pluralsight", Title = "Modern Software Architecture Domain Models, CQRS, and Event Sourcing", LastWatched = DateTime.Parse("24 July 2018")},
		new { Vendor = "Pluralsight", Title = "Microservices Architecture", LastWatched = DateTime.Parse("24 July 2018")},
		new { Vendor = "Pluralsight", Title = "Patterns for Building Distributed Systems for The Enterprise", LastWatched = DateTime.Parse("27 July 2018")},
		new { Vendor = "Pluralsight", Title = "React.JS - Getting Started", LastWatched = DateTime.Parse("09 November 2018")},
		new { Vendor = "Pluralsight", Title = "Building Applications with React and Redux in ES6", LastWatched = DateTime.Parse("22 November 2018")},
		new { Vendor = "Pluralsight", Title = "Building Applications with React and Flux", LastWatched = DateTime.Parse("16 December 2018") },
		new { Vendor = "Pluralsight", Title = "Getting Started with Azure Event Hubs with C#", LastWatched = DateTime.Parse("5 January 2019") },
		new { Vendor = "Pluralsight", Title = "Azure Functions Fundamentals",LastWatched = DateTime.Parse("7 January 2019") },
		new { Vendor = "Pluralsight", Title = "Domain Driven Design Fundamentals", LastWatched = DateTime.Parse("3 February 2019") },
		new { Vendor = "Pluralsight", Title = "Terraform - Getting Started", LastWatched = DateTime.Parse("17 February 2019") },
		new { Vendor = "Pluralsight", Title = "Building Concurrent Applications with the Actor Model in Akka.NET", LastWatched = DateTime.Parse("3 December 2019") },
		new { Vendor = "Pluralsight", Title = "Go: Getting Started", LastWatched = DateTime.Parse("07 April 2020") },
		new { Vendor = "Pluralsight", Title = "Go: The Big Picture", LastWatched = DateTime.Parse("07 April 2020") },
		new { Vendor = "Pluralsight", Title = "The Go CLI Playbook", LastWatched = DateTime.Parse("20 April 2020") },
		new { Vendor = "Pluralsight", Title = "Creating Custom DataTypes With Go", LastWatched = DateTime.Parse("23 April 2020") },
		new { Vendor = "Pluralsight", Title = "Advanced Branching And Looping In Go", LastWatched = DateTime.Parse("24 April 2020") },
		new { Vendor = "Pluralsight", Title = "Deep Dive Into Go Packages", LastWatched = DateTime.Parse("26 April 2020") },
		new { Vendor = "Pluralsight", Title = "Deep Dive Into Go Functions", LastWatched = DateTime.Parse("26 April 2020") },
		new { Vendor = "Pluralsight", Title = "Concurrent Programming With Go", LastWatched = DateTime.Parse("27 April 2020") },
		new { Vendor = "Pluralsight", Title = "Creating Well-Tested Application In Go", LastWatched = DateTime.Parse("28 April 2020") },
		new { Vendor = "Pluralsight", Title = "Exploring Go Modules", LastWatched = DateTime.Parse("30 April 2020") },
		new { Vendor = "Pluralsight", Title = "Debugging Go Applications With Delve", LastWatched = DateTime.Parse("30 April 2020") },
		new { Vendor = "Pluralsight", Title = "Gin: A Website Application Framework In Go", LastWatched = DateTime.Parse("02 May 2020")  },
		new { Vendor = "Pluralsight", Title = "Object-oriented Programming with Go", LastWatched = DateTime.Parse("03 May 2020")},
		new { Vendor = "Pluralsight", Title = "Domain-Driven Design in Practice", LastWatched = DateTime.Parse("07 Feb 2021")},
		new { Vendor = "Pluralsight", Title = "Implementing a Data Management Strategy for an ASP.NET Core Microservices Architecture", LastWatched = DateTime.Parse("08 Feb 2021")},
		new { Vendor = "Pluralsight", Title = "Spring: The Big Picture", LastWatched = DateTime.Parse("08 Feb 2021")},
		new { Vendor = "Pluralsight", Title = "Dependency Injection in ASP.NET Core", LastWatched = DateTime.Parse("20 Feb 2021")},
		new { Vendor = "Pluralsight", Title = "Strategies for Microservice Scalability and Availability in ASP.NET Core", LastWatched = DateTime.Parse("06 March 2021")},
		new { Vendor = "Dometrain", Title = "Getting Started Event Sourcing in .NET", LastWatched = DateTime.Parse("05 January 2025") },
		new { Vendor = "Dometrain", Title = "From Zero to Hero From Microservices To Modular Monoliths", LastWatched = DateTime.Parse("12 January 2025") },
		new { Vendor = "Dometrain", Title = "From Zero to Hero Jetbrains Rider", LastWatched = DateTime.Parse("23 January 2025") },
		new { Vendor = "Dometrain", Title = "From Zero to Hero OpenTelemetry in .NET", LastWatched = DateTime.Parse("4 February 2025") },
		new { Vendor = "Dometrain", Title = "From Zero to Hero Asynchronous Programming in C#", LastWatched = DateTime.Parse("18 April 2025") },
		new { Vendor = "Dometrain", Title = "Getting Started Domain-Driven Design", LastWatched = DateTime.Parse("22 April 2025") },
	};

	var coursesMarkdown = new StringBuilder();
	coursesMarkdown.Append(@"Currently Watching".ToMarkdownHeader());
	coursesMarkdown.Append(currentlyWatching.ToMarkdownTable().WithHeaders("Vendor", "Title", ""));
	coursesMarkdown.Append(Environment.NewLine);
	coursesMarkdown.Append(@"Courses To Watch".ToMarkdownHeader());
	coursesMarkdown.Append(coursesToWatch.ToMarkdownTable().WithHeaders("Vendor", "Title", ""));
	coursesMarkdown.Append(Environment.NewLine);
	coursesMarkdown.Append(@"Courses Already Watched".ToMarkdownHeader());
	coursesMarkdown.Append(coursesAlreadyWatched.OrderBy(ar => ar.LastWatched)
		.ToMarkdownTable(c => c.Vendor, c => c.Title, c => c.LastWatched.ToLongDateString())
		.WithHeaders("Vendor", "Title", "Last Watched"));
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