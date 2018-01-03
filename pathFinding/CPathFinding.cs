using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Threading;
using System.Windows.Forms;

namespace pathFinding
{
    public class CPathFinding
    {
        
        public struct EXIT_DATA
        {
            public int _ExitData;
            public string _ExitDirection;
        }

        public class CCellTypes
        {
            public const int ROOM = 1;
            public const int MAP = 0;
        }

        public struct ROOM_INFO
        {
            public UInt32 mapNumber;
            public UInt32 roomNumber;
            public string roomName;
            public List<string> exitData;
            public List<string> exitDirection;
            public bool visited;
            public int distanceValue;
        }
      
        public struct DISTANCE_INFO
        {
            public int _Distance;
            public ROOM_INFO _Vertex;
        }

        public int roomsSearched
        { get; set; }
        ROOM_INFO startRoom
        { get; set; }
        ROOM_INFO stopRoom
        { get; set; }
        List<string> destinationPath
        { get; set; }
        public bool favorDirection
        { get; set; }
        public List<string> favoriteDirection
        { get; set; }
        public ROOM_INFO[] worldMap
        { get; set; }

        EXIT_DATA[] priorityDirectionList = new EXIT_DATA[10];

        Queue<ROOM_INFO> startQueue = new Queue<ROOM_INFO>();
        Thread findRouteThread;
       
        public void setStartRoom(UInt32 map, UInt32 room)
        {
            startRoom = findRoom(map, room);
        }

        public void setStopRoom(UInt32 map, UInt32 room)
        {
            stopRoom = findRoom(map, room);
        }

        private string oppositeDirection(string inputDirection)
        {
            string direction = "";

            switch (inputDirection)
            {
                case "U":
                    direction = "D";
                    break;
                case "D":
                    direction = "U";
                    break;
                case "N":
                    direction = "S";
                    break;
                case "S":
                    direction = "N";
                    break;
                case "E":
                    direction = "W";
                    break;
                case "W":
                    direction = "E";
                    break;
                case "NW":
                    direction = "SE";
                    break;
                case "NE":
                    direction = "SW";
                    break;
                case "SE":
                    direction = "NW";
                    break;
                case "SW":
                    direction = "NE";
                    break;





            }
            return direction;
        }

        private void loadWorldMap(ROOM_INFO[] inputMap)
        {
            worldMap = inputMap;
        }

        public List<string> findPath(ROOM_INFO fromRoom, ROOM_INFO toRoom)
        {



            if (findRouteThread == null)
            {
                startRoom = fromRoom;
                stopRoom = toRoom;

                destinationPath = new List<string>();


                findRouteThread = new Thread(findRoute);

                findRouteThread.Start();

                while (findRouteThread.IsAlive)
                {

                }
                findRouteThread.Abort();
                findRouteThread = null;
            }
            else
            {
                MessageBox.Show("Already generating a path, please wait...");
            }

            return destinationPath;
        }

        public CPathFinding()
        {
            favoriteDirection = new List<string>();
        }

        public ROOM_INFO findRoom(UInt32 map, UInt32 room)
        {
            return Array.Find(worldMap, fRoom => fRoom.mapNumber == map && fRoom.roomNumber == room);
        }

        public string roomToRoomDirection(ROOM_INFO currentRoom, ROOM_INFO nextRoom)
        {
            string direction = "";
            int dIndex = 0;
            foreach (string exit in currentRoom.exitData)
            {

                ROOM_INFO extractRoomData = extractMapRoom(exit);

                if (extractRoomData.Equals(nextRoom))
                {

                    direction = currentRoom.exitDirection[dIndex];
                    if (direction == "")
                    {

                    }
                    direction = oppositeDirection(direction);
                    break;
                }
                dIndex++;


            }

            return direction;
        }

