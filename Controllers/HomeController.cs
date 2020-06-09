using Microsoft.AspNetCore.Mvc;
using ModelFun.Models;
using System;
using System.Collections.Generic;

namespace ModelFun.Controllers     //be sure to use your own project's namespace!
    {
        public class HomeController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public ViewResult Index()
            {
                string[] message=new string[]{
                    "Hello there!",
                    "Welcome to my webpage!",
                    "Nice to see you!"
                    
                };
            
                return View(message);
            }
            
            [HttpGet]
            [Route("numbers")]

            public ViewResult Numbers()
            {
                int[] numbers=new int[]{
                    1,2,3,4,5,6,7,8,9,10
                };

                return View(numbers);
            }

            [HttpGet]
            [Route("users")]

            public ViewResult Users()
            {
                
            List<User> users = new List<User>();
            User user1=new User(){
                firstName="Summer",
                lastName="Bakr"

            };

            User user2 = new User(){
                firstName="Lia",
                lastName="Zappala"

            };

            User user3= new User(){
                firstName="Ben",
                lastName="Taylor"

            };

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);




                return View(users);
            }

            [HttpGet]
            [Route("user")]

            public ViewResult User()
            {
                
            User user1=new User(){
                firstName="Summer",
                lastName="Bakr"

            };

            




                return View(user1);
            }

        }
    }