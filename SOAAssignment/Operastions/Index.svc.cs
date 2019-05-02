using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAAssignment.Models;
using SOAAssignment.RequestObjects;

namespace SOAAssignment.Operastions
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Index" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Index.svc or Index.svc.cs at the Solution Explorer and start debugging.
    public class Index : ICars, ICustomers, ICompanies, ITransactions, IUsers
    {

        Cars CarsService = new Cars();
        Customers CustomersService = new Customers();
        Companies CompaniesService = new Companies();
        Transactions TransactionsService = new Transactions();
        Users UsersService = new Users();

        public Car[] ListCars(CarRequest Request = null)
        {
            return CarsService.ListCars(Request);
        }

        public Car CreateCar(Car Entity)
        {
            return CarsService.CreateCar(Entity);
        }

        public Car DeleteCar(int CardId)
        {
            return CarsService.DeleteCar(CardId);
        }

        public Car GetCar(int CardId)
        {
            return CarsService.GetCar(CardId);
        }

        public Car UpdateCar(Car Entity)
        {
            return CarsService.UpdateCar(Entity);
        }

        public Car[] ListAvailableCars(AviableCarRequest Request = null)
        {
            return CarsService.ListAvailableCars(Request);
        }

        public Customer[] ListCustomers(CustomerRequest Request = null)
        {
            return CustomersService.ListCustomers(Request);
        }

        public Customer CreateCustomer(Customer Entity)
        {
            return CustomersService.CreateCustomer(Entity);
        }

        public Customer DeleteCustomer(int CustomerdId)
        {
            return CustomersService.DeleteCustomer(CustomerdId);
        }

        public Customer GetCustomer(int CustomerdId)
        {
            return CustomersService.GetCustomer(CustomerdId);
        }

        public Customer UpdateCustomer(Customer Entity)
        {
            return CustomersService.UpdateCustomer(Entity);
        }

        public Company[] ListCompanies(CompanyRequest Request = null)
        {
            return CompaniesService.ListCompanies(Request);
        }

        public Company CreateCompany(Company Entity)
        {
            return CompaniesService.CreateCompany(Entity);
        }

        public Company DeleteCompany(int CompanydId)
        {
            return CompaniesService.DeleteCompany(CompanydId);
        }

        public Company GetCompany(int CompanydId)
        {
            return CompaniesService.GetCompany(CompanydId);
        }

        public Company UpdateCompany(Company Entity)
        {
            return CompaniesService.UpdateCompany(Entity);
        }

        public Transaction[] ListTransactions(TransactionRequest Request = null)
        {
            return TransactionsService.ListTransactions(Request);
        }

        public Transaction CreateTransaction(Customer Customer, Car Car, DateTime DateBegin, int NumDays)
        {
            return TransactionsService.CreateTransaction(Customer, Car, DateBegin, NumDays);
        }

        public Transaction DeleteTransaction(int TransactiondId)
        {
            return TransactionsService.DeleteTransaction(TransactiondId);
        }

        public Transaction GetTransaction(int TransactiondId)
        {
            return TransactionsService.GetTransaction(TransactiondId);
        }

        public Transaction UpdateTransaction(Transaction Entity)
        {
            return TransactionsService.UpdateTransaction(Entity);
        }

        public User[] ListUsers(UserRequest Request = null)
        {
            return UsersService.ListUsers(Request);
        }

        public User CreateUser(User Entity)
        {
            return UsersService.CreateUser(Entity);
        }

        public User DeleteUser(int UserdId)
        {
            return UsersService.DeleteUser(UserdId);
        }

        public User GetUser(int UserdId)
        {
            return UsersService.GetUser(UserdId);
        }

        public User UpdateUser(User Entity)
        {
            return UsersService.UpdateUser(Entity);
        }
    }
}
