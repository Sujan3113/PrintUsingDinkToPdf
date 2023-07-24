using JsonEg.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace JsonEg
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EFDbContext _context;
        public EmployeeService(EFDbContext context)
        {
            _context = context;
        }

        public async Task AddEmployee()
        {
            var contactDetails = new ContactDetails()
            {
                Contacts = new Contacts()
                {
                    Phone = "9849803113",
                    Email = "bhujelsujan64@gmail.com"
                },
                Addresses = new List<Address>()
               {
                   new Address
                   {
                       AddressType="Current",
                       City="Ktm",
                       State="Bagmati",
                       Country="Nepal"
                   },
                   new Address
                   {
                       AddressType="permanent",
                       City="Okhaldhunga",
                       State="koshi",
                       Country="Napal"
                   }
               }
            };
            var employee = new Employee()
            {
                Id = 1,
                FullName = "Sujan Bhujel",
                ContactDetails = contactDetails
            };
            await _context.Employee.AddAsync(employee);
            await _context.SaveChangesAsync();
        }

        public async Task GetEmployee()
        {
            var data = await _context.Employee.ToListAsync();
            var json=JsonConvert.SerializeObject(data, Formatting.Indented);
            await Console.Out.WriteLineAsync(json);
        }
    }
}
