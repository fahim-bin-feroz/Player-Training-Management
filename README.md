# 🏏 Player Management System (Master–Detail Relationship Demo)

This is a **partial full-stack project** built with **ASP.NET Core Web API** and **Angular**, focusing on demonstrating a **many-to-many relationship** between entities in a master–detail structure — specifically, **Players and Trainings**.

> ⚠️ Note: This is not a complete production system — it is a focused, educational implementation of entity relationships and dynamic form handling.

---

## 🛠️ Tech Stack

- **Backend:** ASP.NET Core Web API, C#, Entity Framework Core
- **Frontend:** Angular, TypeScript, Bootstrap
- **Database:** SQL Server
- **Tools:** Visual Studio, Visual Studio Code, Swagger, Postman

---

## 📚 Project Focus

This project demonstrates:

- ✅ A working **many-to-many relationship** between `Player` and `Training` tables using a join table `PlayerTrainingAssignment`
- ✅ Clean RESTful API development using ASP.NET Core
- ✅ Angular frontend form for creating a player with multiple training assignments
- ✅ Image upload support via `FormData`
- ✅ Use of DTOs, AutoMapper, and Model Validation

---

## 🔗 Entity Relationship

**Player** ←▶ **PlayerTrainingAssignment** ←▶ **Training**

Each player can participate in multiple trainings, and each training can have multiple players assigned.

---

## 📁 Project Structure
PlayerManagement/

├── backend/ # ASP.NET Core Web API (Visual Studio)

├── frontend/ # Angular SPA (VS Code)

└── README.md


---

## 🚀 Getting Started

### 📦 Backend (ASP.NET Core API)

1. Open `backend/` in **Visual Studio**
2. Set your connection string in `appsettings.json`
3. Apply migrations or run SQL manually (if using DB-first)
4. Run the API:
   ```bash
   dotnet run
5. Browse https://localhost:5001/swagger to test APIs


### 🌐 Frontend (Angular)
1. Open frontend/ in **VS Code**

2. Install dependencies:
   ```bash
   npm install
3. Run the app:
   ```bash
   ng serve

5. Visit http://localhost:4200

### 📤 Image Upload (Player Picture)
* Handled via IFormFile in backend and FormData in frontend.

* Uploaded files are stored in: wwwroot/images/players/

* URL of image is saved as part of the player’s record.

### 🧪 API Testing
* Use Postman or built-in Swagger UI to test endpoints.

* Sample payloads and file uploads are supported.

### 📌 Planned Improvements
* Full CRUD operations for Trainings

* UI enhancements with Angular Material

* Authentication and Authorization (JWT)

* Role-based player management (Admin/User)

* Filtering, sorting, and pagination

### 📄 License
This project is for educational and portfolio purposes only. Free to use with attribution.

