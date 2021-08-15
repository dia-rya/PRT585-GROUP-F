## Week 1 Learning Outcomes
* What is Blazor and Razor?
* What is WebAssembly and Blazor WebAssembly?
* What is Blazor Server?
* How is Blazor UI defined?
* Create and run a Blazor web app
#### New Blazor App using command prompt
* New Blazor App created by using ``` dotnet new blazorserver -o BlazorApp --no-https ``` command in command promtp
* Content of the directory BlazorApp location investigated.
* Hello World App built and run by using ``` dotnet watch run ``` command in command prompt
* Index.razor file understood that it uses razor syntax consists of Razor markup, C#, and HTML.
* Razor supports C# and uses the @ symbol to transition from HTML to C#. Razor evaluates C# expressions and renders them in the HTML output.
* Counter page tested and Counter.razor code understood.
* One page can show another pages content by simpling adding end of the page ``` <Pagename /> ```
#### New Blazor App using Visual Studio
* Create a folder name BlazorApp and open folder in Visual Studio Code
* Using VS termial ``` dotnet new blazorserver ``` create new a basic Blazor server project (which all required files and pages, along with a C# project file named BlazorApp.csproj. are created)
* Start server with ``` dotnet watch run ```
* The structure of a Blazor project explored
* Counter page (Note: A request for /counter in the browser, as specified by the @page directive at the top, causes the Counter component to render its content.)
#### Create the ToDo page
* In the VS terminal while in Blazor App location run ``` dotnet new razorcomponent -n Todo -o Pages ``` command

The -n|--name option in the preceding command specifies the name of the new Razor component. The new component is created in the project's Pages folder with the -o|--output option.
#### Create SignalR with Blazor
* Create a Blazor project
* Add the SignalR client library
* Add a SignalR hub
* Add SignalR services and an endpoint for the SignalR hub
* Add Razor component code for chat
#### Further Study
* Data binding and events
* C# code-behind in separate files 

Commonly called code-behind, this technique uses separate code files to store app logic.
* C# inline in components

A common practice is to mix HTML and C# in a single Razor component file. For simple components with lighter code requirements, this approach works well. To add code into a Razor file, you'll use directives.
* What are Razor directives?

Razor directives are component markup used to add C# inline with HTML. With directives, developers can define single statements, methods, or larger code blocks.
* Code directives : 

Code directives should be familiar to developers who have used Razor in MVC or Pages.
You can use ``` @expression() ``` to add a C# statement inline with HTML. If you require more code, use the ``` @code ``` directive to add multiple statements enclosed by parentheses.
You can also add an ``` @functions ``` section to the template for methods and properties. They're added to the top of the generated class, where the document can reference them.
* Page directive

The ``` @Page ``` directive is special markup that identifies a component as a page. Use this directive to specify a route. The route maps to an attribute route that the Blazor engine recognizes to register and access the page.
* Razor data binding

Within Razor components, you can data bind HTML elements to C# fields, properties, and Razor expression values. Data binding allows two-way synchronization between HTML and Microsoft .NET.

Data is pushed from HTML to .NET when a component is rendered. Components render themselves after event-handler code executes. That's why property updates are reflected in the UI immediately after an event handler is triggered.

Use ``` @bind ``` markup to bind a C# variable to an HTML object. You define the C# variable by name as a string in the HTML.
* 
