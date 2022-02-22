using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using System.Data;
namespace Horarios.Classes
{
    class HojaCalculo
    {
        public double porcentajeHoraSincrona = 0;
        /*
        Valida Formato de plantilla
        Verdadero: EL formato seleccionado es correcto, se pruede procesar la division de horarios
        Falso: El formato seleccionado tiene un formato incorrecto
         */
        public void abrirPlantillaHorario(string path)
        {

        }

      
        private void quitarEspacios(ref SLDocument sl)
        {

        }

        private void crearHorarioApex(ref  SLDocument sl, ref DataTable tablaDatos, ref string instructor)
        {
            DataView porDocente = new DataView(tablaDatos);
            porDocente.RowFilter = "INSTRUCTOR = '" + instructor + "'";
            porDocente.Sort = "INSTRUCTOR ASC, BLOQUE ASC, INICIO ASC";
            DataTable tabla = new DataTable();
            tabla = porDocente.ToTable();
            int k = tabla.Rows.Count;

            SLStyle estilo = sl.CreateStyle();
            estilo.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            estilo.SetVerticalAlignment(VerticalAlignmentValues.Center);
            estilo.SetWrapText(false);
            estilo.SetFontBold(true);
            estilo.Font.FontSize = 10;
            estilo.Font.FontName = "Calibri";
            estilo.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            estilo.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            estilo.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            estilo.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;

            sl.AddWorksheet("HORARIO APEX");
            sl.SelectWorksheet("HORARIO APEX");
            sl.SetCellValue("A1", "PERIODO");
            sl.SetCellValue("B1", "NRC");
            sl.SetCellValue("C1", "PARTE PERIODO");
            sl.SetCellValue("D1", "LISTA_CRUZADA");
            sl.SetCellValue("E1", "BLOQUE");
            sl.SetCellValue("F1", "MATERIA");
            sl.SetCellValue("G1", "CURSO");
            sl.SetCellValue("H1", "DESCRIPCION_CURSO");
            sl.SetCellValue("I1", "INSCRITOS");
            sl.SetCellValue("J1", "INICIO");
            sl.SetCellValue("K1", "FIN");
            sl.SetCellValue("L1", "HORARIO");
            sl.SetCellValue("M1", "CAMPUS");
            sl.SetCellValue("N1", "LUN");
            sl.SetCellValue("O1", "MAR");
            sl.SetCellValue("P1", "MIE");
            sl.SetCellValue("Q1", "JUE");
            sl.SetCellValue("R1", "VIE");
            sl.SetCellValue("S1", "SAB");
            /*Formateando*******/
            sl.SetColumnWidth(3, 13);
            sl.SetColumnWidth(5, 12);
            sl.SetColumnWidth(8, 30);
            sl.SetColumnWidth(10, 10);
            sl.SetColumnWidth(11, 10);
            sl.SetColumnWidth(12, 11);
            sl.SetColumnWidth(13, 16);
            for (int j = 14; j <= 19; j++)
            {
                sl.SetColumnWidth(j, 5);
            }
            sl.SetCellStyle(1, 1, 1, 19, estilo);

            estilo.SetFontBold(false);
            estilo.Alignment.Horizontal = HorizontalAlignmentValues.Left;

            int fila=1;
            for (int j=0; j< tabla.Rows.Count; j++)
            {
                if(instructor==tabla.Rows[j]["INSTRUCTOR"].ToString())
                {
                    fila++;
                    sl.SetCellValue("A"+ fila , tabla.Rows[j]["PERIODO"].ToString());
                    sl.SetCellValue("B" + fila, tabla.Rows[j]["NRC"].ToString());
                    sl.SetCellValue("C" + fila, tabla.Rows[j]["PARTE_PERIODO"].ToString());
                    sl.SetCellValue("D" + fila, tabla.Rows[j]["LISTA_CRUZADA"].ToString());
                    sl.SetCellValue("E" + fila, tabla.Rows[j]["BLOQUE"].ToString());
                    sl.SetCellValue("F" + fila, tabla.Rows[j]["MATERIA"].ToString());
                    sl.SetCellValue("G" + fila, tabla.Rows[j]["CURSO"].ToString());
                    sl.SetCellValue("H" + fila, tabla.Rows[j]["DESCRIPCIÓN_CURSO"].ToString());
                    sl.SetCellValue("I" + fila, tabla.Rows[j]["INSCRITOS"].ToString());
                    sl.SetCellValue("J" + fila, tabla.Rows[j]["INICIO"].ToString().Substring(0, 10));
                    sl.SetCellValue("K" + fila, tabla.Rows[j]["FIN"].ToString().Substring(0, 10));
                    sl.SetCellValue("L" + fila, tabla.Rows[j]["HORARIO"].ToString());
                    sl.SetCellValue("M" + fila, tabla.Rows[j]["CAMPUS"].ToString());
                    sl.SetCellValue("N" + fila, tabla.Rows[j]["LUN"].ToString());
                    sl.SetCellValue("O" + fila, tabla.Rows[j]["MAR"].ToString());
                    sl.SetCellValue("P" + fila, tabla.Rows[j]["MIE"].ToString());
                    sl.SetCellValue("Q" + fila, tabla.Rows[j]["JUE"].ToString());
                    sl.SetCellValue("R" + fila, tabla.Rows[j]["VIE"].ToString());
                    sl.SetCellValue("S" + fila, tabla.Rows[j]["SAB"].ToString());
                }
                else
                {
                    break;
                }
            }
            sl.SetCellStyle(2, 1, fila, 19, estilo);
            estilo.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            estilo.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.Yellow, System.Drawing.Color.Black);
            sl.SetCellStyle(2, 10, fila,11, estilo);
        }

