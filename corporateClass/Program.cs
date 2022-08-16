using corporateClass;

Company plop = new Company("Plop Inc.", new DateTime() );

Employee rick = new Employee();
rick.FirstName = "Rick";
rick.LastName = "Kersmarki";
rick.Title = "Manager";
rick.StartDate = DateTime.Now;

Employee polly = new Employee();
polly.FirstName = "Polly";
polly.LastName = "DuBose";
polly.Title = "Assistant to the Manager";
polly.StartDate = DateTime.Now; 

Employee ed = new Employee();
ed.FirstName = "Ed";
ed.LastName = "Kersmarki";
ed.Title = "Assitant to the Assitant to the Manager";
ed.StartDate = DateTime.Now;

List<Employee> plopEmployees = new List<Employee>();
plopEmployees.Add(rick);
plopEmployees.Add(polly);
plopEmployees.Add(ed);

foreach (Employee emp in plopEmployees)
{
    emp.ShowEmployee();
}


