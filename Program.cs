using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace FactoryConnections
{
    public class Program
    {
        static void Main(string[] args)
        {
            var factory = new Factory();
            var con =  Factory.RetornaConexao(1);
            var uhahu = con.RetornaStringConexao();
            
        }
 
    }
}

