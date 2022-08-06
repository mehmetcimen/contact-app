using API.Controllers;
using AutoMapper;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.UnitTest
{
    public class ContactControllerTest
    {
         ContactsController _controller;
         IContactService _contactService;
       

        public ContactControllerTest(IContactService contactService, ContactsController controller)
        {
            _contactService = contactService;
            _controller = controller;
            
        }



        [Fact]
        public void GetAllTest()
        {
            //Arrange

            //Act
            var result = _controller.All();
           
            //Assert
            Assert.IsType<OkObjectResult>(result.Result);

            var list = result.Result as OkObjectResult;

            Assert.IsType<List<Contact>>(list.Value);

            var listContact = list.Value as List<Contact>;

            Assert.Equal(2, listContact.Count);
        }


        



    }
}
