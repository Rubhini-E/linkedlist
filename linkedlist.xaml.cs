using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace generic
{
    /// <summary>
    /// Interaction logic for linkedlist.xaml
    /// </summary>
    public partial class linkedlist : Window
    {
        public linkedlist()
        {
            InitializeComponent();
            cmb1.Items.Add("Rubhini");
            cmb1.Items.Add("Uma");
            cmb1.Items.Add("Prakash");
            cmb1.Items.Add("Anand");
            cmb2.ItemsSource = cmb1.Items;

            //lst.AddFirst("Rubhini");
            //lst1.AddFirst("Uma");
            //lst2.AddFirst("Prakash");
            //lst3.AddFirst("Anand");
        }
        LinkedList<string> lst = new LinkedList<string>();
        LinkedList<string> lst1 = new LinkedList<string>();
        LinkedList<string> lst2 = new LinkedList<string>();
        LinkedList<string> lst3 = new LinkedList<string>();

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
                    

            if (cmb1.SelectedItem=="Rubhini")
            {
              //  LinkedListNode<string> pos = lst.Find("Rubhini");
                lst.AddLast(txtname.Text);
            }
           else if (cmb1.SelectedItem == "Uma")
            {
              //  LinkedListNode<string> pos = lst1.Find("Uma");
                lst1.AddLast(txtname.Text);
            }
          else if (cmb1.SelectedItem == "Prakash")
            {
                // LinkedListNode<string> pos = lst2.Find("Prakash");
                //lst2.AddAfter(pos, txtname.Text);
                lst2.AddLast(txtname.Text);
            }
           else if (cmb1.SelectedItem == "Anand")
            {
                // LinkedListNode<string> pos = lst3.Find("Anand");
                // lst3.AddAfter(pos, txtname.Text);
                lst3.AddLast(txtname.Text);
            }

            
           MessageBoxResult res= MessageBox.Show("Registered Successfully","Success",MessageBoxButton.OK,MessageBoxImage.Information);
            
                if(res== MessageBoxResult.OK)
                  {
                     txtname.Clear();
                     cmb1.SelectedItem = null;
                  }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string val = "";

            if (cmb2.SelectedItem == "Rubhini")
            {
                foreach (var item in lst)
                {
                    val += item + "\n";
                }
                MessageBox.Show(val,"Rubhini");

            }
           else if (cmb2.SelectedItem == "Uma")
            {
                foreach (var item in lst1)
                {
                    val += item + "\n";
                }
                MessageBox.Show(val,"Uma");

            }
            else if (cmb2.SelectedItem == "Prakash")
            {
                foreach (var item in lst2)
                {
                    val += item + "\n";
                }
                MessageBox.Show(val,"Prakash");

            }
           else  if (cmb2.SelectedItem == "Anand")
            {
                foreach (var item in lst3)
                {
                    val += item + "\n";
                }
                MessageBox.Show(val,"Anand");

            }
        }
    }
}
