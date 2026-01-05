# Purrfect Blog
Purrfect Blog is a simple blog application built with ASP.NET MVC using .NET Framework 4.7, Entity Framework, and SQL Server.
The application allows users to create, view, edit, and delete blog posts, demonstrating full CRUD functionality.

It features are: home page with the most recent posts, a posts list page, individual post details, form validation, and user-friendly error handling.
The main purpose of this project is to practice the MVC architecture and CRUD operations.

## 🌐 Demo
https://github.com/user-attachments/assets/228e9a77-b1b3-4a58-888b-a2d96c3685da

## 📖 About this Software

Purrfect Blog is an application built with ASP.NET MVC using .NET Framework 4.7.2.
The project uses Entity Framework (Code First) together with SQL Server for data persistence and database management. 
Entity Framework migrations are used to manage database schema changes and ensure the database stays in sync with the application models.
Business logic is separated from controllers through a service layer, improving maintainability.

Autofac is used as the dependency injection container, allowing services to be injected into controllers. This decouples application components and makes the system easier to test and extend.
The application implements full CRUD (Create, Read, Update, Delete) functionality for blog posts, along with server-side validation, routing, and user-friendly error handling. 
The UI is styled using Bootstrap to provide a clean and responsive layout.

### Features:

#### 1. Create Blog Posts
Users can create new blog posts using a validated form that ensures required fields such as title and content are provided.

#### 2. View Blog Posts
Blog posts are displayed in a list view and can be opened individually to read full content, including creation date and category.

#### 3. Edit Existing Posts
Posts can be edited through a pre-populated form, allowing users to update titles, content, and categories with validation.

#### 4. Delete Posts with Confirmation
Posts can be safely deleted using a confirmation modal to prevent accidental removal.

#### 5. Home Page with Recent Posts
The home page displays the three most recent blog posts, ordered by creation date, with preview excerpts and “Read More” links.

#### 6. Form Validation and User Feedback
The application provides clear validation errors, success messages, and user-friendly error pages such as a custom 404 view.

## 🖼️ Screenshots

To give you a visual overview of the application, here are some screenshots:

### Posts list
<img width="1917" height="1029" alt="image" src="https://github.com/user-attachments/assets/2835ad30-1ca9-46b9-ad84-4a5c8c26fcfb" />

### Create Post form
<img width="1915" height="1037" alt="image" src="https://github.com/user-attachments/assets/c4403146-8a9d-4ae1-b9b3-cd046360e08a" />

### Edit Post form
<img width="1920" height="1039" alt="image" src="https://github.com/user-attachments/assets/59e350e3-9bd1-4530-9c85-1b2f2c2ecc0b" />

### Delete confirmation modal
<img width="1919" height="1034" alt="image" src="https://github.com/user-attachments/assets/06645a7f-7b7e-4816-bb34-01c05ca47e8f" />

### 404 Not Found page
<img width="1914" height="1034" alt="image" src="https://github.com/user-attachments/assets/449df192-9080-4e4d-a3e8-4f3a830c5c44" />

### 500 Server Error page
<img width="1920" height="1037" alt="image" src="https://github.com/user-attachments/assets/e31bd07c-ead2-4588-b365-76c56ff40eca" />
