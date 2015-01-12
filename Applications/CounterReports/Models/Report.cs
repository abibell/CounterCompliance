/*
Copyright (c) 2014, RMIT Training
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this
  list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice,
  this list of conditions and the following disclaimer in the documentation
  and/or other materials provided with the distribution.

* Neither the name of CounterCompliance nor the names of its
  contributors may be used to endorse or promote products derived from
  this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CounterReports.Models
{
    public class Report
    {
        public String Users { get; set; }

        [Required]
        // ReSharper disable InconsistentNaming
        public String Report_Template { get; set; }

        [Required]
        public String Report_Start_Date_DFY { get; set; }

        [Required]
        public String Report_Start_Date_DFM { get; set; }

        [Required]
        public String Report_Start_Date_DFD { get; set; }

        public String Report_On_FullText_Subscription { get; set; }
        public String Report_Name { get; set; }

        [Required]
        public String Report_Format { get; set; }

        [Required]
        public String Report_End_Date_DFY { get; set; }

        [Required]
        public String Report_End_Date_DFM { get; set; }

        [Required]
        public String Report_End_Date_DFD { get; set; }

        public String Report_Desc { get; set; }
        public String Organisation_Name { get; set; }
        public String id { get; set; }
        public String formstatus { get; set; }
        public String Creation_Date { get; set; }
        // ReSharper restore InconsistentNaming
    }
}