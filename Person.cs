class Person
{
  // Data felter
  public String firstName;
  public String lastName;

  // Konstruktør
  // Dette er logikken for å lage en ny instanse av type
  public Person(String firstName, String lastName)
  {
    this.firstName = firstName;
    this.lastName = lastName;
  }

  // Metoder
  // Ting vi kan gjøre med denne typen
  public String GetFullName()
  {
    return firstName + " " + lastName;
  }
}
