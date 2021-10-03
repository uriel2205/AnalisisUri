using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Collections;

namespace ProyectoLenguajesFase1
{
    public partial class FormProyecto : Form
    {
        public FormProyecto()
        {
            InitializeComponent();
        }

        int tokenllevado = 0;     //llevo Token SIMBOLOS
        int tokenllevado2 = 0;    //llevo Token ERRORES
     
        int noerror = 0;                  //numero de errores
        
              //************************//
             //-----Boton Abrir--------//
            //************************//   
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "rich text box(*.txt) | *.txt";
            openFileDialog1.FileName = "";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = "Escritorio";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtEntrada.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Archivo Abierto", "Lenguajes Proyecto Fase 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


              //************************//
             //-----Boton Guardar------//
            //************************//
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "rich text box(*.txt) | *.txt";
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.Title = "Save File";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtEntrada.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Archivo Guardado", "Lenguajes Proyecto Fase 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


              //************************//
             //---Boton Guardar HTML---//
            //************************//
        private void guardaHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "rich text box(*.txt) | *.txt";
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.Title = "Save File";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSalida.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Archivo HTML Guardado", "Lenguajes Proyecto Fase 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


              //************************//
             //----Boton Nuevo Doc-----//
            //************************//
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEntrada.Clear();
        }


              //***********************//
             //------Boton Salir------//
            //***********************//
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


