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

namespace Revise.Files {
    /// <summary>
    /// Represents a table point.
    /// </summary>
    public struct TablePoint {
        #region Properties

        /// <summary>
        /// Gets or sets the X point.
        /// </summary>
        /// <value>
        /// The X point.
        /// </value>
        public short X {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Y point.
        /// </summary>
        /// <value>
        /// The Y point.
        /// </value>
        public short Y {
            get;
            set;
        }

        #endregion
    }
}