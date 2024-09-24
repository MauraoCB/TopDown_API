﻿using System.Collections.Generic;
using ToDo_API.Models;

namespace ToDo_API.Repositories.Interfaces
{
    public   interface ITaskRepository
    {
        public void AddTask(Task task);
        public void UpdateTask(Task task);
        public Task GetTask(int id);
        public List<Task> GetAll();
        public void DeleteTask(int id);
       public void UpdateStatus(int id, string status);
    }
}
