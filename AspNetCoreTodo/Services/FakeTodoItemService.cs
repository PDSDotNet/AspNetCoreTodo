using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;


namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Aprender ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(10)
            };

            var item2 = new TodoItem
            {
                Title = "Hacer impresionantes apps",
                DueAt = DateTimeOffset.Now.AddDays(100)
            };

            var item3 = new TodoItem
            {
                Title = "Ganar algunos morlacos con ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddYears(20)
            };

            return Task.FromResult(new[] { item1, item2, item3});
        }



        
    }
}
