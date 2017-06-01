using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PacketLibrary
{
    public enum PacketType
    {
        Connect = 0,
        Login,
        DownLoad_File,
        UpLoad_File,
        Open_Project,
        Open_File,
        Create_Project,
        Refresh,
        Join_Project,
        Leave_Project,
    }
    public enum PacketSendERROR
    {
        정상 = 0,
        에러
    }

    [Serializable]
    public class Packet
    {
        public int Length;
        public int Type;
        public string fileinfo;
        public int sendfile;
        public byte[] Data;

        public Packet()
        {
            this.Length = 0;
            this.Type = 0;
            this.fileinfo = "";
            this.sendfile = 0;
        }

        public static byte[] Serialize(Object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }

        public static Object Deserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            foreach (byte b in bt)
            {
                ms.WriteByte(b);
            }
            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();

            Object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }
    }

    [Serializable]
    public class Connection : Packet
    {
        public string ip;
        public Connection()
        {
            ip = null;
        }
    }

    [Serializable]
    public class Login : Packet
    {
        public string m_strID;
        public Login()
        {
            m_strID = null;
        }
    }
    
    public class DownLoadFile : Packet
    {
        public int indexnum;
        public DownLoadFile()
        {
            indexnum = 0;
        }
    }

    [Serializable]
    public class UpLoadFile : Packet
    {
        public int indexnum;
        public UpLoadFile()
        {
            indexnum = 0;
        }
    }

    [Serializable]
    public class OpenProject : Packet
    {
        public int indexnum;
        public OpenProject()
        {
            indexnum = 0;
        }
    }
    [Serializable]
    public class OpenFile : Packet
    {
        public int indexnum;
        public OpenFile()
        {
            indexnum = 0;
        }
    }

    [Serializable]
    public class CreateProject : Packet
    {
        public int indexnum;
        public CreateProject()
        {
            indexnum = 0;
        }
    }
    [Serializable]
    public class Refresh : Packet
    { 
        public int indexnum;
        public Refresh()
        {
            indexnum = 0;
        }
    }
}
