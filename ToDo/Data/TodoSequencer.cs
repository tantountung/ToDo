using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Data
{
    public class TodoSequencer
    {
        private static int todoId;
        public static int NextTodoId()
        {

            todoId = todoId + 1;
            return todoId;

        }

       
        public static int Reset()
        {
            todoId = 0;
            return todoId;

        }
    }
}
