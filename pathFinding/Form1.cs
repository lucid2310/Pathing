using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace pathFinding
{
    public partial class Form1 : Form
    {
        CPathFinding cpath;
        DataBaseUtilities database_interface = new DataBaseUtilities();
        FileUtility file_interface = new FileUtility();
  
        pathFinding.CPathFinding.ROOM_INFO[] worldMap;

        public delegate void UpdateStatus(string update);

        private pathFinding.CPathFinding.ROOM_INFO startRoom
        { get; set; }
        private pathFinding.CPathFinding.ROOM_INFO stopRoom
        { get; set; }

        public readonly string[] directionIndex = new string[] { "N", "S", "E", "W", "NE",
                                                                 "NW", "SE", "SW", "U", "D"};
        public Form1()
        {
            InitializeComponent();
            cpath = new CPathFinding();
            loadWorldMap();

        }
       
        private void loadWorldMap()
        {

            database_interface.connectToDatabase("");

            DataTable roomTable = database_interface.queryDataBaseForTableInformation("Rooms");

            int roomCount = roomTable.Rows.Count;
            
            worldMap = new CPathFinding.ROOM_INFO[roomCount];

            
            for (int rIndex = 0; rIndex < roomTable.Rows.Count; rIndex++)
            {

                worldMap[rIndex].exitData = new List<string>();
                worldMap[rIndex].exitDirection = new List<string>();

                worldMap[rIndex].mapNumber = UInt32.Parse(roomTable.Rows[rIndex]["Map Number"].ToString());
                worldMap[rIndex].roomNumber = UInt32.Parse(roomTable.Rows[rIndex]["Room Number"].ToString());
                worldMap[rIndex].roomName = roomTable.Rows[rIndex]["Name"].ToString();

                foreach (string direction in directionIndex)
                {
                    string tDirection = roomTable.Rows[rIndex][direction].ToString();

                    if (tDirection != "0")
                    {
                        worldMap[rIndex].exitData.Add(tDirection);
                        worldMap[rIndex].exitDirection.Add(direction);

                    }
                }

            }

            cpath.worldMap = worldMap;

        }

        private void updateStatus(string inputUpdate)
        {
            if (InvokeRequired)
            {
                Invoke(new UpdateStatus(updateStatus), new object[] { inputUpdate });
            }
            else
            {
                statusTB.Text = inputUpdate;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cpath == null)
            {
                cpath = new CPathFinding();
                cpath.worldMap = worldMap;
            }

            if (cpath != null)
            {
                if (northernCB.Checked || eastCB.Checked || westCB.Checked || southCB.Checked)
                {
                    cpath.favorDirection = true;
                    setDirectionalWeight();

                }

                statusTB.Text = "Looking for your room, please standby...";

                startRoom = cpath.findRoom(UInt32.Parse(startMapTB.Text), UInt32.Parse(startRoomTB.Text));
                stopRoom = cpath.findRoom(UInt32.Parse(endMapTB.Text), UInt32.Parse(endRoomTB.Text));

                updatePathListOutput(cpath.findPath(startRoom, stopRoom));

                                                   ;
               

               

            }
            cpath = null;

            
        }
        private void updatePathListOutput(List<string> inputPath)
        {
            directionLB.Items.Clear();

            stepsCountTB.Text = inputPath.Count.ToString();

            foreach (string direction in inputPath)
            {
                directionLB.Items.Add(direction);
            }
            if (inputPath.Count != 0)
            {
                statusTB.Text = "Optimal path found!";
            }
        }

        private List<string> getMeaPath(UInt32 _startMap, UInt32 _startRoom, UInt32 _stopMap, UInt32 _stopRoom)
        {
            List<string> loopPath = new List<string>();

            if (cpath == null)
            {
                cpath = new CPathFinding();
                cpath.worldMap = worldMap;
            }
            if (cpath != null)
            {
                statusTB.Text = "Looking for your room, please standby...";

                startRoom = cpath.findRoom(_startMap, _startRoom);
                stopRoom = cpath.findRoom(_stopMap, _stopRoom);
                
                loopPath = cpath.findPath(startRoom, stopRoom);
            }
            cpath = null;

            return loopPath;

        }
        private void setDirectionalWeight()
        {
            if (northernCB.Checked)
            {
                if (!cpath.favoriteDirection.Contains("N"))
                {
                    cpath.favoriteDirection.Add("N");
                }
            }
            else
            {
                if (cpath.favoriteDirection.Contains("N"))
                {
                    cpath.favoriteDirection.Remove("N");
                }
            }
            if (eastCB.Checked)
            {
                if (!cpath.favoriteDirection.Contains("E"))
                {
                    cpath.favoriteDirection.Add("E");
                }
            }
            else
            {
                if (cpath.favoriteDirection.Contains("E"))
                {
                    cpath.favoriteDirection.Remove("E");
                }
            }
            if (southCB.Checked)
            {
                if (!cpath.favoriteDirection.Contains("S"))
                {
                    cpath.favoriteDirection.Add("S");
                }
            }
            else
            {
                if (cpath.favoriteDirection.Contains("S"))
                {
                    cpath.favoriteDirection.Remove("S");
                }
            }
            if (westCB.Checked)
            {
                if (!cpath.favoriteDirection.Contains("W"))
                {
                    cpath.favoriteDirection.Add("W");
                }
            }
            else
            {
                if (cpath.favoriteDirection.Contains("W"))
                {
                    cpath.favoriteDirection.Remove("W");
                }
            }
        }
        private void outputToFileProc(List<string> _path)
        {

            file_interface.writePathToFile(_path, stopRoom);
        }
        private void outputToFileProc(List<string> _path, pathFinding.CPathFinding.ROOM_INFO _startRoom, 
                                      pathFinding.CPathFinding.ROOM_INFO _stopRoom)
        {
            
            file_interface.writePathToFile(_path, _startRoom, _stopRoom);
        }
        private void outputToFileButton_Click(object sender, EventArgs e)
        {
            List<string> mSteps = new List<string>();

            foreach (string step in directionLB.Items)
            {
                mSteps.Add(step);
            }

            outputToFileProc(mSteps, startRoom, stopRoom);

        }

        private void generateLoopButton_Click(object sender, EventArgs e)
        {
            int numberOfPoints = loopGeneratorDG.Rows.Count - 1;

            List<string> metaPath = new List<string>();


            for (int i = 0; i < numberOfPoints; i++)
            {


                List<string> tPath = getMeaPath(UInt32.Parse(loopGeneratorDG[0, i].Value.ToString()), UInt32.Parse(loopGeneratorDG[1, i].Value.ToString()),
                                                UInt32.Parse(loopGeneratorDG[2, i].Value.ToString()), UInt32.Parse(loopGeneratorDG[3, i].Value.ToString()));


                foreach (string step in tPath)
                {
                    metaPath.Add(step);
                }


            }
            updatePathListOutput(metaPath);
            outputToFileProc(metaPath);



        }

     
    }
}
