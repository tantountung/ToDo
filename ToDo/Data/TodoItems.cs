using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Data
{
    public class TodoItems
    {
        //no 9, wait for input to no 8 in People Class.

        //a.Have a private static Person array declared and
        //instantiated as empty and not null (new Person[0]).

        private static string[] Todo = new string[0];

        //b.Add a method public int Size() that return the length of the array.

        public int TodoSize()
        {
            return Todo.Length;
        }

        //no 9, wait for input to no 8 in People Class.

        //public Todo[] FindByDoneStatus(bool doneStatus)
        //– Returns array with objects that has a matching done status.

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            return Array.Find<Todo>(Todo, true);
        }
        //public Todo[] FindByAssignee(int personId) –
        //Returns array with objects that has an assignee with a personId matching.

        public Todo[] FindByAssignee(int personId)
        {
            return Array.Find<Todo>(Todo[], Predicate < Todo)personId);
        }

        //public Todo[] FindByAssignee(Person assignee) –
        //Returns array with objects that has sent in Person.
        public Todo[] FindByAssignee(Person assignee)
        {
            return Array.Find<Todo>(Todo[], Predicate < Todo > Person assignee);
        }

        //public Todo[] FindUnassignedTodoItems() – 
        //Returns an array of objects that does not have an assignee set.
        public Todo[] FindUnassignedTodoItems()
        {
            return Array.Find<Todo>(Todo[], Predicate < Todo > Person assignee(0));
        }

        //Functionality to remove object from array. (not nulling)
        //First: you need to find the correct array index of the object.
        //Second: You need to rebuild array by excluding the object on found index.

        public RemoveObject()
        {
            int indexRemove = Array.IndexOf(Todo, value);

            for (int a = indexRemove; a < Todo.Length - 1; a++)
            {
                // moving elements downwards, to fill the gap at [index]
                Todo[a] = Todo[a + 1];
            }
            // finally, let's decrement Array's size by one
            return Array.Resize(ref Todo, Todo.Length - 1);

            
            
        }


    }
}
