/*
 * Copyright (c) InWorldz Halcyon Developers
 * Copyright (c) Contributors, http://opensimulator.org/
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the OpenSim Project nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE DEVELOPERS ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE CONTRIBUTORS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System.Collections.Generic;
using OpenMetaverse;

namespace OpenSim.Framework.Communications
{
    /// <summary>
    /// Inventory operations used between grid services.
    /// </summary>
    public interface IInterServiceInventoryServices
    {
        /// <summary>
        /// Create a new inventory for the given user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true if the inventory was successfully created, false otherwise</returns>
        bool CreateNewUserInventory(UUID user);

        /// <summary>
        /// Returns a list of all the folders in a given user's inventory.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>A flat list of the user's inventory folder tree,
        /// null if there is no inventory for this user</returns>
        List<InventoryFolderBase> GetInventorySkeleton(UUID userId);
        
        /// <summary>
        /// Returns a list of all the active gestures in a user's inventory.
        /// </summary>
        /// <param name="userId">
        /// The <see cref="UUID"/> of the user
        /// </param>
        /// <returns>
        /// A flat list of the gesture items.
        /// </returns>
        List<InventoryItemBase> GetActiveGestures(UUID userId);
    }
}