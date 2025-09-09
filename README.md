# Contract Monthly Claim System (CMCS) Prototype

## Overview
The Contract Monthly Claim System (CMCS) is a non-functional prototype developed for the Portfolio of Evidence (PoE) Part 1, designed to streamline claim submissions, reviews, and approvals for Independent Contractor lecturers. Built using ASP.NET Core MVC, the prototype features a role-based interface with Bootstrap for responsiveness, displays amounts in ZAR (South African Rand), and includes a relational database structure with five tables: Role, Lecturer, Coordinator, Manager, Claim, and Document. This project demonstrates C# GUI development skills, focusing on ease of use, accuracy, and accountability.

## Project Structure

CMCS_Prototype
├── Models
│   ├── Lecturer.cs
│   ├── Claim.cs
│   ├── Document.cs
│   ├── Coordinator.cs
│   ├── Manager.cs
│   ├── Role.cs
├── Controllers
│   ├── HomeController.cs
│   ├── ClaimController.cs
├── Views
│   ├── Home
│   │   ├── Index.cshtml
│   │   ├── LecturerDashboard.cshtml
│   │   ├── CoordinatorDashboard.cshtml
│   │   ├── ManagerDashboard.cshtml
│   ├── Claim
│   │   ├── Submit.cshtml
│   │   ├── Reports.cshtml
│   ├── Shared
│   │   ├── _Layout.cshtml
├── wwwroot
│   ├── css
│   │   ├── bootstrap.min.css
│   ├── js
│   │   ├── bootstrap.min.js
├── Documentation
│   ├── CMCS_Part1_Report.docx
│   ├── UML_Diagram.png
│   ├── Requirements.docx
│   ├── LecturerDashboard.png
│   ├── CoordinatorDashboard.png
│   ├── ManagerDashboard.png
│   ├── ClaimSubmission.png
│   ├── Reports.png
├── CMCS_Prototype.csproj
├── .gitignore
├── README.md

## Features
- **Login Page**: Email and password form for user access.
- **Lecturer Dashboard**: Displays claim submission, document upload, and claim status table (with amounts in ZAR, e.g., R500).
- **Coordinator Dashboard**: Shows claims for review with "Review" and "Forward to Manager" buttons and document preview modal.
- **Manager Dashboard**: Displays claims with "Approve"/"Reject" buttons and document modal.
- **Claim Submission Page**: Form for submitting claims (month, year, hours, document upload).
- **Reports Page**: Summarizes claims with an "Export to CSV" button.
- **Database Structure**: UML diagram (`UML_Diagram.png`) defines five tables with one-to-many relationships.
- **Security**: Role-based access ensures functionality is restricted by user role.

## Setup Instructions
1. **Prerequisites**:
   - Install [Visual Studio 2022](https://visualstudio.microsoft.com/) with .NET 8.0 SDK.
   - Install [Git](https://git-scm.com/downloads).
   - Ensure internet connectivity for Bootstrap CDN (or use local files in `wwwroot`).

2. **Clone the Repository**:
   ```bash
   git (https://github.com/brandondlmn/CMCS_Prototype)
   cd CMCS_Prototype

Open and Run:Open CMCS_Prototype.sln in Visual Studio 2022.
Build the solution (Ctrl+Shift+B).
Run the project (F5 or dotnet run) to launch at https://localhost:<port>.

Verify Pages:Navigate to:/ (Login)
/Home/LecturerDashboard
/Home/CoordinatorDashboard
/Home/ManagerDashboard
/Claim/Submit
/Claim/Reports

Confirm amounts display as R500 and layouts are responsive.

