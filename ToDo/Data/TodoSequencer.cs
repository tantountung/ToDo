using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Data
{
    public class TodoSequencer
    {
        private static int todoId;
        public static int NextTodoId(int todoId)
        {

            todoId = todoId + 1;
            return todoId;

        }

       
        public static int Reset(int todoId)
        {
            todoId = 0;
            return todoId;

        }
    }
}
