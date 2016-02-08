﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Microsoft.AspNet.Mvc
{
    public static class NameValueCollectionExtensions
    {
        public static void CopyTo(this NameValueCollection collection, IDictionary<string, object> destination)
        {
            CopyTo(collection, destination, false /* replaceEntries */);
        }

        public static void CopyTo(this NameValueCollection collection, IDictionary<string, object> destination, bool replaceEntries)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }
            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            foreach (string key in collection.Keys)
            {
                if (replaceEntries || !destination.ContainsKey(key))
                {
                    destination[key] = collection[key];
                }
            }
        }
    }
}