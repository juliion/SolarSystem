# "Guide to the Solar System"
---
**The idea**: to make an application that will serve as an educational application
a guide to the Solar System (like a Tourist Guide, but within space),
where there will be all the information about the planets, their satellites and the star.

*The application interface allows:*

- Choose a space object and find out
  its main characteristics.
For a star:
- Photo;
- Age;
- Diameter;
- Mass;
- Absolute magnitude;
- Surface temperature.
For the planet:
- Photo;
- Away from the Sun;
- Diameter;
- Duration of the year;
- Length of day;
- Companions (if any).
For satellite:
- Photo;
- Age;
- Diameter;
- Visible magnitude.

- Learn interesting facts and interesting information,
  about the selected object. Each object has a document (FlowDocument),
  with the necessary information.

*Expansion possibilities:*
Since the application is flexible, it is built dynamically and there is no rigid binding
to space objects, it can be extended for other planetary systems.
Currently, only our solar system is described in it.
Also, in the future, it would be good to apply graphics, for greater clarity.

The MVVM pattern was used to build the architecture.
All data is stored in the database, Entity Framework (code first) is used as ORM.
