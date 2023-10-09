# Library-Management-System

**Minds** is an Online Library Management System website built in **ASP.NET** platform with ### **C#** as a programming language. It provides the users with the ability to **Register** to this website and **Search & Issue** books. Each user will have their **Own Account & User Profile** where their information and issued books will be shown. They can **Edit and Update their profile info** as needed.

Anyone can View book **without being a member** but to issue any book, they need to be registered member of the library. Once they find a book attractive they can apply for the book issuing and his interest in a particular book will be passed to the admin for approval with his user Id and book Id. If he is an active member of the library and not in Defaulters list, then the admin will approve his request and issue the book for a certain period of time if the book is available in the library.


## Database

A Centralized SQL database is maintained in for all users by an administrator so that it is accessible by every registered user. The database is controlled by admin so that database is Secured, Relevent and unnecessary information are not stored in the database. The admin can check every activities of the users. He can **see all information of any users, specify users Account Status and even Delete any users** if he finds anything inappropriate. He can see **Add, Update and Delete books as required**. He can Issue book to any users for a cetain period of time and also take back the book and automatically Stock Status gets updated in the database. If any user does not give back the book by defined time then he will be in the **Defaulters list** and his status will be changed accordingly.


The Website is made with **Visual Studio IDE, MS SQL Express 2017 database** which uses SQL Server Management Studio as a database and Chrome as a browser. In the process of buiding our websites, we have used **Bootstrap framework, Font awesome and Datatables Libraries** for customizing the webpages.





## Description:

Once we have run the website from visual studio, we will see Home page consisting of Seven Page Link options including Home, About Us, Contact at the left end, View books, LogIn and SignUp at the right end and Admin Login at the bottom end. Any one can View book without being a member but to issue any book, they need to be a registered member of the library.  If the user have a previous account then he will go for LogIn. But if he doesn’t have any registed account, then he first have to create an account. To create a new account, he have to click the SignUp button which will take him to UserSignUp Page. Now he will submit some information crucial for the opening of his account including name, email, password, contact, division, city etc. If he fills up the form properly and click signup button, his personal account will be created in the app and all this information will be stored in Members tablr of the database. Once he created his acount he can now LogIn to his account.



If he presses LogIn button, it will take him to the UserLogIn page where he will put his User Id and Password there and press LogIn. This data will be checked with the data stored in database. If they match, User Specific Home Page will be opened where it has some new options including LogOut, user profile names as Hello, user.
If he want to view all the books of the library, then he will click View Books button which will take him View Books Page. There he will find all books and he can choose from them. He can also go to his profile by clicking Hello button and update his profile and also see his issued books.	



In case of  Admin, If he presses AdminLogIn button, it will take him to the AdminLogIn page where he will put his Id and Password there and press LogIn. This data will be checked with the data stored in database. If they match, Admin Specific Home Page will be opened where it has some new and additional options including Book Inventory, Issue Book, Member management, LogOut, Hello, Admin.


If he want to view all the books of the library, then he will click View Books button which will take him View Books Page. There he will find all books. He can click Book Ineventory button which will take him to the BookInventory page where all books resides. He can Add, Update, Delete any books. He can click Issue Book button which will take him to the IssueBook page where he can issue book to any certain user, see the issued book list, defaulters and also take back the books. He can also click Member Management button which will take him to the MemberManagement page where all members info resides. He can change status of any user, see their details and also see the list of all members and certainly can Delete any members he wants. He can also go to his profile by clicking Hello, admin button.
