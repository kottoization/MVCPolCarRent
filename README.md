## MVCPolCarRent

### Introduction
Welcome to the **MVCPolCarRent** repository! This project is aimed at providing an MVC application for managing a vehicle rental service.

### Installation
1. **Clone the Repository:** 
   ```
   git clone https://github.com/kottoization/MVCPolCarRent.git
   ```

2. **Navigate to the Project Directory:**
   ```
   cd MVCPolCarRent
   ```

3. **Restore Dependencies:**
   ```
   dotnet restore
   ```

4. **Database Migration:**
   ```
   dotnet ef database update
   ```

### Configuration
- **Database Configuration:** 
  - Modify the database connection string in `appsettings.json` file under the `ConnectionStrings` section to match your database configuration.

### Usage
- **Run the Application:**
  ```
  dotnet run
  ```
- Access the application through your web browser at `http://localhost:port`.

### Features
- User authentication and authorization.
- CRUD operations for managing vehicles, customers, rentals, etc.
- Dashboard for admin and user roles.

### Contributing
Contributions are welcome! If you'd like to contribute, please fork the repository and submit a pull request.