        private void crearPlantilla(ref SLDocument sl, string nombreHoja)
        {
           
            sl.AddWorksheet(nombreHoja);
            for (int j = 3; j <= 8; j++)
            {
                sl.SetColumnWidth(j, 25);
            }
            sl.SelectWorksheet("PLANTILLA");
            sl.SetCellValue("A1", "HORARIO DE TRABAJO");
            sl.MergeWorksheetCells("A1", "H2");
            SLStyle estiloTitulo = sl.CreateStyle();
            estiloTitulo.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            estiloTitulo.SetVerticalAlignment(VerticalAlignmentValues.Center);
            estiloTitulo.SetFontBold(true);
            estiloTitulo.Font.FontSize = 18;
            estiloTitulo.Font.FontName = "Calibri";
            sl.SetCellStyle(1, 1, 1, 8, estiloTitulo);

            
            SLStyle estilo = sl.CreateStyle();
            estilo.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            estilo.SetVerticalAlignment(VerticalAlignmentValues.Center);
            estilo.SetFontBold(true);
            estilo.Font.FontSize = 12;
            estilo.Font.FontName = "Calibri";
            sl.SetCellStyle(3, 4, 3, 8, estilo);

            estilo.Alignment.Horizontal = HorizontalAlignmentValues.Right;
            sl.SetCellStyle(3, 3, estilo);
           
            sl.SetCellValue("C3", "FECHA DE VIGENCIA");
            sl.MergeWorksheetCells("C3", "D3");
            sl.SetCellValue("E3", "DEL:");
            sl.SetCellValue("G3", "AL:");
            estilo.Font.FontSize = 10;
            estilo.Alignment.Horizontal = HorizontalAlignmentValues.Left;

            sl.SetCellValue("A6", "INSTRUCTOR:");
            sl.SetCellValue("A7", "ID:");
            sl.SetCellStyle(6, 1, 7, 1, estilo);

            estilo.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            sl.SetCellValue("F5", "RESUMEN DE CARGA DE TRABAJO");
            sl.SetCellStyle(5, 6, 5, 8, estilo);
            sl.MergeWorksheetCells("F5", "H5");
            /*CUADRO RESUMEN*/
            estilo.Alignment.Horizontal = HorizontalAlignmentValues.Right;
            estilo.SetFontBold(false);
            estilo.Font.FontSize = 9;
            sl.SetCellValue("G6", "CARGA PEDAGÓGICA");
            sl.SetCellValue("H6", "=I189"); 
            sl.SetCellValue("G7", "PREPARACIÓN DE CLASES");
            sl.SetCellValue("H7", "=I190");
            sl.SetCellValue("G8", "REFRIGERIO");
            sl.SetCellValue("H8", "=I191");
            sl.SetCellValue("G10", "-");
            sl.SetCellValue("H9", "0"); sl.SetCellValue("H10", "0");
            sl.SetCellValue("G11", "TOTAL HORAS POR SEMANA");
            sl.SetCellValue("H11", "=I192");
            sl.SetCellStyle(6, 7, 11, 7, estilo);

            /*Escribir Fórmulas*/

            /**********************/

            /*CABECERA DIAS*/
            //Estilo para Horas
            SLStyle estiloHoras = sl.CreateStyle();
            estiloHoras.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            estiloHoras.SetVerticalAlignment(VerticalAlignmentValues.Center);
            estiloHoras.SetWrapText(true);
            estiloHoras.SetFontBold(true);
            estiloHoras.Font.FontSize = 10;
            estiloHoras.Font.FontName = "Calibri";
            estiloHoras.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            estiloHoras.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin;
            estiloHoras.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            estiloHoras.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            //estiloHoras.Border.VerticalBorder.BorderStyle = BorderStyleValues.Thick;
            //estiloHoras.Border.VerticalBorder.Color = System.Drawing.Color.Black;

            sl.SetCellValue("A14", "INICIO");
            sl.SetCellValue("B14", "FIN");
            sl.SetCellValue("C14", "LUNES");
            sl.SetCellValue("D14", "MARTES");
            sl.SetCellValue("E14", "MIÉRCOLES");
            sl.SetCellValue("F14", "JUEVES");
            sl.SetCellValue("G14", "VIERNES");
            sl.SetCellValue("H14", "SÁBADO");
            sl.SetCellStyle(14, 1, 14, 8, estiloHoras);

            
            /*Colocando Hora Inicio Fin*/
            sl.SetCellValue("A15", "07:30"); sl.SetCellValue("B15", "08:00");
            sl.SetCellValue("A21", "08:00"); sl.SetCellValue("B21", "08:30"); 
            sl.SetCellValue("A27", "08:30"); sl.SetCellValue("B27", "09:00"); 
            sl.SetCellValue("A33", "09:00"); sl.SetCellValue("B33", "09:30");
            sl.SetCellValue("A39", "09:30"); sl.SetCellValue("B39", "10:00");
            sl.SetCellValue("A45", "10:00"); sl.SetCellValue("B45", "10:30");
            sl.SetCellValue("A51", "10:30"); sl.SetCellValue("B51", "11:00");
            sl.SetCellValue("A57", "11:00"); sl.SetCellValue("B57", "11:30");
            sl.SetCellValue("A63", "11:30"); sl.SetCellValue("B63", "12:00");
            sl.SetCellValue("A69", "12:00"); sl.SetCellValue("B69", "12:30");
            sl.SetCellValue("A75", "12:30"); sl.SetCellValue("B75", "13:00");
            sl.SetCellValue("A81", "13:00"); sl.SetCellValue("B81", "13:30");
            sl.SetCellValue("A87", "13:30"); sl.SetCellValue("B87", "14:00");
            sl.SetCellValue("A93", "14:00"); sl.SetCellValue("B93", "14:30");
            sl.SetCellValue("A99", "14:30"); sl.SetCellValue("B99", "15:00");
            sl.SetCellValue("A105", "15:00"); sl.SetCellValue("B105", "15:30");
            sl.SetCellValue("A111", "15:30"); sl.SetCellValue("B111", "16:00");
            sl.SetCellValue("A117", "16:00"); sl.SetCellValue("B117", "16:30");
            sl.SetCellValue("A123", "16:30"); sl.SetCellValue("B123", "17:00");
            sl.SetCellValue("A129", "17:00"); sl.SetCellValue("B129", "17:30");
            sl.SetCellValue("A135", "17:30"); sl.SetCellValue("B135", "18:00");
            sl.SetCellValue("A141", "18:00"); sl.SetCellValue("B141", "18:30");
            sl.SetCellValue("A147", "18:30"); sl.SetCellValue("B147", "19:00");
            sl.SetCellValue("A153", "19:00"); sl.SetCellValue("B153", "19:30");
            sl.SetCellValue("A159", "19:30"); sl.SetCellValue("B159", "20:00");
            sl.SetCellValue("A165", "20:00"); sl.SetCellValue("B165", "20:30");
            sl.SetCellValue("A171", "20:30"); sl.SetCellValue("B171", "21:00");
            sl.SetCellValue("A177", "21:00"); sl.SetCellValue("B177", "21:30");
            sl.SetCellValue("A183", "21:30"); sl.SetCellValue("B183", "22:00");

            SLStyle estiloHorario = sl.CreateStyle();
            estiloHorario.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            estiloHorario.SetVerticalAlignment(VerticalAlignmentValues.Center);
            estiloHorario.SetWrapText(true);
            estiloHorario.SetFontBold(false);
            estiloHorario.Font.FontSize = 10;
            estiloHorario.Font.FontName = "Calibri";
            estiloHorario.Border.TopBorder.BorderStyle = BorderStyleValues.Dotted ; estiloHorario.Border.TopBorder.Color = System.Drawing.Color.White;
            estiloHorario.Border.LeftBorder.BorderStyle = BorderStyleValues.None;
            estiloHorario.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            estiloHorario.Border.BottomBorder.BorderStyle = BorderStyleValues.None ; estiloHorario.Border.BottomBorder.Color = System.Drawing.Color.White;
            SLStyle estiloHorario2 = sl.CreateStyle();
            estiloHorario2.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            estiloHorario2.SetVerticalAlignment(VerticalAlignmentValues.Center);
            estiloHorario2.SetWrapText(true);
            estiloHorario2.SetFontBold(true);
            estiloHorario2.Font.FontSize = 10;
            estiloHorario2.Font.FontName = "Calibri";
            estiloHorario2.Font.FontColor = System.Drawing.Color.Red;
            estiloHorario2.Border.TopBorder.BorderStyle = BorderStyleValues.Thin; estiloHorario2.Border.TopBorder.Color = System.Drawing.Color.White;
            estiloHorario2.Border.LeftBorder.BorderStyle = BorderStyleValues.Thin; estiloHorario2.Border.BottomBorder.Color = System.Drawing.Color.White;
            estiloHorario2.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            estiloHorario2.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;
            SLStyle estiloHorario3 = sl.CreateStyle();
            estiloHorario3.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            estiloHorario3.SetVerticalAlignment(VerticalAlignmentValues.Center);
            estiloHorario3.SetWrapText(true);
            estiloHorario3.SetFontBold(true);
            estiloHorario3.Font.FontSize = 10;
            estiloHorario3.Font.FontName = "Calibri";
            estiloHorario3.Font.FontColor = System.Drawing.Color.DarkGreen ;
            estiloHorario3.Border.TopBorder.BorderStyle = BorderStyleValues.Thin; estiloHorario3.Border.TopBorder.Color = System.Drawing.Color.White;
            estiloHorario3.Border.LeftBorder.BorderStyle = BorderStyleValues.None;
            estiloHorario3.Border.RightBorder.BorderStyle = BorderStyleValues.Thin;
            estiloHorario3.Border.BottomBorder.BorderStyle = BorderStyleValues.Thin;

            for(int j = 15;j<=188; j++)
            {
                sl.SetRowHeight(j, 2);
            }
            
            for (int k = 15; k <= 185; k += 6)
            {
                sl.MergeWorksheetCells("A" + k, "A" + (k + 5));
                sl.MergeWorksheetCells("B" + k, "B" + (k + 5));
                sl.SetCellStyle(k, 3, k + 3, 8, estiloHorario);
                sl.SetCellStyle(k + 4, 3, k + 4, 8, estiloHorario2);
                sl.SetCellStyle(k + 5, 3, k + 5, 8, estiloHorario3);
            }
            

            sl.SetCellStyle(15, 1, 188, 2, estiloHoras);
            
            sl.SetCellValue("A189", "CARGA"); sl.MergeWorksheetCells("A189", "B189");
            sl.SetCellValue("C189", "=COUNTA(C15,C21,C27,C33,C39,C45,C51,C57,C63,C69,C75,C81,C87,C93,C99,C105,C111,C117,C123,C129,C135,C141,C147,C153,C159,C165,C171,C177,C183)*\"0:30\"-C190-C191");
            sl.SetCellValue("D189", "=COUNTA(D15,D21,D27,D33,D39,D45,D51,D57,D63,D69,D75,D81,D87,D93,D99,D105,D111,D117,D123,D129,D135,D141,D147,D153,D159,D165,D171,D177,D183)*\"0:30\"-D190-D191");
            sl.SetCellValue("E189", "=COUNTA(E15,E21,E27,E33,E39,E45,E51,E57,E63,E69,E75,E81,E87,E93,E99,E105,E111,E117,E123,E129,E135,E141,E147,E153,E159,E165,E171,E177,E183)*\"0:30\"-E190-E191");
            sl.SetCellValue("F189", "=COUNTA(F15,F21,F27,F33,F39,F45,F51,F57,F63,F69,F75,F81,F87,F93,F99,F105,F111,F117,F123,F129,F135,F141,F147,F153,F159,F165,F171,F177,F183)*\"0:30\"-F190-F191");
            sl.SetCellValue("G189", "=COUNTA(G15,G21,G27,G33,G39,G45,G51,G57,G63,G69,G75,G81,G87,G93,G99,G105,G111,G117,G123,G129,G135,G141,G147,G153,G159,G165,G171,G177,G183)*\"0:30\"-G190-G191");
            sl.SetCellValue("H189", "=COUNTA(H15,H21,H27,H33,H39,H45,H51,H57,H63,H69,H75,H81,H87,H93,H99,H105,H111,H117,H123,H129,H135,H141,H147,H153,H159,H165,H171,H177,H183)*\"0:30\"-H190-H191");
            sl.SetCellValue("I189", "=SUM(C189:H189)");

            sl.SetCellValue("A190", "PREPARACIÓN"); sl.MergeWorksheetCells("A190", "B190");
            sl.SetCellValue("C190", "=COUNTIF(C15:C188,\"PREPARACION DE CLASES\")*\"0:30\"");
            sl.SetCellValue("D190", "=COUNTIF(D15:D188,\"PREPARACION DE CLASES\")*\"0:30\"");
            sl.SetCellValue("E190", "=COUNTIF(E15:E188,\"PREPARACION DE CLASES\")*\"0:30\"");
            sl.SetCellValue("F190", "=COUNTIF(F15:F188,\"PREPARACION DE CLASES\")*\"0:30\"");
            sl.SetCellValue("G190", "=COUNTIF(G15:G188,\"PREPARACION DE CLASES\")*\"0:30\"");
            sl.SetCellValue("H190", "=COUNTIF(H15:H188,\"PREPARACION DE CLASES\")*\"0:30\"");
            sl.SetCellValue("I190", "=SUM(C190:H190)");

            sl.SetCellValue("A191", "REFRIGERIO"); sl.MergeWorksheetCells("A191", "B191");
            sl.SetCellValue("C191", "=COUNTIF(C15:C188,\"REFRIGERIO\")*\"0:30\"");
            sl.SetCellValue("D191", "=COUNTIF(D15:D188,\"REFRIGERIO\")*\"0:30\"");
            sl.SetCellValue("E191", "=COUNTIF(E15:E188,\"REFRIGERIO\")*\"0:30\"");
            sl.SetCellValue("F191", "=COUNTIF(F15:F188,\"REFRIGERIO\")*\"0:30\"");
            sl.SetCellValue("G191", "=COUNTIF(G15:G188,\"REFRIGERIO\")*\"0:30\"");
            sl.SetCellValue("H191", "=COUNTIF(H15:H188,\"REFRIGERIO\")*\"0:30\"");
            sl.SetCellValue("I191", "=SUM(C191:H191)");
            


            sl.SetCellValue("A192", "TOTAL"); sl.MergeWorksheetCells("A192", "B192");
            sl.SetCellValue("I192", "=SUM(C192:H192)-I188");

            sl.SetCellValue("C192", "=SUM(C189:C191)");
            sl.SetCellValue("D192", "=SUM(D189:D191)");
            sl.SetCellValue("E192", "=SUM(E189:E191)");
            sl.SetCellValue("F192", "=SUM(F189:F191)");
            sl.SetCellValue("G192", "=SUM(G189:G191)");
            sl.SetCellValue(192,8, "=SUM(H189:H191)");
            sl.SetCellStyle(189, 1, 192, 2, estiloHoras);
            estiloHoras.FormatCode = "[h]:mm;@";
            sl.SetCellStyle(189, 3, 192, 9, estiloHoras);

            sl.SetCellStyle(6, 8, 11, 8, estiloHoras);


            estilo.Alignment.Horizontal = HorizontalAlignmentValues.Center;
            estilo.SetFontBold(true);
            estilo.Font.FontSize = 9;
            estilo.Border.TopBorder.BorderStyle = BorderStyleValues.Thin;
            sl.SetCellValue("A197", "RECIBÍ CONFORME"); sl.MergeWorksheetCells("A197", "C197"); sl.SetCellStyle(197, 1, 197, 3, estilo);
            sl.SetCellValue("F197", "ENTREGUÉ CONFORME"); sl.MergeWorksheetCells("F197", "H197"); sl.SetCellStyle(197, 6, 197, 8, estilo);

            estilo.Alignment.Horizontal = HorizontalAlignmentValues.Left;
            estilo.Border.TopBorder.BorderStyle = BorderStyleValues.None;
            sl.SetCellValue("A198", "Apellidos y Nombres:");
            sl.SetCellValue("F198", "Apellidos y Nombres:");
            sl.SetCellValue("A199", "Fecha:");
            sl.SetCellValue("F199", "Fecha:");

            sl.SetCellStyle(198, 1, 199, 1, estilo);
            sl.SetCellStyle(198, 6, 199, 6, estilo);
            //estiloHoras.SetFontBold = true;
            //estiloHoras.SetHorizontalAlignment 
            //estiloHoras.SetHorizontalAlignment 
            //sl.CopyWorksheet("PLANTILLA", "HORARIO");
        }


