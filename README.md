# 📚 3-Tier Web API Architecture – Documentation Branch

This branch explains the **3-Tier Architecture** used in this ASP.NET Core Web API project. It is focused on structuring the application using best practices, and includes sample entities like `Product` and `Category` only for demonstration purposes.

---

## 🧱 What is 3-Tier Architecture?

**3-Tier Architecture** is a software design pattern that separates an application into **three independent layers**:

- **Presentation Layer (API)**
- **Business Logic Layer (BLL)**
- **Data Access Layer (DAL)**

This approach improves:
- ✅ Maintainability
- ✅ Testability
- ✅ Separation of concerns

---

## 🔍 Explanation of Each Layer

### 1️⃣ Presentation Layer (API Layer)
- **Project Folder:** `3TierWebApp.API`
- **Role:** Receives HTTP requests and sends HTTP responses.
- **Responsibilities:**
  - Expose API endpoints using controllers.
  - Accept user input and return responses (JSON).
  - Delegate logic to the Business Layer.

---

### 2️⃣ Business Logic Layer (BLL)
- **Project Folder:** `3TierWebApp.BLL`
- **Role:** Encapsulates all business rules and processing.
- **Responsibilities:**
  - Implements the core logic of the system.
  - Validates data and enforces rules.
  - Acts as a bridge between the API and data layers.

---

### 3️⃣ Data Access Layer (DAL)
- **Project Folder:** `3TierWebApp.DAL`
- **Role:** Handles data persistence using Entity Framework Core.
- **Responsibilities:**
  - Defines entity models (`Product`, `Category`, etc.).
  - Contains `DbContext` to manage the database connection.
  - Implements CRUD operations through repositories.

---

## 🗂️ Project Structure Overview

3TierWebApplication/
├── 3TierWebApp.API/ --> Presentation Layer (Controllers)
├── 3TierWebApp.BLL/ --> Business Logic Layer (Interfaces & Services)
├── 3TierWebApp.DAL/ --> Data Access Layer (Entities, Repositories, DbContext)
├── docs/ --> Documentation assets (e.g., diagram image)
└── README.md --> This documentation


---

## 📌 Purpose of This Branch

This branch is **only** for explaining and demonstrating the architecture.  
Full features such as API logic, authentication, and database configuration will be developed in **separate branches**, each with its own README.

---

## 👩‍💻 Author

**Khawla Saif Al-Harthi**  
GitHub: [@Khawla-alharthi](https://github.com/Khawla-alharthi)
