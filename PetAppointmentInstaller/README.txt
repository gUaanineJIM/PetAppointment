=====================================================================
             Veterinary Clinic Management System (VCMS)
=====================================================================

Developed by: Janine Ishe  
Course: BSIT - 3rd Year  
Subject: Event-Driven Programming  
Language: C# (.NET Framework)  
Database: MySQL  
Reports: Microsoft Excel Interop  
=====================================================================

ABOUT THE SYSTEM:
--------------------
This is a desktop application built to assist veterinary clinics in managing their daily operations. It provides features to manage pet owners, register pets, add staff and doctors, schedule appointments, track treatments, generate billing, and produce reports. 
- Admin dashboard can be accessed using username: admin password: admin

=====================================================================
                        HOW TO INSTALL
=====================================================================

1. **Install MySQL**
   - If MySQL is not yet installed, download and install it manually from:
     https://dev.mysql.com/downloads/installer/
   - During installation, remember your root username and password. You’ll need them when running the setup script.

2. **Import the MySQL Database**
   - Navigate to the `PetAppointment` folder.
   - Run the file: `setup_database.bat`
   - Enter your MySQL username and password when prompted.
   - This will automatically import the database from `mysql\PetAppointmentDB.sql`.

3. **Check the Report Template Folder**
   - Make sure the `ReportTemplate` folder exists in the same directory as `PetAppointment.exe`.
   - It must contain the file `vetBackup.xlsx`, which is required for Excel report generation.

   **Note:**
   - If you encounter an error related to Excel reports, check that `vetBackup.xlsx` exists.
   - If it’s missing, manually create the folder and place the file at:
     `PetAppointment\ReportTemplate\vetBackup.xlsx`

4. **Run the Application**
   - Double-click `PetAppointment.exe` to launch the system.

=====================================================================
NOTES:
--------------------
- Make sure MySQL is installed before importing the database  
- If you move the folder to another computer, run the setup steps again  
- Admin and staff credentials can be set via the user management module
- Admin dashboard can be accessed using username: admin password: admin

=====================================================================







FEATURES:
--------------------
- Login system with Forgot Password & Recovery  
- Admin dashboard can be accessed using username: admin password: admin
- System Users Management (Create, Read, Update, Delete)  
- Register Pet Owners and Pets  
- Add Vet Doctors (with specialization and appointment check)  
- Appointment Scheduling  
- Add Treatments and Billing  
- Staff Management  
- Excel Report Generation (with search & filter)

=====================================================================
TECHNOLOGIES USED:
--------------------
- C# (.NET Framework)  
- MySQL  
- Microsoft Excel Interop  
- MySQL Stored Procedures, Functions, and Triggers

=====================================================================
DATABASE OBJECTS USED:
--------------------
- Stored Procedure:  
  • AddNewDoctor

- Triggers (6 total):  
  • Before Insert, After Insert  
  • Before Update, After Update  
  • Before Delete, After Delete

- Functions (2 total):  
  • CalcVetTotalEarnings  
  • VetUpcomApp_withVetSpec

Total custom DB objects: 9