        public void findRoute()
        {

            Dictionary<ROOM_INFO, bool> visitedStartRooms = new Dictionary<ROOM_INFO, bool>();
            Dictionary<ROOM_INFO, ROOM_INFO> pathTrace = new Dictionary<ROOM_INFO, ROOM_INFO>();

            if (favorDirection)
            {


            }

            startQueue.Enqueue(startRoom); // Queue up the initial room
           
            visitedStartRooms.Add(startRoom, true);// say we have been there, done that
            ROOM_INFO currentRoom = new ROOM_INFO();
            ROOM_INFO nextRoom = new ROOM_INFO();
            List<string> directionForSearch = new List<string>();

            DateTime startTime = DateTime.Now;
            string adjacentRoomData = "";

            while (startQueue.Count != 0)
            {
                currentRoom = startQueue.Dequeue();
              
                if (currentRoom.Equals(stopRoom))
                {
                   
                    break;
                }
                else
                {
                    if (favorDirection)
                    {
                        directionForSearch = reOrderDirections(currentRoom);
                    }
                    else
                    {
                        directionForSearch = currentRoom.exitData;
                    }

                    for(int adjacentRoom = 0; adjacentRoom < currentRoom.exitData.Count; adjacentRoom++)
                    {
                        
                        adjacentRoomData = directionForSearch[adjacentRoom];

                        nextRoom = extractMapRoom(adjacentRoomData);

                       
                            if (nextRoom.mapNumber != 0)
                            {
                                if (!pathTrace.ContainsKey(nextRoom))
                                {
                                    startQueue.Enqueue(nextRoom);
                                    pathTrace.Add(nextRoom, currentRoom);
                                }
                            }
                            
                        
                            
                    }
                } 
            } // end of while

            if (startRoom.Equals(stopRoom))
            {
                destinationPath.Add("Already There");
            }
            else
            {
                // set the final destination path.
                destinationPath = determinePath(pathTrace, stopRoom, startRoom);
                DateTime stopTime = DateTime.Now;
                TimeSpan duration = stopTime - startTime;
            }
        }

        public List<string> reOrderDirections(ROOM_INFO inputRoom)
        {
            List<string> iList = new List<string>();
            priorityDirectionList = new EXIT_DATA[10];
            foreach (string dir in inputRoom.exitDirection)
            {

                iList.Add(dir);

            }
            
            int pIndex = 0;

            foreach (string direct in favoriteDirection)
            {
                if (iList.Contains(direct))
                {
                    priorityDirectionList[pIndex]._ExitDirection = direct;
                    priorityDirectionList[pIndex++]._ExitData = inputRoom.exitDirection.IndexOf(direct);
                    iList.Remove(direct);
                }
            }

            List<string> iCloneList = new List<string>();

            foreach (string dir in iList)
            {
                iCloneList.Add(dir);
            }



            if (iList.Count != 0)
            {
                foreach (string direct in iCloneList)
                {
                    priorityDirectionList[pIndex]._ExitData = inputRoom.exitDirection.IndexOf(direct);
                    priorityDirectionList[pIndex++]._ExitDirection = direct;
                    iList.Remove(direct);
                }
            }

            foreach(EXIT_DATA direct in priorityDirectionList)
            {
                if (direct._ExitDirection != null)
                {
                    iList.Add(inputRoom.exitData[direct._ExitData]);
                }
            }
          
           
            return iList;

        }

        public List<string> determinePath(Dictionary<ROOM_INFO, ROOM_INFO> inputPossiblePath, ROOM_INFO destination, ROOM_INFO start)
        {
            ROOM_INFO destinationRoom = destination;
            ROOM_INFO startRoom  = start;
            ROOM_INFO parent = new ROOM_INFO();
            ROOM_INFO backTrackRoom = destinationRoom;
            List<string> directions = new List<string>();
            //directions.Add("Destination => " + destinationRoom.roomName);

            while (!parent.Equals(startRoom))
            {
                parent = inputPossiblePath[backTrackRoom];

                string direction = roomToRoomDirection(backTrackRoom, parent);

                if (direction.Trim() == "")
                {
                   
                }

                directions.Add(direction);

                backTrackRoom = parent;

            }
            //directions.Add("Start => " + start.roomName);

            directions.Reverse();

            return directions;
        }

        public ROOM_INFO extractMapRoom(string sExit)
        {

            byte tMap = 0;
            ushort tRoom = 0;

            if (sExit.Contains("/"))
            {
                string[] room_data = sExit.Split('/');

                room_data[0] = room_data[0].PadLeft(2, ' ');
                room_data[1] = room_data[1].PadLeft(5, ' ');

                if (room_data.Length > 1)
                {
                    tMap = byte.Parse(room_data[0].Substring(room_data[0].Length - 2, 2).Trim());

                    if (room_data[1].Contains("("))
                    {
                        tRoom = ushort.Parse(room_data[1].Remove(room_data[1].IndexOf("(")));
                    }
                    else if (room_data[1].Contains("]:"))
                    {
                        tRoom = ushort.Parse(room_data[1].Remove(room_data[1].IndexOf(']')));
                    }
                    else
                    {
                        tRoom = ushort.Parse(room_data[1].Trim());
                    }
                }
            }

            return findRoom(tMap, tRoom);
        }

        


    }
}
