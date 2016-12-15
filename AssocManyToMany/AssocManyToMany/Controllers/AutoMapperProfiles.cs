using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssocManyToMany.Controllers
{
    // ATTENTION 00: AUTOMAPPER 5.0 Guide:
    // ATTENTION 01: New way! Put legacy Mapper.CreateMap(s) into a seprate profile like so...(below!)
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Example:
            // CreateMap<Source, Destination>();

            //CreateMap<Employee, EmployeeBase>();
            //CreateMap<Employee, EmployeeWithJobDuties>();
            //CreateMap<Controllers.EmployeeBase, Controllers.EmployeeEditJobDutiesForm>();
            //CreateMap<Models.JobDuty, Controllers.JobDutyBase>();
            //CreateMap<Models.JobDuty, Controllers.JobDutyWithEmployees>();
            //CreateMap<Controllers.JobDutyBase, Controllers.JobDutyEditEmployeesForm>();
        }
    }
}