        /*
       Reparte el horario en diferentes archivos excel

       */
        public DataTable generarHojasCalculo(ref string pathDestino, ref DataTable tablaDatos, string inicioCiclo, string finCiclo, Boolean blackBoard)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add(new DataColumn("INSTRUCTOR"));
            dt.Columns.Add(new DataColumn("HORARIO_GENERADO"));
            tablaDatos.DefaultView.Sort = "INSTRUCTOR ASC, INICIO ASC";
            string instructorTmp = "";
            string horarioAnterior = "";
            Boolean horarioPrincipal = false;
            int horarioModular = 0;
            //SLDocument sl = new SLDocument ("D:\\Plantilla.xlsx");
            SLDocument sl = new SLDocument();
            crearPlantilla(ref sl,"HORARIO");
            sl.SelectWorksheet("HORARIO");
            for (int i = 0; i < tablaDatos.Rows.Count; i++)
            {
               
                if (instructorTmp != tablaDatos.Rows[i]["INSTRUCTOR"].ToString())
                {
                    if (i > 0) {

                        sl.DeleteWorksheet("Sheet1");
                        this.crearHorarioApex(ref sl, ref tablaDatos, ref instructorTmp);
                        if (horarioPrincipal)
                        {
                            sl.SelectWorksheet("HORARIO");
                        }
                        else
                        {
                            sl.DeleteWorksheet("HORARIO");
                            sl.SelectWorksheet("HORARIO_MOD_1");
                        }
                        sl.SaveAs(pathDestino + "\\HORARIO " + instructorTmp + ".xlsx");
                        horarioPrincipal = false;
                        DataRow dataGridS = dt.NewRow();
                        dataGridS["INSTRUCTOR"] = instructorTmp;
                        dataGridS["HORARIO_GENERADO"] = pathDestino + "\\HORARIO " + instructorTmp + ".xlsx";
                        dt.Rows.Add(dataGridS);
                        horarioModular = 0;
                        horarioAnterior = "";
                        if (i < tablaDatos.Rows.Count) {
                            sl = new SLDocument();
                            //sl = new SLDocument("D:\\Plantilla.xlsx");
                            crearPlantilla(ref sl,"HORARIO");
                            
                        } else { 
                            break; 
                        }
                    }
                    
                    instructorTmp = tablaDatos.Rows[i]["INSTRUCTOR"].ToString();

                }
                /*****Escribir en plantilla***/
                /*Validar si es horario semestral*/
                if (tablaDatos.Rows[i]["INICIO"].ToString().Substring(0,10) == inicioCiclo) {
                    
                    sl.SelectWorksheet("HORARIO");
                    horarioPrincipal = true;
                    sl.SetCellValue("F3", inicioCiclo );
                    sl.SetCellValue("H3", finCiclo);

                }
                else/*Se debe de escribir en otra hoja, es horario modular*/
                {
                    if (horarioAnterior!=tablaDatos.Rows[i]["INICIO"].ToString().Substring(0, 10))
                    {
                        horarioAnterior = tablaDatos.Rows[i]["INICIO"].ToString().Substring(0, 10);
                        horarioModular++;
                        this.crearPlantilla(ref sl, "HORARIO_MOD_" + horarioModular);
                        //sl.AddWorksheet("HORARIO_MOD_" + horarioModular);
                    }
                    sl.SelectWorksheet("HORARIO_MOD_" + horarioModular);
                    sl.SetCellValue("F3", tablaDatos.Rows[i]["INICIO"].ToString().Substring(0, 10));
                    sl.SetCellValue("H3", tablaDatos.Rows[i]["FIN"].ToString().Substring(0, 10));
                }
                sl.SetCellValue("C6", instructorTmp);
                sl.SetCellValue("C7", tablaDatos.Rows[i]["ID_INST"].ToString());
               

                /*Colocando Horarios ******************************/
                /******************************************************************************************************************************/
                double[] k = devuelveFila(tablaDatos.Rows[i]["HORARIO"].ToString());
                int fSincronas = 0;
                for(int gg= 3; gg<=8; gg++) { //Columnas
                    fSincronas = 0;
                    k = devuelveFila(tablaDatos.Rows[i]["HORARIO"].ToString());
                    if (tablaDatos.Rows[i][24+gg].ToString()=="X")
                    {
                        for(int g = (int)k[4];g< (k[4]+(k[1]*6));g+=6) {
                            fSincronas++;
                            sl.SetRowHeight(g, 15); sl.SetRowHeight(g+1, 22); sl.SetRowHeight(g+2, 15); sl.SetRowHeight(g+3, 15); sl.SetRowHeight(g+4, 15); sl.SetRowHeight(g+5, 15);
                            sl.SetCellValue(g,gg, tablaDatos.Rows[i]["NRC"].ToString() + " (" + tablaDatos.Rows[i]["MATERIA"].ToString() +"-"+ tablaDatos.Rows[i]["CURSO"].ToString()+")" + tablaDatos.Rows[i]["PERIODO"].ToString());
                            sl.SetCellValue(g+1,gg, tablaDatos.Rows[i][9].ToString());
                            sl.SetCellValue(g+2,gg, tablaDatos.Rows[i]["BLOQUE"].ToString());
                            if (blackBoard) { 
                                if (tablaDatos.Rows[i]["LISTA_CRUZADA"].ToString() == "") { 
                                    sl.SetCellValue(g+3,gg, tablaDatos.Rows[i]["PERIODO"].ToString()+"-"+ tablaDatos.Rows[i]["MATERIA"].ToString()+"-"+ tablaDatos.Rows[i]["CURSO"].ToString()+"-NRC_"+ tablaDatos.Rows[i]["NRC"].ToString());
                                }
                                else
                                {
                                    sl.SetCellValue(g+3,gg, tablaDatos.Rows[i]["PERIODO"].ToString() + "-" + tablaDatos.Rows[i]["MATERIA"].ToString() + "-" + tablaDatos.Rows[i]["CURSO"].ToString() + "-LC_" + tablaDatos.Rows[i]["LISTA_CRUZADA"].ToString());

                                }
                            }
                            if (fSincronas <= k[2]) 
                            {
                                sl.SetCellValue(g + 4, gg, "CLASE SÍNCRONA "); 
                            }
                            else 
                            {
                                if (k[6] > 0)
                                {
                                    sl.SetCellValue(g + 4, gg, "CLASE SÍNCRONA " + k[3]);
                                    sl.SetCellValue(g + 5, gg, "CLASE ASÍNCRONA " + (30 - k[3]));
                                    k[6] = 0;
                                }
                                else
                                {
                                    sl.SetCellValue(g + 5, gg, "CLASE ASÍNCRONA");
                                }
                            }
                        }
                    }
                }
                /*Fin Barrido dataset********************************/
            }
            if (tablaDatos.Rows.Count > 0)
            {
                sl.DeleteWorksheet("Sheet1");
                this.crearHorarioApex(ref sl, ref tablaDatos, ref instructorTmp);
                if (horarioPrincipal) { 
                    sl.SelectWorksheet("HORARIO");
                }
                else
                {
                    sl.DeleteWorksheet("HORARIO");
                    sl.SelectWorksheet("HORARIO_MOD_1");
                }
                sl.SaveAs(pathDestino + "\\HORARIO " + instructorTmp + ".xlsx");
                horarioPrincipal = false;
                DataRow dataGridS = dt.NewRow();
                dataGridS["INSTRUCTOR"] = instructorTmp;
                dataGridS["HORARIO_GENERADO"] = pathDestino + "\\HORARIO " + instructorTmp + ".xlsx";
                dt.Rows.Add(dataGridS);
            }

