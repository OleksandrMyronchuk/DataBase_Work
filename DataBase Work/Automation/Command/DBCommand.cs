using System;

//namespace DataBase_Work.Automation.Command
//{
//    class DBCommand
//    {
//        public const int CommandsSize = 5;
//        public static string[][] Commands = new string[CommandsSize][];

//        public DBCommand()
//        {
//            // Priority 1
//            Commands[0] = new string[2];
//            Commands[0][0] = "SAVETOFILE";
//            Commands[0][1] = "ENDSAVETOFILE";

//            // Priority 2
//            Commands[1] = new string[2];
//            Commands[1][0] = "CONNECT";
//            Commands[1][1] = "UNCONNECT";

//            // Priority 3
//            Commands[2] = new string[2];
//            Commands[2][0] = "IF";
//            Commands[2][1] = "ENDIF";

//            // Priority 4
//            Commands[3] = new string[1];
//            Commands[3][0] = "STOP";

//            // Priority 5
//            Commands[4] = new string[1];
//            Commands[4][0] = "MESSAGE";
//        }
        
//        private void FindCommand(string text)
//        {
//            for (int i = 0; i < CommandsSize; i++)
//            {
//                /**/
//                int indexOfStartCommand = text.IndexOf("[" + Commands[i][0]);
//                int indexOfEndCommand = text.IndexOf("]", indexOfStartCommand);
//                /**/
//                int difference = indexOfStartCommand - indexOfEndCommand;
//                /**/
//                if (difference > 255)
//                {
//                    throw new Exception(
//                        "Error! There are more than 255 characters difference " +
//                        "between the \"[\" and \"]\" brackets");
//                }
//                /*Params*/
//                /*First param*/
//                /*del
//                 =
//                 From first char 
//                 To first space or "]" char
//                 */
//                int indexOfStartFirstParam = indexOfStartCommand + 1 + Commands[i][0].Length;
//                if(!(text[indexOfStartFirstParam]=='=' && text[indexOfStartFirstParam] == '"'))
//                {
//                    throw new Exception(
//                        "Error! No parameter found");
//                }
//                indexOfStartFirstParam += 2;
//                int indexOfEndFirstParam = text.IndexOf("\"", indexOfStartFirstParam);
//                //? = indexOfStartFirstParam * indexOfEndFirstParam

//                /*Param list*/
//                int indexOfStartNextParam = indexOfEndFirstParam + 1;
//                for (?)
//                {
//                    string buffer = "";
//                    for (int j = 0; j < indexOfStartNextParam; j++)
//                    {
//                        if (text[indexOfStartNextParam] != ' ')
//                        {
//                            if(text[indexOfStartNextParam] == '=')
//                            {
//                                buffer2 = buffer;
//                            }
//                            if(key)
//                            {
//                                //done
//                            }
//                            buffer += text[indexOfStartNextParam];
//                            key = true;
//                        }

//                    }
//                }

//                /**/
//                if (Commands[i].Length == 2)
//                {
//                    int indexOfCommand2 = text.IndexOf("[" + Commands[i][1] + "]");
//                }
//            }
//        }
//    }
//}

/*
             
             [CONNECT="DataBase Name"] Priority 2
             [UNCONNECT]
             [IF="A{=,!,>,<,=<,=>}{&,|}..."] Priority 3
                 [COMPARE]QUERY -> RETURN VALUE[ENDCOMPARE]
                 [DO]...[ENDDO]
                 [ELSEDO]...[ENDELSEDO]
             [ENDIF] (A==RETURN) //=,!,>,<,=<,=>
             [STOP] Priority 4
             [MESSAGE="value"] Priority 5
             [SAVETOFILE="path.extension" FETCH="Y/N" COLDIVIDER="|" HEADER="Y/N"] Priority 1
             [ENDSAVETOFILE]

            метод який знаходить / парсить параметри
            що робити коли [ зустрічається в запиті (наприклад:в лапках) ?
            -> Має бути структура [КОМАНДА]

            [CONNECT="[Черкаси] ol_2300_olbp"]
              [IF="150= & 21108="]
                 [COMPARE]Select payment_sum, status_id From payments where id=1037489514[ENDCOMPARE]
                 [DO]Update payments Set status_id=21107 where id=1012700811;[ENDDO]
                 [ELSEDO]
                    [CONNECT="[Черкаси] ol_2300_olbp"]
                      [IF="150= & 21108="]
                         [COMPARE]Select payment_sum, status_id From payments where id=1037489514[ENDCOMPARE]
                         [DO]Update payments Set status_id=21107 where id=1012700811;[ENDDO]
                         [ELSEDO][MESSAGE="Error on the query number 1"][STOP][ENDELSEDO]
                      [ENDIF]
                      [IF="150= & 21108="]
                         [COMPARE]Select payment_sum, status_id From payments where id=1037489514[ENDCOMPARE]
                         [DO]Update payments Set status_id=21107 where id=1012700811;[ENDDO]
                         [ELSEDO][MESSAGE="Error on the query number 1"][STOP][ENDELSEDO]
                      [ENDIF]
                    [UNCONNECT]
                 [ENDELSEDO]
              [ENDIF]
              [IF="150= & 21108="]
                 [COMPARE]Select payment_sum, status_id From payments where id=1037489514[ENDCOMPARE]
                 [DO]Update payments Set status_id=21107 where id=1012700811;[ENDDO]
                 [ELSEDO][MESSAGE="Error on the query number 1"][STOP][ENDELSEDO]
              [ENDIF]
            [UNCONNECT]
            [CONNECT="[Черкаси] ol_2300_olbp"]
              [IF="150= & 21108="]
                 [COMPARE]Select payment_sum, status_id From payments where id=1037489514[ENDCOMPARE]
                 [DO]Update payments Set status_id=21107 where id=1012700811;[ENDDO]
                 [ELSEDO][MESSAGE="Error on the query number 1"][STOP][ENDELSEDO]
              [ENDIF]
              [IF="150= & 21108="]
                 [COMPARE]Select payment_sum, status_id From payments where id=1037489514[ENDCOMPARE]
                 [DO]Update payments Set status_id=21107 where id=1012700811;[ENDDO]
                 [ELSEDO][MESSAGE="Error on the query number 1"][STOP][ENDELSEDO]
              [ENDIF]
            [UNCONNECT]
             */
