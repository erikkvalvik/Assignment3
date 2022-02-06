# Assignment 3

## EF Core Code First

Database created with Code First approach in ASP.NET Core as specified in the assignment.

*Characters and movies*  
One **movie** contains many **characters**, and a **character** can play in multiple **movies**.  
Many-to-many relationship  

*Movies and franchises*  
One **movie** belongs to one **franchise**, but a **franchise** can contain many **movies**.  
One-to-many relationship.  

The database [Models](https://github.com/erikkvalvik/Assignment3/tree/main/Assignment3/Models) and [DbContext](https://github.com/erikkvalvik/Assignment3/blob/main/Assignment3/Models/CinemaDbContext.cs) files can be found in the [Models](https://github.com/erikkvalvik/Assignment3/tree/main/Assignment3/Models) folder.

This is how the database relationships look.

![Relationship Diagram for the database.](https://github.com/erikkvalvik/Assignment3/blob/main/Assets/RelationshipDiagram.png)  

The database gets seeded with 3 franchises, 7 movies and 10 characters.  

There is full CRUD operations for each table in the database.
 - [Movies](https://github.com/erikkvalvik/Assignment3/blob/main/Assignment3/Controllers/MovieController.cs)
 - [Characters](https://github.com/erikkvalvik/Assignment3/blob/main/Assignment3/Controllers/CharacterController.cs)
 - [Franchises](https://github.com/erikkvalvik/Assignment3/blob/main/Assignment3/Controllers/FranchiseController.cs)

 As well as Get functions for getting:
 - [All **movies** in a **franchise**](https://github.com/erikkvalvik/Assignment3/blob/main/Assignment3/Controllers/MovieFranchiseController.cs)
 - [All **characters** in a **movie**](https://github.com/erikkvalvik/Assignment3/blob/main/Assignment3/Controllers/CharacterMovieController.cs)

 Every model has data transfer objects [(DTO)](https://github.com/erikkvalvik/Assignment3/tree/main/Assignment3/Models/DTO)

 I did not manage to get everything to work. There is no functionality to get all **characters** in a **franchise**  
 or updating **characters** in a **movie** or updating **movies** in a **franchise**. 