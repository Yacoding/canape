//    CANAPE Network Testing Tool
//    Copyright (C) 2014 Context Information Security
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.

using CANAPE.DataFrames;

namespace CANAPE.Utils
{
    /// <summary>
    /// An interface to populate an object from a data node
    /// </summary>
    public interface INodeInitializer
    {
        /// <summary>
        /// Populate object from node
        /// </summary>
        /// <param name="node">The node</param>
        void FromNode(DataNode node);
    }
}
