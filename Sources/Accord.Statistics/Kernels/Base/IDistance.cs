﻿// Accord Statistics Library
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2014
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.Statistics.Kernels
{
    /// <summary>
    ///   Kernel space distance interface for kernel functions.
    /// </summary>
    /// 
    /// <seealso cref="IKernel"/>
    ///
    public interface IDistance
    {

        /// <summary>
        ///   Computes the squared distance in feature space
        ///   between two points given in input space.
        /// </summary>
        /// 
        /// <param name="x">Vector <c>x</c> in input space.</param>
        /// <param name="y">Vector <c>y</c> in input space.</param>
        /// 
        /// <returns>Squared distance between <c>x</c> and <c>y</c> in feature (kernel) space.</returns>
        /// 
        double Distance(double[] x, double[] y);

    }
}
