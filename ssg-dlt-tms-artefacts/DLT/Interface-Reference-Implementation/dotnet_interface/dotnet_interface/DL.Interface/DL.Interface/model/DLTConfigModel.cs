﻿/*
* Copyright 2020 EY or its affiliates. All Rights Reserved.
* 
* Licensed under the Apache License, Version 2.0 (the "License").
* You may not use this file except in compliance with the License.
* You may obtain a copy of the License at
* 
*     http://www.apache.org/licenses/LICENSE-2.0
* 
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Interface
{
    /// <summary>
    /// Model class to generate AWS Fabric Object
    /// </summary>
    class DLTConfigModel
    {
        public string NetworkId { get; set; }
        public string MemberId { get; set; }
        public string EnrolmentId { get; set; }
        public override string ToString()
        {
            return " Network Id : " + NetworkId + " Member Id : " + MemberId + " Enrolment Id : " + EnrolmentId;
        }
    }
}
