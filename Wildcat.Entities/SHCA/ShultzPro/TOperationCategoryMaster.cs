﻿using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TOperationCategoryMaster
    {
        public TOperationCategoryMaster()
        {
            TOperationCategoryDetail = new HashSet<TOperationCategoryDetail>();
        }

        public Guid SOperationCategoryMasterGuid { get; set; }
        public string SDescription { get; set; }
        public bool? BInactive { get; set; }
        public DateTime? DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime? DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowVersion { get; set; }

        public ICollection<TOperationCategoryDetail> TOperationCategoryDetail { get; set; }
    }
}