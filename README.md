# Blazor Web Development Project – Event Management

This project was created as part of a **Blazor for Front-End Development** course.  
The goal was to build a simple event management web app using **Blazor WebAssembly** while leveraging **Microsoft Copilot** to speed up development, follow best practices, and experiment with AI-assisted coding.

## 📌 Project Overview
The application allows users to:
- View event details in a dedicated **Event Card** component.
- Navigate between event pages using Blazor routing.
- Register for events via a form with validation.
- Track attendance with a basic state management service.

## 🛠️ Technologies Used
- **Blazor WebAssembly** (.NET 9)
- **C#** for components and logic
- **Microsoft Copilot** for AI-assisted code generation
- **Bootstrap** for quick styling
- **.NET Routing & Data Binding** features

## 🤖 How Microsoft Copilot Helped
Copilot was used throughout the project to:
1. **Build the basics** – Generated the Event Card component with markup and data binding.
2. **Implement routing** – Provided navigation link code, fixed routing errors, and suggested user-friendly error handling.
3. **Optimize performance** – Recommended the `@key` directive for list rendering and added form validation.
4. **Add advanced features** – Scaffolded the registration form, created a user session service, and implemented attendance tracking.

## 🚀 Running the Project
To run the project locally:
```bash
# Clone the repository
git clone https://github.com/your-username/your-repo-name.git
cd your-repo-name

# Restore dependencies
dotnet restore

# Run the app
dotnet run
