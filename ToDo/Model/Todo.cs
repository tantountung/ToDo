using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ToDo;

namespace ToDo.Model
{

    /*Create Todo class in the model folder
    a.Required private fields are todoId(int and readonly), description(String), done(bool) 
    and assignee(Person).
    b.Make a constructor that take in todoId(int) and a description(String).
    c.Unit test Todo class.
    d.Commit changes.*/

    public class Todo
    {
        private readonly int todoId;
        private string description;
        private bool done;
        private Person assignee;

        public Todo(int todoId, string description)
        {
            this.todoId = todoId;
            this.description = description;
        }

        public int TodoId
        {
            get { return todoId; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }


        }
    }
}
