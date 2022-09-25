// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

namespace tictactoe // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            
            string[] numbers= {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
            List<string> nums= new List<string>();
            nums.AddRange(numbers);


            // Program p = new Program();
            // p.message(nums);
            int counter= 1;
            int runner =1;
            while (runner != 100){
                message(nums);
                Console.Write("Enter the number you want to change into your symbol.");
                string choice= Console.ReadLine();
                List<string> n = the_play(nums, choice, counter);
                counter = counter+1;
                runner= result(nums);
                Console.WriteLine(result(nums));
                nums=n;
                
               
            }
            message(nums);
             Console.WriteLine($"You won the game");
            
        }

        

        

        static void message(List<string> nums )
            {
            Console.WriteLine("This is multiplayer Tic-Tac_Toe");
            Console.WriteLine("Happy to have you here.");
            int a = 0;
            int b = 0;
            int c = 0;

        foreach (string numbs in nums){

            string st = numbs;
            int i1 = nums.IndexOf(numbs);
            int divider = i1%2;

            b= b+1;

            if (b ==2 || b==3 || b ==5 || b ==6|| b==8|| b==9 ){
                Console.Write(" | ");            
            }
            Console.Write(st);

            a = a+1;
            if ( a == 3 || a== 6){
                Console.Write("\n---+---+---\n");
             }
             
             
        }
        }
        static List<string> the_play(List<string> nums, string choice, int counter ){
            //List<string> numbers= new List<string>();
            //numbers.AddRange(nums);
                foreach (string parms in nums.ToList()){
                    if (parms==choice){
                        var index= nums.IndexOf(choice);
                        int Turn= counter%2;
                        if (Turn==1){
                            nums[index]= "x";
                        }
                        else{
                            nums[index]="o";
                        }
                    }
                    }



                    return nums;

                    }
            
            
        static int result(List<string> nums){
            int res = 0;
            //foreach( string parm in nums.ToList()){
                string parm="x";
                if (nums[0]=="x" && nums[1]=="x"  && nums[2]=="x" ){
                    res =100;
                }
                else if (nums[0]=="x"  && nums[4]=="x"  && nums[8]=="x" ){
                    res= 100;
                    }
                else if (nums[0]=="x"  && nums[3]=="x"  && nums[6]=="x" ){
                    res = 100;}
                else if (nums[1]=="x"  && nums[4]=="x"  && nums[7]=="x" ){
                    res = 100;
                }
                else if (nums[2]=="x"  && nums[5]=="x"  && nums[8]=="x" ){
                    res =100;
                }
                else if (nums[3]=="x"  &&nums[4]=="x"  && nums[5]=="x" ){
                    res =100;
                }
                else if (nums[6]=="x"  && nums[7]=="x"  && nums[8]=="x" ){
                    res =100;
                }
                else if (nums[8]=="x"  &&nums[4]=="x"  && nums[0]=="x" ){
                    res =100;
                }
                
            //}
                else if(nums[0]=="o" && nums[1]=="o"  && nums[2]=="o" ){
                    res =100;
                }
                else if (nums[0]=="o"  && nums[4]=="o"  && nums[8]=="o" ){
                    res= 100;
                    }
                else if (nums[0]=="o"  && nums[3]=="o"  && nums[6]=="o" ){
                    res = 100;}
                else if (nums[1]=="o"  && nums[4]=="o"  && nums[7]=="o" ){
                    res = 100;
                }
                else if (nums[2]=="o"  && nums[5]=="o"  && nums[8]=="o" ){
                    res =100;
                }
                else if (nums[3]=="o"  &&nums[4]=="o"  && nums[5]=="o" ){
                    res =100;
                }
                else if (nums[6]=="o"  && nums[7]=="o"  && nums[8]=="o" ){
                    res =100;
                }
                else if (nums[8]=="o"  &&nums[4]=="o"  && nums[0]=="o" ){
                    res =100;
                }
                else{
                    res =0;
                }

            
            return res;
        }      


                
        //         }
        //     return nums;
        }

}
