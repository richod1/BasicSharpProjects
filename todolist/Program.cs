using System;
using System.Collections.Generic;
namespace TodoList{
    public class TodoList{
        // creating list with generic
        static List<string> tasks=new List<string>();
        public static void Main(String[] args){
            Console.WriteLine("Welcome to console Todolist");

            while(true){
                Console.WriteLine("\n1.Add Task");
                Console.WriteLine("2. View Task");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit");


                Console.Write("Choose an option: ");
                string option=Console.ReadLine();


                switch(option){
                    case "1":
                    AddTask();
                    break;
                    case "2":
                    ViewTask();
                    break;
                    case "3":
                    RemoveTask();
                    break;
                    case "4":
                    return;
                    default:
                    Console.WriteLine("Invalid Input!");
                    break;
                    
                    
                }
            }
        }
        static void AddTask(){
            Console.WriteLine("Enter a new task ");
            string task=Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added!");
        }
        static void ViewTask(){
            Console.WriteLine("\nTo-Do List");
            for(int i=0;i<tasks.Count;i++){
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
        static void RemoveTask(){
            ViewTask();
            Console.Write("Enter the number of task to remove :");
            int taskNumber;
            if(int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber > 0 && taskNumber <=tasks.Count){
                tasks.RemoveAt(taskNumber -1);
                Console.WriteLine("Task removed!");
            }else{
                Console.WriteLine("Invalid task number !");
            }
        }
    }
}