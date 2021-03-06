﻿using System.ServiceModel.Channels;

using Microsoft.AspNetCore.Http;

using Cogito.AspNetCore.ServiceModel.Collections;

namespace Cogito.AspNetCore.ServiceModel
{

    /// <summary>
    /// Holds various information regarding the ASP.Net Core integration.
    /// </summary>
    public class AspNetCoreMessageProperty
    {

        /// <summary>
        /// Indexes the <see cref="AspNetCoreMessageProperty"/> on the <see cref="MessageProperties"/> collection.
        /// </summary>
        public const string Name = nameof(AspNetCoreMessageProperty);

        /// <summary>
        /// Gets the value of the <see cref="AspNetCoreMessageProperty"/>.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static AspNetCoreMessageProperty GetValue(Message message)
        {
            return message.Properties.GetValue<AspNetCoreMessageProperty>(Name);
        }

        /// <summary>
        /// Gets or adds the <see cref="AspNetCoreMessageProperty"/> to the message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static AspNetCoreMessageProperty GetOrAdd(Message message)
        {
            return (AspNetCoreMessageProperty)message.Properties.GetOrAdd(Name, _ => new AspNetCoreMessageProperty());
        }

        /// <summary>
        /// <see cref="HttpContext"/> associated with the request/reply.
        /// </summary>
        public HttpContext Context { get; internal set; }

    }

}
