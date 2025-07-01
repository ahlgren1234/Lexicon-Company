﻿using AutoMapper;
using Domain.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<ICompanyService> companyService;
    private readonly Lazy<IEmployeeService> employeeService;

    public ICompanyService CompanyService => companyService.Value;
    public IEmployeeService EmployeeService => employeeService.Value;

    //public ServiceManager(IUnitOfWork uow, IMapper mapper)
    //{
    //    ArgumentNullException.ThrowIfNull(nameof(uow));

    //    companyService = new Lazy<ICompanyService>(() => new CompanyService(uow, mapper));

    //    employeeService = new Lazy<IEmployeeService>(() => new EmployeeService(uow, mapper));
    //}

    public ServiceManager(Lazy<ICompanyService> companyservice, Lazy<IEmployeeService> employeeservice)
    {
        companyService = companyservice;
        employeeService = employeeservice;
    }
}
