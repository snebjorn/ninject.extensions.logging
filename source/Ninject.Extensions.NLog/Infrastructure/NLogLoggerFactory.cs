#region License

//
// Author: Ivan Porto Carrero <ivan@flanders.co.nz>
// Copyright (c) 2008-2010, Flanders International Marketing Ltd.
// Copyright (c) 2007-2010, Enkari, Ltd.
//
// Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
// See the file LICENSE.txt for details.
//

#endregion

#region Using Directives

using System;

#endregion

namespace Ninject.Extensions.Logging.NLog.Infrastructure
{
    /// <summary>
    /// An implementation of a logger factory that creates <see cref="NLogLogger"/>s.
    /// </summary>
    public class NLogLoggerFactory : LoggerFactoryBase
    {
        /// <summary>
        /// Creates a logger for the specified type.
        /// </summary>
        /// <param name="type">The type to create the logger for.</param>
        /// <returns>The newly-created logger.</returns>
        protected override ILogger CreateLogger( Type type )
        {
            return new NLogLogger( type );
        }
    }
}