            return dt;
        }


        /********************************************
         * Devuelve parámetros para construir horario
         * *******************************************/

        private double[] devuelveFila(string horario)
        {
            string[] horas = horario.Split("-");
            double[] k = { 0,0,0,0,0,0,0};
            k[0] = devuelveMinutos(horas[0], horas[1]);  //Número de Minutos entre horas
            //k[1] = (((int)(k[0] / 30))) + ((k[0] % 30 > 0) ? 1 : 0); //Número de Filas que necesita replicarse
            k[1] = ((int)(k[0]) / 45) * 2;//Número de Filas que necesita replicarse
            k[2] = (int)(((30* k[1]) * porcentajeHoraSincrona) / 30);
            k[3] = (int)(((30 * k[1]) * porcentajeHoraSincrona)% 30);
            //k[2] = (int)((devuelveMinutos(horas[0], horas[1])* porcentajeHoraSincrona)/30); //Numero de Filas Sincronas
            //k[3] = (int)((devuelveMinutos(horas[0], horas[1]) * porcentajeHoraSincrona) %30); //Número de minutos residuo de Horas Sincronas
            k[4] = 15 + ((devuelveMinutos("07:30", horas[0])/30)*6);//Fila en la que inicia curso
            k[5] = k[1] - k[2];  //Número de Filas Asincronas
            k[6] = ((k[3] >  0) ? 1 : 0);
            return k;
        }
       

        /*
              Devuelve la cantidad de minutos que hay entre las dos hora entregadas en el formato HH:mm*/
        /*******************/
        private int devuelveMinutos(string horaInicio, string horaFin)
        {
            DateTime inicio = DateTime.ParseExact(horaInicio, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            DateTime fin = DateTime.ParseExact(horaFin, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            int minutes = (int)(fin - inicio).TotalMinutes;
            return minutes;
        }


    }
}
