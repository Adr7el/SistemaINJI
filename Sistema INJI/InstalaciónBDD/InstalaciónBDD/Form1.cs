using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InstalaciónBDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=" + "localhost" + ";" + "database=master; integrated security=yes");
            string CrearDB = "CREATE DATABASE " + "BDINJI";
            string tGrados = "USE BDINJI;" + "Create Table Grados(" +
                             "IDgrado int IDENTITY(1,1)," +
                             "Grado varchar (20)," +
                             "Constraint PK_Grado Primary Key(IDgrado));";

            string tAutores = "USE BDINJI;" + "Create table Autores(" +
                "IDautor int IDENTITY(1,1) Primary key," +
                "Nombrecompleto varchar(60)); ";

            string tAlumnos = "USE BDINJI;" + "Create Table Alumnos(" +
                                "NIE int NOT NULL," +
                                "Nombre1 varchar(25)," +
                                "Nombre2 varchar(25)," +
                                "Apellido1 varchar(25)," +
                                "Apellido2 varchar(25)," +
                                "Idgrad int," +
                                "Constraint PK_Alumno Primary Key(NIE)," +
                                "Constraint FK_grado Foreign Key(IDgrad) References Grados(IDgrado) ON UPDATE CASCADE ON DELETE CASCADE);";

            string tDistribuciones = "USE BDINJI;" + "Create Table Distribuciones(" +
                                        "IDdistribucion int IDENTITY(1, 1) Primary key," +
                                         "Nombre varchar(50)," +
                                        "Pais varchar(15)); ";

            string tCategorias = "USE BDINJI;" + "Create Table Categorias(" +
                                   " IDcategoria int IDENTITY(1, 1) ," +
                                    "Nombre varchar(50)," +
                                   " Descripcion varchar(150)," +
                                    "Constraint PK_categoria Primary Key(IDcategoria));";

            string tLibros = "USE BDINJI;" + "Create Table Libros(" +
                                "IDlibro varchar(15) NOT NULL Primary Key," +
                                "Titulo varchar(50)," +
                                "Editorial varchar(20)," +
                                "Stock int," +
                                "Ubicacion varchar(20)," +
                                "IDdistri int Foreign Key(IDdistri) References Distribuciones(IDdistribucion)," +
                                "IDcate int Foreign Key(IDcate) References Categorias(IDcategoria) ON UPDATE CASCADE ON DELETE CASCADE);";


            string Autores_Libros = "USE BDINJI;" + "Create Table Autores_Libros(" +
                                    "ID_libro varchar(15) NOT NULL Foreign Key(ID_libro) References Libros(IDlibro)," +
                                   " ID_autor int IDENTITY(1, 1) Foreign Key(ID_autor) References Autores(IDautor));";

            string Bibliotecario = "USE BDINJI;" + "Create Table Bibliotecarios(" +
                                        "IDbibliotecario int IDENTITY(1, 1)," +
                                        "nombre1 varchar(25)," +
                                        "nombre2 varchar(25)," +
                                        "apellido1 varchar(25)," +
                                        "apellido2 varchar(25)," +
                                        "usuario varchar(20)," +
                                        "contraseña varchar(15)," +
                                        "Constraint PK_bibliotecario Primary Key(IDbibliotecario));";


            string Prestamos = "USE BDINJI;" + "Create Table Prestamos(" +
                                "IDprestamo int IDENTITY(1, 1) ," +
                                "ID_libro varchar(15) NOT NULL Foreign Key(ID_libro) References Libros(IDlibro)," +
                                "NombreLibro varchar(50)," +
                                "NIEprestamo int NOT NULL," +
                                "NombreAlumno1 varchar(25)," +
                                "NombreAlumno2 varchar(25)," +
                                "ApellidoAlumno1 varchar(25)," +
                               "ApellidoAlumno2 varchar(25)," +
                                "IDgra int," +
                                "IDBibliotecarioPrestamo int," +
                                "Fecha_entrega varchar(40)," +
                                "Fecha_devolucion varchar(40)," +
                                "Constraint PK_Prestamo Primary Key(IDPrestamo)," +
                                "Constraint FK_NIEPrestamo Foreign Key(NIEPrestamo) References Alumnos(NIE)," +
                                "Constraint FK_BibliotecarioPrestamo Foreign Key(IDBibliotecarioPrestamo) References Bibliotecarios(IDBibliotecario)ON UPDATE CASCADE ON DELETE CASCADE);";

            string InsertarBibliotecaria = "USE BDINJI;" + "insert into Bibliotecarios values('Gilma','Maria','Argueta','Hernandez','Gilma','12345')insert into Autores values ('gerardo')";
            string InsertarGrado1 = "USE BDINJI;" + "insert into Grados values ('1er año A')";
            string InsertarGrado2 = "USE BDINJI;" + "insert into Grados values ('1er año B')";
            string InsertarGrado3 = "USE BDINJI;" + "insert into Grados values ('1er año C')";
            string InsertarGrado4 = "USE BDINJI;" + "insert into Grados values ('1er año D')";
            string InsertarGrado5 = "USE BDINJI;" + "insert into Grados values ('1er año E')";
            string InsertarGrado6 = "USE BDINJI;" + "insert into Grados values ('1er año F')";
            string InsertarGrado7 = "USE BDINJI;" + "insert into Grados values ('1er año G')";
            string InsertarGrado8 = "USE BDINJI;" + "insert into Grados values ('1er año H')";

            string InsertarGrado9 = "USE BDINJI;" + "insert into Grados values ('2do año A')";
            string InsertarGrado10 = "USE BDINJI;" + "insert into Grados values ('2do año B')";
            string InsertarGrado11 = "USE BDINJI;" + "insert into Grados values ('2do año C')";
            string InsertarGrado12 = "USE BDINJI;" + "insert into Grados values ('2do año D')";
            string InsertarGrado13 = "USE BDINJI;" + "insert into Grados values ('2do año E')";
            string InsertarGrado14 = "USE BDINJI;" + "insert into Grados values ('2do año F')";
            string InsertarGrado15 = "USE BDINJI;" + "insert into Grados values ('2do año G')";

            string InsertarGrado16 = "USE BDINJI;" + "insert into Grados values ('3er año A')";
            string InsertarGrado17 = "USE BDINJI;" + "insert into Grados values ('3er año B')";
            string InsertarGrado18 = "USE BDINJI;" + "insert into Grados values ('3er año C')";
            string InsertarGrado19 = "USE BDINJI;" + "insert into Grados values ('3er año D')";
            string InsertarGrado20 = "USE BDINJI;" + "insert into Grados values ('3er año E')";
            string InsertarGrado21 = "USE BDINJI;" + "insert into Grados values ('3er año F')";


            string Lenguaje = "USE BDINJI;" + "set language spanish";

            








            SqlCommand cmd = new SqlCommand(CrearDB, cnn);
            SqlCommand cmd1 = new SqlCommand(tGrados, cnn);
            SqlCommand cmd2 = new SqlCommand(tAutores, cnn);
            SqlCommand cmd3 = new SqlCommand(tAlumnos, cnn);
            SqlCommand cmd4 = new SqlCommand(tDistribuciones, cnn);
            SqlCommand cmd5 = new SqlCommand(tCategorias, cnn);
            SqlCommand cmd6 = new SqlCommand(tLibros, cnn);
            SqlCommand cmd7 = new SqlCommand(Autores_Libros, cnn);
            SqlCommand cmd8 = new SqlCommand(Bibliotecario, cnn);
            SqlCommand cmd9 = new SqlCommand(Prestamos, cnn);
            SqlCommand cmd10 = new SqlCommand(InsertarBibliotecaria, cnn);

            SqlCommand cmd11 = new SqlCommand(InsertarGrado1, cnn);
            SqlCommand cmd12 = new SqlCommand(InsertarGrado2, cnn);
            SqlCommand cmd13 = new SqlCommand(InsertarGrado3, cnn);
            SqlCommand cmd14 = new SqlCommand(InsertarGrado4, cnn);
            SqlCommand cmd15 = new SqlCommand(InsertarGrado5, cnn);
            SqlCommand cmd16 = new SqlCommand(InsertarGrado6, cnn);
            SqlCommand cmd17 = new SqlCommand(InsertarGrado7, cnn);
            SqlCommand cmd18 = new SqlCommand(InsertarGrado8, cnn);
            SqlCommand cmd19 = new SqlCommand(InsertarGrado9, cnn);
            SqlCommand cmd20 = new SqlCommand(InsertarGrado10, cnn);
            SqlCommand cmd21 = new SqlCommand(InsertarGrado11, cnn);
            SqlCommand cmd22 = new SqlCommand(InsertarGrado12, cnn);
            SqlCommand cmd23 = new SqlCommand(InsertarGrado13, cnn);
            SqlCommand cmd24 = new SqlCommand(InsertarGrado14, cnn);
            SqlCommand cmd25 = new SqlCommand(InsertarGrado15, cnn);
            SqlCommand cmd26 = new SqlCommand(InsertarGrado16, cnn);
            SqlCommand cmd27 = new SqlCommand(InsertarGrado17, cnn);
            SqlCommand cmd28 = new SqlCommand(InsertarGrado18, cnn);
            SqlCommand cmd29 = new SqlCommand(InsertarGrado19, cnn);
            SqlCommand cmd30 = new SqlCommand(InsertarGrado20, cnn);
            SqlCommand cmd31 = new SqlCommand(InsertarGrado21, cnn);
            SqlCommand cmd32 = new SqlCommand(Lenguaje, cnn);



            //SqlCommand cmd33 = new SqlCommand(IngresarPrestamo, cnn);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                cmd8.ExecuteNonQuery();
                cmd9.ExecuteNonQuery();
                cmd10.ExecuteNonQuery();
                cmd11.ExecuteNonQuery();
                cmd12.ExecuteNonQuery();
                cmd13.ExecuteNonQuery();
                cmd14.ExecuteNonQuery();
                cmd15.ExecuteNonQuery();
                cmd16.ExecuteNonQuery();
                cmd17.ExecuteNonQuery();
                cmd18.ExecuteNonQuery();
                cmd19.ExecuteNonQuery();
                cmd20.ExecuteNonQuery();
                cmd21.ExecuteNonQuery();
                cmd22.ExecuteNonQuery();
                cmd23.ExecuteNonQuery();
                cmd24.ExecuteNonQuery();
                cmd25.ExecuteNonQuery();
                cmd26.ExecuteNonQuery();
                cmd27.ExecuteNonQuery();
                cmd28.ExecuteNonQuery();
                cmd29.ExecuteNonQuery();
                cmd30.ExecuteNonQuery();
                cmd31.ExecuteNonQuery();
                cmd32.ExecuteNonQuery();
                //cmd33.ExecuteNonQuery();

                cnn.Close();
                MessageBox.Show("Base de datos" + "\nCreada correctamente....", "Generar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGenerarDevolucion.Enabled = true;
                btnIngresarLibro.Enabled = true;
                btnIngresarPrestamo.Enabled = true;
                btnMostrarStock.Enabled = true;

                btngenerar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al crear la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
               

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=" + "localhost" + ";" + "database=BDINJI; integrated security=yes");

            string bd = "USE BDINJI; ";
            string IngresarLibro = " CREATE PROCEDURE ingresarlibro" +
                                                           

                                                        " @IDLibros varchar(15)," +
                                                        " @IDAutores int," +
                                                        " @titulo varchar(20)," +
                                                         "@Editorial varchar(20)," +
                                                        " @Stock int," +
                                                        " @ubicacion varchar(20)," +
                                                        " @IDdistri int," +
                                                         " @IDcate int, " +
                                                         " @Nombrecompleto varchar(30) " +
                                                         " AS " +
                                                         " SET IDENTITY_INSERT Autores ON" +
                                                        " SET @IDAutores = (select IDautor from Autores where IDautor = (select max(IDautor) From Autores)); " +


                                                                     " INSERT INTO Autores(IDautor, Nombrecompleto) " +
                                                         " VALUES(@IDAutores + 1, @Nombrecompleto); " +

                                                                     " SET IDENTITY_INSERT Autores OFF " +


                                                         " INSERT INTO Libros " +
                                                         " (IDlibro, Titulo, Editorial, Stock, Ubicacion, IDdistri, IDcate) " +
                                                         " VALUES(@IDLibros, @titulo, @Editorial, @Stock, @ubicacion, @IDdistri, @IDcate); " +


                                                                     " SET IDENTITY_INSERT Autores_Libros ON " +
                                                         " INSERT INTO Autores_Libros(ID_libro, ID_autor) " +
                                                         " VALUES(@IDLibros, @IDAutores + 1); " +

                                                                     "SET IDENTITY_INSERT Autores_Libros OFF";

           

            try
            {
                cnn.Open();
                SqlCommand cmd33 = new SqlCommand(bd, cnn);
                SqlCommand cmd32 = new SqlCommand(IngresarLibro, cnn);
                
                cmd32.ExecuteNonQuery();
                MessageBox.Show("Base de datos" + "\nProcedimiento creado correctamente....", "Generar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.Close();
                btnIngresarLibro.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Crear \n\n\n procedimiento en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=" + "localhost" + ";" + "database=master; integrated security=yes");
            string BorrarBD = " DROP DATABASE " + "BDINJI";

            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea borrar la base de datos?", "Borrar Base de Datos", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    cnn.Open();
                    SqlCommand cmd1 = new SqlCommand(BorrarBD, cnn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Base de datos" + "\nEliminada correctamente....", "Generar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.Close();
                    btnborrar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al Eliminar la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=" + "localhost" + ";" + "database=BDINJI; integrated security=yes");
            string bd = "USE BDINJI; ";
            string IngresarPrestamo = "CREATE PROCEDURE ingresarprestamo" +

                                                    " @IDLibros varchar(20)," +
                                                    " @Titulo varchar(20)," +
                                                    " @NIE int," +
                                                    " @Nom1 varchar(20)," +
                                                    " @Nom2 varchar(20)," +
                                                    " @Ape1 varchar(20)," +
                                                    " @Ape2 varchar(20)," +
                                                    " @Grado varchar(15)," +
                                                    " @Nombiblio varchar(20)," +
                                                    " @Fechentrega varchar(40)," +
                                                    " @Fechdevolucion varchar(40)," +
                                                    " @Idgrado int," +
                                                    " @Idbiblio int" +
                                                    " as " +
                                                    " SET @Idbiblio = (select IDbibliotecario from Bibliotecarios where usuario = @Nombiblio); " +
                                                                " SET @Idgrado = (select IDgrado from Grados where Grado = @Grado); " +
                                                                " set @IDLibros = (select IDlibro from Libros where IDlibro = @IDLibros); " +

                                                                " INSERT INTO Prestamos(ID_libro, NombreLibro, NIEprestamo, NombreAlumno1, NombreAlumno2, ApellidoAlumno1, ApellidoAlumno2, IDgra, IDBibliotecarioPrestamo, Fecha_entrega, Fecha_devolucion) VALUES(@IDLibros, @Titulo, @NIE, @Nom1, @Nom2, @Ape1, @Ape2, @Idgrado, @Idbiblio, @Fechentrega, @Fechdevolucion); " +
                                                                " update Libros set Stock = (Stock - 1) where IDlibro = @IDLibros;"; 







            try
            {
                cnn.Open();
                SqlCommand cmd33 = new SqlCommand(bd, cnn);
                SqlCommand cmd32 = new SqlCommand(IngresarPrestamo, cnn);
                cmd32.ExecuteNonQuery();
                MessageBox.Show("Base de datos" + "\nProcedimiento creado correctamente....", "Generar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.Close();
                btnIngresarPrestamo.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Crear \n\n\n procedimiento en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=" + "localhost" + ";" + "database=BDINJI; integrated security=yes");
            string bd = "USE BDINJI; ";
            string GenerarDevolucion =  "CREATE PROCEDURE generardevolucion "+
                                                            " @IDprestamo int,"+
                                                           " @Titulo varchar(20),"+
                                                            " @IDlibros varchar(20)"+
                                                           " as "+
                                                            " SET @IDlibros = (select IDlibro from Libros where Titulo = @Titulo);" +
                                                                        " Delete from Prestamos where IDprestamo = @IDprestamo;" +
                                                                        " update Libros set Stock = (Stock + 1) where IDlibro = @IDlibros;";








            try
            {
                cnn.Open();
                SqlCommand cmd31 = new SqlCommand(bd, cnn);
                SqlCommand cmd32 = new SqlCommand(GenerarDevolucion, cnn);
                cmd32.ExecuteNonQuery();
                MessageBox.Show("Base de datos" + "\nProcedimiento creado correctamente....", "Generar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.Close();
                btnGenerarDevolucion.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Crear \n\n\n procedimiento en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=" + "localhost" + ";" + "database=master; integrated security=yes");
            string bd = "USE BDINJI; ";
            string GenerarDevolucion = "CREATE PROCEDURE generardevolucion " +
                                                            " @IDprestamo int," +
                                                           " @Titulo varchar(20)," +
                                                            " @IDlibros varchar(20)" +
                                                           " as " +
                                                            " SET @IDlibros = (select IDlibro from Libros where Titulo = @Titulo);" +
                                                                        " Delete from Prestamos where IDprestamo = @IDprestamo;" +
                                                                        " update Libros set Stock = (Stock + 1) where IDlibro = @IDlibros;";








            try
            {
                cnn.Open();
                SqlCommand cmd31 = new SqlCommand(bd, cnn);
                SqlCommand cmd32 = new SqlCommand(GenerarDevolucion, cnn);
                cmd32.ExecuteNonQuery();
                MessageBox.Show("Base de datos" + "\nProcedimiento creado correctamente....", "Generar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Crear \n\n\n procedimiento en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=" + "localhost" + ";" + "database=BDINJI; integrated security=yes");
            string bd = "USE BDINJI; ";
            string IngresarPrestamo =  " CREATE PROCEDURE mostrarstock "+ 
                                                        " @IDlibro varchar(20),"+
                                                        " @Titulo varchar(20)"+
                                                        " as " +
                                                        " SET @IDlibro = (select IDlibro from Libros where Titulo = @Titulo);"+
                                                                    " select stock from Libros where IDlibro = @IDlibro;"; 







            try
            {
                cnn.Open();
            SqlCommand cmd32 = new SqlCommand(bd, cnn);
            SqlCommand cmd31 = new SqlCommand(IngresarPrestamo, cnn);
                cmd32.ExecuteNonQuery();
                MessageBox.Show("Base de datos" + "\nProcedimiento creado correctamente....", "Generar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnn.Close();
                btnMostrarStock.Enabled = false;
                btnborrar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Crear \n\n\n procedimiento en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
