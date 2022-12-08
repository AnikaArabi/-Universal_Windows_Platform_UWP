using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeApp.Models
{
    public class TraineeRepo
    {
        ObservableCollection<Trainee> trainees;
        public TraineeRepo()
        {
            this.trainees = new ObservableCollection<Trainee>()
            {
                new Trainee{ Id= 1234989, Name="Maksuda Yesmin", Round="50", Course="C#", BatchID="CS/ACSL-A/50/01", Gender="Female", ClassStartDate=new DateTime(2022, 1, 31), Email="maksuda@gamil.com", Address="Mirpur, Dhaka-1206", isContinuing=true, Picture="Assets/Student01.jpg" },
                new Trainee{ Id= 1256679, Name="Jobaida Tasnim", Round="50", Course="ASP.NET", BatchID="ASP/ACSL-A/50/01", Gender="Female", ClassStartDate=new DateTime(2022, 1, 12), Email="jobaida@gamil.com", Address="Mirpur-2, Dhaka-1216", isContinuing=true, Picture="Assets/Student02.jpg" },
                new Trainee{ Id= 1298989, Name="Nuzat Tabassum", Round="50", Course="SQL Server", BatchID="SQL/ACSL-M/50/01", Gender="Female", ClassStartDate=new DateTime(2022, 1, 12), Email="tabassum@gamil.com", Address="Mohammadpur, Dhaka-1216", isContinuing=true, Picture="Assets/Student03.jpg" },
                new Trainee{ Id= 1267947, Name="Anika Arabi", Round="50", Course="C#", BatchID="CS/ACSL-A/50/01", Gender="Female", ClassStartDate=new DateTime(2022, 3, 10), Email="anikaarabi@gamil.com", Address="Ibrahimpur, Dhaka-1206", isContinuing=true,  Picture="Assets/Student04.jpg" },
                new Trainee{ Id= 1267986, Name="Md Reyad", Round="50", Course="NT", BatchID="NT/ACSL-A/50/01", Gender="Male", ClassStartDate=new DateTime(2022, 1, 31), Email="reyad@gamil.com", Address="Dhanmondi, Dhaka-1209", isContinuing=true, Picture="Assets/Student05.jpg" },
                new Trainee{ Id= 1278988, Name="Mahidul Molla", Round="50", Course="DDL", BatchID="DDL/ACSL-A/50/01", Gender="Male", ClassStartDate=new DateTime(2022, 1, 31), Email="mahidul@gamil.com", Address="Mohakhali, Dhaka", isContinuing=true, Picture="Assets/Student06.jpg" },
                new Trainee{ Id= 1289876, Name="Md Shakib", Round="50", Course="JEE", BatchID="JEE/ACSL-A/50/01", Gender="Male", ClassStartDate=new DateTime(2022, 1, 11), Email="shakib@gamil.com", Address="Motijhil, Dhaka-1206", isContinuing=true, Picture="Assets/Student07.jpg" },
                new Trainee{ Id= 1256897, Name="MA Sharif", Round="50", Course="ASP.NET", BatchID="ASP/ACSL-A/50/01", Gender="Male", ClassStartDate=new DateTime(2022, 2, 22), Email="sharif@gamil.com", Address="Gulshan, Dhaka-1216", isContinuing=true, Picture="Assets/Student08.jpg" },
                new Trainee{ Id= 1276856, Name="Md Musfiqur Rahman", Round="50", Course="GAVE", BatchID="GAVE/ACSL-A/50/01", Gender="Male", ClassStartDate=new DateTime(2022, 1, 11), Email="musfiq@gamil.com", Address="Lalbagh, Dhaka-1216", isContinuing=true, Picture="Assets/Student09.jpg" },
                new Trainee{ Id= 1298797, Name="Md Abdur Rahman", Round="50", Course="NT", BatchID="NT/ACSL-A/50/01", Gender="Male", ClassStartDate=new DateTime(2022, 3, 12), Email="abdurrahman@gamil.com", Address="Banani, Dhaka", isContinuing=true,  Picture="Assets/Student10.jpg" },
                new Trainee{ Id= 1287987, Name="Md Maruf Villah", Round="50", Course="JEE", BatchID="JEE/ACSL-A/50/01", Gender="Male", ClassStartDate=new DateTime(2022, 3, 12), Email="maruf@gamil.com", Address="Mohakhali, Dhaka", isContinuing=true, Picture="Assets/Student11.jpg" },
                new Trainee{ Id= 1276949, Name="Md Shoyeb", Round="50", Course="PHP", BatchID="PHP/ACSL-A/50/01", Gender="Male", ClassStartDate=new DateTime(2022, 1, 11), Email="shoyeb@gamil.com", Address="Dhanmondi, Dhaka-1209", isContinuing=true, Picture="Assets/Student12.jpg" },
                new Trainee{ Id= 1267957, Name="Md Hasan Ali", Round="50", Course="C#", BatchID="CS/ACSL-A/50/01", Gender="Male", ClassStartDate=new DateTime(2022, 3, 12), Email="hasanali@gamil.com", Address="Ibrahimpur, Dhaka-1206", isContinuing=true, Picture="Assets/Student13.jpg" },
                new Trainee{ Id= 1267959, Name="Md Nur Shakib", Round="50", Course="NT", BatchID="NT/ACSL-A/50/01", Gender="Male", ClassStartDate=new DateTime(2022, 2, 11), Email="nurshakib@gamil.com", Address="Motijhil, Dhaka-1216", isContinuing=true, Picture="Assets/Student14.jpg" },
                new Trainee{ Id= 1267961, Name="Md Asif Mustakim", Round="50", Course="C#", BatchID="CS/ACSL-A/50/01", Gender="Male", ClassStartDate=new DateTime(2022, 1, 12), Email="asif@gamil.com", Address="Ibrahimpur, Dhaka-1216", isContinuing=true, Picture="Assets/Student15.jpg" },
                new Trainee{ Id= 1267965, Name="Samiul Rahman Tanjid", Round="50", Course="NT", BatchID="NT/ACSL-A/50/01", Gender="Male", ClassStartDate=new DateTime(2022, 2, 12), Email="tanjidplays01@gamil.com", Address="Gulshan, Dhaka", isContinuing=false,  Picture="Assets/Student16.jpg" }
            };
        }
        public ObservableCollection<Trainee> Get()
        {
            return this.trainees;
        }
        public Trainee Get(int id)
        {
            return this.trainees.FirstOrDefault(t => t.Id == id);
        }
    }
}