              //**********************************//
             //------Boton Generar Analisis------//
            //**********************************//
        private void tbngenerar_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();
            string cadenatoken = txtEntrada.Text;       //obtiene la informacion del txtdatos
            MetodoAutomataAnalizador(cadenatoken);     // y lo envia al metodo Automata
            
        }



              //*******************************************//    
             //------METODO PRINCIPAL DEL ANALIZADOR------//
            //*******************************************//  
        private void MetodoAutomataAnalizador(string cadena)
        {
            
            int inicioestado = 0;            //Estado 0    
            int estadoprincipal = 0;        //Estado en el que me encuentro
            char cadenaconcatenar;         //Cadena que compara los token's
            string token = "";            //Concatena lo analizado 
            dataErrores.Rows.Clear();    //limpia el datagried
            dataLexemas.Rows.Clear();   //limpia el datagried

               
        for (inicioestado = 0; inicioestado < cadena.Length; inicioestado++)
            {
                cadenaconcatenar = cadena[inicioestado];
               
                switch(estadoprincipal)
                {
                    case 0: 
                        switch(cadenaconcatenar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\n':
                            case '\b':
                            case '\f':
                                estadoprincipal = 0; //si es espacio o salto de linea o tab sigue en el estado 0
                            break;
                            
                            case 'p': 
                                token += cadenaconcatenar;   //Concatena
                                estadoprincipal = 1;        //pasa al estado 1
                            break;

                            case 'P':
                                token += cadenaconcatenar;  //concatena
                                estadoprincipal = 1;       //pasa al estado 1 
                            break;
                            
                            case 'c':
                            token += cadenaconcatenar;  //concatena
                            estadoprincipal = 3;       //pasa al estado 3 
                            break;

                            case 'C':
                            token += cadenaconcatenar;  //concatena
                            estadoprincipal = 6;       //pasa al estado 6
                            break;
                            
                            case '{':
                                token += cadenaconcatenar;
                                estadoprincipal = 9;
                                inicioestado = inicioestado - 1;
                            break;

                            case '}':
                                token += cadenaconcatenar;
                                estadoprincipal = 9;
                                inicioestado = inicioestado - 1;
                            break;

                            case ';':
                            token += cadenaconcatenar;
                            estadoprincipal = 9;
                            inicioestado = inicioestado - 1;
                            break;

                            case ',':
                            token += cadenaconcatenar;
                            estadoprincipal = 9;
                            inicioestado = inicioestado - 1;
                            break;

                            case 'I':
                            token += cadenaconcatenar;  
                            estadoprincipal = 10;       
                            break;

                            case 'b':
                            token += cadenaconcatenar;
                            estadoprincipal = 14;
                            break;

                            case 'S':
                                token += cadenaconcatenar;
                                estadoprincipal = 17;
                            break;
                            
                            default:
                                token += cadenaconcatenar;
                            break;
                        }   
                    break; 
                    


                   case 1:
                        if(cadenaconcatenar == 'p' || cadenaconcatenar == 'P') 
                        {
                            token += cadenaconcatenar;
                            estadoprincipal = 1;
                        }
                        else if(cadenaconcatenar.Equals('u'))
                        {
                            token += cadenaconcatenar;  //cancatena si es espacio u
                            estadoprincipal = 1;       //Sigue en el estado 1
                        }
                        else if(cadenaconcatenar.Equals('b')) 
                        {
                            token += cadenaconcatenar;
                            estadoprincipal = 1;
                        }
                        else if(cadenaconcatenar.Equals('l')) 
                        {
                            token += cadenaconcatenar;
                            estadoprincipal = 1;
                        }
                        else if(cadenaconcatenar.Equals('i')) 
                        {
                            token += cadenaconcatenar;
                            estadoprincipal = 1;
                        }
                        else if (cadenaconcatenar.Equals('c')) 
                        {
                            token += cadenaconcatenar;
                            estadoprincipal = 2;               //estado de Aceptacion
                            inicioestado = inicioestado - 1;  //regresa al estado 0, para volver a leer 
                        }
                        else if (cadenaconcatenar.Equals('r'))
                        {
                            token += cadenaconcatenar;
                            estadoprincipal = 12;
                        }
                        
                    break;  



                    case  2:                                     //Estado de aceptacion
                        DescripciondelosToken(token);           //Enviar al data de token
                        TokenValidos(token);                   //Token validos en el data
                        token = "";                           //Vacia la cadena 
                        estadoprincipal = 0;                 //regresa al estado 0
                    break;  
                


                    case 3:
                        if(cadenaconcatenar == 'c') 
                        {
                            token += cadenaconcatenar;
                            estadoprincipal = 3;
                        }
                        else if (cadenaconcatenar.Equals('l')) 
                        {
                            token += cadenaconcatenar;
                            estadoprincipal = 3;
                        }
                        else if (cadenaconcatenar.Equals('a')) 
                        {
                            token += cadenaconcatenar;
                            estadoprincipal = 3;
                        }
                        else if (cadenaconcatenar == 's') 
                        {
                            token += cadenaconcatenar;
                            estadoprincipal = 4;
                        }                                        
                    break;  


                    case 4:
                    if (cadenaconcatenar == 's') 
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 5;
                        inicioestado = inicioestado - 1;
                    }
                    break; 
                    
                    
                    case 5:
                        DescripciondelosToken(token);           
                        TokenValidos(token);                   
                        token = "";                           
                        estadoprincipal = 0;                 
                    break;

                    
                    
                    case 6:
                    if (cadenaconcatenar == 'C') 
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 6;
                    }
                    else if (cadenaconcatenar.Equals('a')) 
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 6;
                    }
                    else if (cadenaconcatenar.Equals('s')) 
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 6;
                    }
                    else if (cadenaconcatenar == 'i') 
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 6;

                    }
                    else if (cadenaconcatenar.Equals('l')) 
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 7;
                    }
                    break;  

                    
                    
                    case 7:
                    if (cadenaconcatenar.Equals('l')) 
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 7;
                    }
                    else if (cadenaconcatenar == 'a') 
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 8;
                        inicioestado = inicioestado - 1;
                    }
                    break;

                    case 8:
                        DescripciondelosToken(token);           
                        TokenValidos(token);                  
                        token = "";                           
                        estadoprincipal = 0;                 
                    break;
                    
                    case 9:
                        DescripciondelosToken(token);         
                        TokenValidos(token);                 
                        token = "";                          
                        estadoprincipal = 0;   
                    break;


                    case 10:
                    if (cadenaconcatenar == 'I')
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 10;
                    }
                    else if (cadenaconcatenar.Equals('n'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 10;
                    }
                    else if (cadenaconcatenar.Equals('t'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 11;
                        inicioestado = inicioestado - 1;
                    }
                    break;

                    case 11:
                    DescripciondelosToken(token);
                    TokenValidos(token);
                    token = "";
                    estadoprincipal = 0;
                    break;

                    case 12:
                       if (cadenaconcatenar.Equals('r'))
                        {
                            token += cadenaconcatenar;
                            estadoprincipal = 12;
                        }
                       else if (cadenaconcatenar.Equals('o'))
                       {
                           token += cadenaconcatenar;
                           estadoprincipal = 12;
                       }
                       else if (cadenaconcatenar.Equals('t'))
                       {
                           token += cadenaconcatenar;
                           estadoprincipal = 12;
                       }
                       else if (cadenaconcatenar.Equals('e'))
                       {
                           token += cadenaconcatenar;
                           estadoprincipal = 12;
                       }
                       else if (cadenaconcatenar.Equals('c'))
                       {
                           token += cadenaconcatenar;
                           estadoprincipal = 12;
                       }
                       else if (cadenaconcatenar.Equals('t'))
                       {
                           token += cadenaconcatenar;
                           estadoprincipal = 12;
                       }
                       else if (cadenaconcatenar.Equals('e'))
                       {
                           token += cadenaconcatenar;
                           estadoprincipal = 12;
                       }
                       else if (cadenaconcatenar.Equals('d'))
                       {
                           token += cadenaconcatenar;
                           estadoprincipal = 13;
                           inicioestado = inicioestado - 1;
                       }
                    break;

                    case 13:
                    DescripciondelosToken(token);
                    TokenValidos(token);
                    token = "";
                    estadoprincipal = 0;
                    break;

                    case 14:
                    if (cadenaconcatenar.Equals('b'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 14;
                    }
                    else if (cadenaconcatenar.Equals('o'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 15;
                    }
                    break;

                    case 15:
                    if (cadenaconcatenar.Equals('o'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 15;
                    }
                    else if (cadenaconcatenar.Equals('l'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 15;
                    }
                    else if (cadenaconcatenar.Equals('e'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 15;
                    }
                    else if (cadenaconcatenar.Equals('a'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 15;
                    }
                    else if (cadenaconcatenar.Equals('n'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 16;
                        inicioestado = inicioestado - 1;
                    }
                    break;

                    case 16:
                    DescripciondelosToken(token);
                    TokenValidos(token);
                    token = "";
                    estadoprincipal = 0;
                    break;
                    
                    
                    case 17:
                    if (cadenaconcatenar.Equals('S'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 17;
                    }
                    else if (cadenaconcatenar.Equals('t'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 17;
                    }
                    else if (cadenaconcatenar.Equals('r'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 17;
                    }
                    else if (cadenaconcatenar.Equals('i'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 17;
                    }
                    else if (cadenaconcatenar.Equals('n'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 17;
                    }
                    else if (cadenaconcatenar.Equals('g'))
                    {
                        token += cadenaconcatenar;
                        estadoprincipal = 18;
                        inicioestado = inicioestado - 1;
                    }
                    break;

                    case 18:
                    DescripciondelosToken(token);
                    TokenValidos(token);
                    token = "";
                    estadoprincipal = 0;
                    break;
                    

                }   
             }  
          } 



        
            //*******************************************//    
           //--------METODO PARA DESCRIBIR TOKEN--------//
          //*******************************************//  
        public void DescripciondelosToken(string tokeniguala)
        {
            switch (tokeniguala)
            {
                case "public":
                    txtSalida.Text = txtSalida.Text + "Public" + " "+ "Variable Publica\n";
                    break;
                case "Public":
                    txtSalida.Text = txtSalida.Text + "Public" + " "+ "Variable Publica\n";
                    break;
                case "class":
                    txtSalida.Text = txtSalida.Text + "Class" + " "+ "Clase Java\n";
                    break;
                case "Casilla":
                    txtSalida.Text = txtSalida.Text + "Casilla" + " " + "Nombre Clase\n";
                    break;
                case "{":
                    txtSalida.Text = txtSalida.Text + "{" + " " + "Singno Apertura-LLave\n";
                    break;
                case "}":
                    txtSalida.Text = txtSalida.Text + "}" + " " + "Signo Cierre-LLave\n";
                    break;
                case ",":
                    txtSalida.Text = txtSalida.Text + "," + " " + "Singno\n";
                    break;
                case ";":
                    txtSalida.Text = txtSalida.Text + ";" + " " + "Signo\n";
                    break;
                case "Int":
                    txtSalida.Text = txtSalida.Text + "Int" + " " + "Variable Entera\n";
                    break;
                case "protected":
                    txtSalida.Text = txtSalida.Text + "Protected" + " " + "Variabel Protegida\n";
                    break;
                case "boolean":
                    txtSalida.Text = txtSalida.Text + "Boolean "+ " " + "Variabel Boleana\n";
                    break;
                case "String":
                    txtSalida.Text = txtSalida.Text + "String" + " " + "Variabel String\n";
                    break;
            }
        }


            //*******************************************//    
           //-----------METODO TOKEN VALIDOS------------//
          //*******************************************// 
        private void TokenValidos(string lexema)
        {
            tokenllevado = dataLexemas.Rows.Add();
            switch (lexema)
            {
                case "public":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Public":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "class":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "Casilla":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "{":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Signo Reservado";
                    break;
                case "}":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Signo Reservado";
                    break;
                case ";":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Signo Reservado";
                    break;
                case ",":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Signo Reservado";
                    break;
                case "Int":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "protected":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "boolean":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                case "String":
                    dataLexemas.Rows[tokenllevado].Cells["Lexema"].Value = lexema;
                    dataLexemas.Rows[tokenllevado].Cells["Token"].Value = "Palabra Reservada";
                    break;
                default:
                    errores(lexema);    //error en el texto
                    noerror += 1;      //numero de error
                    break;
                    
            }
        }

        //*******************************************//    
        //----------METODO TOKEN ERRORES-------------//
        //*******************************************// 
        private void errores(string errores)
        {
            tokenllevado2 = dataErrores.Rows.Add();
            dataErrores.Rows[tokenllevado2].Cells["Error"].Value = errores;
            dataErrores.Rows[tokenllevado2].Cells["Token2"].Value = "Token error";

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    
    }   //Fin Clase
    }  //Fin Proyecto
