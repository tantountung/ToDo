using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Model;

namespace ToDo.Data
{
    public class TodoItems
    {
        //a.Have a private static Person array declared and
        //instantiated as empty and not null (new Person[0]).

        private static Todo[] todoitems = new Todo[0];

        //b.Add a method public int Size() that return the length of the array.

        public int Size()
        {
            return todoitems.Length;
        }

        // Add a method public Person[] FindAll() that return the Person array.
        public Todo[] FindAll()
        {
            return todoitems;
        }

        //d.Add a method public Person FindById(int personId) that return
        //the person that has a matching personId as the passed in parameter.

        public Todo FindById(int todoId)
        {
            for (int i = 0; i < todoitems.Length; i++)
            {
                if (todoitems[i].TodoId == todoId)
                {
                    return todoitems[i];
                }
            }
            return null;

        }

        //e.Add a method that creates a new Person, adds the newly created object in the array
        //and then return the created object. You have to “expand” the Person array.
        //(tip: send in parameters needed to create the Person object and
        //use the PersonSequencer to give a unique personId)

        public Todo AddNewTodo(string description)
        {
            Todo todo1item = new Todo(TodoSequencer.NextTodoId(), description);
            Array.Resize<Todo>(ref todoitems, todoitems.Length + 1);
            todoitems[todoitems.Length - 1] = todo1item;
            return todo1item;
        }


        //f.Add a method public void Clear() that clears all Person objects from the Person array.

        public void Clear()
        {
            Array.Clear(todoitems, 0, todoitems.Length);
        }

        //public Todo[] FindByDoneStatus(bool doneStatus)
        //– Returns array with objects that has a matching done status.

        public Todo FindByDoneStatus(bool doneStatus)
        {


            for (int i = 0; i < todoitems.Length; i++)
            {
                if (todoitems[i].doneStatus.Equals(doneStatus))
                {
                    return todoitems[i];
                }
            }
            return null;
        }


        //public Todo[] FindByAssignee(int personId) –
        //Returns array with objects that has an assignee with a personId matching.

        public Todo FindByAssignee(int personId)
        {
            for (int i = 0; i < todoitems.Length; i++)
            {
                if (todoitems[i].assignee.PersonId == personId)
                {
                    return todoitems[i];
                }
            }
            return null;
        }

        //public Todo[] FindByAssignee(Person assignee) –
        //Returns array with objects that has sent in Person.
        public Todo FindByAssignee(Person assignee)
        {
            for (int i = 0; i < todoitems.Length; i++)
            {
                if (todoitems[i].assignee == assignee)
                {
                    return todoitems[i];
                }
            }
            return null;

            //return Array.Find<Todo>(Todo[], Predicate < Todo > Person assignee);
            //not time yet to use 'predicate'
        }

        //public Todo[] FindUnassignedTodoItems() – 
        //Returns an array of objects that does not have an assignee set.
        public Todo FindUnassignedTodoItems()//Todo[] changed to Todo since return todoitems[i] is not compatible with return type
        {
            
            for (int i = 0; i < todoitems.Length; i++)
            {
                if (todoitems[i].assignee == null)
                {
                    return todoitems[i];
                }
            }
            return null;

            //return Array.Find<Todo>(Todo[], Predicate < Todo > Person assignee(0));
        }

        //Functionality to remove object from array. (not nulling)
        //First: you need to find the correct array index of the object.
        //Second: You need to rebuild array by excluding the object on found index.

        public Todo RemoveObject()
        {
            
            
            Todo todo1item = new Todo(TodoSequencer.NextTodoId(), description);
            Array.Resize<Todo>(ref todoitems, todoitems.Length + 1);
            todoitems[todoitems.Length - 1] = todo1item;
            return todo1item;


            //int indexRemove = Array.IndexOf(Todo, value);

            //for (int a = indexRemove; a < Todo.Length - 1; a++)
            //{
            //    // moving elements downwards, to fill the gap at [index]
            //    Todo[a] = Todo[a + 1];
            //}
            //// finally, let's decrement Array's size by one
            //return Array.Resize(ref Todo, Todo.Length - 1);



        }


    }
}
