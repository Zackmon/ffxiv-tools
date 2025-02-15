﻿//
// AnnounceResponse.cs
//
// Authors:
//   Alan McGovern alan.mcgovern@gmail.com
//
// Copyright (C) 2006 Alan McGovern
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//


using System;
using System.Collections.Generic;

namespace MonoTorrent.Trackers
{
    public class AnnounceResponse : TrackerResponse
    {
        /// <summary>
        /// The list of peers returned by the tracker.
        /// </summary>
        public IList<PeerInfo> Peers { get; }

        public TimeSpan MinUpdateInterval { get; }

        public TimeSpan UpdateInterval { get; }

        public AnnounceResponse (
            TrackerState state,
            IList<PeerInfo> peers = null,
            TimeSpan? minUpdateInterval = null,
            TimeSpan? updateInterval = null,
            int? complete = null,
            int? incomplete = null,
            int? downloaded = null,
            string warningMessage = null,
            string failureMessage = null
            )
            : base (state, complete, incomplete, downloaded, warningMessage, failureMessage)
        {
            Peers = peers ?? Array.Empty<PeerInfo> ();
            MinUpdateInterval = minUpdateInterval ?? TimeSpan.FromMinutes (3);
            UpdateInterval = updateInterval ?? TimeSpan.FromMinutes (30);
        }
    }
}
