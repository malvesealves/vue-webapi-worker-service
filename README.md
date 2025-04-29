# Vue.js with .NET Framework and Hangfire Project

<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->

<a id="readme-top"></a>

<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->

<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
<!--
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![project_license][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
-->

<!-- PROJECT LOGO -->
<br />
<!--<div align="center">
  <a href="https://github.com/github_username/repo_name">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>-->

 <!--<h3 align="center">TDD project</h3>-->

  <p align="center">
     Project for knowledge and practice purposes
    <br />
    <!--<a href="https://github.com/github_username/repo_name"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/github_username/repo_name">View Demo</a>
    &middot;
    <a href="https://github.com/github_username/repo_name/issues/new?labels=bug&template=bug-report---.md">Report Bug</a>
    &middot;
    <a href="https://github.com/github_username/repo_name/issues/new?labels=enhancement&template=feature-request---.md">Request Feature</a>-->
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<!--<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>-->

<!-- ABOUT THE PROJECT -->

## About The Project

1. Create a .NET Solution:

   Use the latest .NET version.
   Implement the solution using C#.

2. Project Structure:

   Include two hosts in your solution, each in a separate .csproj file:
   One host as a WebAPI.
   One host as a WorkerService.

3. Architecture:

   Develop the solution based on the Clean Architecture combined with the DDD pattern.
   Use a Class Library for each layer to implement the DDD pattern.
   The compontents of the project should comply to the SOLID principle

4. Data Storage:

   Store data using the Repository Pattern with the latest version of Entity Framework Core (EF Core).

5. Data Upsert:

   Implement data upsert functionality using a Hangfire Job.
   Host the Hangfire Job in the WorkerService host.
   Place the jobs in a separate Class Library.
   Schedule the job to run every hour.

6. Data Source:

   Use a data source of your choice from here: https://github.com/public-api-lists/public-api-lists

7. Database:

   Use MSSQL for data storage.

8. Frontend:

   Add a Vue.js frontend written in Typescript.
   Display the data in a filterable grid.

<!--[![Product Name Screen Shot][product-screenshot]](https://example.com)

Here's a blank template to get started. To avoid retyping too much info, do a search and replace with your text editor for the following: `github_username`, `repo_name`, `twitter_handle`, `linkedin_username`, `email_client`, `email`, `project_title`, `project_description`, `project_license`-->

<!--<p align="right">(<a href="#readme-top">back to top</a>)</p>-->

### Built With

<!--* ![C#](https://img.shields.io/badge/-C%23%2013-333333?style=flat&logo=C&logoColor=00599C)-->

- ![.NET Framework](https://img.shields.io/badge/-.NET%20Framework%204.8.1-333333?style=flat&logo=dotnet&logoColor=00599C)
- ![Visual Studio](https://img.shields.io/badge/Visual%20Studio%202022-5C2D91.svg?style=flat&logo=visual-studio&logoColor=white)
- ![VSCode](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=flat&logo=visual-studio-code&logoColor=white)
- ![EntityFrameworkCore](https://img.shields.io/badge/Entity%20Framework%20Core-9932CC.svg?style=flat&logo=.NET&logoColor=512BD4)
  <!--* ![RabbitMQ](https://img.shields.io/badge/-RabbitMQ-FF6600?style=flat&logo=rabbitmq&logoColor=white)-->
  <!--* ![kafka-url](https://img.shields.io/static/v1?label=&message=Apache%20Kafka&logo=apache-kafka&color=4f4f4f)
- ![docker-url](https://img.shields.io/badge/Docker-2496ED?logo=Docker&logoColor=white)-->
<!--* ![XUnit](https://img.shields.io/badge/-XUnit%202.9.2-333333?style=flat&logo=NuGet)
- ![Moq](https://img.shields.io/badge/-Moq%204.20.72-333333?style=flat&logo=NuGet)
- ![Git](https://img.shields.io/badge/-Git%202.47.1-333333?style=flat&logo=git)-->
<!--* ![GitHub](https://img.shields.io/badge/-GitHub-333333?style=flat&logo=github)
- [![Next][Next.js]][Next-url]
- [![React][React.js]][React-url]-->
- ![Vue](https://img.shields.io/badge/Vue.js-35495E?style=flat&logo=vuedotjs&logoColor=4FC08D)
<!--* [![Angular][Angular.io]][Angular-url]
- [![Svelte][Svelte.dev]][Svelte-url]
- [![Laravel][Laravel.com]][Laravel-url]
- [![Bootstrap][Bootstrap.com]][Bootstrap-url]
- [![JQuery][JQuery.com]][JQuery-url]-->

<!--<p align="right">(<a href="#readme-top">back to top</a>)</p>-->

<!-- GETTING STARTED -->
<!--## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

This is an example of how to list things you need to use the software and how to install them.
* npm
  ```sh
  npm install npm@latest -g
  ```

### Compile and Hot-Reload for Development

```sh
npm run dev
```

### Type-Check, Compile and Minify for Production

```sh
npm run build
```

### Run Unit Tests with [Vitest](https://vitest.dev/)

```sh
npm run test:unit
```

### Run End-to-End Tests with [Cypress](https://www.cypress.io/)

```sh
npm run test:e2e:dev
```

This runs the end-to-end tests against the Vite development server.
It is much faster than the production build.

But it's still recommended to test the production build with `test:e2e` before deploying (e.g. in CI environments):

```sh
npm run build
npm run test:e2e
```

### Lint with [ESLint](https://eslint.org/)

```sh
npm run lint
```
