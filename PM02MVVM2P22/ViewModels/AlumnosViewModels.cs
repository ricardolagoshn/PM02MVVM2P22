using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PM02MVVM2P22.ViewModels
{
    public class AlumnosViewModels : BaseViewModels
    {
        private int _id;
        private string _nombres;
        private string _apellidos;
        private string _sexo;
        private string _direccion;

        public int id
        {
            get { return this._id; }
            set { this._id = value; OnPropertyChanged(); }
        }

        public string nombres
        {
            get { return this._nombres; }
            set { this._nombres = value; OnPropertyChanged(); }
        }

        public string apellidos
        {
            get { return this._apellidos; }
            set { this._apellidos = value; OnPropertyChanged(); }
        }

        public string sexo
        {
            get { return this._sexo; }
            set { this._sexo = value; OnPropertyChanged(); }
        }

        public string direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; OnPropertyChanged(); }
        }

        public ICommand CleanCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }

        void Limpiar()
        {
            id = 0;
            nombres = String.Empty;
            apellidos = String.Empty;
            sexo = String.Empty;
            direccion = String.Empty;
        }


        void AddAlumn()
        {
            //SQlite
            // RestApi
        }

        async Task UpdateAlumn()
        {
            //SQlite
            // RestApi
          
        }

        public AlumnosViewModels()
        {
            CleanCommand = new Command(() => Limpiar());
            AddCommand = new Command(() => AddAlumn());
            //UpdateCommand = new Command(() => await UpdateAlumn());
        }
    }
}
