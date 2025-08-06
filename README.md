# BevoBnB – Lodging Marketplace Platform

BevoBnB is a full-stack web application inspired by Airbnb, developed as part of the MIS 333K Final Project at The University of Texas at Austin. Built using ASP.NET Core MVC and hosted on Microsoft Azure, the app enables customers to book vacation rentals, hosts to manage properties, and administrators to oversee platform activity.

## 🔧 Tech Stack

- **Backend**: ASP.NET Core MVC (C#)
- **Frontend**: Razor Views + HTML/CSS
- **Database**: SQL Server (hosted on Azure)
- **Auth**: Microsoft Identity with role-based authorization
- **Hosting**: Microsoft Azure App Service
- **Seed Data**: Preloaded via Excel for demo grading

## 🧑‍🤝‍🧑 Roles & Features

### 👤 Customers
- Browse and filter properties by category, location, price, features, ratings
- Create/edit profile, manage reservations, and leave reviews
- View reservation history and cancel future bookings
- See calculated totals, tax, and discounts before checkout

### 🏡 Hosts
- Create and update property listings with dynamic pricing and availability
- Set cleaning fees and long-stay discounts
- View financial reports (revenue, cleaning fees, completed bookings)
- Dispute unfair reviews

### 🛠️ Administrators
- Manage user accounts (hire/fire/rehire admins, update user profiles)
- Approve new properties and categories
- Resolve review disputes
- Generate platform-wide reports (commissions, reservation volume, revenue)

