# Mvc5 Angular SignalR Seed Project With Webpack

Working Starter Project using Mvc5 - Angular - SignalR

Inital setup created from the [Angular Tutorial](https://angular.io/docs/ts/latest/cookbook/visual-studio-2015.html) (but using Angular2-seed instead of the quickstart)

MVC5 SignalR created using the [Microsoft Tutorial](https://docs.microsoft.com/en-us/aspnet/signalr/overview/getting-started/tutorial-getting-started-with-signalr-and-mvc)

Angular SignalR creating with hints from this [excellent project for .NET Core](https://github.com/FabianGosebrink/ASPNETCore-Angular-SignalR-Typescript)


## Setup

- Clone this repository.
- If using VS2015, you will need to go to 'Tools > Extensions And Updates > Online' and Install Typescript 2.7.2
- Open a command prompt at {root}\Mvc5AngularSignalRWithWebpack\Mvc5Angular2SignalRWithWebpack and run `npm install`
- Open in VS2015 or greater.
- If you're using VS2015, you *must* add https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebPackTaskRunner

- Thanks to this on [StackOverflow](http://stackoverflow.com/a/36374413/852806). You should be able to hit play and it'll build the js in webpack too.

- If that fails - Either via the webpack task runner run (Run-Development), then press play in visual studio, or from the command line run "webpack -d", then press play in visual studio.


Note: The project uses webpack, bundling or minification.

Urls:

http://localhost:58056/Home/Chat -> MVC5 Version

http://localhost:62499/src/index.html#/home -> Angular2 Version


####Note:

If for some reason this doesnt work 'out of the box', try removing the tildes(~) and hats(^) from the project.json and rebuild.


