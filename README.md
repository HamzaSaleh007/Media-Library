# Media library in .Net

## Description
This project is a **Console Application (.NET Framework)** that demonstrates the use of **interfaces**, **abstract classes**, and **inheritance** to manage various types of media (Books, Movies, and Songs). The application reads and processes media data from a file (`Data.txt`), provides user interaction through a menu, and supports search and encryption functionality.

The project utilizes:
- **`IEncryptable` Interface**: Defines methods for `Encrypt()` and `Decrypt()`.
- **`ISearchable` Interface**: Defines a method for `Search()`.
- **`Media` Abstract Class**: Represents a single media object and serves as the base class for `Book`, `Movie`, and `Song`.

---

## Features
### **Interfaces**
1. **IEncryptable**:
   - Contains method signatures:
     ```csharp
     void Encrypt();
     void Decrypt();
     ```
   - Used to encrypt and decrypt summaries for Books and Movies using the Rot13 algorithm.

2. **ISearchable**:
   - Contains a method signature:
     ```csharp
     bool Search(string searchTerm);
     ```
   - Enables searching media objects by their title.

### **Abstract Class**
- **Media**:
  - Represents a single media object with the following properties:
    - `Title` (string)
    - `Year` (int)
  - Serves as the base class for:
    - `Book`: Includes `Author` and `Summary` properties.
    - `Movie`: Includes `Director` and `Summary` properties.
    - `Song`: Includes `Album` and `Artist` properties.

### **Main Application Features**
1. **Data Handling**:
   - Reads up to 100 media objects from `Data.txt`.
   - The file includes encrypted summaries for Books and Movies.
   - Exception handling for file input/output operations.

2. **User Menu**:
   - Allows the user to interact with the media objects using the following options:
     - **List All Books**: Displays all books (excluding summaries).
     - **List All Movies**: Displays all movies (excluding summaries).
     - **List All Songs**: Displays all songs.
     - **List All Media**: Displays all media objects (excluding summaries).
     - **Search All Media by Title**: Searches media titles for a keyword and displays decrypted summaries for Books and Movies.
     - **Exit Program**: Closes the application.

3. **Encryption/Decryption**:
   - Implements a simple **Rot13 algorithm** for encrypting and decrypting summaries of Books and Movies.

4. **Error Handling**:
   - Includes exception handling for file I/O.
   - Provides input validation for the user menu.

5. **Modularized Design**:
   - The `Main()` method is highly modularized for better readability and maintainability.

---

## File Structure
- **Interfaces**:
  - `IEncryptable.cs`
  - `ISearchable.cs`
- **Abstract Class**:
  - `Media.cs`
- **Derived Classes**:
  - `Book.cs`
  - `Movie.cs`
  - `Song.cs`
- **Main Class**:
  - `Lab3A.cs`
- **Data File**:
  - `Data.txt`: Contains encrypted summaries and media details.

---

## How to Run
1. **Clone the Repository**:
   git clone https://github.com/your-username/lab3a.git

2. Open the Project:
Open the project in Visual Studio.
3. Build and Run:
Build the solution and run the program.
4. Follow the Menu Prompts:
Interact with the program using the menu to list or search media
