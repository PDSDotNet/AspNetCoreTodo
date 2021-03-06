﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo.Services;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }


        public async Task<IActionResult> Index()
        {
            // Get to-do items from database
            // Put items into a model
            // Render view using the model
            var items = await _todoItemService.GetIncompleteItemsAsync();

            var model = new TodoViewModels()
            {
                Items = items
            };

            return View(model);
        }
    }
}