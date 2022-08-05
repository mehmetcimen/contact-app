﻿using Core.Dto;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IContactRepository:IGenericRepository<Contact>
    {


        Task<List<Contact>> GetContactWithContactInformation();

       
        
   

    }
}
