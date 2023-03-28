// See https://aka.ms/new-console-template for more information

using System;
namespace firstDNProject
{
    class myClass
    {

        public static void Main(String[] args)
        {
            whatsapp whatsapp1 =new whatsapp();
            whatsapp1.sendMessage();//Sending whatsapp message

            IChatSystem whatsapp=new whatsapp();
            whatsapp.sendMessage();//Sending whatsapp message
        }
    }
}

