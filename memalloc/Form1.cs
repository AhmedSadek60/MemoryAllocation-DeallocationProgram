using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memalloc
{
    public partial class Form1 : Form
    {
        int MemorySize,NumHoles,NumProcesses; 
        string algorithm;
        ArrayList Holes_list = new ArrayList();
        ArrayList Process_list = new ArrayList();

        

        public Form1()
        {
            InitializeComponent();
        }

        public int Best_fit(int process_index)
        {
            int index = 0;
            int minsize = 0;
            int diff;
            for (int j = 0; j < NumHoles; j++)
            {
                if (((Hole)Holes_list[j]).filled == false)
                {
                    diff = ((Hole)Holes_list[j]).size - ((Process)Process_list[process_index]).size;
                    if (j == 0)
                    {
                        if (diff == 0)
                        {
                            ((Hole)Holes_list[j]).assigned_process = (Process)Process_list[process_index];
                            ((Process)Process_list[process_index]).my_hole = (Hole)Holes_list[j];
                            ((Hole)Holes_list[j]).filled = true;
                            break;
                        }
                        else if (diff > 0)
                        {
                            minsize = diff;
                            index = j;
                        }
                        else
                        {
                            minsize = ((Process)Process_list[process_index]).size;
                        }
                    }
                    else
                    {
                        if (diff == 0)
                        {
                            ((Hole)Holes_list[j]).assigned_process = (Process)Process_list[process_index];
                            ((Process)Process_list[process_index]).my_hole = (Hole)Holes_list[j];
                            ((Hole)Holes_list[j]).filled = true;
                            break;
                        }
                        if (diff > 0 && Math.Abs(diff) < minsize)
                        {
                            minsize = diff;
                            index = j;
                        }
                    }
                }

            }
            return index;
        }
       
        private void StartBtn_Click(object sender, EventArgs e)
        {
            MemorySize = int.Parse(memory_size.Text);
            NumHoles = int.Parse(number_holes.Text);
            NumProcesses = int.Parse(number_processes.Text);
            algorithm = algorithm_type.Text;
            string processsizes = size_processes.Text;
            string[] process_sizes_array = processsizes.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string holesizes = size_holes.Text;
            string[] hole_sizes_array = holesizes.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string startingaddresses = starting_addresses.Text;
            string[] starting_addresses_array = startingaddresses.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i<NumHoles;i++)           // insert Hole objects into Holes Arraylist 
            {
                Hole temp = new Hole(int.Parse(hole_sizes_array[i]), int.Parse(starting_addresses_array[i])) ;
                Holes_list.Add(temp);
            }

            for (int i = 0; i < NumProcesses; i++)             //  insert Process objects into Processes Arraylist
            {
                Process temp1 = new Process(int.Parse(process_sizes_array[i]),"p"+(i+1));
                Process_list.Add(temp1);
            }

            if (algorithm == "First Fit")
            {
                for (int i = 0; i < NumProcesses; i++)
                {
                    for (int j = 0;j < NumHoles; j++)
                    {
                        if(((Hole)Holes_list[j]).filled==false)            // if this hole is free
                        {
                            if (((Hole)Holes_list[j]).size >= ((Process)Process_list[i]).size)      // if the process can fit in this hole
                            {
                                ((Hole)Holes_list[j]).assigned_process = (Process)Process_list[i];      // assign the process to this hole
                                ((Process)Process_list[i]).my_hole = (Hole)Holes_list[j];               // process save the hole which it fills
                                ((Hole)Holes_list[j]).filled = true;
                                break;
                            }
                        }

                    }
                    

                }

            }

            else if (algorithm == "Best Fit")
            {
                for (int i = 0; i < Process_list.Capacity; i++)
                {
                    int index;
                    index = Best_fit(i);
                    ((Hole)Holes_list[index]).assigned_process = (Process)Process_list[i];
                    ((Process)Process_list[i]).my_hole = (Hole)Holes_list[index];
                    ((Hole)Holes_list[index]).filled = true;
                }

            }

             for (int i = 0; i < NumHoles; i++)           // print the state of holes if a process fills it or it is free
             {

                // listBox1.Items.Add(((Process)Process_list[i]).get_size());
                
               if(((Hole)Holes_list[i]).filled==false)
                    listBox1.Items.Add("free hole");
                else
                    listBox1.Items.Add(((Hole)Holes_list[i]).assigned_process.name);

             }

        }



        private void AllocateBtn_Click(object sender, EventArgs e)
        {
           

            int process_index = int.Parse(Process_to_Allocate.Text)-1;


            if (algorithm == "Best Fit")
            {
                int index;
                index = Best_fit(process_index);
                ((Hole)Holes_list[index]).assigned_process = (Process)Process_list[process_index];
                ((Process)Process_list[process_index]).my_hole = (Hole)Holes_list[index];
                ((Hole)Holes_list[index]).filled = true;
            }



            else if (algorithm == "First Fit")
            {
                for (int j = 0; j < NumHoles; j++)
                {
                    if (((Hole)Holes_list[j]).filled == false)
                    {
                        if (((Hole)Holes_list[j]).size >= ((Process)Process_list[process_index]).size)
                        {
                            ((Hole)Holes_list[j]).assigned_process = (Process)Process_list[process_index];
                            ((Process)Process_list[process_index]).my_hole = (Hole)Holes_list[j];
                            ((Hole)Holes_list[j]).filled = true;
                            break;
                        }
                    }

                }



            }
            for (int i = 0; i < NumHoles; i++)
            {

                // listBox1.Items.Add(((Process)Process_list[i]).get_size());

                if (((Hole)Holes_list[i]).filled == false)
                    listBox1.Items.Add("free hole");
                else
                    listBox1.Items.Add(((Hole)Holes_list[i]).assigned_process.name);

            }



            Process_to_Allocate.Text = "process to allocate...";
        }


        private void DeallocateBtn_Click(object sender, EventArgs e)
        {
            int process_index = int.Parse(Process_to_Deallocate.Text)-1;


            ((Process)Process_list[process_index]).my_hole.filled=false;        
            //((Process)Process_list[process_index]).my_hole.assigned_process = null;


            for (int i = 0; i < NumHoles; i++)
            {

                // listBox1.Items.Add(((Process)Process_list[i]).get_size());

                if (((Hole)Holes_list[i]).filled == false)
                    listBox1.Items.Add("free hole");
                else
                    listBox1.Items.Add(((Hole)Holes_list[i]).assigned_process.name);

            }

            Process_to_Deallocate.Text = "process to allocate...";
        }

        private void Process_to_Allocate_Enter(object sender, EventArgs e)
        {
            Process_to_Allocate.Text = "";
        }

        private void Process_to_Deallocate_Enter(object sender, EventArgs e)
        {
            Process_to_Deallocate.Text = "";
        }

    }
}
