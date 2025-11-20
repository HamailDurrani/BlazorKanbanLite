# 📌 Blazor Kanban Board

A lightweight and clean **Kanban Task Management System** built with **Blazor WebAssembly**.  
Supports drag-and-drop, full CRUD operations, and per-column pagination.

---

## ✨ Features

### 📝 Task Management
- Add tasks  
- Edit tasks  
- Delete tasks  
- Validation for required fields

### 📊 Kanban Workflow
- Three task stages:
  - **To Do**
  - **In Progress**
  - **Done**

### 🖱️ Drag & Drop Support
- Move tasks between columns  
- Automatically updates task status  
- Smooth browser-native drag API

### 📄 Pagination
- Shows **3 tasks per column per page**  
- Dynamic page navigation  
- Prevents long overflowing columns

---

## 🔧 Technologies Used

- **Blazor WebAssembly**
- **C# .NET 7 / 8**
- **JavaScript Interop** (Drag & Drop helper)
- **Bootstrap / Custom CSS**



## 🧠 How It Works (Short Summary)

### 🟦 1. Task Service  
Stores all tasks using an in-memory list.  
Provides:
- `GetAll()`
- `Add()`
- `Update()`
- `Delete()`

### 🟩 2. Drag-and-Drop  
Implemented using:
- `@ondragstart`
- JS helper `dragHelper.set(id)`
- Drop zone reads the id → updates status

### 🟧 3. Pagination  
Each page shows:
- **3 tasks per column**

Navigation:
- `NextPage()`
- `PrevPage()`

### 🟨 4. UI  
Reusable **TaskCard** component for each task.

---

