# splunkWebHook

Basic proof of concept for Splunk webHook JSON receiver.

See: http://docs.splunk.com/Documentation/Splunk/latest/Alert/Webhooks

The whole project is here, but the main details can be summarized:
![alt tag](https://github.com/gojimmypi/splunkWebHook/blob/master/doc/webHook%20sample.PNG?raw=true)


Use a webhook alert action:
http://docs.splunk.com/Documentation/Splunk/6.4.4/Alert/Webhooks#Configure_a_webhook_alert_action

using newtonsoft: http://www.newtonsoft.com/json/help/html/SerializingJSON.htm

http://www.newtonsoft.com/json/help/html/DeserializeObject.htm


Other ways to get data out of splunk: https://discoveredintelligence.ca/get-data-out-of-splunk/

Inspiration sources:

http://stackoverflow.com/questions/20151556/how-to-get-the-http-post-data-in-c

http://stackoverflow.com/questions/25782765/newtonsoft-json-jsonconvert-to-datatable


Testing without splunk event:

http://stackoverflow.com/questions/7837826/in-c-how-can-i-create-a-textreader-object-from-a-string-without-writing-to-di

