using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

namespace splunkWebHook
{
    // sample content = "{\"sid\": \"scheduler__gojimmypi__search__RMD57525c539bfb104b8_at_1488477300_48160\", \"app\": \"search\", \"results_link\": \"https://splunk.pidomain.intra:8000/app/search/@go?sid=scheduler__gojimmypi__search__RMD57525c539bfb104b8_at_1488477300_48160\", \"result\": {\"vendor_severity\": \"\", \"EventCodeDescription\": \"\", \"id\": [\"1255514\"], \"dest\": [\"PISERVER.pidomain.intra\"], \"dvc_nt_host\": [\"PISERVER\"], \"protocol\": \"\", \"_pre_msg\": \"03/02/2017 09:50:18 AM\\nLogName=Application\\nSourceName=MSSQLSERVER\\nEventCode=18453\\nEventType=0\\nType=Information\\nComputerName=PISERVER.pidomain.intra\\nUser=gojimmypi\\nSid=S-1-5-21-117609710-1060284298-1957994488-9984\\nSidType=1\\nTaskCategory=Logon\\nOpCode=None\\nRecordNumber=1255514\\nKeywords=Audit Success, Classic\", \"_time\": \"1488477018\", \"signature\": \"\", \"action\": \"\", \"source\": \"WinEventLog:Application\", \"_sourcetype\": \"WinEventLog:Application\", \"Type\": \"Information\", \"LogName\": \"Application\", \"app\": \"\", \"product\": \"\", \"host\": \"PISERVER\", \"object_category\": \"\", \"enabled\": \"\", \"sourcetype\": \"WinEventLog:Application\", \"punct\": \"//_::_======.....==-------=====_,_=____'\\\\'._____._\", \"change_type\": \"\", \"name\": \"\", \"vendor\": \"\", \"Image_File_Name\": \"\", \"ComputerName\": \"PISERVER.pidomain.intra\", \"EventCode\": \"18453\", \"tag::app\": \"\", \"severity\": [\"0\"], \"Keywords\": \"Audit Success, Classic\", \"_raw\": \"03/02/2017 09:50:18 AM\\nLogName=Application\\nSourceName=MSSQLSERVER\\nEventCode=18453\\nEventType=0\\nType=Information\\nComputerName=PISERVER.pidomain.intra\\nUser=gojimmypi\\nSid=S-1-5-21-117609710-1060284298-1957994488-9984\\nSidType=1\\nTaskCategory=Logon\\nOpCode=None\\nRecordNumber=1255514\\nKeywords=Audit Success, Classic\\nMessage=Login succeeded for user 'PIDOMAIN\\\\gojimmypi'. Connection made using Windows authentication. [CLIENT: 10.17.13.47]\\n\", \"Sid\": \"S-1-5-21-117609710-1060284298-1957994488-9984\", \"eventtype\": [\"winapp\", \"wineventlog_application\", \"wineventlog_windows\"], \"linecount\": \"16\", \"EventType\": \"0\", \"User\": \"gojimmypi\", \"TaskCategory\": \"Logon\", \"dvc\": [\"PISERVER\"], \"user_type\": \"\", \"_eventtype_color\": \"none\", \"event_id\": [\"1255514\"], \"_cd\": \"611:38131519\", \"ids_type\": \"\", \"range\": \"\", \"CategoryString\": \"\", \"tag::eventtype\": [\"alert\", \"os\", \"windows\"], \"status\": \"\", \"splunk_server_group\": \"\", \"_si\": [\"splunk.pidomain.intra\", \"pi_index\"], \"SidType\": \"1\", \"OpCode\": \"None\", \"_indextime\": \"1488477017\", \"signature_id\": \"18453\", \"tag\": [\"alert\", \"os\", \"windows\"], \"RecordNumber\": \"1255514\", \"SourceName\": \"MSSQLSERVER\", \"_serial\": \"0\", \"index\": \"pi_index\", \"_bkt\": \"pi_index~611~0A331DE1-D139-456F-A967-AC974B1CFB2B\", \"transport\": \"\", \"Message\": \"Login succeeded for user 'PIDOMAIN\\\\gojimmypi'. Connection made using Windows authentication. [CLIENT: 10.17.13.47]\", \"splunk_server\": \"splunk.pidomain.intra\"}, \"search_name\": \"HA DEV webhook test\", \"owner\": \"gojimmypi\"}"    string


    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String content = "";
            if (Request.InputStream.Length > 0)
            {
                using (var reader = new StreamReader(Request.InputStream))
                {
                    content = reader.ReadToEnd();
                }
                var json = (JObject)JsonConvert.DeserializeObject(content);
                string appDetails = json["app"].ToString();

                string theHost = json["result"]["host"].ToString();
                string theMessage = json["result"]["Message"].ToString();
            }
            return;
        }
    }
}
