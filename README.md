# Grifindo Travels - Vehicle Rental & Hire Management System

## 🚗 About the Project
Grifindo Travels is the transport division of **Grifindo Leisure (Pvt) Ltd**, an emerging travel & tour company in Sri Lanka. This system is designed to manage vehicle rental, hire, and sales transactions efficiently. It supports different vehicle types, pricing structures, and booking modes, ensuring a seamless customer experience.

## ✨ Features
- **Vehicle Rental (With/Without Driver)**
  - Rental rates calculated per **day, week, or month**
  - Driver cost added if needed
  - Automatic total rent calculation
  
- **Vehicle Hire (With Driver Only)**
  - Predefined packages such as **airport drop, pickup, 100km/day, 200km/day, etc.**
  - **Extra charges** for exceeding time or kilometer limits
  - Driver overnight and vehicle night parking fees
  
- **Sales & Record Management**
  - Records each rental/hire with **date, time, type (rent/hire), mode (with or without driver), and calculated amount**
  - Stored in the database for future analysis

## 🛠️ Technologies Used
- **Frontend:** HTML, CSS, JavaScript
- **Backend:** PHP
- **Database:** MySQL

## 📂 Project Structure
```
/GrifindoTravels
│── index.php            # Homepage
│── rent.php             # Vehicle rental form & processing
│── hire.php             # Hire package selection & booking
│── sales.php            # Transaction records & reports
│── database.sql         # Database structure & sample data
│── assets/              # CSS, JavaScript, images
│── includes/            # PHP functions, database connection
```

## 📝 Setup Instructions
1. **Clone the repository:**
   ```bash
   git clone https://github.com/Sandyy68/Grifindo-Travels-Vehicle-Management.git
   ```
2. **Move to the project directory:**
   ```bash
   cd Grifindo-Travels-Vehicle-Management
   ```
3. **Import the database:**
   - Open **phpMyAdmin** (or any MySQL tool)
   - Create a database named `grifindo_travels`
   - Import `database.sql` into `grifindo_travels`
4. **Run the project:**
   - Place files inside `htdocs` if using XAMPP
   - Start Apache and MySQL
   - Open `http://localhost/GrifindoTravels`

## 📧 Contact
For any inquiries, feel free to reach out!

---
Developed by **Sandapoorni Shakalya** 🚀
