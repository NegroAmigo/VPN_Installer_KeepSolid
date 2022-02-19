using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Windows.Forms;


namespace VPN_wpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num_of_frame = 1;
        string path_install = "";
        string path_shortcut = "VPN Unlimited";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void agree_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            button_next.IsEnabled = true;
        }

        private void disagree_radioButton_Checked(object sender, RoutedEventArgs e)
        {
            button_next.IsEnabled = false;
        }

        

        void Draw_Frame()
        {
            switch (num_of_frame)
            {
                case 1:

                    label1.Content = "License agreement";
                    label2.Content = "Please read the following important information before continuing.";
                    label3.Content = "Please read the following License Agreement. You must accept the terms of this \nagreement before continuing installation.";

                    agree_radioButton.IsChecked = true;
                    button_next.IsEnabled = true;
                    license_TextBox.Visibility = Visibility.Visible;
                    agree_radioButton.Visibility = Visibility.Visible;
                    disagree_radioButton.Visibility = Visibility.Visible;
                    back_button.Visibility = Visibility.Collapsed;
                    path_TextBox.Visibility = Visibility.Collapsed;
                    button_browse.Visibility = Visibility.Collapsed;
                    label_memory.Visibility = Visibility.Collapsed;
                    little_image.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    label1.Content = "Select destination Location";
                    label2.Content = "Where should VPN Unlimited be installed?";
                    label3.Content = "\tSetup will install VPN Inlimited into following folder.To continue, click Next. \nIf would like to select a different folder, click Browse..";

                    little_image.Source = new BitmapImage(new Uri(@"C:\Users\Andrew\Desktop\VPN_wpf2\logos\folder.png"));
                    little_image.Stretch = Stretch.Fill;

                    little_image.Visibility = Visibility.Visible;
                    license_TextBox.Visibility = Visibility.Collapsed;
                    agree_radioButton.Visibility = Visibility.Collapsed;
                    disagree_radioButton.Visibility = Visibility.Collapsed;
                    back_button.Visibility = Visibility.Visible;
                    path_TextBox.Visibility = Visibility.Visible;
                    button_browse.Visibility = Visibility.Visible;
                    label_memory.Visibility = Visibility.Visible;

                    path_TextBox.Text = path_install;

                    if (path_install == string.Empty) button_next.IsEnabled = false;
                    break;
                case 3:
                    label1.Content = "Select Start Menu Folder";
                    label2.Content = "Where should Setup place program`s shortcuts?";
                    label3.Content = "\tSetup will create program`s shortcut in the following Start Menu folder. \nTo continue, click Next. If would like to select a different folder, click Browse.";

                    little_image.Source = new BitmapImage(new Uri(@"C:\Users\Andrew\Desktop\VPN_wpf2\logos\start_menu.png"));
                    little_image.Stretch = Stretch.Fill;

                    little_image.Visibility = Visibility.Visible;
                    label_memory.Visibility = Visibility.Collapsed;
                    shortcut_CheckBox.Visibility = Visibility.Collapsed;
                    additional_label.Visibility = Visibility.Collapsed;
                    path_TextBox.Visibility = Visibility.Visible;
                    button_browse.Visibility = Visibility.Visible;
                    path_TextBox.Text = path_shortcut;
                    break;
                case 4:
                    label1.Content = "Select Additional Tasks";
                    label2.Content = "Which additional tasks should be performed?";
                    label3.Content = "Select the additional tasks you would like Setup to perform while installing VPN\nUnlimited, then click Next\n\nAdditional shortcuts:";

                    little_image.Visibility = Visibility.Collapsed;
                    path_TextBox.Visibility = Visibility.Collapsed;
                    button_browse.Visibility = Visibility.Collapsed;
                    label_memory.Visibility = Visibility.Collapsed;
                    final_TextBox.Visibility = Visibility.Collapsed;
                    shortcut_CheckBox.Visibility = Visibility.Visible;
                    additional_label.Visibility = Visibility.Visible;
                    
                    break;

                case 5:
                    label1.Content = "Ready to Install";
                    label2.Content = "Setup is now ready to begin installing VPN Unlimited on your computer.";
                    label3.Content = "Click Install to continue with installation, or click Back if you want to review or\nchange any settings.";

                    final_TextBox.Text = "Destination location:\n\t" + path_install + "\n\nStart Menu folder:\n\t" + path_shortcut;
                    if ((bool)shortcut_CheckBox.IsChecked) final_TextBox.Text += "\n\nAdditional tasks:\n\tAdditional shortcuts:\n\t\tCreate a desktop shortcut";
                    shortcut_CheckBox.Visibility = Visibility.Collapsed;
                   
                    additional_label.Visibility = Visibility.Collapsed;
                    final_TextBox.Visibility = Visibility.Visible;

                    break;
                case 6:
                    label1.Content = "Completing The VPN\nUnlimited setup Wizard";
                    label3.Content = "Setup has finished installing VPN Unlimited on your \ncomputer. The application may be launched by selecting \nthe installed shortcuts.\n\nClick finish to exit Setup";

                    label1.FontSize = 18;

                    button_next.Content = "Finish";

                    logo_image.Source = new BitmapImage(new Uri(@"C:\Users\Andrew\Desktop\VPN_wpf2\logos\big_logo.png"));
                    logo_image.Stretch = Stretch.Fill;
                    logo_image.Width = 140;
                    logo_image.Height = 260;
                    logo_image.Margin = new Thickness(0, 50, 0, 0);

                    final_TextBox.Visibility = Visibility.Collapsed;
                    launch_CheckBox.Visibility = Visibility.Visible;
                    back_button.Visibility = Visibility.Collapsed;
                    button_cancel.Visibility = Visibility.Collapsed;

                    panel_high.Margin = new Thickness(150, 30, 0, 0);
                    rectangle.Visibility = Visibility.Collapsed;
                    label3.Margin = new Thickness(120, 5, 0, 0);
                    label3.Height = 120;
                 
                    break;
                case 7:
                    System.Windows.Application.Current.Shutdown();
                    break;
            }
        }

        private void button_next_Click(object sender, RoutedEventArgs e)
        {
            num_of_frame++;
            Draw_Frame();
        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            if (num_of_frame > 1)
            {
                num_of_frame--;
                Draw_Frame();
            }
            
        }

        private void button_browse_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog openFileDlg = new System.Windows.Forms.FolderBrowserDialog();
            var result = openFileDlg.ShowDialog();
            if (result.ToString()!=null)
            {
                if (num_of_frame == 2) path_install = openFileDlg.SelectedPath;
                if (num_of_frame == 3) path_shortcut = openFileDlg.SelectedPath;
                path_TextBox.Text = openFileDlg.SelectedPath;
                button_next.IsEnabled = true;
            }
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Setup is not complete. If you exit now, the program will not be installed.\tYou may run Setup again at another time to complete the installation.\n\nExit Setup?",
                    "Exit Setup",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        
    }
}
