using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static public int NoIndividualParticpant = 0;
        static public int MaxIndividualParticipant = 20;
        static public int NoTeamParticpant = 0;
        static public int MaxTeamParticipant = 4;
        static public int MaxTeamEvent = 5;
        static public int MaxIndividualEvent = 5;




        struct IndividualParticipant
        {
            public string IndividualID;
            public string Firstname;
            public string Surname;
            public string IndividualYearGroup;
            public string TeamID;
            public string FirstTeamMmeber;
            public string SecondTeamMmeber;
            public string ThirdTeamMmeber;
            public string FourthTeamMmeber;
            public string FifthTeamMmeber;
            public string TeamYearGroup;


        }

        struct Events
        {
            public string IndividualEventID;
            public string TeamEventID;
            public string IndividualEventsType;
            public string TeamEventsType;

        }

        struct IndiviudalScores
        {
            public string IndividualID;
            public string IndividualEventID;
            public int score;
        }

        struct TeamScores
        {
            public string TeamID;
            public string TeamEventID;
            public int score;
        }

        static IndividualParticipant[] IndividualParticipantInformation = new IndividualParticipant[MaxIndividualParticipant];
        static IndividualParticipant[] TeamParticipantInformation = new IndividualParticipant[MaxTeamParticipant];
        static Events[] IndividualEvents = new Events[MaxIndividualEvent];
        static Events[] TeamEvents = new Events[MaxTeamEvent];
        static IndiviudalScores[] IndiviudalScoresList = new IndiviudalScores[99];
        static TeamScores[] TeamScoresList = new TeamScores[99];


        static void Main(string[] args)
        {
            //Define local variables
            int menuChoice = 0;
            AddIndividualEvent();
            AddTeamEvent();
            do
            {
                try
                {
                    // Display menu options
                    Console.WriteLine("Welcome to the Tournament");
                    Console.WriteLine();
                    Console.WriteLine("1. Maintain Participant / Team");
                    Console.WriteLine("2. Maintain Events");
                    Console.WriteLine("3. Record Score");
                    Console.WriteLine("4. Reports");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine();
                    Console.WriteLine("Enter choice: ");
                    menuChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    switch (menuChoice)
                    {
                        case 1:
                            //Console.WriteLine("Choice 1 selected");
                            //Console.WriteLine();
                            subMenuParticipants(); // Calling subMenuparticipants() procedure
                            break;
                        case 2:
                            //Console.WriteLine("Choice 2 selected");
                            //Console.WriteLine();
                            subMenuEvent(); // Calling subMenuEvents() procedure
                            break;
                        case 3:
                            //Console.WriteLine("Choice 3 selected");
                            //Console.WriteLine();
                            subMenuRecordScores(); // Calling subMenuEvents() procedure

                            break;
                        case 4:
                            //Console.WriteLine("Choice 4 selected");
                            //Console.WriteLine();
                            subMenuReport(); // Calling subMenuEvents() procedure
                            break;
                    }
                }

                catch
                {
                    Console.WriteLine("Error, wrong input");
                }

            } while (menuChoice != 5);
        }//end main

        static void subMenuParticipants()
        {
            //Define local variables
            int menuChoice1 = 0;
            do
            {
                try
                {
                    // Display menu options
                    Console.WriteLine("Maintain Participant / Team");
                    Console.WriteLine();
                    Console.WriteLine("1. Add Indiviudal Participant ");
                    Console.WriteLine("2. Add Team Particpant");
                    Console.WriteLine("3. Edit Indiviudal Participant ");
                    Console.WriteLine("4. Edit Team Particpant");
                    Console.WriteLine("5. View Indiviudal Particpant");
                    Console.WriteLine("6. View Team Particpant");
                    Console.WriteLine("7. Exit");
                    Console.WriteLine();
                    Console.WriteLine("Enter choice: ");
                    menuChoice1 = Convert.ToInt32(Console.ReadLine());
                    switch (menuChoice1)
                    {
                        case 1:
                            AddIndividualParticipant();
                            break;
                        case 2:
                            AddTeamParticipant();
                            break;
                        case 3:
                            EditIndividualParticipant();
                            break;
                        case 4:
                            EditTeamParticipant();
                            break;
                        case 5:
                            ViewIndiviualParticipant();
                            break;
                        case 6:
                            ViewTeamParticipant();
                            break;

                    }
                }
                catch
                {
                    Console.WriteLine("Error, wrong input");
                }

            } while (menuChoice1 != 7);
        }

        static void AddIndividualParticipant()
        {

            try
            {

                if (NoIndividualParticpant >= MaxIndividualParticipant)
                {
                    Console.WriteLine("Max Individual of participants reached. Cannot add any more records...");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please input Individual participant Information");
                    Console.WriteLine();
                    Console.WriteLine("Please enter the particpant Indiviual Id: ");
                    IndividualParticipantInformation[NoIndividualParticpant].IndividualID = Console.ReadLine();
                    Console.WriteLine("Please enter the particpant Firstname: ");
                    IndividualParticipantInformation[NoIndividualParticpant].Firstname = Console.ReadLine();
                    Console.WriteLine("Please enter the particpant Surname: ");
                    IndividualParticipantInformation[NoIndividualParticpant].Surname = Console.ReadLine();
                    Console.WriteLine("Please enter the particpant Year Group: ");
                    IndividualParticipantInformation[NoIndividualParticpant].IndividualYearGroup = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Participant Information has been saved!");
                    Console.WriteLine("Please enter any key to continue");
                    Console.ReadLine();
                    NoIndividualParticpant = NoIndividualParticpant + 1;


                }

            }
            catch
            {
                Console.WriteLine("Error, wrong input");
            }

        }

        static void AddTeamParticipant()
        {
            if (NoTeamParticpant >= MaxTeamParticipant)
            {
                Console.WriteLine("Max Team of participants reached. Cannot add any more records...");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please input Team participant infromation");
                Console.WriteLine();
                Console.WriteLine("Please enter your Team Id: ");
                TeamParticipantInformation[NoTeamParticpant].TeamID = Console.ReadLine();
                Console.WriteLine("Please enter the first members name: ");
                TeamParticipantInformation[NoTeamParticpant].FirstTeamMmeber = Console.ReadLine();
                Console.WriteLine("Please enter the second members name: ");
                TeamParticipantInformation[NoTeamParticpant].SecondTeamMmeber = Console.ReadLine();
                Console.WriteLine("Please enter the third members name: ");
                TeamParticipantInformation[NoTeamParticpant].ThirdTeamMmeber = Console.ReadLine();
                Console.WriteLine("Please enter the fourth members name: ");
                TeamParticipantInformation[NoTeamParticpant].FourthTeamMmeber = Console.ReadLine();
                Console.WriteLine("Please enter the fifth members name: ");
                TeamParticipantInformation[NoTeamParticpant].FifthTeamMmeber = Console.ReadLine();
                Console.WriteLine("Please enter your Year Group: ");
                TeamParticipantInformation[NoTeamParticpant].TeamYearGroup = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Team Participant has been added");
                Console.WriteLine("Please enter any key to continue");
                NoTeamParticpant = NoTeamParticpant + 1;
                Console.ReadLine();
            }
        }

        static void EditIndividualParticipant()
        {
            Console.WriteLine();
            Console.WriteLine("Editing Indiviudal Participant details");
            Console.WriteLine();
            Console.WriteLine("Enter Indiviudal Participant Id: ");
            string Searchid = Console.ReadLine();
            Boolean found = false;
            int index = 0;
            do
            {
                if (IndividualParticipantInformation[index].IndividualID == Searchid)
                {
                    found = true;
                    break;
                }
                index = index + 1;

            } while ((index <= NoIndividualParticpant - 1) | found);
            if (!found)
            {
                Console.WriteLine("Error! No such record found.");
            }
            else
            {
                Console.Write(IndividualParticipantInformation[index].IndividualID + "\t" + IndividualParticipantInformation[index].Firstname + "\t" + IndividualParticipantInformation[index].Surname + "\t" + IndividualParticipantInformation[index].IndividualYearGroup);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Edit details of Participant / Team");
                Console.WriteLine("Re-enter firstname: ");
                IndividualParticipantInformation[index].Firstname = Console.ReadLine();
                Console.WriteLine("Re-enter surname: ");
                IndividualParticipantInformation[index].Surname = Console.ReadLine();
                Console.WriteLine("Re-enter year group: ");
                IndividualParticipantInformation[index].IndividualYearGroup = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Record has been edited. Press any key to continue...");
            }
            Console.WriteLine();
        }

        static void EditTeamParticipant()
        {
            Console.WriteLine();
            Console.WriteLine("Editing Team Participant details");
            Console.WriteLine();
            Console.WriteLine("Enter Team Participant Id: ");
            string Searchid = Console.ReadLine();
            Boolean found = false;
            int index = 0;
            do
            {
                if (TeamParticipantInformation[index].TeamID == Searchid)
                {
                    found = true;
                    break;
                }
                index = index + 1;

            } while ((index <= NoTeamParticpant - 1) | found);
            if (!found)
            {
                Console.WriteLine("Error! No such record found.");
            }
            else
            {
                Console.Write(TeamParticipantInformation[index].TeamID + "\t" + TeamParticipantInformation[index].FirstTeamMmeber + "\t" + TeamParticipantInformation[index].SecondTeamMmeber + "\t" + TeamParticipantInformation[index].ThirdTeamMmeber + "\t" + TeamParticipantInformation[index].FourthTeamMmeber + "\t" + TeamParticipantInformation[index].FifthTeamMmeber + "\t" + TeamParticipantInformation[index].TeamYearGroup);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Edit details of Team membera");
                Console.WriteLine("Re-enter the first team members name : ");
                TeamParticipantInformation[index].FirstTeamMmeber = Console.ReadLine();
                Console.WriteLine("Re-enter the second members name: ");
                TeamParticipantInformation[index].SecondTeamMmeber = Console.ReadLine();
                Console.WriteLine("Re-enter the third team members name : ");
                TeamParticipantInformation[index].ThirdTeamMmeber = Console.ReadLine();
                Console.WriteLine("Re-enter the fourth team members name : ");
                TeamParticipantInformation[index].FourthTeamMmeber = Console.ReadLine();
                Console.WriteLine("Re-enter the fifth team members name : ");
                TeamParticipantInformation[index].FifthTeamMmeber = Console.ReadLine();
                Console.WriteLine("Re-enter year group: ");
                TeamParticipantInformation[index].TeamYearGroup = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Record has been edited. Press any key to continue...");
            }
            Console.WriteLine();
        }

        static void ViewTeamParticipant()
        {
            Console.WriteLine("Total number of participants: " + NoTeamParticpant);
            Console.WriteLine("List of Team participants");
            for (int index = 0; index <= NoTeamParticpant - 1; index++)
            {
                Console.WriteLine();
                Console.Write(TeamParticipantInformation[index].TeamID + "\t" + TeamParticipantInformation[index].FirstTeamMmeber + "\t" + TeamParticipantInformation[index].SecondTeamMmeber + "\t" + TeamParticipantInformation[index].ThirdTeamMmeber + "\t" + TeamParticipantInformation[index].FourthTeamMmeber + "\t" + TeamParticipantInformation[index].FifthTeamMmeber + "\t" + TeamParticipantInformation[index].TeamYearGroup);
                Console.WriteLine();

            }
        }

        static void ViewIndiviualParticipant()
        {
            Console.WriteLine("Total number of participants: " + NoIndividualParticpant);
            Console.WriteLine("List of Indiviudal participants");
            for (int index = 0; index <= NoIndividualParticpant - 1; index++)
            {


                Console.WriteLine();
                Console.Write(IndividualParticipantInformation[index].IndividualID + "\t" + IndividualParticipantInformation[index].Firstname + "\t" + IndividualParticipantInformation[index].Surname + "\t" + IndividualParticipantInformation[index].IndividualYearGroup);
                Console.WriteLine("");


            }
        }

        static void subMenuEvent()
        {
            //Define local variables
            int menuChoice2 = 0;
            do
            {
                try
                {


                    // Display menu options
                    Console.WriteLine("Maintain Events");
                    Console.WriteLine();
                    Console.WriteLine("1. Display Individual Events information");
                    Console.WriteLine("2. Display Team Events information");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine();
                    Console.WriteLine("Enter choice: ");
                    menuChoice2 = Convert.ToInt32(Console.ReadLine());
                    switch (menuChoice2)
                    {

                        case 1:
                            ViewIndiviualEvents();
                            break;
                        case 2:
                            ViewTeamEvents();
                            break;



                    }
                }
                catch
                {
                    Console.WriteLine("Error, wrong input");
                }
            } while (menuChoice2 != 3);
        }

        static void AddIndividualEvent()
        {
            IndividualEvents[0].IndividualEventID = "SI1";
            IndividualEvents[0].IndividualEventsType = "Sports - Sack Race";
            IndividualEvents[1].IndividualEventID = "SI2";
            IndividualEvents[1].IndividualEventsType = "Sports - High Jump";
            IndividualEvents[2].IndividualEventID = "SI3";
            IndividualEvents[2].IndividualEventsType = "Sports - 800m Race";
            IndividualEvents[3].IndividualEventID = "AI1";
            IndividualEvents[3].IndividualEventsType = "Academic - Spelling Bee";
            IndividualEvents[4].IndividualEventID = "AI2";
            IndividualEvents[4].IndividualEventsType = "Academic - Maths Quiz";


        }

        static void AddTeamEvent()
        {
            TeamEvents[0].TeamEventID = "ST1";
            TeamEvents[0].TeamEventsType = "Sports - Tug Of War";
            TeamEvents[1].TeamEventID = "ST2";
            TeamEvents[1].TeamEventsType = "Sports - Relay Race";
            TeamEvents[2].TeamEventID = "ST3";
            TeamEvents[2].TeamEventsType = "Sports - Dodgeball";
            TeamEvents[3].TeamEventID = "AT1";
            TeamEvents[3].TeamEventsType = "Academix - The Chase";
            TeamEvents[4].TeamEventID = "AT2";
            TeamEvents[4].TeamEventsType = "Academix - Science Quiz";

        }



        static void ViewIndiviualEvents()
        {
            Console.WriteLine("List of Individual events");
            for (int index = 0; index <= MaxIndividualEvent - 1; index++)
            {
                Console.WriteLine();
                Console.Write(IndividualEvents[index].IndividualEventID + "\t" + IndividualEvents[index].IndividualEventsType);
                Console.WriteLine();
            }
        }

        static void ViewTeamEvents()
        {
            Console.WriteLine("List of Team events");
            for (int index = 0; index <= MaxTeamEvent - 1; index++)
            {
                Console.WriteLine();
                Console.Write(TeamEvents[index].TeamEventID + "\t" + TeamEvents[index].TeamEventsType);
                Console.WriteLine();
            }
        }

        static void subMenuRecordScores()
        {
            //Define local variables
            int menuChoice3 = 0;
            do
            {
                // Display menu options
                Console.WriteLine("Record Scores");
                Console.WriteLine();
                Console.WriteLine("1. Record Individual Particpant Score ");
                Console.WriteLine("2. Record Team Particpant Score");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter choice: ");
                menuChoice3 = Convert.ToInt32(Console.ReadLine());
                switch (menuChoice3)
                {
                    case 1:
                        RecordIndividual();
                        break;
                    case 2:

                        RecordTeam();
                        break;

                }
            } while (menuChoice3 != 3);
        }

        static void RecordIndividual()
        {

            int score_count = 0;
            for (int index = 0; index <= NoIndividualParticpant - 1; index++)
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("Participant [{0}]", index);
                Console.Write(IndividualParticipantInformation[index].IndividualID + "\t" + IndividualParticipantInformation[index].Firstname + "\t" + IndividualParticipantInformation[index].Surname + "\t" + IndividualParticipantInformation[index].IndividualYearGroup);
                Console.WriteLine();
                score_count = score_count + index;
                string temp_id = IndividualParticipantInformation[index].IndividualID;

                for (int index2 = 0; index2 <= MaxIndividualEvent - 1; index2++)
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Event [{0}]", index2);
                    Console.Write(IndividualEvents[index2].IndividualEventID + "\t" + IndividualEvents[index2].IndividualEventsType);
                    Console.WriteLine();
                    Console.WriteLine("Please enter your rank you recived in this event: ");
                    string temp_eventid = IndividualEvents[index2].IndividualEventID;
                    int temp_score = Convert.ToInt32(Console.ReadLine());

                    // Saving data
                    score_count = score_count + index2;
                    IndiviudalScoresList[score_count].IndividualID = temp_id;
                    IndiviudalScoresList[score_count].IndividualEventID = temp_eventid;
                    IndiviudalScoresList[score_count].score = temp_score;

                }
            }
        }


        static void RecordTeam()
        {
            int score_count = 0;
            for (int index = 0; index <= NoTeamParticpant - 1; index++)
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("Participant [{0}]", index);
                Console.Write(TeamParticipantInformation[index].TeamID + "\t" + TeamParticipantInformation[index].FirstTeamMmeber + "\t" + TeamParticipantInformation[index].SecondTeamMmeber + "\t" + TeamParticipantInformation[index].ThirdTeamMmeber + "\t" + TeamParticipantInformation[index].FourthTeamMmeber + "\t" + TeamParticipantInformation[index].FifthTeamMmeber + "\t" + TeamParticipantInformation[index].TeamYearGroup);
                Console.WriteLine();
                score_count = score_count + index;
                string temp_id = TeamParticipantInformation[index].TeamID;

                for (int index2 = 0; index2 <= MaxIndividualEvent - 1; index2++)
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Event [{0}]", index2);
                    Console.Write(TeamEvents[index2].TeamEventID + "\t" + TeamEvents[index2].TeamEventsType);
                    Console.WriteLine();
                    Console.WriteLine("Please enter your rank you recived in this event: ");
                    string temp_eventid = TeamEvents[index2].TeamEventID;
                    int temp_score = Convert.ToInt32(Console.ReadLine());

                    // Saving data
                    score_count = score_count + index2;
                    TeamScoresList[score_count].TeamID = temp_id;
                    TeamScoresList[score_count].TeamEventID = temp_eventid;
                    TeamScoresList[score_count].score = temp_score;

                }
            }
        }

        static void subMenuReport()
        {
            //Define local variables
            int menuChoice4 = 0;
            do
            {
                // Display menu options
                Console.WriteLine("Record Scores");
                Console.WriteLine();
                Console.WriteLine("1. Display Individual Participant Score ");
                Console.WriteLine("2. Display Team Particpant Score");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter choice: ");
                menuChoice4 = Convert.ToInt32(Console.ReadLine());
                switch (menuChoice4)
                {
                    case 1:
                        ViewIndiviualScores();
                        break;
                    case 2:
                        ViewTeamScores();
                        break;

                }
            } while (menuChoice4 != 3);
        }

        static void ViewIndiviualScores()
        {
            Console.WriteLine("RESULTS");
            Console.WriteLine("Student" + "\t" + "Event" + "\t" + "Score");
            for (int index = 0; index <= 98; index++)
            {

                {

                }
            }
        }

        static void ViewTeamScores()
        {

        }
    }//end class
}//end namespace


