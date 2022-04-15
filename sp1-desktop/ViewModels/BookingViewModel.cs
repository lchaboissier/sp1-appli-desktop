using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using sp1_desktop.Models;

namespace sp1_desktop.ViewModels
{
    class BookingViewModel : ObservableObject
    {
        private List<Vehicle> _awaitingVehicles;
        private List<Vehicle> _completedVehicles;
        private Vehicle _selectedVehicle;
        // Properties and Getters/Setters: Action commands needed to be binded /registered to interact with the view BookingView
        private String _bookingsTitle;
        public RelayCommand FlushCommand { get; private set; }
        public RelayCommand<object> VehicleRowSelectedCommand { get; private set; }

        // Getters and Setters only for the datas
        public List<Vehicle> AwaitingVehicles
        {
            get
            {
                return _awaitingVehicles;
            }
            set
            {
                this.SetProperty(ref _awaitingVehicles, value);
            }
        }
        public List<Vehicle> CompletedVehicles
        {
            get
            {
                return _completedVehicles;
            }
            set
            {
                this.SetProperty(ref _completedVehicles, value);
            }
        }
        public Vehicle SelectedVehicle
        {
            get
            {
                return _selectedVehicle;
            }
            set
            {
                this.SetProperty(ref _selectedVehicle, value);
            }
        }
        public String BookingsTitle
        {
            get
            {
                return _bookingsTitle;
            }
            set
            {
                this.SetProperty(ref _bookingsTitle, value);
            }
        }
        // Constructor 

        public BookingViewModel()
        {
            Console.WriteLine("BookingViewModel - Constructor");

            // The default title of the products list of the selected category
            BookingsTitle = "Aucune réservation sélectionnée.";

            // Init the RelayCommands
            this.FlushCommand = new RelayCommand(FlushAction);
            this.VehicleRowSelectedCommand = new RelayCommand<object>(VehicleRowSelectedAction);
            // Get the datas for the view, ideally dynamically with a dropdown list
            this.AwaitingVehicles = Vehicle.ForClient(3,1,1);
            this.CompletedVehicles = Vehicle.ForClient(3,1,3);
        }

        // Object methods that interract with the actions commands
        private void FlushAction()
        {
            Console.WriteLine("StockViewModel - FlushAction");

            // Reload the datas for the view
            AwaitingVehicles = Vehicle.ForClient(3,1,1);
            CompletedVehicles = Vehicle.ForClient(3,1,3);
        }

        private void VehicleRowSelectedAction(object SelectedItem)
        {
            Console.WriteLine("StockViewModel - BookingRowSelectedAction");

            Console.WriteLine(((Vehicle)SelectedItem).Id);

            // Reload the datas for the view
            //SelectedVehicle = List<Vehicle>.Find(((Vehicle)SelectedItem).Id);
            BookingsTitle = "Détail de la réservation n° " + SelectedVehicle.Id;
        }
    }
}