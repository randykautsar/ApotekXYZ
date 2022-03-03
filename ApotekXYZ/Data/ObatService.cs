using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApotekXYZ.Data
{
    public class ObatService
    {
        #region Property
        private readonly AppDbContext _appDBContext;
        #endregion

        #region Constructor
        public ObatService(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Employees
        public async Task<List<Obat>> GetAllEmployeesAsync()
        {
            return await _appDBContext.Obat.ToListAsync();
        }
        #endregion

        #region Insert Employee
        public async Task<bool> InsertEmployeeAsync(Obat employee)
        {
            await _appDBContext.Obat.AddAsync(employee);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Employee by Id
        public async Task<Obat> GetEmployeeAsync(string Id)
        {
            Obat employee = await _appDBContext.Obat.FirstOrDefaultAsync(c => c.kodeObat.Equals(Id));
            return employee;
        }
        #endregion

        #region Update Employee
        public async Task<bool> UpdateEmployeeAsync(Obat employee)
        {
            _appDBContext.Obat.Update(employee);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteEmployee
        public async Task<bool> DeleteEmployeeAsync(Obat employee)
        {
            _appDBContext.Remove(employee);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}
