﻿#region License

/**
 * Copyright (C) 2012 Jack Wakefield
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

#endregion

using System;
using System.IO;

namespace Revise.Files.Exceptions {
    /// <summary>
    /// The exception that is thrown when an attempt is made to get or set the value of a cell which is out of the column range.
    /// </summary>
    public class DataCellOutOfRangeException : Exception {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataCellOutOfRangeException"/> class.
        /// </summary>
        public DataCellOutOfRangeException()
            : base(string.Format("Cell specified is out of the column range")) {
        }
    }
}