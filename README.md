[![LinkedIn](https://img.shields.io/badge/LinkedIn-devmuniz-0A66C2?logo=linkedin&logoColor=white)](https://www.linkedin.com/in/devmuniz)
[![GitHub Profile](https://img.shields.io/badge/GitHub-devMuniz02-181717?logo=github&logoColor=white)](https://github.com/devMuniz02)
[![Portfolio](https://img.shields.io/badge/Portfolio-devmuniz02.github.io-0F172A?logo=googlechrome&logoColor=white)](https://devmuniz02.github.io/)
[![Hugging Face](https://img.shields.io/badge/Hugging%20Face-manu02-FFD21E?logoColor=black)](https://huggingface.co/manu02)

# Clone the repository

This project was created as part of a **Blazor for Front-End Development** course. The goal was to build a simple event management web app using **Blazor WebAssembly** while leveraging **Microsoft Copilot** to speed up development, follow best practices, and experiment with AI-assisted coding.

## Repository Structure

| Path | Description |
| --- | --- |
| `bin/` | Top-level project directory containing repository-specific resources. |
| `Layout/` | Top-level project directory containing repository-specific resources. |
| `obj/` | Top-level project directory containing repository-specific resources. |
| `Pages/` | Top-level project directory containing repository-specific resources. |
| `Properties/` | Top-level project directory containing repository-specific resources. |
| `Services/` | Top-level project directory containing repository-specific resources. |
| `wwwroot/` | Top-level project directory containing repository-specific resources. |
| `_Imports.razor` | Top-level file included in the repository. |
| `App.razor` | Top-level file included in the repository. |
| `CourseraBlazor.csproj` | Solution or project definition for the .NET codebase. |

## Getting Started

1. Clone the repository.

   ```bash
   git clone https://github.com/devMuniz02/BlazorCourseraProject.git
   cd BlazorCourseraProject
   ```

2. Prepare the local environment.

Restore .NET dependencies:
```bash
dotnet restore
```

3. Run or inspect the project entry point.

Build the .NET project:
```bash
dotnet build
```

## ️ Technologies Used

- **Blazor WebAssembly** (.NET 9)
- **C#** for components and logic
- **Microsoft Copilot** for AI-assisted code generation
- **Bootstrap** for quick styling
- **.NET Routing & Data Binding** features

## How Microsoft Copilot Helped

Copilot was used throughout the project to:
1. **Build the basics** – Generated the Event Card component with markup and data binding.
2. **Implement routing** – Provided navigation link code, fixed routing errors, and suggested user-friendly error handling.
3. **Optimize performance** – Recommended the `@key` directive for list rendering and added form validation.
4. **Add advanced features** – Scaffolded the registration form, created a user session service, and implemented attendance tracking.

## Running the Project

To run the project locally:
```bash
# Clone the repository
git clone https://github.com/your-username/your-repo-name.git
cd your-repo-name

# Restore dependencies
dotnet restore

# Run the app
dotnet run
