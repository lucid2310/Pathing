using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace pathFinding
{
    class FileUtility
    {
        public void writePathToFile(List<string> inputPath, 
                                    pathFinding.CPathFinding.ROOM_INFO fromRoom, 
                                    pathFinding.CPathFinding.ROOM_INFO toRoom)
        {
            System.Reflection.Assembly exe = System.Reflection.Assembly.GetEntryAssembly(); 
            string filePath = System.IO.Path.GetDirectoryName(exe.Location);

            using (StreamWriter outfile = new StreamWriter(filePath + @"\Resources\" + 
                                                           fromRoom.mapNumber.ToString() + "_" + fromRoom.roomNumber.ToString() + 
                                                           " to " + toRoom.mapNumber.ToString() + "_" + toRoom.roomNumber.ToString() + ".txt"))
            {
                foreach (string step in inputPath)
                {
                    outfile.WriteLine(step);
                }
            }
        }

        public void writePathToFile(List<string> inputPath, pathFinding.CPathFinding.ROOM_INFO startRoom)
        {
            System.Reflection.Assembly exe = System.Reflection.Assembly.GetEntryAssembly();
            string filePath = System.IO.Path.GetDirectoryName(exe.Location);

            using (StreamWriter outfile = new StreamWriter(filePath + @"\Resources\" + "Loop_" + startRoom.roomName + ".txt"))
            {
                foreach (string step in inputPath)
                {
                    outfile.WriteLine(step);
                }
            }
        }
    }
}
