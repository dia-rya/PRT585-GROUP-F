﻿using System;
namespace ToDoAPI.Models
{
    public class TodoContext
    {
        public class TodoContext : DbContext
        {
            public TodoContext(DbContextOptions<TodoContext> options)
                : base(options)
            {
            }

            public DbSet<TodoItem> TodoItems { get; set; }
        }
    }
}