using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace SigmaNEST.Plugin
{
    public static class SNExtensions
    {
        #region Lists Extensions

        public static List<T> ToList<T>(this ISNListBase list)
        {
            var objectlist = new List<T>();

            var snList = list as ISNListBase2;

            if (snList == null)
                return null;

            snList.Reset();

            while (!snList.EndOfList)
            {
                objectlist.Add((T)snList.GetCurrentAsISNObject());
                snList.MoveNext();
            }
            return objectlist;
        }

        /// <summary>
        /// Gets a part from the parts list by name
        /// </summary>
        /// <param name="partsList"></param>
        /// <param name="partName"></param>
        /// <returns></returns>
        public static ISNPartObj GetByName(this ISNPartsList partsList, string partName)
        {
            partsList.Reset();

            while (!partsList.EndOfList)
            {
                var part = partsList.Current;

                if (part.Name.Equals(partName, StringComparison.InvariantCultureIgnoreCase))
                    return part;

                partsList.MoveNext();
            }
            return null;
        }

        /// <summary>
        /// Removes a part from the parts list by name
        /// </summary>
        /// <param name="partsList"></param>
        /// <param name="partName"></param>
        /// <returns></returns>
        public static bool RemoveByName(this ISNPartsList partsList, string partName)
        {
            partsList.Reset();

            while (!partsList.EndOfList)
            {
                var part = partsList.Current;

                if (part.Name.Equals(partName, StringComparison.InvariantCultureIgnoreCase))
                {
                    partsList.Remove();
                    return true;
                }

                partsList.MoveNext();
            }
            return false;
        }

        /// <summary>
        /// Gets the parts list associated with the nest object
        /// </summary>
        /// <param name="nestObj"></param>
        /// <returns></returns>
        public static ISNPartsList PartsList(this ISNNestObj nestObj)
        {
            var task = nestObj.ParentObject as ISNTaskObj;

            if (task != null)
                return task.PartsList;
            else
                return null;
        }

        /// <summary>
        /// Gets a task from the tasks list by name
        /// </summary>
        /// <param name="tasksList"></param>
        /// <param name="taskName"></param>
        /// <returns></returns>
        public static ISNTaskObj GetByName(this ISNTasksList tasksList, string taskName)
        {
            tasksList.Reset();

            while (!tasksList.EndOfList)
            {
                var task = tasksList.Current;

                if (task.Name.Equals(taskName, StringComparison.InvariantCultureIgnoreCase))
                    return task;

                tasksList.MoveNext();
            }
            return null;
        }

        /// <summary>
        /// Removes a task from the tasks list by name
        /// </summary>
        /// <param name="tasksList"></param>
        /// <param name="taskName"></param>
        /// <returns></returns>
        public static bool RemoveByName(this ISNTasksList tasksList, string taskName)
        {
            tasksList.Reset();

            while (!tasksList.EndOfList)
            {
                var task = tasksList.Current;

                if (task.Name.Equals(taskName, StringComparison.InvariantCultureIgnoreCase))
                {
                    tasksList.Remove();
                    return true;
                }

                tasksList.MoveNext();
            }
            return false;
        }

        /// <summary>
        /// Gets a sheet from the sheets list by name
        /// </summary>
        /// <param name="sheetsList"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        public static ISNSheetObj GetByName(this ISNSheetsList sheetsList, string sheetName)
        {
            sheetsList.Reset();

            while (!sheetsList.EndOfList)
            {
                var sheet = sheetsList.Current;

                if (sheet.Name.Equals(sheetName, StringComparison.InvariantCultureIgnoreCase))
                    return sheet;

                sheetsList.MoveNext();
            }
            return null;
        }

        /// <summary>
        /// Removes a sheet from the sheets list by name
        /// </summary>
        /// <param name="sheetsList"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        public static bool RemoveByName(this ISNSheetsList sheetsList, string sheetName)
        {
            sheetsList.Reset();

            while (!sheetsList.EndOfList)
            {
                var task = sheetsList.Current;

                if (task.Name.Equals(sheetName, StringComparison.InvariantCultureIgnoreCase))
                {
                    sheetsList.Remove();
                    return true;
                }

                sheetsList.MoveNext();
            }
            return false;
        }

        /// <summary>
        /// Gets a nest from the nests list by name
        /// </summary>
        /// <param name="nestsList"></param>
        /// <param name="nestName"></param>
        /// <returns></returns>
        public static ISNNestObj GetByName(this ISNNestsList nestsList, string nestName)
        {
            nestsList.Reset();

            while (!nestsList.EndOfList)
            {
                var nest = nestsList.Current;

                if (nest.ProgramName.Equals(nestName, StringComparison.InvariantCultureIgnoreCase))
                    return nest;

                nestsList.MoveNext();
            }
            return null;
        }

        /// <summary>
        /// Removes a nest from the nests list by name
        /// </summary>
        /// <param name="nestsList"></param>
        /// <param name="nestName"></param>
        /// <returns></returns>
        public static bool RemoveByName(this ISNNestsList nestsList, string nestName)
        {
            nestsList.Reset();

            while (!nestsList.EndOfList)
            {
                var nest = nestsList.Current;

                if (nest.ProgramName.Equals(nestName, StringComparison.InvariantCultureIgnoreCase))
                {
                    nestsList.Remove();
                    return true;
                }

                nestsList.MoveNext();
            }
            return false;
        }

        /// <summary>
        /// Gets a nested part object from the nested parts list by name
        /// </summary>
        /// <param name="nestedPartsList"></param>
        /// <param name="partName"></param>
        /// <returns></returns>
        public static List<ISNNestedPartObj> GetByName(this ISNNestedPartsList nestedPartsList, string partName)
        {
            var nestPartList = new List<ISNNestedPartObj>();
            var task = nestedPartsList.OwnerObject.ParentObject as ISNTaskObj;

            if (task != null)
            {
                var part = task.PartsList.GetByName(partName);

                nestedPartsList.Reset();

                while (!nestedPartsList.EndOfList)
                {
                    var nestedPart = nestedPartsList.Current;

                    if (nestedPart.NestedPartID == part.PartID)
                        nestPartList.Add(nestedPart);

                    nestedPartsList.MoveNext();
                }

                return nestPartList;
            }
            return null;
        }

        /// <summary>
        /// Removes a nested part object from the nested parts list by name
        /// </summary>
        /// <param name="nestedPartsList"></param>
        /// <param name="partName"></param>
        /// <returns></returns>
        public static bool RemoveByName(this ISNNestedPartsList nestedPartsList, string partName)
        {
            var result = false;
            var task = nestedPartsList.OwnerObject.ParentObject as ISNTaskObj;

            if (task != null)
            {
                var part = task.PartsList.GetByName(partName);

                nestedPartsList.Reset();

                while (!nestedPartsList.EndOfList)
                {
                    var nestedPart = nestedPartsList.Current;

                    if (nestedPart.NestedPartID == part.PartID)
                    {
                        nestedPartsList.Remove();
                        result = true;
                        continue;
                    }

                    nestedPartsList.MoveNext();
                }
            }
            return result;
        }

        #endregion

        #region Object Extensions

        /// <summary>
        /// Removes a part object from its containing list
        /// </summary>
        /// <param name="partObj"></param>
        /// <returns></returns>
        public static bool Remove(this ISNPartObj partObj)
        {
            var partsList = partObj.OwnerList as ISNPartsList;

            if (partsList != null)
                return partsList.RemoveByName(partObj.Name);

            return false;
        }

        /// <summary>
        /// Removes a task object from its containing list
        /// </summary>
        /// <param name="taskObj"></param>
        /// <returns></returns>
        public static bool Remove(this ISNTaskObj taskObj)
        {
            var tasksList = taskObj.OwnerList as ISNTasksList;

            if (tasksList != null)
                return tasksList.RemoveByName(taskObj.Name);

            return false;
        }

        /// <summary>
        /// Removes a sheet object from its containing list
        /// </summary>
        /// <param name="sheetObj"></param>
        /// <returns></returns>
        public static bool Remove(this ISNSheetObj sheetObj)
        {
            var sheetsList = sheetObj.OwnerList as ISNSheetsList;

            if (sheetsList != null)
                return sheetsList.RemoveByName(sheetObj.Name);

            return false;
        }

        /// <summary>
        /// Removes a nest object from its containing list
        /// </summary>
        /// <param name="nestObj"></param>
        /// <returns></returns>
        public static bool Remove(this ISNNestObj nestObj)
        {
            var nestsList = nestObj.OwnerList as ISNNestsList;

            if (nestsList != null)
                return nestsList.RemoveByName(nestObj.ProgramName);

            return false;
        }

        /// <summary>
        /// Removes a nested part object from its containing list
        /// </summary>
        /// <param name="nestedPartObj"></param>
        /// <returns></returns>
        public static bool Remove(this ISNNestedPartObj nestedPartObj)
        {
            var result = false;
            var nestedPartsList = nestedPartObj.OwnerList as ISNNestedPartsList;

            if (nestedPartsList != null)
            {
                nestedPartsList.Reset();

                while (!nestedPartsList.EndOfList)
                {
                    var nestedPart = nestedPartsList.Current;

                    if (nestedPart.NestedPartID == nestedPartObj.NestedPartID)
                    {
                        nestedPartsList.Remove();
                        result = true;
                        continue;
                    }

                    nestedPartsList.MoveNext();
                }
            }

            return result;
        }

        /// <summary>
        /// Adds standard part objects to a part group
        /// </summary>
        /// <param name="partGroupObj"></param>
        /// <param name="partObj"></param>
        public static void AddPart(this ISNPartGroupObj partGroupObj, ISNPartObj partObj)
        {
            var handle = Marshal.GetComInterfaceForObject(partObj, typeof(ISNPartObj));
            partGroupObj.AddInstanceOfPart(handle);
            Marshal.Release(handle);
        }

        /// <summary>
        /// Removes leadins and leadouts from a part
        /// </summary>
        /// <param name="partObj"></param>
        public static void DeleteLeadInOut(this ISNPartObj partObj)
        {
            var partPolyLinesList = partObj.PartPolyLinesList;
            partPolyLinesList.Reset();

            while (!partPolyLinesList.EndOfList)
            {
                var partPolyLineObj = partPolyLinesList.Current;
                partPolyLineObj.DeleteLeadins();
                partPolyLineObj.DeleteLeadouts();

                partPolyLinesList.MoveNext();
            }
        }

        /// <summary>
        /// Refreshes the SigmaNEST view and configuration
        /// </summary>
        /// <param name="snApp"></param>
        public static void Refresh(this ISNApp snApp)
        {
            snApp.RefreshTreeView();
            snApp.PartTile();
            snApp.AutoScale();
            snApp.ExecuteBatchCommand("RELOADCONFIG");
        }

        /// <summary>
        /// Gets a bitmap of an SNObject
        /// </summary>
        /// <param name="snObj"></param>
        /// <param name="xSize"></param>
        /// <param name="ySize"></param>
        /// <param name="drawType"></param>
        /// <returns></returns>
        public static Bitmap GetBmpImage(this ISNObject snObj, int xSize = 0, int ySize = 0, DrawTypeEum drawType = DrawTypeEum.Draw_All)
        {
            // Create a unique temporary file name
            string tmpImgPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".bmp");

            // Get default size from object if not passed
            if ((xSize == 0) || (ySize == 0))
            {
                double minX, minY, maxX, maxY;
                snObj.GetXYExtents(true, true, out minX, out minY, out maxX, out maxY);

                xSize = (int)Math.Ceiling(maxX - minX);
                ySize = (int)Math.Ceiling(maxY - minY);
            }

            // Save image from SigmaNest
            ISaveBitmap saveBmp = (ISaveBitmap)snObj;
            saveBmp.SaveBitMapImage2(xSize, ySize, BitMapPixelFormat.bmppf_device, (int)drawType, tmpImgPath);

            // Create a file stream to read in the image
            FileStream bitmapFileStream = new FileStream(tmpImgPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            // Create a Bitmap object using the stream
            Bitmap bitmapImage = new Bitmap(bitmapFileStream);

            // Clean up resources
            try
            {
                File.Delete(tmpImgPath);
            }
            catch { }

            // Return object in memory
            return bitmapImage;
        }

        #endregion
    }
}
