using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace StreamerBotActionRunner
{

    public class VoiceAttackPlugin
    {
        public static string VA_DisplayName()
        {
            return "Streamer.bot Action Runner - v1.0";
        }

        public static string VA_DisplayInfo()
        {
            return "Run actions in Streamer.Bot";
        }

        public static Guid VA_Id()
        {
            return new Guid("{826449D2-CB82-45F1-93F1-CFC62CA12FAE}");
        }

        public static void VA_StopCommand()  
        {
        }

        public static void VA_Init1(dynamic vaProxy)
        {
        }
        
        public static void VA_Exit1(dynamic vaProxy)
        {
        }

        public static void VA_Invoke1(dynamic vaProxy)
        {
            var actionName = vaProxy.GetText("~actionName") ?? "";
            var ipEndPoint = new IPEndPoint(IPAddress.Broadcast, 4242);

            try
            {
                using (var udpClient = new UdpClient { EnableBroadcast = true })
                {
                    var messageBytes = Encoding.ASCII.GetBytes("{\"request\":\"DoAction\",\"action\":{\"name\": \"" + actionName + "\",},\"args\":{\"value\": \"value\",}}");
                    udpClient.Send(messageBytes, messageBytes.Length, ipEndPoint);
                }
            }
            catch (Exception e)
            {
                vaProxy.WriteToLog("UDP sender exception: " + e);
            }
        }
    }
}