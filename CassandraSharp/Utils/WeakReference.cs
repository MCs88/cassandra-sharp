﻿// cassandra-sharp - high performance .NET driver for Apache Cassandra
// Copyright (c) 2011-2013 Pierre Chalamet
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


#if NET40

namespace CassandraSharp.Utils
{
    using System;
    using System.Runtime.Serialization;

    internal class WeakReference<T> : WeakReference
    {
        public WeakReference(T target)
                : base(target)
        {
        }

        public WeakReference(T target, bool trackResurrection)
                : base(target, trackResurrection)
        {
        }

        protected WeakReference(SerializationInfo info, StreamingContext context)
                : base(info, context)
        {
        }

        public bool TryGetTarget(out T target)
        {
            object tmp = base.Target;
            if (null != tmp)
            {
                target = (T) tmp;
                return true;
            }

            target = default(T);
            return false;
        }

        public void SetTarget(T target)
        {
            base.Target = target;
        }
    }
}

#endif