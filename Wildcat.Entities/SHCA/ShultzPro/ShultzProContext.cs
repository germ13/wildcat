using Microsoft.EntityFrameworkCore;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class ShultzProContext : DbContext
    {
        public ShultzProContext()
        {
        }

        public ShultzProContext(DbContextOptions<ShultzProContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TAccessControlEvent> TAccessControlEvent { get; set; }
        public virtual DbSet<TAccessControlTransaction> TAccessControlTransaction { get; set; }
        public virtual DbSet<TAccount> TAccount { get; set; }
        public virtual DbSet<TAlarmSubscriptionDetail> TAlarmSubscriptionDetail { get; set; }
        public virtual DbSet<TAlarmSubscriptionMaster> TAlarmSubscriptionMaster { get; set; }
        public virtual DbSet<TAppAssemblyVersion> TAppAssemblyVersion { get; set; }
        public virtual DbSet<TAppDbversion> TAppDbversion { get; set; }
        public virtual DbSet<TAppEntryComputer> TAppEntryComputer { get; set; }
        public virtual DbSet<TAppEntryComputerProperty> TAppEntryComputerProperty { get; set; }
        public virtual DbSet<TAttachment> TAttachment { get; set; }
        public virtual DbSet<TAttachmentInventory> TAttachmentInventory { get; set; }
        public virtual DbSet<TBbxaractivity> TBbxaractivity { get; set; }
        public virtual DbSet<TBbxarjnl> TBbxarjnl { get; set; }
        public virtual DbSet<TBbxaropenTrans> TBbxaropenTrans { get; set; }
        public virtual DbSet<TBbxcustomerMaster> TBbxcustomerMaster { get; set; }
        public virtual DbSet<TBbxgenLedger> TBbxgenLedger { get; set; }
        public virtual DbSet<TBbxglpostings> TBbxglpostings { get; set; }
        public virtual DbSet<TBbxtraveler> TBbxtraveler { get; set; }
        public virtual DbSet<TCamera> TCamera { get; set; }
        public virtual DbSet<TCameraExport> TCameraExport { get; set; }
        public virtual DbSet<TCellPhoneChargeDetail> TCellPhoneChargeDetail { get; set; }
        public virtual DbSet<TCellPhoneSummaryCharges> TCellPhoneSummaryCharges { get; set; }
        public virtual DbSet<TCellPhoneUsage> TCellPhoneUsage { get; set; }
        public virtual DbSet<TCellPhoneVoiceDetail> TCellPhoneVoiceDetail { get; set; }
        public virtual DbSet<TCity> TCity { get; set; }
        public virtual DbSet<TCompany> TCompany { get; set; }
        public virtual DbSet<TControlledDocument> TControlledDocument { get; set; }
        public virtual DbSet<TControlledDocumentAction> TControlledDocumentAction { get; set; }
        public virtual DbSet<TControlledDocumentApproval> TControlledDocumentApproval { get; set; }
        public virtual DbSet<TControlledDocumentAuthoringUser> TControlledDocumentAuthoringUser { get; set; }
        public virtual DbSet<TControlledDocumentContent> TControlledDocumentContent { get; set; }
        public virtual DbSet<TControlledDocumentDetail> TControlledDocumentDetail { get; set; }
        public virtual DbSet<TCountry> TCountry { get; set; }
        public virtual DbSet<TCraneScale> TCraneScale { get; set; }
        public virtual DbSet<TCustomDictionary> TCustomDictionary { get; set; }
        public virtual DbSet<TCustomer> TCustomer { get; set; }
        public virtual DbSet<TCustomerAddress> TCustomerAddress { get; set; }
        public virtual DbSet<TCustomerContact> TCustomerContact { get; set; }
        public virtual DbSet<TCustomerContactAddress> TCustomerContactAddress { get; set; }
        public virtual DbSet<TCustomerContactPhone> TCustomerContactPhone { get; set; }
        public virtual DbSet<TCustomerPhone> TCustomerPhone { get; set; }
        public virtual DbSet<TDeformlog> TDeformlog { get; set; }
        public virtual DbSet<TDeformlogStep> TDeformlogStep { get; set; }
        public virtual DbSet<TDeformrequest> TDeformrequest { get; set; }
        public virtual DbSet<TDepartment> TDepartment { get; set; }
        public virtual DbSet<TDepartmentSupervisor> TDepartmentSupervisor { get; set; }
        public virtual DbSet<TDigitalSignagePackage> TDigitalSignagePackage { get; set; }
        public virtual DbSet<TDigitalSignagePackageDetail> TDigitalSignagePackageDetail { get; set; }
        public virtual DbSet<TDprarchiveDetail> TDprarchiveDetail { get; set; }
        public virtual DbSet<TDprarchiveFile> TDprarchiveFile { get; set; }
        public virtual DbSet<TDprmachineShopDetail> TDprmachineShopDetail { get; set; }
        public virtual DbSet<TDprmachineShopMaster> TDprmachineShopMaster { get; set; }
        public virtual DbSet<TEmployee> TEmployee { get; set; }
        public virtual DbSet<TEmployeeAttendance> TEmployeeAttendance { get; set; }
        public virtual DbSet<TEmployeeBank> TEmployeeBank { get; set; }
        public virtual DbSet<TEmployeeDate> TEmployeeDate { get; set; }
        public virtual DbSet<TForgeClampDetail> TForgeClampDetail { get; set; }
        public virtual DbSet<TForgeClampMaster> TForgeClampMaster { get; set; }
        public virtual DbSet<TForgeClampOperation> TForgeClampOperation { get; set; }
        public virtual DbSet<TForgeCondDyeReason> TForgeCondDyeReason { get; set; }
        public virtual DbSet<TForgeCondPiece> TForgeCondPiece { get; set; }
        public virtual DbSet<TForgeCondRate> TForgeCondRate { get; set; }
        public virtual DbSet<TForgeCondSpark> TForgeCondSpark { get; set; }
        public virtual DbSet<TForgeLoadMapBatch> TForgeLoadMapBatch { get; set; }
        public virtual DbSet<TForgeLoadMapDetail> TForgeLoadMapDetail { get; set; }
        public virtual DbSet<TForgeLoadMapDetailRegister> TForgeLoadMapDetailRegister { get; set; }
        public virtual DbSet<TForgeLoadMapFurnace> TForgeLoadMapFurnace { get; set; }
        public virtual DbSet<TForgeLoadMapItem> TForgeLoadMapItem { get; set; }
        public virtual DbSet<TForgeLoadMapJob> TForgeLoadMapJob { get; set; }
        public virtual DbSet<TForgeLoadMapSnapshot> TForgeLoadMapSnapshot { get; set; }
        public virtual DbSet<TForgeLoadMapSnapshotDetail> TForgeLoadMapSnapshotDetail { get; set; }
        public virtual DbSet<TForgeLoadMapTag> TForgeLoadMapTag { get; set; }
        public virtual DbSet<TForgeLoadMapWorkBatch> TForgeLoadMapWorkBatch { get; set; }
        public virtual DbSet<TForgeLoadOptimizationDetail> TForgeLoadOptimizationDetail { get; set; }
        public virtual DbSet<TForgeLoadOptimizationMaster> TForgeLoadOptimizationMaster { get; set; }
        public virtual DbSet<TForgeMetric> TForgeMetric { get; set; }
        public virtual DbSet<TForgeMetricGreenhouseGasTarget> TForgeMetricGreenhouseGasTarget { get; set; }
        public virtual DbSet<TForgeMetricNote> TForgeMetricNote { get; set; }
        public virtual DbSet<TGasMeter> TGasMeter { get; set; }
        public virtual DbSet<TGasMeterLog> TGasMeterLog { get; set; }
        public virtual DbSet<TGasMeterReading> TGasMeterReading { get; set; }
        public virtual DbSet<THelpDeskAsset> THelpDeskAsset { get; set; }
        public virtual DbSet<THelpDeskAssetNote> THelpDeskAssetNote { get; set; }
        public virtual DbSet<THelpDeskAssetToRequest> THelpDeskAssetToRequest { get; set; }
        public virtual DbSet<THelpDeskAssignedRep> THelpDeskAssignedRep { get; set; }
        public virtual DbSet<THelpDeskCategory> THelpDeskCategory { get; set; }
        public virtual DbSet<THelpDeskInvolvedUser> THelpDeskInvolvedUser { get; set; }
        public virtual DbSet<THelpDeskProjectTemplateDetail> THelpDeskProjectTemplateDetail { get; set; }
        public virtual DbSet<THelpDeskProjectTemplateMaster> THelpDeskProjectTemplateMaster { get; set; }
        public virtual DbSet<THelpDeskProjectTemplateResource> THelpDeskProjectTemplateResource { get; set; }
        public virtual DbSet<THelpDeskRequest> THelpDeskRequest { get; set; }
        public virtual DbSet<THelpDeskRequestAttachment> THelpDeskRequestAttachment { get; set; }
        public virtual DbSet<THelpDeskRequestDependency> THelpDeskRequestDependency { get; set; }
        public virtual DbSet<THelpDeskRequestDetail> THelpDeskRequestDetail { get; set; }
        public virtual DbSet<THelpStarcount> THelpStarcount { get; set; }
        public virtual DbSet<THrabsenceLog> THrabsenceLog { get; set; }
        public virtual DbSet<THrapplicant> THrapplicant { get; set; }
        public virtual DbSet<THrapplicantDate> THrapplicantDate { get; set; }
        public virtual DbSet<THrdeptId> THrdeptId { get; set; }
        public virtual DbSet<THtCycle> THtCycle { get; set; }
        public virtual DbSet<THtHeatTreat> THtHeatTreat { get; set; }
        public virtual DbSet<THtJob> THtJob { get; set; }
        public virtual DbSet<THtJobPiece> THtJobPiece { get; set; }
        public virtual DbSet<THtPidloop> THtPidloop { get; set; }
        public virtual DbSet<THtQuenchData> THtQuenchData { get; set; }
        public virtual DbSet<THtRegion> THtRegion { get; set; }
        public virtual DbSet<THtschedule> THtschedule { get; set; }
        public virtual DbSet<THtscheduleDetail> THtscheduleDetail { get; set; }
        public virtual DbSet<TInfoSysIpaddress> TInfoSysIpaddress { get; set; }
        public virtual DbSet<TInfoSysIpaddressCategory> TInfoSysIpaddressCategory { get; set; }
        public virtual DbSet<TInfoSysIpaddressCategoryToAddress> TInfoSysIpaddressCategoryToAddress { get; set; }
        public virtual DbSet<TInfoSysIpaddressChange> TInfoSysIpaddressChange { get; set; }
        public virtual DbSet<TInfoSysNewEmployeeDetail> TInfoSysNewEmployeeDetail { get; set; }
        public virtual DbSet<TInfoSysNewEmployeeMaster> TInfoSysNewEmployeeMaster { get; set; }
        public virtual DbSet<TInventoryCount> TInventoryCount { get; set; }
        public virtual DbSet<TIpaddress> TIpaddress { get; set; }
        public virtual DbSet<TJobDetail> TJobDetail { get; set; }
        public virtual DbSet<TJobMaster> TJobMaster { get; set; }
        public virtual DbSet<TLabImportBadJobs> TLabImportBadJobs { get; set; }
        public virtual DbSet<TLabImportBend> TLabImportBend { get; set; }
        public virtual DbSet<TLabImportChem> TLabImportChem { get; set; }
        public virtual DbSet<TLabImportCompany> TLabImportCompany { get; set; }
        public virtual DbSet<TLabImportCompression> TLabImportCompression { get; set; }
        public virtual DbSet<TLabImportCompressionOffset> TLabImportCompressionOffset { get; set; }
        public virtual DbSet<TLabImportContact> TLabImportContact { get; set; }
        public virtual DbSet<TLabImportCreep> TLabImportCreep { get; set; }
        public virtual DbSet<TLabImportCreepAreaReduction> TLabImportCreepAreaReduction { get; set; }
        public virtual DbSet<TLabImportCreepElongationResult> TLabImportCreepElongationResult { get; set; }
        public virtual DbSet<TLabImportCreepSystemData> TLabImportCreepSystemData { get; set; }
        public virtual DbSet<TLabImportCreepTime> TLabImportCreepTime { get; set; }
        public virtual DbSet<TLabImportElectricalConductivity> TLabImportElectricalConductivity { get; set; }
        public virtual DbSet<TLabImportElementResult> TLabImportElementResult { get; set; }
        public virtual DbSet<TLabImportEmbrittlement> TLabImportEmbrittlement { get; set; }
        public virtual DbSet<TLabImportEmbrittlementResult> TLabImportEmbrittlementResult { get; set; }
        public virtual DbSet<TLabImportEnergyAbsorbed> TLabImportEnergyAbsorbed { get; set; }
        public virtual DbSet<TLabImportHardness> TLabImportHardness { get; set; }
        public virtual DbSet<TLabImportHardnessResultSet> TLabImportHardnessResultSet { get; set; }
        public virtual DbSet<TLabImportHeatTreatment> TLabImportHeatTreatment { get; set; }
        public virtual DbSet<TLabImportHeatTreatmentLine> TLabImportHeatTreatmentLine { get; set; }
        public virtual DbSet<TLabImportImpact> TLabImportImpact { get; set; }
        public virtual DbSet<TLabImportImpactLateralExpansion> TLabImportImpactLateralExpansion { get; set; }
        public virtual DbSet<TLabImportImpactShear> TLabImportImpactShear { get; set; }
        public virtual DbSet<TLabImportMacroMetallurgy> TLabImportMacroMetallurgy { get; set; }
        public virtual DbSet<TLabImportMacroMetallurgyResult> TLabImportMacroMetallurgyResult { get; set; }
        public virtual DbSet<TLabImportMagneticParticle> TLabImportMagneticParticle { get; set; }
        public virtual DbSet<TLabImportMicroMetallurgy> TLabImportMicroMetallurgy { get; set; }
        public virtual DbSet<TLabImportMicroMetallurgyResult> TLabImportMicroMetallurgyResult { get; set; }
        public virtual DbSet<TLabImportNote> TLabImportNote { get; set; }
        public virtual DbSet<TLabImportPlaneStrain> TLabImportPlaneStrain { get; set; }
        public virtual DbSet<TLabImportPlaneStrainCrackLength> TLabImportPlaneStrainCrackLength { get; set; }
        public virtual DbSet<TLabImportPlaneStrainInvalidity> TLabImportPlaneStrainInvalidity { get; set; }
        public virtual DbSet<TLabImportPlaneStrainSpecimenDimension> TLabImportPlaneStrainSpecimenDimension { get; set; }
        public virtual DbSet<TLabImportPrecrack> TLabImportPrecrack { get; set; }
        public virtual DbSet<TLabImportRevision> TLabImportRevision { get; set; }
        public virtual DbSet<TLabImportShear> TLabImportShear { get; set; }
        public virtual DbSet<TLabImportShearSystemData> TLabImportShearSystemData { get; set; }
        public virtual DbSet<TLabImportShearUltimate> TLabImportShearUltimate { get; set; }
        public virtual DbSet<TLabImportSpecification> TLabImportSpecification { get; set; }
        public virtual DbSet<TLabImportSpecimen> TLabImportSpecimen { get; set; }
        public virtual DbSet<TLabImportStatus> TLabImportStatus { get; set; }
        public virtual DbSet<TLabImportStatusDetail> TLabImportStatusDetail { get; set; }
        public virtual DbSet<TLabImportStatusFacility> TLabImportStatusFacility { get; set; }
        public virtual DbSet<TLabImportStatusLab> TLabImportStatusLab { get; set; }
        public virtual DbSet<TLabImportStressCorrosion> TLabImportStressCorrosion { get; set; }
        public virtual DbSet<TLabImportStressCorrosionResultSet> TLabImportStressCorrosionResultSet { get; set; }
        public virtual DbSet<TLabImportStressRupture> TLabImportStressRupture { get; set; }
        public virtual DbSet<TLabImportStressRuptureAreaReduction> TLabImportStressRuptureAreaReduction { get; set; }
        public virtual DbSet<TLabImportStressRuptureDurationStress> TLabImportStressRuptureDurationStress { get; set; }
        public virtual DbSet<TLabImportStressRuptureDurationStressStep> TLabImportStressRuptureDurationStressStep { get; set; }
        public virtual DbSet<TLabImportStressRuptureElongationResult> TLabImportStressRuptureElongationResult { get; set; }
        public virtual DbSet<TLabImportTensile> TLabImportTensile { get; set; }
        public virtual DbSet<TLabImportTensileAreaReduction> TLabImportTensileAreaReduction { get; set; }
        public virtual DbSet<TLabImportTensileElongationResult> TLabImportTensileElongationResult { get; set; }
        public virtual DbSet<TLabImportTensileOffset> TLabImportTensileOffset { get; set; }
        public virtual DbSet<TLabImportTensileSystemData> TLabImportTensileSystemData { get; set; }
        public virtual DbSet<TLabImportTensileUltimate> TLabImportTensileUltimate { get; set; }
        public virtual DbSet<TLabImportTest> TLabImportTest { get; set; }
        public virtual DbSet<TLabPurchaseOrder> TLabPurchaseOrder { get; set; }
        public virtual DbSet<TLabPurchaseOrderApproval> TLabPurchaseOrderApproval { get; set; }
        public virtual DbSet<TLabPurchaseOrderDetail> TLabPurchaseOrderDetail { get; set; }
        public virtual DbSet<TLabPurchaseOrderError> TLabPurchaseOrderError { get; set; }
        public virtual DbSet<TLabPurchaseOrderHeatTreatmentLotNumber> TLabPurchaseOrderHeatTreatmentLotNumber { get; set; }
        public virtual DbSet<TLabPurchaseOrderHistory> TLabPurchaseOrderHistory { get; set; }
        public virtual DbSet<TLabPurchaseOrderNote> TLabPurchaseOrderNote { get; set; }
        public virtual DbSet<TLabPurchaseOrderOperation> TLabPurchaseOrderOperation { get; set; }
        public virtual DbSet<TLabPurchaseOrderQualityClause> TLabPurchaseOrderQualityClause { get; set; }
        public virtual DbSet<TLabPurchaseOrderSpec> TLabPurchaseOrderSpec { get; set; }
        public virtual DbSet<TLabPurchaseOrderTestItem> TLabPurchaseOrderTestItem { get; set; }
        public virtual DbSet<TLogMachineStatus> TLogMachineStatus { get; set; }
        public virtual DbSet<TLogTrans> TLogTrans { get; set; }
        public virtual DbSet<TMachine> TMachine { get; set; }
        public virtual DbSet<TMailboxSizeReport> TMailboxSizeReport { get; set; }
        public virtual DbSet<TMasterToolInventory> TMasterToolInventory { get; set; }
        public virtual DbSet<TMasterToolInventoryDetail> TMasterToolInventoryDetail { get; set; }
        public virtual DbSet<TMasterToolInventoryLink> TMasterToolInventoryLink { get; set; }
        public virtual DbSet<TMasterToolInventorySink> TMasterToolInventorySink { get; set; }
        public virtual DbSet<TMetal> TMetal { get; set; }
        public virtual DbSet<TMillImportBadJobs> TMillImportBadJobs { get; set; }
        public virtual DbSet<TMillImportBillingAddress> TMillImportBillingAddress { get; set; }
        public virtual DbSet<TMillImportCertifications> TMillImportCertifications { get; set; }
        public virtual DbSet<TMillImportComplianceStatements> TMillImportComplianceStatements { get; set; }
        public virtual DbSet<TMillImportMills> TMillImportMills { get; set; }
        public virtual DbSet<TMillImportProductChemistryTests> TMillImportProductChemistryTests { get; set; }
        public virtual DbSet<TMillImportProducts> TMillImportProducts { get; set; }
        public virtual DbSet<TMillImportProductStatements> TMillImportProductStatements { get; set; }
        public virtual DbSet<TMillImportShippingAddress> TMillImportShippingAddress { get; set; }
        public virtual DbSet<TMillImportSpecifications> TMillImportSpecifications { get; set; }
        public virtual DbSet<TMobileEquipmentOperator> TMobileEquipmentOperator { get; set; }
        public virtual DbSet<TMobileEquipmentOperatorDetail> TMobileEquipmentOperatorDetail { get; set; }
        public virtual DbSet<TMotionStudyDefinition> TMotionStudyDefinition { get; set; }
        public virtual DbSet<TMotionStudyDefinitionToJob> TMotionStudyDefinitionToJob { get; set; }
        public virtual DbSet<TMotionStudyJob> TMotionStudyJob { get; set; }
        public virtual DbSet<TMotionStudyLogDetail> TMotionStudyLogDetail { get; set; }
        public virtual DbSet<TMotionStudyLogDetailNote> TMotionStudyLogDetailNote { get; set; }
        public virtual DbSet<TMrCycle> TMrCycle { get; set; }
        public virtual DbSet<TMrCycleName> TMrCycleName { get; set; }
        public virtual DbSet<TMrCycleQuery> TMrCycleQuery { get; set; }
        public virtual DbSet<TMrFurnace> TMrFurnace { get; set; }
        public virtual DbSet<TMrFurnaceHearth> TMrFurnaceHearth { get; set; }
        public virtual DbSet<TMrFurnaceQuery> TMrFurnaceQuery { get; set; }
        public virtual DbSet<TMrMasterRecipe> TMrMasterRecipe { get; set; }
        public virtual DbSet<TMrMaterial> TMrMaterial { get; set; }
        public virtual DbSet<TMrMaterialType> TMrMaterialType { get; set; }
        public virtual DbSet<TMrOperatorQuery> TMrOperatorQuery { get; set; }
        public virtual DbSet<TMrPiece> TMrPiece { get; set; }
        public virtual DbSet<TMrPieceType> TMrPieceType { get; set; }
        public virtual DbSet<TMrQuenchMediaType> TMrQuenchMediaType { get; set; }
        public virtual DbSet<TMrRegion> TMrRegion { get; set; }
        public virtual DbSet<TMrTestMaterialType> TMrTestMaterialType { get; set; }
        public virtual DbSet<TNonConformingMetal> TNonConformingMetal { get; set; }
        public virtual DbSet<TOpenDieNoteCallout> TOpenDieNoteCallout { get; set; }
        public virtual DbSet<TOpenDieNoteDetail> TOpenDieNoteDetail { get; set; }
        public virtual DbSet<TOpenDieNoteMaster> TOpenDieNoteMaster { get; set; }
        public virtual DbSet<TOperationCategoryDetail> TOperationCategoryDetail { get; set; }
        public virtual DbSet<TOperationCategoryMaster> TOperationCategoryMaster { get; set; }
        public virtual DbSet<TPcc004> TPcc004 { get; set; }
        public virtual DbSet<TPcc004FileList> TPcc004FileList { get; set; }
        public virtual DbSet<TPccChartOfAccounts> TPccChartOfAccounts { get; set; }
        public virtual DbSet<TPccDeptForecast> TPccDeptForecast { get; set; }
        public virtual DbSet<TPccEsh> TPccEsh { get; set; }
        public virtual DbSet<TPccFlexDepartment> TPccFlexDepartment { get; set; }
        public virtual DbSet<TPccGlposting> TPccGlposting { get; set; }
        public virtual DbSet<TPccHeadcount> TPccHeadcount { get; set; }
        public virtual DbSet<TPccHoliday> TPccHoliday { get; set; }
        public virtual DbSet<TPccHrAdp> TPccHrAdp { get; set; }
        public virtual DbSet<TPccMonthDef> TPccMonthDef { get; set; }
        public virtual DbSet<TPccOpCodeToDepartment> TPccOpCodeToDepartment { get; set; }
        public virtual DbSet<TPccPcgraf> TPccPcgraf { get; set; }
        public virtual DbSet<TPccTstrav> TPccTstrav { get; set; }
        public virtual DbSet<TPocLog> TPocLog { get; set; }
        public virtual DbSet<TPressOpCode> TPressOpCode { get; set; }
        public virtual DbSet<TProperty> TProperty { get; set; }
        public virtual DbSet<TPurchaseOrder> TPurchaseOrder { get; set; }
        public virtual DbSet<TPurchaseOrderAccount> TPurchaseOrderAccount { get; set; }
        public virtual DbSet<TPurchaseOrderContact> TPurchaseOrderContact { get; set; }
        public virtual DbSet<TPurchaseOrderContactAddress> TPurchaseOrderContactAddress { get; set; }
        public virtual DbSet<TPurchaseOrderContactPhone> TPurchaseOrderContactPhone { get; set; }
        public virtual DbSet<TPurchaseOrderDetail> TPurchaseOrderDetail { get; set; }
        public virtual DbSet<TQueryWriterSecGroup> TQueryWriterSecGroup { get; set; }
        public virtual DbSet<TQueryWriterSecGroupToObject> TQueryWriterSecGroupToObject { get; set; }
        public virtual DbSet<TQueryWriterSecGroupToQuery> TQueryWriterSecGroupToQuery { get; set; }
        public virtual DbSet<TQueryWriterSecObject> TQueryWriterSecObject { get; set; }
        public virtual DbSet<TQueryWriterSecQuery> TQueryWriterSecQuery { get; set; }
        public virtual DbSet<TQueryWriterSecUserToGroup> TQueryWriterSecUserToGroup { get; set; }
        public virtual DbSet<TRateLookup> TRateLookup { get; set; }
        public virtual DbSet<TReceivingLog> TReceivingLog { get; set; }
        public virtual DbSet<TReport> TReport { get; set; }
        public virtual DbSet<TReportHistory> TReportHistory { get; set; }
        public virtual DbSet<TReportToGroup> TReportToGroup { get; set; }
        public virtual DbSet<TRssnews> TRssnews { get; set; }
        public virtual DbSet<TRssweatherDetail> TRssweatherDetail { get; set; }
        public virtual DbSet<TRssweatherMaster> TRssweatherMaster { get; set; }
        public virtual DbSet<TRtf> TRtf { get; set; }
        public virtual DbSet<TSalesSurveyResult> TSalesSurveyResult { get; set; }
        public virtual DbSet<TSawBladeChange> TSawBladeChange { get; set; }
        public virtual DbSet<TSawBladeDetail> TSawBladeDetail { get; set; }
        public virtual DbSet<TSawBladeManualEntryCut> TSawBladeManualEntryCut { get; set; }
        public virtual DbSet<TSawBladeMaster> TSawBladeMaster { get; set; }
        public virtual DbSet<TSawConversionDetail> TSawConversionDetail { get; set; }
        public virtual DbSet<TSawConversionMaster> TSawConversionMaster { get; set; }
        public virtual DbSet<TSawCustomer> TSawCustomer { get; set; }
        public virtual DbSet<TSawLogTrans> TSawLogTrans { get; set; }
        public virtual DbSet<TSawRunChartDetail> TSawRunChartDetail { get; set; }
        public virtual DbSet<TSawRunChartEntry> TSawRunChartEntry { get; set; }
        public virtual DbSet<TSawRunChartEntryException> TSawRunChartEntryException { get; set; }
        public virtual DbSet<TSawRunChartMaster> TSawRunChartMaster { get; set; }
        public virtual DbSet<TSawSession> TSawSession { get; set; }
        public virtual DbSet<TSawSessionHistory> TSawSessionHistory { get; set; }
        public virtual DbSet<TSawSystemSetting> TSawSystemSetting { get; set; }
        public virtual DbSet<TSawUser> TSawUser { get; set; }
        public virtual DbSet<TScheduleBreak> TScheduleBreak { get; set; }
        public virtual DbSet<TScheduleDay> TScheduleDay { get; set; }
        public virtual DbSet<TScheduleExclusion> TScheduleExclusion { get; set; }
        public virtual DbSet<TScheduleJob> TScheduleJob { get; set; }
        public virtual DbSet<TScheduleJobCandidate> TScheduleJobCandidate { get; set; }
        public virtual DbSet<TScheduleJobHistory> TScheduleJobHistory { get; set; }
        public virtual DbSet<TScheduleJobOpenTraveler> TScheduleJobOpenTraveler { get; set; }
        public virtual DbSet<TScheduleJobPlan> TScheduleJobPlan { get; set; }
        public virtual DbSet<TScheduleJobPlanReason> TScheduleJobPlanReason { get; set; }
        public virtual DbSet<TScheduleJobPreFurnace> TScheduleJobPreFurnace { get; set; }
        public virtual DbSet<TScheduleJobResource> TScheduleJobResource { get; set; }
        public virtual DbSet<TScheduleManager> TScheduleManager { get; set; }
        public virtual DbSet<TSearchFavorite> TSearchFavorite { get; set; }
        public virtual DbSet<TSecGroup> TSecGroup { get; set; }
        public virtual DbSet<TSecGroupToObject> TSecGroupToObject { get; set; }
        public virtual DbSet<TSecObject> TSecObject { get; set; }
        public virtual DbSet<TSecurityCameraLog> TSecurityCameraLog { get; set; }
        public virtual DbSet<TSecurityCameraLogDetail> TSecurityCameraLogDetail { get; set; }
        public virtual DbSet<TSecUserToGroup> TSecUserToGroup { get; set; }
        public virtual DbSet<TSerialNumber> TSerialNumber { get; set; }
        public virtual DbSet<TSession> TSession { get; set; }
        public virtual DbSet<TSiemensFurnace> TSiemensFurnace { get; set; }
        public virtual DbSet<TSiemensHost> TSiemensHost { get; set; }
        public virtual DbSet<TSiemensSecGroup> TSiemensSecGroup { get; set; }
        public virtual DbSet<TSiemensSecGroupToObject> TSiemensSecGroupToObject { get; set; }
        public virtual DbSet<TSiemensSecObject> TSiemensSecObject { get; set; }
        public virtual DbSet<TSiemensSecUserToGroup> TSiemensSecUserToGroup { get; set; }
        public virtual DbSet<TSiemensUser> TSiemensUser { get; set; }
        public virtual DbSet<TSiemensUserBadge> TSiemensUserBadge { get; set; }
        public virtual DbSet<TState> TState { get; set; }
        public virtual DbSet<TSystemSetting> TSystemSetting { get; set; }
        public virtual DbSet<TTravelerLine> TTravelerLine { get; set; }
        public virtual DbSet<TTravelerLogDetail> TTravelerLogDetail { get; set; }
        public virtual DbSet<TTravelerLogMaster> TTravelerLogMaster { get; set; }
        public virtual DbSet<TTravelerOperation> TTravelerOperation { get; set; }
        public virtual DbSet<TUser> TUser { get; set; }
        public virtual DbSet<TUserBadge> TUserBadge { get; set; }
        public virtual DbSet<TUserExtendedProperty> TUserExtendedProperty { get; set; }
        public virtual DbSet<TVardetail> TVardetail { get; set; }
        public virtual DbSet<TVarmaster> TVarmaster { get; set; }
        public virtual DbSet<TVendor> TVendor { get; set; }
        public virtual DbSet<TVendorAddress> TVendorAddress { get; set; }
        public virtual DbSet<TVendorContact> TVendorContact { get; set; }
        public virtual DbSet<TVendorContactAddress> TVendorContactAddress { get; set; }
        public virtual DbSet<TVendorContactPhone> TVendorContactPhone { get; set; }
        public virtual DbSet<TVendorPhone> TVendorPhone { get; set; }
        public virtual DbSet<TWidget> TWidget { get; set; }
        public virtual DbSet<TWidgetToUser> TWidgetToUser { get; set; }
        public virtual DbSet<TZendeskUserPhoto> TZendeskUserPhoto { get; set; }
        public virtual DbSet<TZipCode> TZipCode { get; set; }

        // Unable to generate entity type for table 'dbo.tInventoryCount_OLD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tBBXPCGRAF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tPCC_FiscalDate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tTSTRAV'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tSystemSetting_ORIG'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SHCA-SQL03;Database=ShultzPro;user id=ShultzUser;password=Password123!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TAccessControlEvent>(entity =>
            {
                entity.HasKey(e => e.SAcguid);

                entity.ToTable("tAccessControlEvent");

                entity.HasIndex(e => e.DtEvent)
                    .HasName("IX_dtEvent");

                entity.Property(e => e.SAcguid)
                    .HasColumnName("sACGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsGuard).HasColumnName("bIsGuard");

                entity.Property(e => e.BIsVisitor).HasColumnName("bIsVisitor");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBadgeActivated)
                    .HasColumnName("dtBadgeActivated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtBadgeDeactivated)
                    .HasColumnName("dtBadgeDeactivated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtEvent)
                    .HasColumnName("dtEvent")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLastChanged)
                    .HasColumnName("dtLastChanged")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IEmpId).HasColumnName("iEmpID");

                entity.Property(e => e.IHrdeptId).HasColumnName("iHRDeptID");

                entity.Property(e => e.SAccessPanelName)
                    .HasColumnName("sAccessPanelName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBadgeType)
                    .HasColumnName("sBadgeType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SCardNum)
                    .HasColumnName("sCardNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SFirstName)
                    .HasColumnName("sFirstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLastName)
                    .HasColumnName("sLastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SMiddleName)
                    .HasColumnName("sMiddleName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SReader)
                    .HasColumnName("sReader")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TAccessControlTransaction>(entity =>
            {
                entity.HasKey(e => e.SAcguid);

                entity.ToTable("tAccessControlTransaction");

                entity.HasIndex(e => e.DtEvent)
                    .HasName("IX_dtEvent");

                entity.Property(e => e.SAcguid)
                    .HasColumnName("sACGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEvent)
                    .HasColumnName("dtEvent")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SComputerName)
                    .HasColumnName("sComputerName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SEnterValue)
                    .HasColumnName("sEnterValue")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SFirstName)
                    .HasColumnName("sFirstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLastName)
                    .HasColumnName("sLastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SObjectName)
                    .HasColumnName("sObjectName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SOperationName)
                    .HasColumnName("sOperationName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TAccount>(entity =>
            {
                entity.HasKey(e => e.SAccountGuid)
                    .IsClustered(false);

                entity.ToTable("tAccount");

                entity.HasIndex(e => e.IAccountId)
                    .HasName("ix_AccountID")
                    .IsClustered();

                entity.Property(e => e.SAccountGuid)
                    .HasColumnName("sAccountGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAccountId).HasColumnName("iAccountID");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TAlarmSubscriptionDetail>(entity =>
            {
                entity.HasKey(e => e.SAlarmSubscriptionDetailGuid);

                entity.ToTable("tAlarmSubscriptionDetail");

                entity.Property(e => e.SAlarmSubscriptionDetailGuid)
                    .HasColumnName("sAlarmSubscriptionDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAlarmSubscriptionMasterGuid).HasColumnName("sAlarmSubscriptionMasterGUID");

                entity.Property(e => e.SEmployeeGuid).HasColumnName("sEmployeeGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SAlarmSubscriptionMasterGu)
                    .WithMany(p => p.TAlarmSubscriptionDetail)
                    .HasForeignKey(d => d.SAlarmSubscriptionMasterGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tAlarmSubscriptionDetail_tAlarmSubscriptionMaster");
            });

            modelBuilder.Entity<TAlarmSubscriptionMaster>(entity =>
            {
                entity.HasKey(e => e.SAlarmSubscriptionMasterGuid);

                entity.ToTable("tAlarmSubscriptionMaster");

                entity.Property(e => e.SAlarmSubscriptionMasterGuid)
                    .HasColumnName("sAlarmSubscriptionMasterGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IStartSubscriptionHour).HasColumnName("iStartSubscriptionHour");

                entity.Property(e => e.IStopSubscriptionHour).HasColumnName("iStopSubscriptionHour");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAlarmType)
                    .IsRequired()
                    .HasColumnName("sAlarmType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SGroupName)
                    .IsRequired()
                    .HasColumnName("sGroupName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TAppAssemblyVersion>(entity =>
            {
                entity.HasKey(e => new { e.IDbversionKey, e.SAssemblyName });

                entity.ToTable("tAppAssemblyVersion");

                entity.Property(e => e.IDbversionKey).HasColumnName("iDBVersionKey");

                entity.Property(e => e.SAssemblyName)
                    .HasColumnName("sAssemblyName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DtCreatedDate)
                    .HasColumnName("dtCreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAssemblyBuild).HasColumnName("iAssemblyBuild");

                entity.Property(e => e.IAssemblyMajor).HasColumnName("iAssemblyMajor");

                entity.Property(e => e.IAssemblyMinor).HasColumnName("iAssemblyMinor");

                entity.Property(e => e.SUpdateUser)
                    .IsRequired()
                    .HasColumnName("sUpdateUser")
                    .HasMaxLength(255);

                entity.HasOne(d => d.IDbversionKeyNavigation)
                    .WithMany(p => p.TAppAssemblyVersion)
                    .HasForeignKey(d => d.IDbversionKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tAppAssemblyVersion_tAppDBVersion");
            });

            modelBuilder.Entity<TAppDbversion>(entity =>
            {
                entity.HasKey(e => e.IDbversionKey)
                    .IsClustered(false);

                entity.ToTable("tAppDBVersion");

                entity.HasIndex(e => new { e.IMajorVersion, e.IMinorVersion, e.IRevision })
                    .HasName("ix_tAppDBVersion_MajorMinorVersion")
                    .IsUnique();

                entity.Property(e => e.IDbversionKey).HasColumnName("iDBVersionKey");

                entity.Property(e => e.DtVersionDate)
                    .HasColumnName("dtVersionDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IMajorVersion).HasColumnName("iMajorVersion");

                entity.Property(e => e.IMinorVersion).HasColumnName("iMinorVersion");

                entity.Property(e => e.IRevision).HasColumnName("iRevision");

                entity.Property(e => e.SUpdateUser)
                    .IsRequired()
                    .HasColumnName("sUpdateUser")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TAppEntryComputer>(entity =>
            {
                entity.HasKey(e => e.SAppEntryGuid)
                    .IsClustered(false);

                entity.ToTable("tAppEntryComputer");

                entity.HasIndex(e => new { e.SComputerName, e.SAppToRun })
                    .HasName("IX_tAppEntryComputer")
                    .IsClustered();

                entity.Property(e => e.SAppEntryGuid)
                    .HasColumnName("sAppEntryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BLoginRequired).HasColumnName("bLoginRequired");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAppToRun)
                    .IsRequired()
                    .HasColumnName("sAppToRun")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SComputerName)
                    .HasColumnName("sComputerName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SIpaddress)
                    .HasColumnName("sIPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TAppEntryComputerProperty>(entity =>
            {
                entity.HasKey(e => e.SPropGuid);

                entity.ToTable("tAppEntryComputerProperty");

                entity.Property(e => e.SPropGuid)
                    .HasColumnName("sPropGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BValue).HasColumnName("bValue");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IValue).HasColumnName("iValue");

                entity.Property(e => e.ImgValue)
                    .HasColumnName("imgValue")
                    .HasColumnType("image");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SComputerName)
                    .HasColumnName("sComputerName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SIpaddress)
                    .HasColumnName("sIPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPropName)
                    .HasColumnName("sPropName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SValue)
                    .HasColumnName("sValue")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SValueText)
                    .HasColumnName("sValueText")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TAttachment>(entity =>
            {
                entity.HasKey(e => e.SAttachmentGuid)
                    .IsClustered(false);

                entity.ToTable("tAttachment");

                entity.Property(e => e.SAttachmentGuid)
                    .HasColumnName("sAttachmentGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsPhoto).HasColumnName("bIsPhoto");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BinAttachment)
                    .HasColumnName("binAttachment")
                    .HasColumnType("image");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastAccessed)
                    .HasColumnName("dtLastAccessed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SBatchGuid).HasColumnName("sBatchGUID");

                entity.Property(e => e.SCurrentFilePath1)
                    .HasColumnName("sCurrentFilePath1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SCurrentFilePath2)
                    .HasColumnName("sCurrentFilePath2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SEntityGuid).HasColumnName("sEntityGUID");

                entity.Property(e => e.SKey)
                    .IsRequired()
                    .HasColumnName("sKey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SOriginalExtension)
                    .HasColumnName("sOriginalExtension")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOriginalFileName)
                    .HasColumnName("sOriginalFileName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SUaddedByUserId)
                    .HasColumnName("sUAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TAttachmentInventory>(entity =>
            {
                entity.HasKey(e => e.SAttachmentInventoryGuid)
                    .IsClustered(false);

                entity.ToTable("tAttachmentInventory");

                entity.Property(e => e.SAttachmentInventoryGuid)
                    .HasColumnName("sAttachmentInventoryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BIsFileOrphan).HasColumnName("bIsFileOrphan");

                entity.Property(e => e.BIsFoundInSql).HasColumnName("bIsFoundInSql");

                entity.Property(e => e.BIsFoundOnPath1).HasColumnName("bIsFoundOnPath1");

                entity.Property(e => e.BIsFoundOnPath2).HasColumnName("bIsFoundOnPath2");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SFullFilePath1)
                    .HasColumnName("sFullFilePath1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SFullFilePath2)
                    .HasColumnName("sFullFilePath2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SOriginalFileName)
                    .HasColumnName("sOriginalFileName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBbxaractivity>(entity =>
            {
                entity.HasKey(e => e.SAractGuid);

                entity.ToTable("tBBXARActivity");

                entity.Property(e => e.SAractGuid)
                    .HasColumnName("sARActGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurDiscAmt)
                    .HasColumnName("curDiscAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurGrossAmt)
                    .HasColumnName("curGrossAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurInvoiceAmt)
                    .HasColumnName("curInvoiceAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurMaterialCostAmt)
                    .HasColumnName("curMaterialCostAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurMiscAmt)
                    .HasColumnName("curMiscAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurPaymentAmt)
                    .HasColumnName("curPaymentAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurTotalCostAmt)
                    .HasColumnName("curTotalCostAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DInvoiceDate)
                    .HasColumnName("dInvoiceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DPaymentDate)
                    .HasColumnName("dPaymentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBbxupdt)
                    .HasColumnName("dtBBXUpdt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBbxupdtBy)
                    .HasColumnName("sBBXUpdtBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustName)
                    .HasColumnName("sCustName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustPoid)
                    .HasColumnName("sCustPOID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SGlnumber)
                    .HasColumnName("sGLNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .IsRequired()
                    .HasColumnName("sKey")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SMachNumber)
                    .HasColumnName("sMachNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SOrderStatusCode)
                    .HasColumnName("sOrderStatusCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBbxarjnl>(entity =>
            {
                entity.HasKey(e => e.SArjnlguid);

                entity.ToTable("tBBXARJNL");

                entity.Property(e => e.SArjnlguid)
                    .HasColumnName("sARJNLGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurCommissionPct)
                    .HasColumnName("curCommissionPCT")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFreightAmt)
                    .HasColumnName("curFreightAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurGrossAmt)
                    .HasColumnName("curGrossAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurInvoiceAmt)
                    .HasColumnName("curInvoiceAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurMiscAmt)
                    .HasColumnName("curMiscAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurTaxAmt)
                    .HasColumnName("curTaxAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBbxupdt)
                    .HasColumnName("dtBBXUpdt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IActShipWeight).HasColumnName("iActShipWeight");

                entity.Property(e => e.IActWeightPulled).HasColumnName("iActWeightPulled");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBbxupdtBy)
                    .HasColumnName("sBBXUpdtBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SClassification)
                    .HasColumnName("sClassification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCommRenogCode)
                    .HasColumnName("sCommRenogCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustName)
                    .HasColumnName("sCustName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SCustNumber)
                    .HasColumnName("sCustNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustPonumber)
                    .HasColumnName("sCustPONumber")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SFinalInvoiceCode)
                    .HasColumnName("sFinalInvoiceCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SInvoiceNumber)
                    .IsRequired()
                    .HasColumnName("sInvoiceNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineCode)
                    .HasColumnName("sMachineCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMaterialCode)
                    .HasColumnName("sMaterialCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOpen9)
                    .HasColumnName("sOpen9")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STermsCode)
                    .HasColumnName("sTermsCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STerritoryNumber)
                    .HasColumnName("sTerritoryNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByuserId)
                    .HasColumnName("sUpdatedByuserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBbxaropenTrans>(entity =>
            {
                entity.HasKey(e => e.SAropenTransGuid);

                entity.ToTable("tBBXAROpenTrans");

                entity.Property(e => e.SAropenTransGuid)
                    .HasColumnName("sAROpenTransGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurInvoiceAmt)
                    .HasColumnName("curInvoiceAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DAgeDate)
                    .HasColumnName("dAgeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DCallDate)
                    .HasColumnName("dCallDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DEstRecDate)
                    .HasColumnName("dEstRecDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DinvoiceDate)
                    .HasColumnName("dinvoiceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBbxupdt)
                    .HasColumnName("dtBBXUpdt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBbxupdtBy)
                    .HasColumnName("sBBXUpdtBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCode)
                    .HasColumnName("sCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustSoldToName)
                    .HasColumnName("sCustSoldToName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SFinalInvoiceCode)
                    .HasColumnName("sFinalInvoiceCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .IsRequired()
                    .HasColumnName("sKEY")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SPersonContacted)
                    .HasColumnName("sPersonContacted")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SReferenceNumber)
                    .HasColumnName("sReferenceNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.STermsCode)
                    .HasColumnName("sTermsCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.STransCode)
                    .HasColumnName("sTransCode")
                    .HasMaxLength(10);

                entity.Property(e => e.SUpdateByUserId)
                    .HasColumnName("sUpdateByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBbxcustomerMaster>(entity =>
            {
                entity.HasKey(e => e.SCustomerGuid);

                entity.ToTable("tBBXCustomerMaster");

                entity.Property(e => e.SCustomerGuid)
                    .HasColumnName("sCustomerGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurHighBalance)
                    .HasColumnName("curHighBalance")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurMtdcosts)
                    .HasColumnName("curMTDCosts")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurMtdsales)
                    .HasColumnName("curMTDSales")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurYtdcosts)
                    .HasColumnName("curYTDCosts")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurYtdsales)
                    .HasColumnName("curYTDSales")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblArcontrol)
                    .HasColumnName("dblARControl")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBbxupdt)
                    .HasColumnName("dtBBXUpdt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICertMaterial).HasColumnName("iCertMaterial");

                entity.Property(e => e.ICustBackoffDays).HasColumnName("iCustBackoffDays");

                entity.Property(e => e.IEstimatedDays).HasColumnName("iEstimatedDays");

                entity.Property(e => e.ITerritory).HasColumnName("iTerritory");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBbxupdtBy)
                    .HasColumnName("sBBXUpdtBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCertMailed)
                    .HasColumnName("sCertMailed")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SCodeStr)
                    .HasColumnName("sCodeStr")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SContact)
                    .HasColumnName("sContact")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SCreditHoldFlag)
                    .HasColumnName("sCreditHoldFlag")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SCustNum)
                    .HasColumnName("sCustNum")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SMailToAddr1)
                    .HasColumnName("sMailToAddr1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SMailToAddr2)
                    .HasColumnName("sMailToAddr2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SPayHist)
                    .HasColumnName("sPayHist")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SResaleNum)
                    .HasColumnName("sResaleNum")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SShipToAddr1)
                    .HasColumnName("sShipToAddr1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SShipToAddr2)
                    .HasColumnName("sShipToAddr2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SShipToAddr3)
                    .HasColumnName("sShipToAddr3")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SShipToAddr4)
                    .HasColumnName("sShipToAddr4")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SSoldToAddr1)
                    .HasColumnName("sSoldToAddr1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SSoldToAddr2)
                    .HasColumnName("sSoldToAddr2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SSoldToAddr3)
                    .HasColumnName("sSoldToAddr3")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SSoldToAddr4)
                    .HasColumnName("sSoldToAddr4")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.STelNum)
                    .HasColumnName("sTelNum")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBbxgenLedger>(entity =>
            {
                entity.HasKey(e => e.SGlguid);

                entity.ToTable("tBBXGenLedger");

                entity.Property(e => e.SGlguid)
                    .HasColumnName("sGLGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurBalForward)
                    .HasColumnName("curBalForward")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCrntAcctPayCr)
                    .HasColumnName("curCrntAcctPayCR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCrntAcctPayDr)
                    .HasColumnName("curCrntAcctPayDR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCrntCashDisbCr)
                    .HasColumnName("curCrntCashDisbCR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCrntCashDisbDr)
                    .HasColumnName("curCrntCashDisbDR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCrntCashReceiptsCr)
                    .HasColumnName("curCrntCashReceiptsCR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCrntCashReceiptsDr)
                    .HasColumnName("curCrntCashReceiptsDR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCrntDprcr)
                    .HasColumnName("curCrntDPRCR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCrntDprdr)
                    .HasColumnName("curCrntDPRDR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCrntPayrollRegCr)
                    .HasColumnName("curCrntPayrollRegCR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCrntPayrollRegDr)
                    .HasColumnName("curCrntPayrollRegDR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCrntSalesJournalCr)
                    .HasColumnName("curCrntSalesJournalCR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCrntSalesJournalDr)
                    .HasColumnName("curCrntSalesJournalDR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFullAcctPayCr)
                    .HasColumnName("curFullAcctPayCR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFullAcctPayDr)
                    .HasColumnName("curFullAcctPayDR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFullCashDisbCr)
                    .HasColumnName("curFullCashDisbCR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFullCashDisbDr)
                    .HasColumnName("curFullCashDisbDR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFullCashReceiptsCr)
                    .HasColumnName("curFullCashReceiptsCR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFullCashReceiptsDr)
                    .HasColumnName("curFullCashReceiptsDR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFullDprcr)
                    .HasColumnName("curFullDPRCR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFullDprdr)
                    .HasColumnName("curFullDPRDR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFullPayrollRegCr)
                    .HasColumnName("curFullPayrollRegCR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFullPayrollRegDr)
                    .HasColumnName("curFullPayrollRegDR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFullSalesJournalCr)
                    .HasColumnName("curFullSalesJournalCR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurFullSalesJournalDr)
                    .HasColumnName("curFullSalesJournalDR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurGenJnl1Cr)
                    .HasColumnName("curGenJnl1CR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurGenJnl1Dr)
                    .HasColumnName("curGenJnl1DR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurGenJnl2Cr)
                    .HasColumnName("curGenJnl2CR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurGenJnl2Dr)
                    .HasColumnName("curGenJnl2DR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurGenJnl3Cr)
                    .HasColumnName("curGenJnl3CR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurGenJnl3Dr)
                    .HasColumnName("curGenJnl3DR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurGenJnl4Cr)
                    .HasColumnName("curGenJnl4CR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurGenJnl4Dr)
                    .HasColumnName("curGenJnl4DR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurGenJnl5Cr)
                    .HasColumnName("curGenJnl5CR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurGenJnl5Dr)
                    .HasColumnName("curGenJnl5DR")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBbxupdt)
                    .HasColumnName("dtBBXUpdt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAcctNumber)
                    .IsRequired()
                    .HasColumnName("sAcctNumber")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBbxupdtBy)
                    .HasColumnName("sBBXUpdtBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByuserId)
                    .HasColumnName("sUpdatedByuserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBbxglpostings>(entity =>
            {
                entity.HasKey(e => e.SGlpostingsGuid);

                entity.ToTable("tBBXGLPostings");

                entity.Property(e => e.SGlpostingsGuid)
                    .HasColumnName("sGLPostingsGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurPostingAmt)
                    .HasColumnName("curPostingAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBbxupdt)
                    .HasColumnName("dtBBXUpdt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPostingDate)
                    .HasColumnName("dtPostingDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IPeriodPostedTo).HasColumnName("iPeriodPostedTo");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBbxupdtBy)
                    .HasColumnName("sBBXUpdtBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescriptions)
                    .HasColumnName("sDescriptions")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .IsRequired()
                    .HasColumnName("sKEY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByuserId)
                    .HasColumnName("sUpdatedByuserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBbxtraveler>(entity =>
            {
                entity.HasKey(e => e.STravelerGuid);

                entity.ToTable("tBBXTraveler");

                entity.Property(e => e.STravelerGuid)
                    .HasColumnName("sTravelerGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BClosed).HasColumnName("bClosed");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurCostAct)
                    .HasColumnName("curCostAct")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCostEst)
                    .HasColumnName("curCostEst")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMacHrsEst)
                    .HasColumnName("dblMacHrsEst")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMachHrsAct)
                    .HasColumnName("dblMachHrsAct")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBbxupdt)
                    .HasColumnName("dtBBXUpdt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtCalcDueDate)
                    .HasColumnName("dtCalcDueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLastProdDate)
                    .HasColumnName("dtLastProdDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IMachCode).HasColumnName("iMachCode");

                entity.Property(e => e.IPiecesAct).HasColumnName("iPiecesAct");

                entity.Property(e => e.IPiecesEst).HasColumnName("iPiecesEst");

                entity.Property(e => e.ISchedDays).HasColumnName("iSchedDays");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBbxupdtBy)
                    .HasColumnName("sBBXUpdtBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDateString)
                    .HasColumnName("sDateString")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc1)
                    .HasColumnName("sDesc1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc2)
                    .HasColumnName("sDesc2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SLastManUpdate)
                    .HasColumnName("sLastManUpdate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOpCode)
                    .HasColumnName("sOpCode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SStatus)
                    .HasColumnName("sStatus")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.STravelerId)
                    .HasColumnName("sTravelerID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCamera>(entity =>
            {
                entity.HasKey(e => e.SCameraGuid);

                entity.ToTable("tCamera");

                entity.Property(e => e.SCameraGuid)
                    .HasColumnName("sCameraGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BBlurry).HasColumnName("bBlurry");

                entity.Property(e => e.BBoschLogo).HasColumnName("bBoschLogo");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BNeedsToBeCleaned).HasColumnName("bNeedsToBeCleaned");

                entity.Property(e => e.BNoPing).HasColumnName("bNoPing");

                entity.Property(e => e.BNoSignal).HasColumnName("bNoSignal");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BShowDateTimestamp).HasColumnName("bShowDateTimestamp");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IChannel)
                    .HasColumnName("iChannel")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.IImageHeight).HasColumnName("iImageHeight");

                entity.Property(e => e.IImageWidth).HasColumnName("iImageWidth");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCameraName)
                    .HasColumnName("sCameraName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SImageUrlpage)
                    .HasColumnName("sImageURLPage")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SIpaddress)
                    .HasColumnName("sIPAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPassword)
                    .HasColumnName("sPassword")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserName)
                    .HasColumnName("sUserName")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TCameraExport>(entity =>
            {
                entity.HasKey(e => e.SExportGuid);

                entity.ToTable("tCameraExport");

                entity.Property(e => e.SExportGuid)
                    .HasColumnName("sExportGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEndTime)
                    .HasColumnName("dtEndTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtEndTimeUtc)
                    .HasColumnName("dtEndTimeUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStartTime)
                    .HasColumnName("dtStartTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStartTimeUtc)
                    .HasColumnName("dtStartTimeUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCameraGuid).HasColumnName("sCameraGUID");

                entity.Property(e => e.SCameraName)
                    .HasColumnName("sCameraName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVideoFilePath1)
                    .HasColumnName("sVideoFilePath1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SVideoFilePath2)
                    .HasColumnName("sVideoFilePath2")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCellPhoneChargeDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tCellPhoneChargeDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurCost)
                    .HasColumnName("curCost")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblBillable)
                    .HasColumnName("dblBillable")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblUsed)
                    .HasColumnName("dblUsed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBillCycle)
                    .HasColumnName("dtBillCycle")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IEccprofileId).HasColumnName("iECCProfileID");

                entity.Property(e => e.SAccountNum)
                    .HasColumnName("sAccountNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAllowance)
                    .HasColumnName("sAllowance")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SCostCenter)
                    .HasColumnName("sCostCenter")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SDateRange)
                    .HasColumnName("sDateRange")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SInvoiceNum)
                    .HasColumnName("sInvoiceNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SItemCategory)
                    .HasColumnName("sItemCategory")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SItemDescription)
                    .HasColumnName("sItemDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SItemType)
                    .HasColumnName("sItemType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SOrderDetails)
                    .HasColumnName("sOrderDetails")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SShareData)
                    .HasColumnName("sShareData")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SShareDescription)
                    .HasColumnName("sShareDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SShareMessaging)
                    .HasColumnName("sShareMessaging")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SShareVoice)
                    .HasColumnName("sShareVoice")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUsagePeriod)
                    .HasColumnName("sUsagePeriod")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUserId)
                    .HasColumnName("sUserID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUsername)
                    .HasColumnName("sUsername")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SVendorName)
                    .HasColumnName("sVendorName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SWirelessNumber)
                    .HasColumnName("sWirelessNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCellPhoneSummaryCharges>(entity =>
            {
                entity.HasKey(e => e.SSummaryGuid);

                entity.ToTable("tCellPhoneSummaryCharges");

                entity.Property(e => e.SSummaryGuid)
                    .HasColumnName("sSummaryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurAccountCharges)
                    .HasColumnName("curAccountCharges")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurAdjustments)
                    .HasColumnName("curAdjustments")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurBalanceForward)
                    .HasColumnName("curBalanceForward")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurEquipmentCharges)
                    .HasColumnName("curEquipmentCharges")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurLateFee)
                    .HasColumnName("curLateFee")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurMonthlyCharges)
                    .HasColumnName("curMonthlyCharges")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurPayments)
                    .HasColumnName("curPayments")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurPreviousBalance)
                    .HasColumnName("curPreviousBalance")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurSurcharges)
                    .HasColumnName("curSurcharges")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurTaxesGovernment)
                    .HasColumnName("curTaxesGovernment")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurThirdPartyAccount)
                    .HasColumnName("curThirdPartyAccount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurThirdPartyLines)
                    .HasColumnName("curThirdPartyLines")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurTotalAmountDue)
                    .HasColumnName("curTotalAmountDue")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurTotalCharges)
                    .HasColumnName("curTotalCharges")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurUsageAndPurchaseCharges)
                    .HasColumnName("curUsageAndPurchaseCharges")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurUsageChargesData)
                    .HasColumnName("curUsageChargesData")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurUsageChargesInternational)
                    .HasColumnName("curUsageChargesInternational")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurUsageChargesMobile)
                    .HasColumnName("curUsageChargesMobile")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurUsageChargesPurchases)
                    .HasColumnName("curUsageChargesPurchases")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurUsageChargesRoaming)
                    .HasColumnName("curUsageChargesRoaming")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurUsageChargesVoice)
                    .HasColumnName("curUsageChargesVoice")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBillCycle)
                    .HasColumnName("dtBillCycle")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtDue)
                    .HasColumnName("dtDue")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IEccprofileId).HasColumnName("iECCProfileID");

                entity.Property(e => e.SAccountNum)
                    .HasColumnName("sAccountNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBillName)
                    .HasColumnName("sBillName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SBillPeriod)
                    .HasColumnName("sBillPeriod")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SInvoiceNum)
                    .HasColumnName("sInvoiceNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRemittanceAddress)
                    .HasColumnName("sRemittanceAddress")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCellPhoneUsage>(entity =>
            {
                entity.HasKey(e => e.SUsageGuid);

                entity.ToTable("tCellPhoneUsage");

                entity.Property(e => e.SUsageGuid)
                    .HasColumnName("sUsageGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblDataRoamingGb)
                    .HasColumnName("dblDataRoamingGB")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDataRoamingKb)
                    .HasColumnName("dblDataRoamingKB")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDataRoamingMb)
                    .HasColumnName("dblDataRoamingMB")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDataUsageGb)
                    .HasColumnName("dblDataUsageGB")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDataUsageKb)
                    .HasColumnName("dblDataUsageKB")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDataUsageMb)
                    .HasColumnName("dblDataUsageMB")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblEquipmentCharges)
                    .HasColumnName("dblEquipmentCharges")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMonthlyCharges)
                    .HasColumnName("dblMonthlyCharges")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTaxes)
                    .HasColumnName("dblTaxes")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblThirdPartyCharges)
                    .HasColumnName("dblThirdPartyCharges")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTotalCharges)
                    .HasColumnName("dblTotalCharges")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTotalSurcharges)
                    .HasColumnName("dblTotalSurcharges")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblUsagePurchaseCharges)
                    .HasColumnName("dblUsagePurchaseCharges")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBillCycle)
                    .HasColumnName("dtBillCycle")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtDue)
                    .HasColumnName("dtDue")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAccountChargesCredits).HasColumnName("iAccountChargesCredits");

                entity.Property(e => e.IEccprofileId).HasColumnName("iECCProfileID");

                entity.Property(e => e.IMessagingRoaming).HasColumnName("iMessagingRoaming");

                entity.Property(e => e.IMessagingUsage).HasColumnName("iMessagingUsage");

                entity.Property(e => e.IVoicePlanUsage).HasColumnName("iVoicePlanUsage");

                entity.Property(e => e.IVoiceRoaming).HasColumnName("iVoiceRoaming");

                entity.Property(e => e.SAccountNum)
                    .HasColumnName("sAccountNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBillPeriod)
                    .HasColumnName("sBillPeriod")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SCallingPlan)
                    .HasColumnName("sCallingPlan")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SCostCenter)
                    .HasColumnName("sCostCenter")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SInvoiceNum)
                    .HasColumnName("sInvoiceNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserId)
                    .HasColumnName("sUserID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUsername)
                    .HasColumnName("sUsername")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SWirelessNumber)
                    .HasColumnName("sWirelessNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCellPhoneVoiceDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tCellPhoneVoiceDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCharge)
                    .HasColumnName("dblCharge")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblLongDistance)
                    .HasColumnName("dblLongDistance")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTotal)
                    .HasColumnName("dblTotal")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBillCycle)
                    .HasColumnName("dtBillCycle")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtCall)
                    .HasColumnName("dtCall")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IEccprofileId).HasColumnName("iECCProfileID");

                entity.Property(e => e.IMinutes).HasColumnName("iMinutes");

                entity.Property(e => e.SAccountNum)
                    .HasColumnName("sAccountNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SDestination)
                    .HasColumnName("sDestination")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SInternationalCallType)
                    .HasColumnName("sInternationalCallType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SInvoiceNum)
                    .HasColumnName("sInvoiceNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SNumber)
                    .HasColumnName("sNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SOrigination)
                    .HasColumnName("sOrigination")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRate)
                    .HasColumnName("sRate")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUsageCategory)
                    .HasColumnName("sUsageCategory")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUsageType)
                    .HasColumnName("sUsageType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUsername)
                    .HasColumnName("sUsername")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SWirelessNumber)
                    .HasColumnName("sWirelessNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCity>(entity =>
            {
                entity.HasKey(e => e.SCityGuid);

                entity.ToTable("tCity");

                entity.Property(e => e.SCityGuid)
                    .HasColumnName("sCityGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCityName)
                    .HasColumnName("sCityName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SStateGuid).HasColumnName("sStateGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SZipGuid).HasColumnName("sZipGUID");

                entity.HasOne(d => d.SStateGu)
                    .WithMany(p => p.TCity)
                    .HasForeignKey(d => d.SStateGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCity_tState");

                entity.HasOne(d => d.SZipGu)
                    .WithMany(p => p.TCity)
                    .HasForeignKey(d => d.SZipGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCity_tZipCode");
            });

            modelBuilder.Entity<TCompany>(entity =>
            {
                entity.HasKey(e => e.SCompanyGuid);

                entity.ToTable("tCompany");

                entity.Property(e => e.SCompanyGuid)
                    .HasColumnName("sCompanyGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BHragency).HasColumnName("bHRAgency");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BOnsiteOv).HasColumnName("bOnsiteOV");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress)
                    .HasColumnName("sAddress")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SCity)
                    .HasColumnName("sCity")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SHrshorthand)
                    .HasColumnName("sHRShorthand")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SState)
                    .HasColumnName("sState")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SZipCode)
                    .HasColumnName("sZipCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TControlledDocument>(entity =>
            {
                entity.HasKey(e => e.SDocumentGuid);

                entity.ToTable("tControlledDocument");

                entity.Property(e => e.SDocumentGuid)
                    .HasColumnName("sDocumentGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BAllUsersCanAuthor).HasColumnName("bAllUsersCanAuthor");

                entity.Property(e => e.BAllUsersMustApprove).HasColumnName("bAllUsersMustApprove");

                entity.Property(e => e.BAnyUserCanApprove).HasColumnName("bAnyUserCanApprove");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDepartmentGuid).HasColumnName("sDepartmentGUID");

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.SDocumentCode)
                    .IsRequired()
                    .HasColumnName("sDocumentCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SDocumentType)
                    .IsRequired()
                    .HasColumnName("sDocumentType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STitle)
                    .IsRequired()
                    .HasColumnName("sTitle")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TControlledDocumentAction>(entity =>
            {
                entity.HasKey(e => e.SActionGuid);

                entity.ToTable("tControlledDocumentAction");

                entity.Property(e => e.SActionGuid)
                    .HasColumnName("sActionGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAction)
                    .HasColumnName("dtAction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAction)
                    .IsRequired()
                    .HasColumnName("sAction")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDetailGuid).HasColumnName("sDetailGUID");

                entity.Property(e => e.SExtDesc)
                    .HasColumnName("sExtDesc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SReason)
                    .HasColumnName("sReason")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SDetailGu)
                    .WithMany(p => p.TControlledDocumentAction)
                    .HasForeignKey(d => d.SDetailGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tControlledDocumentAction_tControlledDocumentDetail");
            });

            modelBuilder.Entity<TControlledDocumentApproval>(entity =>
            {
                entity.HasKey(e => e.SApprovalGuid);

                entity.ToTable("tControlledDocumentApproval");

                entity.Property(e => e.SApprovalGuid)
                    .HasColumnName("sApprovalGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDocumentGuid).HasColumnName("sDocumentGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SDocumentGu)
                    .WithMany(p => p.TControlledDocumentApproval)
                    .HasForeignKey(d => d.SDocumentGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tControlledDocumentApproval_tControlledDocument");

                entity.HasOne(d => d.SUserGu)
                    .WithMany(p => p.TControlledDocumentApproval)
                    .HasForeignKey(d => d.SUserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tControlledDocumentApproval_tUser");
            });

            modelBuilder.Entity<TControlledDocumentAuthoringUser>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tControlledDocumentAuthoringUser");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDocumentGuid).HasColumnName("sDocumentGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SDocumentGu)
                    .WithMany(p => p.TControlledDocumentAuthoringUser)
                    .HasForeignKey(d => d.SDocumentGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tControlledDocumentAuthoringUsers_tControlledDocument");

                entity.HasOne(d => d.SUserGu)
                    .WithMany(p => p.TControlledDocumentAuthoringUser)
                    .HasForeignKey(d => d.SUserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tControlledDocumentAuthoringUser_tUser");
            });

            modelBuilder.Entity<TControlledDocumentContent>(entity =>
            {
                entity.HasKey(e => e.SContentGuid);

                entity.ToTable("tControlledDocumentContent");

                entity.Property(e => e.SContentGuid)
                    .HasColumnName("sContentGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ILineNum).HasColumnName("iLineNum");

                entity.Property(e => e.IPageNum).HasColumnName("iPageNum");

                entity.Property(e => e.ISlideIndex).HasColumnName("iSlideIndex");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SCellLocation)
                    .HasColumnName("sCellLocation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SContent)
                    .IsRequired()
                    .HasColumnName("sContent")
                    .HasColumnType("text");

                entity.Property(e => e.SDetailGuid).HasColumnName("sDetailGUID");

                entity.Property(e => e.SDocType)
                    .HasColumnName("sDocType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSheetName)
                    .HasColumnName("sSheetName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SDetailGu)
                    .WithMany(p => p.TControlledDocumentContent)
                    .HasForeignKey(d => d.SDetailGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tControlledDocumentContent_tControlledDocumentDetail");
            });

            modelBuilder.Entity<TControlledDocumentDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tControlledDocumentDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BPublishedRev).HasColumnName("bPublishedRev");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SDocumentGuid).HasColumnName("sDocumentGUID");

                entity.Property(e => e.SRevisionNum)
                    .IsRequired()
                    .HasColumnName("sRevisionNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SDocumentGu)
                    .WithMany(p => p.TControlledDocumentDetail)
                    .HasForeignKey(d => d.SDocumentGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tControlledDocumentDetail_tControlledDocument");
            });

            modelBuilder.Entity<TCountry>(entity =>
            {
                entity.HasKey(e => e.SCountryGuid);

                entity.ToTable("tCountry");

                entity.Property(e => e.SCountryGuid)
                    .HasColumnName("sCountryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISort).HasColumnName("iSort");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCountryName)
                    .IsRequired()
                    .HasColumnName("sCountryName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCraneScale>(entity =>
            {
                entity.HasKey(e => e.SScaleGuid);

                entity.ToTable("tCraneScale");

                entity.Property(e => e.SScaleGuid)
                    .HasColumnName("sScaleGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SScaleIpaddress)
                    .IsRequired()
                    .HasColumnName("sScaleIPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SScaleLocation)
                    .HasColumnName("sScaleLocation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SScaleModel)
                    .IsRequired()
                    .HasColumnName("sScaleModel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SScaleSerialNumber)
                    .IsRequired()
                    .HasColumnName("sScaleSerialNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCustomDictionary>(entity =>
            {
                entity.HasKey(e => e.SWordGuid);

                entity.ToTable("tCustomDictionary");

                entity.Property(e => e.SWordGuid)
                    .HasColumnName("sWordGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SWord)
                    .IsRequired()
                    .HasColumnName("sWord")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCustomer>(entity =>
            {
                entity.HasKey(e => e.SCustomerGuid);

                entity.ToTable("tCustomer");

                entity.Property(e => e.SCustomerGuid)
                    .HasColumnName("sCustomerGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAccountNumber)
                    .HasColumnName("sAccountNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCompanyName)
                    .HasColumnName("sCompanyName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCustomerAddress>(entity =>
            {
                entity.HasKey(e => e.SAddressGuid);

                entity.ToTable("tCustomerAddress");

                entity.Property(e => e.SAddressGuid)
                    .HasColumnName("sAddressGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress1)
                    .HasColumnName("sAddress1")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress2)
                    .HasColumnName("sAddress2")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SAddressHash)
                    .HasColumnName("sAddressHash")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SCity)
                    .HasColumnName("sCity")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SCountry)
                    .HasColumnName("sCountry")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomerGuid).HasColumnName("sCustomerGUID");

                entity.Property(e => e.SPostalCode)
                    .HasColumnName("sPostalCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SState)
                    .HasColumnName("sState")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STypeCode)
                    .HasColumnName("sTypeCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCustomerGu)
                    .WithMany(p => p.TCustomerAddress)
                    .HasForeignKey(d => d.SCustomerGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCustomerAddress_tCustomer");
            });

            modelBuilder.Entity<TCustomerContact>(entity =>
            {
                entity.HasKey(e => e.SContactGuid);

                entity.ToTable("tCustomerContact");

                entity.Property(e => e.SContactGuid)
                    .HasColumnName("sContactGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomerGuid).HasColumnName("sCustomerGUID");

                entity.Property(e => e.SEmail)
                    .HasColumnName("sEMail")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SFirstName)
                    .HasColumnName("sFirstName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SLastName)
                    .HasColumnName("sLastName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SMiddleName)
                    .HasColumnName("sMiddleName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SPositionTitle)
                    .HasColumnName("sPositionTitle")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SSuffix)
                    .HasColumnName("sSuffix")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.STitle)
                    .HasColumnName("sTitle")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCustomerGu)
                    .WithMany(p => p.TCustomerContact)
                    .HasForeignKey(d => d.SCustomerGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCustomerContact_tCustomer");
            });

            modelBuilder.Entity<TCustomerContactAddress>(entity =>
            {
                entity.HasKey(e => e.SAddressGuid);

                entity.ToTable("tCustomerContactAddress");

                entity.Property(e => e.SAddressGuid)
                    .HasColumnName("sAddressGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress1)
                    .HasColumnName("sAddress1")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress2)
                    .HasColumnName("sAddress2")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SAddressHash)
                    .HasColumnName("sAddressHash")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SCity)
                    .HasColumnName("sCity")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SContactGuid).HasColumnName("sContactGUID");

                entity.Property(e => e.SCountry)
                    .HasColumnName("sCountry")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SPostalCode)
                    .HasColumnName("sPostalCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SState)
                    .HasColumnName("sState")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STypeCode)
                    .HasColumnName("sTypeCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SContactGu)
                    .WithMany(p => p.TCustomerContactAddress)
                    .HasForeignKey(d => d.SContactGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCustomerContactAddress_tCustomerContact");
            });

            modelBuilder.Entity<TCustomerContactPhone>(entity =>
            {
                entity.HasKey(e => e.SPhoneGuid);

                entity.ToTable("tCustomerContactPhone");

                entity.Property(e => e.SPhoneGuid)
                    .HasColumnName("sPhoneGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SContactGuid).HasColumnName("sContactGUID");

                entity.Property(e => e.SPhoneHash)
                    .HasColumnName("sPhoneHash")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SPhoneNumber)
                    .HasColumnName("sPhoneNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STypeCode)
                    .HasColumnName("sTypeCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SContactGu)
                    .WithMany(p => p.TCustomerContactPhone)
                    .HasForeignKey(d => d.SContactGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCustomerContactPhone_tCustomerContact");
            });

            modelBuilder.Entity<TCustomerPhone>(entity =>
            {
                entity.HasKey(e => e.SPhoneGuid);

                entity.ToTable("tCustomerPhone");

                entity.Property(e => e.SPhoneGuid)
                    .HasColumnName("sPhoneGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomerGuid).HasColumnName("sCustomerGUID");

                entity.Property(e => e.SPhoneHash)
                    .HasColumnName("sPhoneHash")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SPhoneNumber)
                    .HasColumnName("sPhoneNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STypeCode)
                    .HasColumnName("sTypeCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCustomerGu)
                    .WithMany(p => p.TCustomerPhone)
                    .HasForeignKey(d => d.SCustomerGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCustomerPhone_tCustomer");
            });

            modelBuilder.Entity<TDeformlog>(entity =>
            {
                entity.HasKey(e => e.SLogGuid);

                entity.ToTable("tDEFORMLog");

                entity.Property(e => e.SLogGuid)
                    .HasColumnName("sLogGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCoeffHeatTransfer)
                    .HasColumnName("dblCoeffHeatTransfer")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblDieGap)
                    .HasColumnName("dblDieGap")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFriction)
                    .HasColumnName("dblFriction")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPressSpeed)
                    .HasColumnName("dblPressSpeed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblRadiationFactor)
                    .HasColumnName("dblRadiationFactor")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtSimulation)
                    .HasColumnName("dtSimulation")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IFemrunTimeInMinutes).HasColumnName("iFEMRunTimeInMinutes");

                entity.Property(e => e.IPva).HasColumnName("iPVA");

                entity.Property(e => e.IRemeshRunTimeInMinutes).HasColumnName("iRemeshRunTimeInMinutes");

                entity.Property(e => e.ISurfaceArea).HasColumnName("iSurfaceArea");

                entity.Property(e => e.ITemp).HasColumnName("iTemp");

                entity.Property(e => e.ITonnage).HasColumnName("iTonnage");

                entity.Property(e => e.ITotalElements).HasColumnName("iTotalElements");

                entity.Property(e => e.IWeight).HasColumnName("iWeight");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMachine)
                    .HasColumnName("sMachine")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMaterial)
                    .HasColumnName("sMaterial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNote)
                    .HasColumnName("sNote")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SOperation)
                    .HasColumnName("sOperation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOtherNum)
                    .HasColumnName("sOtherNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRunBy)
                    .HasColumnName("sRunBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TDeformlogStep>(entity =>
            {
                entity.HasKey(e => e.SStepGuid);

                entity.ToTable("tDEFORMLogStep");

                entity.Property(e => e.SStepGuid)
                    .HasColumnName("sStepGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblStepIncrement)
                    .HasColumnName("dblStepIncrement")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.ISteps).HasColumnName("iSteps");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SLogGuid).HasColumnName("sLogGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SLogGu)
                    .WithMany(p => p.TDeformlogStep)
                    .HasForeignKey(d => d.SLogGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tDEFORMLogStep_tDEFORMLog");
            });

            modelBuilder.Entity<TDeformrequest>(entity =>
            {
                entity.HasKey(e => e.SRequestGuid);

                entity.ToTable("tDEFORMRequest");

                entity.Property(e => e.SRequestGuid)
                    .HasColumnName("sRequestGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblBilletSizeMax)
                    .HasColumnName("dblBilletSizeMax")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblBilletSizeMin)
                    .HasColumnName("dblBilletSizeMin")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPressSpeed)
                    .HasColumnName("dblPressSpeed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtExpected)
                    .HasColumnName("dtExpected")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRequest)
                    .HasColumnName("dtRequest")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDieTemp).HasColumnName("iDieTemp");

                entity.Property(e => e.IForgingTemp).HasColumnName("iForgingTemp");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDeformlogGuid).HasColumnName("sDEFORMLogGUID");

                entity.Property(e => e.SInfoRequest)
                    .HasColumnName("sInfoRequest")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SInfoRequestOther)
                    .HasColumnName("sInfoRequestOther")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SInstruction)
                    .HasColumnName("sInstruction")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMachine)
                    .HasColumnName("sMachine")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SMaterial)
                    .HasColumnName("sMaterial")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SModelStlfilePath)
                    .HasColumnName("sModelSTLFilePath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SOtherNum)
                    .HasColumnName("sOtherNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SProcess)
                    .HasColumnName("sProcess")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SRequestBy)
                    .HasColumnName("sRequestBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSimulationType)
                    .HasColumnName("sSimulationType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TDepartment>(entity =>
            {
                entity.HasKey(e => e.SDepartmentGuid)
                    .IsClustered(false);

                entity.ToTable("tDepartment");

                entity.HasIndex(e => e.IDeptId)
                    .HasName("IX_tDepartment")
                    .IsClustered();

                entity.Property(e => e.SDepartmentGuid)
                    .HasColumnName("sDepartmentGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDeptId).HasColumnName("iDeptID");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBestPracticeAbbrev)
                    .HasColumnName("sBestPracticeAbbrev")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TDepartmentSupervisor>(entity =>
            {
                entity.HasKey(e => e.SSupervisorGuid);

                entity.ToTable("tDepartmentSupervisor");

                entity.Property(e => e.SSupervisorGuid)
                    .HasColumnName("sSupervisorGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDepartmentGuid).HasColumnName("sDepartmentGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");
            });

            modelBuilder.Entity<TDigitalSignagePackage>(entity =>
            {
                entity.HasKey(e => e.SPackageGuid);

                entity.ToTable("tDigitalSignagePackage");

                entity.Property(e => e.SPackageGuid)
                    .HasColumnName("sPackageGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BEmergencyPackage).HasColumnName("bEmergencyPackage");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BScreenSaverPackage).HasColumnName("bScreenSaverPackage");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtRunPackageFrom)
                    .HasColumnName("dtRunPackageFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRunPackageTo)
                    .HasColumnName("dtRunPackageTo")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobName)
                    .HasColumnName("sJobName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.STargetComputerName)
                    .HasColumnName("sTargetComputerName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STargetIpaddress)
                    .HasColumnName("sTargetIPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TDigitalSignagePackageDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tDigitalSignagePackageDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BFooterTextFadeOut).HasColumnName("bFooterTextFadeOut");

                entity.Property(e => e.BHeaderTextFadeOut).HasColumnName("bHeaderTextFadeOut");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IRefreshInterval)
                    .HasColumnName("iRefreshInterval")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SFileChecksum)
                    .HasColumnName("sFileChecksum")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SFooterText)
                    .HasColumnName("sFooterText")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SHeaderText)
                    .HasColumnName("sHeaderText")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SPackageGuid).HasColumnName("sPackageGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVideoPath)
                    .HasColumnName("sVideoPath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPackageGu)
                    .WithMany(p => p.TDigitalSignagePackageDetail)
                    .HasForeignKey(d => d.SPackageGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tDigitalSignagePackageDetail_tDigitalSignagePackage");
            });

            modelBuilder.Entity<TDprarchiveDetail>(entity =>
            {
                entity.HasKey(e => e.SArchiveGuid);

                entity.ToTable("tDPRArchiveDetail");

                entity.HasIndex(e => e.SFileGuid)
                    .HasName("IX_FileGUID");

                entity.HasIndex(e => e.SJobNum)
                    .HasName("IX_sJobNum");

                entity.HasIndex(e => new { e.SFileGuid, e.IOriginalLineNum })
                    .HasName("IX_FileGUID_LineNum");

                entity.Property(e => e.SArchiveGuid)
                    .HasColumnName("sArchiveGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblHours)
                    .HasColumnName("dblHours")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLogged)
                    .HasColumnName("dtLogged")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IOriginalLineNum)
                    .HasColumnName("iOriginalLineNum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IPieces).HasColumnName("iPieces");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDepartment)
                    .HasColumnName("sDepartment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SEmployeeName)
                    .HasColumnName("sEmployeeName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEmployeeNum)
                    .HasColumnName("sEmployeeNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFileGuid).HasColumnName("sFileGUID");

                entity.Property(e => e.SGlcode)
                    .HasColumnName("sGLCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMachine)
                    .HasColumnName("sMachine")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperationNum)
                    .HasColumnName("sOperationNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SStatus)
                    .HasColumnName("sStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SStepNum)
                    .HasColumnName("sStepNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STravelerLineDesc)
                    .HasColumnName("sTravelerLineDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SFileGu)
                    .WithMany(p => p.TDprarchiveDetail)
                    .HasForeignKey(d => d.SFileGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tDPRArchiveDetail_tDPRArchiveFile");
            });

            modelBuilder.Entity<TDprarchiveFile>(entity =>
            {
                entity.HasKey(e => e.SFileGuid);

                entity.ToTable("tDPRArchiveFile");

                entity.HasIndex(e => e.DtDateInTitle)
                    .HasName("IX_DateInTitle");

                entity.HasIndex(e => e.DtDprrun)
                    .HasName("IX_DateDPRRun");

                entity.HasIndex(e => e.SDirectoryName)
                    .HasName("IX_DirName");

                entity.HasIndex(e => new { e.SDirectoryName, e.SFileName })
                    .HasName("IX_DirName_FileName");

                entity.Property(e => e.SFileGuid)
                    .HasColumnName("sFileGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.Dbl0405)
                    .HasColumnName("dbl0405")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.Dbl0406)
                    .HasColumnName("dbl0406")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblCreditTotal)
                    .HasColumnName("dblCreditTotal")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblDebit0140)
                    .HasColumnName("dblDebit0140")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblGrandTotalCost)
                    .HasColumnName("dblGrandTotalCost")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblGrandTotalHours)
                    .HasColumnName("dblGrandTotalHours")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblOther)
                    .HasColumnName("dblOther")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblTotalDirect)
                    .HasColumnName("dblTotalDirect")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblTotalIndirect)
                    .HasColumnName("dblTotalIndirect")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblTotalWarehouse)
                    .HasColumnName("dblTotalWarehouse")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblXx99)
                    .HasColumnName("dblXX99")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDateInFileName)
                    .HasColumnName("dtDateInFileName")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtDateInTitle)
                    .HasColumnName("dtDateInTitle")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtDprrun)
                    .HasColumnName("dtDPRRun")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLogged)
                    .HasColumnName("dtLogged")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtPostingsFor)
                    .HasColumnName("dtPostingsFor")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDirectoryName)
                    .HasColumnName("sDirectoryName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SFileName)
                    .HasColumnName("sFileName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SFileType)
                    .HasColumnName("sFileType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SProgram)
                    .HasColumnName("sProgram")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRawText)
                    .HasColumnName("sRawText")
                    .HasColumnType("text");

                entity.Property(e => e.SReportTitle)
                    .HasColumnName("sReportTitle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserInFileName)
                    .HasColumnName("sUserInFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserName)
                    .HasColumnName("sUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TDprmachineShopDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tDPRMachineShopDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IMinutes).HasColumnName("iMinutes");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDprguid).HasColumnName("sDPRGUID");

                entity.Property(e => e.SReason)
                    .HasColumnName("sReason")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SDprgu)
                    .WithMany(p => p.TDprmachineShopDetail)
                    .HasForeignKey(d => d.SDprguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tDPRMachineShopDetail_tDPRMachineShopMaster");
            });

            modelBuilder.Entity<TDprmachineShopMaster>(entity =>
            {
                entity.HasKey(e => e.SDprguid);

                entity.ToTable("tDPRMachineShopMaster");

                entity.Property(e => e.SDprguid)
                    .HasColumnName("sDPRGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BCompleted).HasColumnName("bCompleted");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEntry)
                    .HasColumnName("dtEntry")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IMinutes).HasColumnName("iMinutes");

                entity.Property(e => e.ISrrstepNum).HasColumnName("iSRRStepNum");

                entity.Property(e => e.ITravelerStepNum).HasColumnName("iTravelerStepNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEmployeeId)
                    .IsRequired()
                    .HasColumnName("sEmployeeID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .IsRequired()
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineCode)
                    .HasColumnName("sMachineCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SNote)
                    .HasColumnName("sNote")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SSerialNum)
                    .IsRequired()
                    .HasColumnName("sSerialNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TEmployee>(entity =>
            {
                entity.HasKey(e => e.SEmployeeGuid);

                entity.ToTable("tEmployee");

                entity.HasIndex(e => e.SGoesByLastName)
                    .HasName("IX_GoesByLastName");

                entity.HasIndex(e => new { e.SEmployeeGuid, e.IDeptNum, e.SLastName, e.SFirstName, e.SGoesByFirstName, e.BInactive })
                    .HasName("IX_Emp_Inactive");

                entity.HasIndex(e => new { e.SEmployeeGuid, e.IDeptNum, e.SLastName, e.SFirstName, e.SGoesByFirstName, e.BIsTemp, e.BInactive })
                    .HasName("IX_IsTemp_Inactive");

                entity.Property(e => e.SEmployeeGuid)
                    .HasColumnName("sEmployeeGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BFraudFalsification).HasColumnName("bFraudFalsification");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsDisabled).HasColumnName("bIsDisabled");

                entity.Property(e => e.BIsSalary).HasColumnName("bIsSalary");

                entity.Property(e => e.BIsTemp).HasColumnName("bIsTemp");

                entity.Property(e => e.BIsVeteran).HasColumnName("bIsVeteran");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAffordableCareAct)
                    .HasColumnName("dblAffordableCareAct")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblMarkup)
                    .HasColumnName("dblMarkup")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblShiftDifferential)
                    .HasColumnName("dblShiftDifferential")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblYearsService)
                    .HasColumnName("dblYearsService")
                    .HasColumnType("numeric(18, 2)")
                    .HasComputedColumnSql("([dbo].[fnHR_YearsService]([sEmployeeGUID]))");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtHire)
                    .HasColumnName("dtHire")
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("([dbo].[fnHR_GetHireDate]([sEmployeeGUID]))");

                entity.Property(e => e.DtLastAnniversary)
                    .HasColumnName("dtLastAnniversary")
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("([dbo].[fnHR_NextLastAnniversaryDate]([sEmployeeGUID],(-1)))");

                entity.Property(e => e.DtNextAnniversary)
                    .HasColumnName("dtNextAnniversary")
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("([dbo].[fnHR_NextLastAnniversaryDate]([sEmployeeGUID],(1)))");

                entity.Property(e => e.DtTermination)
                    .HasColumnName("dtTermination")
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("([dbo].[fnHR_GetTerminationDate]([sEmployeeGUID]))");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAdpnumber)
                    .HasColumnName("iADPNumber")
                    .HasComputedColumnSql("([dbo].[fnHR_ADPNumber]([iEmpID]))");

                entity.Property(e => e.IDeptNum).HasColumnName("iDeptNum");

                entity.Property(e => e.IEmpId).HasColumnName("iEmpID");

                entity.Property(e => e.IExecutiveLevel).HasColumnName("iExecutiveLevel");

                entity.Property(e => e.IPhoneExtension).HasColumnName("iPhoneExtension");

                entity.Property(e => e.IShift).HasColumnName("iShift");

                entity.Property(e => e.ITempAccessKey).HasColumnName("iTempAccessKey");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttenuation)
                    .HasColumnName("sAttenuation")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SAttenuationExtended)
                    .HasColumnName("sAttenuationExtended")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SBusinessPhone)
                    .HasColumnName("sBusinessPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCellPhone1)
                    .HasColumnName("sCellPhone1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCellPhone2)
                    .HasColumnName("sCellPhone2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCompanyGuid).HasColumnName("sCompanyGUID");

                entity.Property(e => e.SDeptText)
                    .HasColumnName("sDeptText")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[fnHR_DeptText]([iDeptNum]))");

                entity.Property(e => e.SEmail)
                    .HasColumnName("sEMail")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SEmpNumber)
                    .HasColumnName("sEmpNumber")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[fnHR_EmpNumber]([iDeptNum],[iEmpID]))");

                entity.Property(e => e.SFirstName)
                    .IsRequired()
                    .HasColumnName("sFirstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SGoesByFirstName)
                    .IsRequired()
                    .HasColumnName("sGoesByFirstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SGoesByLastName)
                    .IsRequired()
                    .HasColumnName("sGoesByLastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SJobTitle)
                    .HasColumnName("sJobTitle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLastName)
                    .IsRequired()
                    .HasColumnName("sLastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SNotes)
                    .HasColumnName("sNotes")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SSsn)
                    .HasColumnName("sSSN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSsnlastFour)
                    .HasColumnName("sSSNLastFour")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSupervisorGuid).HasColumnName("sSupervisorGUID");

                entity.Property(e => e.STempEmpId)
                    .HasColumnName("sTempEmpID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STempStatus)
                    .HasColumnName("sTempStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SWorkAddress)
                    .HasColumnName("sWorkAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SWorkCity)
                    .HasColumnName("sWorkCity")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SWorkState)
                    .HasColumnName("sWorkState")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SWorkZip)
                    .HasColumnName("sWorkZip")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TEmployeeAttendance>(entity =>
            {
                entity.HasKey(e => e.SReasonGuid);

                entity.ToTable("tEmployeeAttendance");

                entity.Property(e => e.SReasonGuid)
                    .HasColumnName("sReasonGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblHours)
                    .HasColumnName("dblHours")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEntry)
                    .HasColumnName("dtEntry")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEmployeeGuid).HasColumnName("sEmployeeGUID");

                entity.Property(e => e.SReason)
                    .HasColumnName("sReason")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SEmployeeGu)
                    .WithMany(p => p.TEmployeeAttendance)
                    .HasForeignKey(d => d.SEmployeeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tEmployeeAttendance_tEmployee");
            });

            modelBuilder.Entity<TEmployeeBank>(entity =>
            {
                entity.HasKey(e => e.SBankGuid);

                entity.ToTable("tEmployeeBank");

                entity.HasIndex(e => new { e.DtTransaction, e.STransDesc, e.SEmployeeGuid, e.SBankType })
                    .HasName("IX_EmpGUID_BankType");

                entity.Property(e => e.SBankGuid)
                    .HasColumnName("sBankGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblHours)
                    .HasColumnName("dblHours")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtTransaction)
                    .HasColumnName("dtTransaction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBankType)
                    .IsRequired()
                    .HasColumnName("sBankType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEmployeeGuid).HasColumnName("sEmployeeGUID");

                entity.Property(e => e.STransDesc)
                    .HasColumnName("sTransDesc")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SEmployeeGu)
                    .WithMany(p => p.TEmployeeBank)
                    .HasForeignKey(d => d.SEmployeeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tEmployeeBank_tEmployee");
            });

            modelBuilder.Entity<TEmployeeDate>(entity =>
            {
                entity.HasKey(e => e.SDateGuid);

                entity.ToTable("tEmployeeDate");

                entity.HasIndex(e => e.SEmployeeGuid)
                    .HasName("IX_EmployeeGUID");

                entity.Property(e => e.SDateGuid)
                    .HasColumnName("sDateGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEvent)
                    .HasColumnName("dtEvent")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .IsRequired()
                    .HasColumnName("sDescription")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SEmployeeGuid).HasColumnName("sEmployeeGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SEmployeeGu)
                    .WithMany(p => p.TEmployeeDate)
                    .HasForeignKey(d => d.SEmployeeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tEmployeeDate_tEmployee");
            });

            modelBuilder.Entity<TForgeClampDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tForgeClampDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IPosition).HasColumnName("iPosition");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SClampOption)
                    .HasColumnName("sClampOption")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOpGuid).HasColumnName("sOpGUID");

                entity.Property(e => e.SSingleDouble)
                    .HasColumnName("sSingleDouble")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STopBottom)
                    .HasColumnName("sTopBottom")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SOpGu)
                    .WithMany(p => p.TForgeClampDetail)
                    .HasForeignKey(d => d.SOpGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeClampDetail_tForgeClampOperation");
            });

            modelBuilder.Entity<TForgeClampMaster>(entity =>
            {
                entity.HasKey(e => e.SMasterGuid);

                entity.ToTable("tForgeClampMaster");

                entity.Property(e => e.SMasterGuid)
                    .HasColumnName("sMasterGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .IsRequired()
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPress)
                    .HasColumnName("sPress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRevision)
                    .HasColumnName("sRevision")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TForgeClampOperation>(entity =>
            {
                entity.HasKey(e => e.SOpGuid);

                entity.ToTable("tForgeClampOperation");

                entity.Property(e => e.SOpGuid)
                    .HasColumnName("sOpGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBottomLeftImageAttachmentGuid).HasColumnName("sBottomLeftImageAttachmentGUID");

                entity.Property(e => e.SBottomRightImageAttachmentGuid).HasColumnName("sBottomRightImageAttachmentGUID");

                entity.Property(e => e.SDieLocationBottomLeft)
                    .HasColumnName("sDieLocationBottomLeft")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SDieLocationBottomRight)
                    .HasColumnName("sDieLocationBottomRight")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SDieLocationTopLeft)
                    .HasColumnName("sDieLocationTopLeft")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SDieLocationTopRight)
                    .HasColumnName("sDieLocationTopRight")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SFlashTextBottom)
                    .HasColumnName("sFlashTextBottom")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SFlashTextTop)
                    .HasColumnName("sFlashTextTop")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SMasterGuid).HasColumnName("sMasterGUID");

                entity.Property(e => e.SOperation)
                    .HasColumnName("sOperation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.STopLeftImageAttachmentGuid).HasColumnName("sTopLeftImageAttachmentGUID");

                entity.Property(e => e.STopRightImageAttachmentGuid).HasColumnName("sTopRightImageAttachmentGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMasterGu)
                    .WithMany(p => p.TForgeClampOperation)
                    .HasForeignKey(d => d.SMasterGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeClampOperation_tForgeClampMaster");
            });

            modelBuilder.Entity<TForgeCondDyeReason>(entity =>
            {
                entity.HasKey(e => e.SDyeReasonGuid);

                entity.ToTable("tForgeCondDyeReason");

                entity.Property(e => e.SDyeReasonGuid)
                    .HasColumnName("sDyeReasonGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SReason)
                    .HasColumnName("sReason")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TForgeCondPiece>(entity =>
            {
                entity.HasKey(e => e.SJobGuid);

                entity.ToTable("tForgeCondPiece");

                entity.HasIndex(e => new { e.SRateGuid, e.IStepNum, e.SSerialNumber })
                    .HasName("IX_RateGUID_StepNum_SerialNum");

                entity.Property(e => e.SJobGuid)
                    .HasColumnName("sJobGuid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BDyePenUsed)
                    .HasColumnName("bDyePenUsed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BInprogress).HasColumnName("bInprogress");

                entity.Property(e => e.BRework).HasColumnName("bRework");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMeterFinishRead)
                    .HasColumnName("dblMeterFinishRead")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMeterStartRead)
                    .HasColumnName("dblMeterStartRead")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCompletion)
                    .HasColumnName("dtCompletion")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStartTime)
                    .HasColumnName("dtStartTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStopTime)
                    .HasColumnName("dtStopTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IFinisherBadgeId).HasColumnName("iFinisherBadgeID");

                entity.Property(e => e.IStarterBadgeId).HasColumnName("iStarterBadgeID");

                entity.Property(e => e.IStepNum).HasColumnName("iStepNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SComments)
                    .HasColumnName("sComments")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SMachine)
                    .IsRequired()
                    .HasColumnName("sMachine")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRateGuid).HasColumnName("sRateGUID");

                entity.Property(e => e.SReason)
                    .HasColumnName("sReason")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SSerialNumber)
                    .IsRequired()
                    .HasColumnName("sSerialNumber")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SShift)
                    .IsRequired()
                    .HasColumnName("sShift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SRateGu)
                    .WithMany(p => p.TForgeCondPiece)
                    .HasForeignKey(d => d.SRateGuid)
                    .HasConstraintName("FK_tForgeCondPiece_tForgeCondRate");
            });

            modelBuilder.Entity<TForgeCondRate>(entity =>
            {
                entity.HasKey(e => e.SRateGuid);

                entity.ToTable("tForgeCondRate");

                entity.HasIndex(e => e.BInactive)
                    .HasName("ix_Inactive");

                entity.HasIndex(e => e.SJobNumber)
                    .HasName("ix_JobNumber");

                entity.Property(e => e.SRateGuid)
                    .HasColumnName("sRateGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BAddStep).HasColumnName("bAddStep");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblActualHours)
                    .HasColumnName("dblActualHours")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblActualMinutes)
                    .HasColumnName("dblActualMinutes")
                    .HasColumnType("numeric(21, 4)")
                    .HasComputedColumnSql("([dblActualHours]*(60))");

                entity.Property(e => e.DblDeltaHours)
                    .HasColumnName("dblDeltaHours")
                    .HasColumnType("numeric(19, 4)")
                    .HasComputedColumnSql("([dblEstimatedHours]-[dblActualHours])");

                entity.Property(e => e.DblDeltaMinutes)
                    .HasColumnName("dblDeltaMinutes")
                    .HasColumnType("numeric(22, 4)")
                    .HasComputedColumnSql("([dblEstimatedHours]*(60)-(60)*[dblActualHours])");

                entity.Property(e => e.DblEstimatedHours)
                    .HasColumnName("dblEstimatedHours")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblEstimatedMinutes)
                    .HasColumnName("dblEstimatedMinutes")
                    .HasColumnType("numeric(21, 4)")
                    .HasComputedColumnSql("([dblEstimatedHours]*(60))");

                entity.Property(e => e.DblHoursPerPiece)
                    .HasColumnName("dblHoursPerPiece")
                    .HasColumnType("numeric(29, 15)")
                    .HasComputedColumnSql("([dblActualHours]/nullif([iQtyDone],(0)))");

                entity.Property(e => e.DblPcsHour)
                    .HasColumnName("dblPcsHour")
                    .HasColumnType("numeric(33, 19)")
                    .HasComputedColumnSql("([iQtyDone]/nullif([dblActualHours],(0)))");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCompletion)
                    .HasColumnName("dtCompletion")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtEstimatedCompletion)
                    .HasColumnName("dtEstimatedCompletion")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtReceived)
                    .HasColumnName("dtReceived")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDays)
                    .HasColumnName("iDays")
                    .HasComputedColumnSql("(datediff(day,[dtReceived],[dtCompletion]))");

                entity.Property(e => e.IQtyDone).HasColumnName("iQtyDone");

                entity.Property(e => e.IQtyRequired).HasColumnName("iQtyRequired");

                entity.Property(e => e.IStepNum).HasColumnName("iStepNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SArea)
                    .HasColumnName("sArea")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SCalculationNotes)
                    .HasColumnName("sCalculationNotes")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SComments)
                    .HasColumnName("sComments")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumber)
                    .IsRequired()
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SMaterialType)
                    .HasColumnName("sMaterialType")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SOperation)
                    .HasColumnName("sOperation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SReason)
                    .HasColumnName("sReason")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SSizeStage)
                    .HasColumnName("sSizeStage")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TForgeCondSpark>(entity =>
            {
                entity.HasKey(e => e.SSparkGuid);

                entity.ToTable("tForgeCondSpark");

                entity.Property(e => e.SSparkGuid)
                    .HasColumnName("sSparkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISparkMaxValue).HasColumnName("iSparkMaxValue");

                entity.Property(e => e.ISparkMinValue).HasColumnName("iSparkMinValue");

                entity.Property(e => e.ISparkTime).HasColumnName("iSparkTime");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPieceGuid).HasColumnName("sPieceGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPieceGu)
                    .WithMany(p => p.TForgeCondSpark)
                    .HasForeignKey(d => d.SPieceGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeCondSpark_tForgeCondSpark");
            });

            modelBuilder.Entity<TForgeLoadMapBatch>(entity =>
            {
                entity.HasKey(e => e.SBatchGuid);

                entity.ToTable("tForgeLoadMapBatch");

                entity.Property(e => e.SBatchGuid)
                    .HasColumnName("sBatchGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BLowerAtSelected1).HasColumnName("bLowerAtSelected1");

                entity.Property(e => e.BLowerAtSelected2).HasColumnName("bLowerAtSelected2");

                entity.Property(e => e.BLowerAtSelected3).HasColumnName("bLowerAtSelected3");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BWillAdvise1).HasColumnName("bWillAdvise1");

                entity.Property(e => e.BWillAdvise2).HasColumnName("bWillAdvise2");

                entity.Property(e => e.BWillAdvise3).HasColumnName("bWillAdvise3");

                entity.Property(e => e.BWillAdvise4).HasColumnName("bWillAdvise4");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dtCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtDoNotForgeBefore)
                    .HasColumnName("dtDoNotForgeBefore")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLightAtTime)
                    .HasColumnName("dtLightAtTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRaiseAt1)
                    .HasColumnName("dtRaiseAt1")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRaiseAt2)
                    .HasColumnName("dtRaiseAt2")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRaiseAt3)
                    .HasColumnName("dtRaiseAt3")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRunScheduled)
                    .HasColumnName("dtRunScheduled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtSigned)
                    .HasColumnName("dtSigned")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IEstWeightLbs).HasColumnName("iEstWeightLbs");

                entity.Property(e => e.IFurnaceAngle).HasColumnName("iFurnaceAngle");

                entity.Property(e => e.ISetTemp1).HasColumnName("iSetTemp1");

                entity.Property(e => e.ISetTemp2).HasColumnName("iSetTemp2");

                entity.Property(e => e.ISetTemp3).HasColumnName("iSetTemp3");

                entity.Property(e => e.ISetTemp4).HasColumnName("iSetTemp4");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SBatchInstance)
                    .HasColumnName("sBatchInstance")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFurnaceGuid).HasColumnName("sFurnaceGUID");

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNoteRtf)
                    .HasColumnName("sNoteRTF")
                    .HasColumnType("text");

                entity.Property(e => e.SNoteText)
                    .HasColumnName("sNoteText")
                    .HasColumnType("text");

                entity.Property(e => e.SOverTempSetPoint1Signed)
                    .HasColumnName("sOverTempSetPoint1Signed")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOverTempSetPoint2Signed)
                    .HasColumnName("sOverTempSetPoint2Signed")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOverTempSetPoint3Signed)
                    .HasColumnName("sOverTempSetPoint3Signed")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSignedBy)
                    .HasColumnName("sSignedBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SFurnaceGu)
                    .WithMany(p => p.TForgeLoadMapBatch)
                    .HasForeignKey(d => d.SFurnaceGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeLoadMapBatch_tForgeLoadMapFurnace");
            });

            modelBuilder.Entity<TForgeLoadMapDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tForgeLoadMapDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BHasPartBeenBackCharged).HasColumnName("bHasPartBeenBackCharged");

                entity.Property(e => e.BHasPartBeenInitialLoaded).HasColumnName("bHasPartBeenInitialLoaded");

                entity.Property(e => e.BHasPartBeenProcessed).HasColumnName("bHasPartBeenProcessed");

                entity.Property(e => e.BHasPartBeenTransfered).HasColumnName("bHasPartBeenTransfered");

                entity.Property(e => e.BPrematurelyUnloaded).HasColumnName("bPrematurelyUnloaded");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAngleOnFurnace)
                    .HasColumnName("dblAngleOnFurnace")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DblAngleOnFurnaceOriginal)
                    .HasColumnName("dblAngleOnFurnaceOriginal")
                    .HasColumnType("numeric(18, 13)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DblPerctFromRadius)
                    .HasColumnName("dblPerctFromRadius")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DblPerctHeightOfCanvas)
                    .HasColumnName("dblPerctHeightOfCanvas")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DblPerctWidthOfCanvas)
                    .HasColumnName("dblPerctWidthOfCanvas")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SItemGuid).HasColumnName("sItemGUID");

                entity.Property(e => e.SLoadMapGuid).HasColumnName("sLoadMapGUID");

                entity.Property(e => e.SPartType)
                    .HasColumnName("sPartType")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('CONVENTIONAL_PART')");

                entity.Property(e => e.SSerialNum)
                    .HasColumnName("sSerialNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SItemGu)
                    .WithMany(p => p.TForgeLoadMapDetail)
                    .HasForeignKey(d => d.SItemGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeLoadMapDetail_tForgeLoadMapItem");

                entity.HasOne(d => d.SLoadMapGu)
                    .WithMany(p => p.TForgeLoadMapDetail)
                    .HasForeignKey(d => d.SLoadMapGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeLoadMapDetail_tForgeLoadMapJob");
            });

            modelBuilder.Entity<TForgeLoadMapDetailRegister>(entity =>
            {
                entity.HasKey(e => e.SRegisterGuid)
                    .IsClustered(false);

                entity.ToTable("tForgeLoadMapDetailRegister");

                entity.Property(e => e.SRegisterGuid)
                    .HasColumnName("sRegisterGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAngleOnFurnace)
                    .HasColumnName("dblAngleOnFurnace")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DblPerctFromRadius)
                    .HasColumnName("dblPerctFromRadius")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DblPerctHeightOfCanvas)
                    .HasColumnName("dblPerctHeightOfCanvas")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DblPerctWidthOfCanvas)
                    .HasColumnName("dblPerctWidthOfCanvas")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dtEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dtStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IFurnaceAngle).HasColumnName("iFurnaceAngle");

                entity.Property(e => e.SActionType)
                    .HasColumnName("sActionType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDetailGuid).HasColumnName("sDetailGUID");

                entity.Property(e => e.SMachine)
                    .HasColumnName("sMachine")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SDetailGu)
                    .WithMany(p => p.TForgeLoadMapDetailRegister)
                    .HasForeignKey(d => d.SDetailGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeLoadMapDetailRegister_tForgeLoadMapDetail");
            });

            modelBuilder.Entity<TForgeLoadMapFurnace>(entity =>
            {
                entity.HasKey(e => e.SFurnaceGuid);

                entity.ToTable("tForgeLoadMapFurnace");

                entity.Property(e => e.SFurnaceGuid)
                    .HasColumnName("sFurnaceGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BCenterColumn).HasColumnName("bCenterColumn");

                entity.Property(e => e.BLoadCcw).HasColumnName("bLoadCCW");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblDoorOpeningWidth)
                    .HasColumnName("dblDoorOpeningWidth")
                    .HasColumnType("numeric(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICenterColumnHeight).HasColumnName("iCenterColumnHeight");

                entity.Property(e => e.ICenterColumnWidth).HasColumnName("iCenterColumnWidth");

                entity.Property(e => e.IHeight).HasColumnName("iHeight");

                entity.Property(e => e.IRotationAngle)
                    .HasColumnName("iRotationAngle")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IWidth).HasColumnName("iWidth");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFurnaceName)
                    .HasColumnName("sFurnaceName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFurnaceType)
                    .HasColumnName("sFurnaceType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TForgeLoadMapItem>(entity =>
            {
                entity.HasKey(e => e.SItemGuid);

                entity.ToTable("tForgeLoadMapItem");

                entity.Property(e => e.SItemGuid)
                    .HasColumnName("sItemGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblPartLength)
                    .HasColumnName("dblPartLength")
                    .HasColumnType("decimal(18, 9)");

                entity.Property(e => e.DblPartWidth)
                    .HasColumnName("dblPartWidth")
                    .HasColumnType("decimal(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IImageHeight).HasColumnName("iImageHeight");

                entity.Property(e => e.IImageWidth).HasColumnName("iImageWidth");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SImagePathLarge)
                    .HasColumnName("sImagePathLarge")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SImagePathSmall)
                    .HasColumnName("sImagePathSmall")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TForgeLoadMapJob>(entity =>
            {
                entity.HasKey(e => e.SLoadMapGuid);

                entity.ToTable("tForgeLoadMapJob");

                entity.Property(e => e.SLoadMapGuid)
                    .HasColumnName("sLoadMapGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBatchGuid).HasColumnName("sBatchGUID");

                entity.Property(e => e.SCoating)
                    .HasColumnName("sCoating")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SFurnaceSheetName)
                    .HasColumnName("sFurnaceSheetName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobType)
                    .HasColumnName("sJobType")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SMaintSheetName)
                    .HasColumnName("sMaintSheetName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SMaterial)
                    .HasColumnName("sMaterial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNoteRtf)
                    .HasColumnName("sNoteRTF")
                    .HasColumnType("text");

                entity.Property(e => e.SNoteText)
                    .HasColumnName("sNoteText")
                    .HasColumnType("text");

                entity.Property(e => e.SSize)
                    .HasColumnName("sSize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSourceFurnace)
                    .HasColumnName("sSourceFurnace")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSupport)
                    .HasColumnName("sSupport")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STargetFurnace)
                    .HasColumnName("sTargetFurnace")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STravelerName)
                    .HasColumnName("sTravelerName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SBatchGu)
                    .WithMany(p => p.TForgeLoadMapJob)
                    .HasForeignKey(d => d.SBatchGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeLoadMapJob_tForgeLoadMapBatch");
            });

            modelBuilder.Entity<TForgeLoadMapSnapshot>(entity =>
            {
                entity.HasKey(e => e.SSnapshotGuid);

                entity.ToTable("tForgeLoadMapSnapshot");

                entity.Property(e => e.SSnapshotGuid)
                    .HasColumnName("sSnapshotGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedBy)
                    .HasColumnName("sAddedBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SFurnaceGuid).HasColumnName("sFurnaceGUID");

                entity.Property(e => e.SUpdatedBy)
                    .HasColumnName("sUpdatedBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TForgeLoadMapSnapshotDetail>(entity =>
            {
                entity.HasKey(e => e.SSnapshotDetailGuid);

                entity.ToTable("tForgeLoadMapSnapshotDetail");

                entity.Property(e => e.SSnapshotDetailGuid)
                    .HasColumnName("sSnapshotDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAngleOnFurnace)
                    .HasColumnName("dblAngleOnFurnace")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DblPercFromRadius)
                    .HasColumnName("dblPercFromRadius")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DblPerctHeightOfCanvas)
                    .HasColumnName("dblPerctHeightOfCanvas")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DblPerctWidthOfCanvas)
                    .HasColumnName("dblPerctWidthOfCanvas")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IFurnaceAngle).HasColumnName("iFurnaceAngle");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SBatchGuid).HasColumnName("sBatchGUID");

                entity.Property(e => e.SDetailGuid).HasColumnName("sDetailGUID");

                entity.Property(e => e.SFurnaceGuid).HasColumnName("sFurnaceGUID");

                entity.Property(e => e.SItemGuid).HasColumnName("sItemGUID");

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSerialNum)
                    .HasColumnName("sSerialNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSnapShotMainGuid).HasColumnName("sSnapShotMainGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SSnapShotMainGu)
                    .WithMany(p => p.TForgeLoadMapSnapshotDetail)
                    .HasForeignKey(d => d.SSnapShotMainGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeLoadMapSnapshotDetail_tForgeLoadMapSnapshot");
            });

            modelBuilder.Entity<TForgeLoadMapTag>(entity =>
            {
                entity.HasKey(e => e.SRecGuid);

                entity.ToTable("tForgeLoadMapTag");

                entity.Property(e => e.SRecGuid)
                    .HasColumnName("sRecGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFurnaceGuid).HasColumnName("sFurnaceGUID");

                entity.Property(e => e.STagName)
                    .IsRequired()
                    .HasColumnName("sTagName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.STagType)
                    .HasColumnName("sTagType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SFurnaceGu)
                    .WithMany(p => p.TForgeLoadMapTag)
                    .HasForeignKey(d => d.SFurnaceGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeLoadMapTag_tForgeLoadMapFurnace");
            });

            modelBuilder.Entity<TForgeLoadMapWorkBatch>(entity =>
            {
                entity.HasKey(e => e.SWorkGuid);

                entity.ToTable("tForgeLoadMapWorkBatch");

                entity.Property(e => e.SWorkGuid)
                    .HasColumnName("sWorkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BCenterColumn).HasColumnName("bCenterColumn");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsPartInFurnace).HasColumnName("bIsPartInFurnace");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAngleOnFurnace)
                    .HasColumnName("dblAngleOnFurnace")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DblPartLength)
                    .HasColumnName("dblPartLength")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblPartWidth)
                    .HasColumnName("dblPartWidth")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblPerctHeightOfCanvas)
                    .HasColumnName("dblPerctHeightOfCanvas")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DblPerctRadiusFromCenter)
                    .HasColumnName("dblPerctRadiusFromCenter")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DblPerctWidthOfCanvas)
                    .HasColumnName("dblPerctWidthOfCanvas")
                    .HasColumnType("numeric(18, 13)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDoNotForgeBefore)
                    .HasColumnName("dtDoNotForgeBefore")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRunScheduled)
                    .HasColumnName("dtRunScheduled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICenterColumnHeight).HasColumnName("iCenterColumnHeight");

                entity.Property(e => e.ICenterColumnWidth).HasColumnName("iCenterColumnWidth");

                entity.Property(e => e.IFurnaceAngle).HasColumnName("iFurnaceAngle");

                entity.Property(e => e.IFurnaceRotationAngle).HasColumnName("iFurnaceRotationAngle");

                entity.Property(e => e.IHeight).HasColumnName("iHeight");

                entity.Property(e => e.IImageHeight).HasColumnName("iImageHeight");

                entity.Property(e => e.IImageWidth).HasColumnName("iImageWidth");

                entity.Property(e => e.IWidth).HasColumnName("iWidth");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBatchInstance)
                    .HasColumnName("sBatchInstance")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCoating)
                    .HasColumnName("sCoating")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDetailGuid).HasColumnName("sDetailGUID");

                entity.Property(e => e.SFurnaceName)
                    .HasColumnName("sFurnaceName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFurnaceType)
                    .HasColumnName("sFurnaceType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SImagePathLarge)
                    .HasColumnName("sImagePathLarge")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SImagePathSmall)
                    .HasColumnName("sImagePathSmall")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMaterial)
                    .HasColumnName("sMaterial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSerialNum)
                    .HasColumnName("sSerialNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSize)
                    .HasColumnName("sSize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSupport)
                    .HasColumnName("sSupport")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SDetailGu)
                    .WithMany(p => p.TForgeLoadMapWorkBatch)
                    .HasForeignKey(d => d.SDetailGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeLoadMapWorkBatch_tForgeLoadMapDetail");

                entity.HasOne(d => d.SWorkGu)
                    .WithOne(p => p.InverseSWorkGu)
                    .HasForeignKey<TForgeLoadMapWorkBatch>(d => d.SWorkGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeLoadMapWorkBatch_tForgeLoadMapWorkBatch");
            });

            modelBuilder.Entity<TForgeLoadOptimizationDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tForgeLoadOptimizationDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblXcoordinate)
                    .HasColumnName("dblXCoordinate")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblYcoordinate)
                    .HasColumnName("dblYCoordinate")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblZforce)
                    .HasColumnName("dblZForce")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IStepNum).HasColumnName("iStepNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SDisplayGuid).HasColumnName("sDisplayGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SDisplayGu)
                    .WithMany(p => p.TForgeLoadOptimizationDetail)
                    .HasForeignKey(d => d.SDisplayGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeForceCenterDetail_tForgeForceCenterMaster");
            });

            modelBuilder.Entity<TForgeLoadOptimizationMaster>(entity =>
            {
                entity.HasKey(e => e.SDisplayGuid);

                entity.ToTable("tForgeLoadOptimizationMaster");

                entity.Property(e => e.SDisplayGuid)
                    .HasColumnName("sDisplayGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblBottom)
                    .HasColumnName("dblBottom")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblDieRegisterX)
                    .HasColumnName("dblDieRegisterX")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblDieRegisterY)
                    .HasColumnName("dblDieRegisterY")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblLeft)
                    .HasColumnName("dblLeft")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblRight)
                    .HasColumnName("dblRight")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblTop)
                    .HasColumnName("dblTop")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .IsRequired()
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNote)
                    .HasColumnName("sNote")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SOperation)
                    .IsRequired()
                    .HasColumnName("sOperation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SPress)
                    .IsRequired()
                    .HasColumnName("sPress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TForgeMetric>(entity =>
            {
                entity.HasKey(e => e.SMetricGuid);

                entity.ToTable("tForgeMetric");

                entity.Property(e => e.SMetricGuid)
                    .HasColumnName("sMetricGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRework).HasColumnName("bRework");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblActual)
                    .HasColumnName("dblActual")
                    .HasColumnType("numeric(18, 4)")
                    .HasComputedColumnSql("([dbo].[fnForgeMetric_CalcActual]([dblActualRate],[iQty]))");

                entity.Property(e => e.DblActualRate)
                    .HasColumnName("dblActualRate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblAmount)
                    .HasColumnName("dblAmount")
                    .HasColumnType("numeric(18, 4)")
                    .HasComputedColumnSql("([dbo].[fnForgeMetric_CalcAmount]([sUnit],[dblPrevTarget],[dblActualRate],[iQty]))");

                entity.Property(e => e.DblNewTarget)
                    .HasColumnName("dblNewTarget")
                    .HasColumnType("numeric(18, 4)")
                    .HasComputedColumnSql("([dbo].[fnForgeMetric_CalcNewTarget]([dblPrevTarget],[iQty]))");

                entity.Property(e => e.DblOldTarget)
                    .HasColumnName("dblOldTarget")
                    .HasColumnType("numeric(18, 4)")
                    .HasComputedColumnSql("([dbo].[fnForgeMetric_CalcOldTarget]([dblPrevTarget]))");

                entity.Property(e => e.DblPercentTimeRemove)
                    .HasColumnName("dblPercentTimeRemove")
                    .HasColumnType("numeric(22, 4)")
                    .HasComputedColumnSql("([dbo].[fnForgeMetric_CalcMinutes]([iMinutesToRemove],[iMinutesToSetup],[iMinutesToRemove],[dblActualRate],[iQty])*(100))");

                entity.Property(e => e.DblPercentTimeSetup)
                    .HasColumnName("dblPercentTimeSetup")
                    .HasColumnType("numeric(22, 4)")
                    .HasComputedColumnSql("([dbo].[fnForgeMetric_CalcMinutes]([iMinutesToSetup],[iMinutesToSetup],[iMinutesToRemove],[dblActualRate],[iQty])*(100))");

                entity.Property(e => e.DblPrev)
                    .HasColumnName("dblPrev")
                    .HasColumnType("numeric(18, 4)")
                    .HasComputedColumnSql("([dbo].[fnForgeMetric_CalcPrev]([dblPrevTarget],[iQty]))");

                entity.Property(e => e.DblPrevTarget)
                    .HasColumnName("dblPrevTarget")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblToPrev)
                    .HasColumnName("dblToPrev")
                    .HasColumnType("numeric(18, 4)")
                    .HasComputedColumnSql("([dbo].[fnForgeMetric_CalcToPrev]([dblPrevTarget],[dblActualRate],[iQty]))");

                entity.Property(e => e.DblToTarget)
                    .HasColumnName("dblToTarget")
                    .HasColumnType("numeric(18, 4)")
                    .HasComputedColumnSql("([dbo].[fnForgeMetric_CalcToTarget]([dblPrevTarget],[dblActualRate],[iQty]))");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtRun)
                    .HasColumnName("dtRun")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDelayMinRemoval).HasColumnName("iDelayMinRemoval");

                entity.Property(e => e.IDelayMinRun).HasColumnName("iDelayMinRun");

                entity.Property(e => e.IDelayMinSetup).HasColumnName("iDelayMinSetup");

                entity.Property(e => e.IDieSetCount).HasColumnName("iDieSetCount");

                entity.Property(e => e.IMinutesToRemove)
                    .HasColumnName("iMinutesToRemove")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IMinutesToSetup)
                    .HasColumnName("iMinutesToSetup")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.INumRestrikes).HasColumnName("iNumRestrikes");

                entity.Property(e => e.IQty).HasColumnName("iQty");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCalculationNotes)
                    .HasColumnName("sCalculationNotes")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SDelayReasonRemoval)
                    .HasColumnName("sDelayReasonRemoval")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SDelayReasonRun)
                    .HasColumnName("sDelayReasonRun")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SDelayReasonSetup)
                    .HasColumnName("sDelayReasonSetup")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SDieSet)
                    .HasColumnName("sDieSet")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperation)
                    .HasColumnName("sOperation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SReason)
                    .HasColumnName("sReason")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SShift)
                    .IsRequired()
                    .HasColumnName("sShift")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SUnit)
                    .HasColumnName("sUnit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TForgeMetricGreenhouseGasTarget>(entity =>
            {
                entity.HasKey(e => e.STargetGuid)
                    .IsClustered(false);

                entity.ToTable("tForgeMetricGreenhouseGasTarget");

                entity.HasIndex(e => e.SJobNumMaster)
                    .HasName("IX_JobNum");

                entity.HasIndex(e => new { e.SJobNumMaster, e.SOperation })
                    .HasName("IX_JobNum_Operation");

                entity.Property(e => e.STargetGuid)
                    .HasColumnName("sTargetGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblTarget2009)
                    .HasColumnName("dblTarget2009")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumMaster)
                    .IsRequired()
                    .HasColumnName("sJobNumMaster")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperation)
                    .IsRequired()
                    .HasColumnName("sOperation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUnit)
                    .IsRequired()
                    .HasColumnName("sUnit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TForgeMetricNote>(entity =>
            {
                entity.HasKey(e => e.SNoteGuid);

                entity.ToTable("tForgeMetricNote");

                entity.Property(e => e.SNoteGuid)
                    .HasColumnName("sNoteGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SMetricGuid).HasColumnName("sMetricGUID");

                entity.Property(e => e.SRtfguid).HasColumnName("sRTFGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMetricGu)
                    .WithMany(p => p.TForgeMetricNote)
                    .HasForeignKey(d => d.SMetricGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tForgeMetricNote_tForgeMetric");
            });

            modelBuilder.Entity<TGasMeter>(entity =>
            {
                entity.HasKey(e => e.SMeterGuid);

                entity.ToTable("tGasMeter");

                entity.Property(e => e.SMeterGuid)
                    .HasColumnName("sMeterGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMeterIp)
                    .IsRequired()
                    .HasColumnName("sMeterIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMeterName)
                    .IsRequired()
                    .HasColumnName("sMeterName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TGasMeterLog>(entity =>
            {
                entity.HasKey(e => e.SRecGuid);

                entity.ToTable("tGasMeterLog");

                entity.Property(e => e.SRecGuid)
                    .HasColumnName("sRecGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowVersion)
                    .IsRequired()
                    .HasColumnName("bRowVersion")
                    .IsRowVersion();

                entity.Property(e => e.DblAveragePressure)
                    .HasColumnName("dblAveragePressure")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblAverageTemperature)
                    .HasColumnName("dblAverageTemperature")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblAvgCorrectedFlowRate)
                    .HasColumnName("dblAvgCorrectedFlowRate")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblBatteryVoltage)
                    .HasColumnName("dblBatteryVoltage")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblCorrectionFactor)
                    .HasColumnName("dblCorrectionFactor")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblEndingPressure)
                    .HasColumnName("dblEndingPressure")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblEndingTemperature)
                    .HasColumnName("dblEndingTemperature")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblMaxPressure)
                    .HasColumnName("dblMaxPressure")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblMaxTemperature)
                    .HasColumnName("dblMaxTemperature")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblMinTemperature)
                    .HasColumnName("dblMinTemperature")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblMinimumPressure)
                    .HasColumnName("dblMinimumPressure")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblPeakCorrectedFlowRate)
                    .HasColumnName("dblPeakCorrectedFlowRate")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblSupperCompressibility)
                    .HasColumnName("dblSupperCompressibility")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLog)
                    .HasColumnName("dtLog")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICorrectedVolume).HasColumnName("iCorrectedVolume");

                entity.Property(e => e.IUncorrectedVolUnderFault)
                    .HasColumnName("iUncorrectedVolUnderFault")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.IUncorrectedVolume).HasColumnName("iUncorrectedVolume");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMeterGuid).HasColumnName("sMeterGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TGasMeterReading>(entity =>
            {
                entity.HasKey(e => e.SRecGuid);

                entity.ToTable("tGasMeterReading");

                entity.Property(e => e.SRecGuid)
                    .HasColumnName("sRecGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblBatteryVoltage)
                    .HasColumnName("dblBatteryVoltage")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblCorrectedResidual)
                    .HasColumnName("dblCorrectedResidual")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblCorrectedVolume)
                    .HasColumnName("dblCorrectedVolume")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblCorrectionFactor)
                    .HasColumnName("dblCorrectionFactor")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblFlowRate)
                    .HasColumnName("dblFlowRate")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblOccurredAlarms)
                    .HasColumnName("dblOccurredAlarms")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblOccurredFaults)
                    .HasColumnName("dblOccurredFaults")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblPresentAlarms)
                    .HasColumnName("dblPresentAlarms")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblPresentFaults)
                    .HasColumnName("dblPresentFaults")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblPressure)
                    .HasColumnName("dblPressure")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblRawPressure)
                    .HasColumnName("dblRawPressure")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblRawTemperature)
                    .HasColumnName("dblRawTemperature")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblTemperature)
                    .HasColumnName("dblTemperature")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblUncorrectedResidual)
                    .HasColumnName("dblUncorrectedResidual")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblUncorrectedUnderFault)
                    .HasColumnName("dblUncorrectedUnderFault")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblUncorrectedVolume)
                    .HasColumnName("dblUncorrectedVolume")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblZfactor)
                    .HasColumnName("dblZFactor")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLog)
                    .HasColumnName("dtLog")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMeterGuid).HasColumnName("sMeterGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMeterGu)
                    .WithMany(p => p.TGasMeterReading)
                    .HasForeignKey(d => d.SMeterGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tGasMeterReading_tGasMeter");
            });

            modelBuilder.Entity<THelpDeskAsset>(entity =>
            {
                entity.HasKey(e => e.SAssetGuid);

                entity.ToTable("tHelpDeskAsset");

                entity.Property(e => e.SAssetGuid)
                    .HasColumnName("sAssetGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BAllocatedToStock).HasColumnName("bAllocatedToStock");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurCost)
                    .HasColumnName("curCost")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAcquisition)
                    .HasColumnName("dtAcquisition")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastBackup)
                    .HasColumnName("dtLastBackup")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRemovedFromService)
                    .HasColumnName("dtRemovedFromService")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtWarrantyExpiration)
                    .HasColumnName("dtWarrantyExpiration")
                    .HasColumnType("datetime");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAssetType)
                    .HasColumnName("sAssetType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SCompanyGuid).HasColumnName("sCompanyGUID");

                entity.Property(e => e.SDeptGuid).HasColumnName("sDeptGUID");

                entity.Property(e => e.SDisposition)
                    .HasColumnName("sDisposition")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SIdtag)
                    .HasColumnName("sIDTag")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SParentAssetGuid).HasColumnName("sParentAssetGUID");

                entity.Property(e => e.SProductGuid).HasColumnName("sProductGUID");

                entity.Property(e => e.SSerialNum)
                    .HasColumnName("sSerialNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.Property(e => e.SVendorGuid).HasColumnName("sVendorGUID");
            });

            modelBuilder.Entity<THelpDeskAssetNote>(entity =>
            {
                entity.HasKey(e => e.SNoteGuid);

                entity.ToTable("tHelpDeskAssetNote");

                entity.Property(e => e.SNoteGuid)
                    .HasColumnName("sNoteGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtNote)
                    .HasColumnName("dtNote")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAssetGuid).HasColumnName("sAssetGUID");

                entity.Property(e => e.SNoteRtf)
                    .HasColumnName("sNoteRTF")
                    .HasColumnType("text");

                entity.Property(e => e.SNoteText)
                    .HasColumnName("sNoteText")
                    .HasColumnType("text");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SAssetGu)
                    .WithMany(p => p.THelpDeskAssetNote)
                    .HasForeignKey(d => d.SAssetGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHelpDeskAssetNote_tHelpDeskAsset");
            });

            modelBuilder.Entity<THelpDeskAssetToRequest>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tHelpDeskAssetToRequest");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAssetGuid).HasColumnName("sAssetGUID");

                entity.Property(e => e.SRequestGuid).HasColumnName("sRequestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SAssetGu)
                    .WithMany(p => p.THelpDeskAssetToRequest)
                    .HasForeignKey(d => d.SAssetGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHelpDeskAssetToRequest_tHelpDeskAsset");

                entity.HasOne(d => d.SRequestGu)
                    .WithMany(p => p.THelpDeskAssetToRequest)
                    .HasForeignKey(d => d.SRequestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHelpDeskAssetToRequest_tHelpDeskRequest");
            });

            modelBuilder.Entity<THelpDeskAssignedRep>(entity =>
            {
                entity.HasKey(e => e.SRecGuid);

                entity.ToTable("tHelpDeskAssignedRep");

                entity.Property(e => e.SRecGuid)
                    .HasColumnName("sRecGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsSupportRep).HasColumnName("bIsSupportRep");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");
            });

            modelBuilder.Entity<THelpDeskCategory>(entity =>
            {
                entity.HasKey(e => e.SCategoryGuid);

                entity.ToTable("tHelpDeskCategory");

                entity.Property(e => e.SCategoryGuid)
                    .HasColumnName("sCategoryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .HasColumnName("sName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SParentGuid).HasColumnName("sParentGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<THelpDeskInvolvedUser>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tHelpDeskInvolvedUser");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BProjectComplete).HasColumnName("bProjectComplete");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRequestGuid).HasColumnName("sRequestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SUserGu)
                    .WithMany(p => p.THelpDeskInvolvedUser)
                    .HasForeignKey(d => d.SUserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHelpDeskInvolvedUser_tUser");
            });

            modelBuilder.Entity<THelpDeskProjectTemplateDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tHelpDeskProjectTemplateDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblHourEstimateHidden)
                    .HasColumnName("dblHourEstimateHidden")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IIndentLevelHidden).HasColumnName("iIndentLevelHidden");

                entity.Property(e => e.ISortOrderHidden)
                    .HasColumnName("iSortOrderHidden")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ITaskNumHidden).HasColumnName("iTaskNumHidden");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMasterGuid).HasColumnName("sMasterGUID");

                entity.Property(e => e.SParentDetailGuid).HasColumnName("sParentDetailGUID");

                entity.Property(e => e.SPredecessors)
                    .HasColumnName("sPredecessors")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.STaskName)
                    .HasColumnName("sTaskName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.STimeEstimate)
                    .HasColumnName("sTimeEstimate")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMasterGu)
                    .WithMany(p => p.THelpDeskProjectTemplateDetail)
                    .HasForeignKey(d => d.SMasterGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHelpDeskProjectTemplateDetail_tHelpDeskProjectTemplateMaster");
            });

            modelBuilder.Entity<THelpDeskProjectTemplateMaster>(entity =>
            {
                entity.HasKey(e => e.SMasterGuid);

                entity.ToTable("tHelpDeskProjectTemplateMaster");

                entity.Property(e => e.SMasterGuid)
                    .HasColumnName("sMasterGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STemplateName)
                    .IsRequired()
                    .HasColumnName("sTemplateName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<THelpDeskProjectTemplateResource>(entity =>
            {
                entity.HasKey(e => e.SResourceGuid);

                entity.ToTable("tHelpDeskProjectTemplateResource");

                entity.Property(e => e.SResourceGuid)
                    .HasColumnName("sResourceGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDetailGuid).HasColumnName("sDetailGUID");

                entity.Property(e => e.SResourceName)
                    .HasColumnName("sResourceName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SDetailGu)
                    .WithMany(p => p.THelpDeskProjectTemplateResource)
                    .HasForeignKey(d => d.SDetailGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHelpDeskProjectTemplateResource_tHelpDeskProjectTemplateDetail");
            });

            modelBuilder.Entity<THelpDeskRequest>(entity =>
            {
                entity.HasKey(e => e.SRequestGuid);

                entity.ToTable("tHelpDeskRequest");

                entity.HasIndex(e => new { e.BInactive, e.DtAdded, e.DtBeginWork, e.DtDueBy, e.DtLogged, e.DtUpdated, e.INumSecondsEstimate, e.IRefNo, e.SAddedByUserId, e.SCaseType, e.SCategoryGuid, e.SInternalPriority, e.SRequestGuid, e.SRequestingUserGuid, e.STitle, e.SUpdatedByUserId, e.SUserUrgency, e.SAssignedRepUserGuid, e.BClosed })
                    .HasName("IX_AssignedRepUserGUID_Closed");

                entity.Property(e => e.SRequestGuid)
                    .HasColumnName("sRequestGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BClosed).HasColumnName("bClosed");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBeginWork)
                    .HasColumnName("dtBeginWork")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtDueBy)
                    .HasColumnName("dtDueBy")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLogged)
                    .HasColumnName("dtLogged")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.INumSecondsEstimate).HasColumnName("iNumSecondsEstimate");

                entity.Property(e => e.IRefNo).HasColumnName("iRefNo");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAssignedRepUserGuid).HasColumnName("sAssignedRepUserGUID");

                entity.Property(e => e.SCaseType)
                    .HasColumnName("sCaseType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCategoryGuid).HasColumnName("sCategoryGUID");

                entity.Property(e => e.SInternalPriority)
                    .HasColumnName("sInternalPriority")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRequestingUserGuid).HasColumnName("sRequestingUserGUID");

                entity.Property(e => e.STitle)
                    .IsRequired()
                    .HasColumnName("sTitle")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserUrgency)
                    .HasColumnName("sUserUrgency")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<THelpDeskRequestAttachment>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tHelpDeskRequestAttachment");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SDetailGuid).HasColumnName("sDetailGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SDetailGu)
                    .WithMany(p => p.THelpDeskRequestAttachment)
                    .HasForeignKey(d => d.SDetailGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHelpDeskRequestAttachment_tHelpDeskRequestDetail");
            });

            modelBuilder.Entity<THelpDeskRequestDependency>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tHelpDeskRequestDependency");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SChildRequestGuid).HasColumnName("sChildRequestGUID");

                entity.Property(e => e.SParentRequestGuid).HasColumnName("sParentRequestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<THelpDeskRequestDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tHelpDeskRequestDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BPrivateMemo).HasColumnName("bPrivateMemo");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLogged)
                    .HasColumnName("dtLogged")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtWorked)
                    .HasColumnName("dtWorked")
                    .HasColumnType("datetime");

                entity.Property(e => e.INumSecondsWorked).HasColumnName("iNumSecondsWorked");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMemoRtf)
                    .HasColumnName("sMemoRTF")
                    .HasColumnType("text");

                entity.Property(e => e.SMemoText)
                    .HasColumnName("sMemoText")
                    .HasColumnType("text");

                entity.Property(e => e.SRequestGuid).HasColumnName("sRequestGUID");

                entity.Property(e => e.STraceInfo)
                    .HasColumnName("sTraceInfo")
                    .HasColumnType("text");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SWorkedByUserGuid).HasColumnName("sWorkedByUserGUID");

                entity.HasOne(d => d.SRequestGu)
                    .WithMany(p => p.THelpDeskRequestDetail)
                    .HasForeignKey(d => d.SRequestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHelpDeskRequestDetail_tHelpDeskRequest");
            });

            modelBuilder.Entity<THelpStarcount>(entity =>
            {
                entity.HasKey(e => e.SLogGuid);

                entity.ToTable("tHelpSTARCount");

                entity.Property(e => e.SLogGuid)
                    .HasColumnName("sLogGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCurrent)
                    .HasColumnName("dtCurrent")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAverageInHours).HasColumnName("iAverageInHours");

                entity.Property(e => e.IAverageInMinutes).HasColumnName("iAverageInMinutes");

                entity.Property(e => e.IAverageInSeconds).HasColumnName("iAverageInSeconds");

                entity.Property(e => e.ICountClosedInLast24Hours).HasColumnName("iCountClosedInLast24Hours");

                entity.Property(e => e.ICountClosedInLast7Days).HasColumnName("iCountClosedInLast7Days");

                entity.Property(e => e.IDispatchCount).HasColumnName("iDispatchCount");

                entity.Property(e => e.IGreaterThan30Count).HasColumnName("iGreaterThan30Count");

                entity.Property(e => e.IGreaterThan60Count).HasColumnName("iGreaterThan60Count");

                entity.Property(e => e.IInQueueCount).HasColumnName("iInQueueCount");

                entity.Property(e => e.IInServiceCount).HasColumnName("iInServiceCount");

                entity.Property(e => e.ITotalCaseCount).HasColumnName("iTotalCaseCount");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<THrabsenceLog>(entity =>
            {
                entity.HasKey(e => e.SAttendanceGuid);

                entity.ToTable("tHRAbsenceLog");

                entity.Property(e => e.SAttendanceGuid)
                    .HasColumnName("sAttendanceGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblHours)
                    .HasColumnName("dblHours")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEntry)
                    .HasColumnName("dtEntry")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEmployeeGuid).HasColumnName("sEmployeeGUID");

                entity.Property(e => e.SNote)
                    .HasColumnName("sNote")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SReason)
                    .IsRequired()
                    .HasColumnName("sReason")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<THrapplicant>(entity =>
            {
                entity.HasKey(e => e.SApplicantGuid);

                entity.ToTable("tHRApplicant");

                entity.Property(e => e.SApplicantGuid)
                    .HasColumnName("sApplicantGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsDisabled).HasColumnName("bIsDisabled");

                entity.Property(e => e.BIsVeteran).HasColumnName("bIsVeteran");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IApplicantNumber).HasColumnName("iApplicantNumber");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEthnicity)
                    .HasColumnName("sEthnicity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFirstName)
                    .HasColumnName("sFirstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SGender)
                    .HasColumnName("sGender")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SJobCode)
                    .HasColumnName("sJobCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLastName)
                    .HasColumnName("sLastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRecruiterSupervisor)
                    .HasColumnName("sRecruiterSupervisor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SReferralSource)
                    .HasColumnName("sReferralSource")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SStatusCode)
                    .HasColumnName("sStatusCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<THrapplicantDate>(entity =>
            {
                entity.HasKey(e => e.SDateGuid);

                entity.ToTable("tHRApplicantDate");

                entity.Property(e => e.SDateGuid)
                    .HasColumnName("sDateGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtTransaction)
                    .HasColumnName("dtTransaction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SApplicantGuid).HasColumnName("sApplicantGUID");

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .IsRequired()
                    .HasColumnName("sKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SApplicantGu)
                    .WithMany(p => p.THrapplicantDate)
                    .HasForeignKey(d => d.SApplicantGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHRApplicantDate_tHRApplicant");
            });

            modelBuilder.Entity<THrdeptId>(entity =>
            {
                entity.HasKey(e => e.IId);

                entity.ToTable("tHRDeptID");

                entity.Property(e => e.IId).HasColumnName("iID");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IProxId).HasColumnName("iProxID");

                entity.Property(e => e.IRandNum).HasColumnName("iRandNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDeptId)
                    .HasColumnName("sDeptID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFirstName)
                    .IsRequired()
                    .HasColumnName("sFirstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SLastName)
                    .IsRequired()
                    .HasColumnName("sLastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<THtCycle>(entity =>
            {
                entity.HasKey(e => e.SHtcycleGuid);

                entity.ToTable("tHT_Cycle");

                entity.Property(e => e.SHtcycleGuid)
                    .HasColumnName("sHTCycleGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtRun)
                    .HasColumnName("dtRun")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoadMapImagePath)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHearthGuid).HasColumnName("sHearthGUID");

                entity.Property(e => e.SHeatTreatGuid).HasColumnName("sHeatTreatGUID");

                entity.Property(e => e.SLotNo)
                    .HasColumnName("sLotNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SMrcycleGuid).HasColumnName("sMRCycleGUID");

                entity.Property(e => e.SNotes)
                    .HasColumnName("sNotes")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.SRacking)
                    .HasColumnName("sRacking")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SHearthGu)
                    .WithMany(p => p.THtCycle)
                    .HasForeignKey(d => d.SHearthGuid)
                    .HasConstraintName("FK_tHT_Cycle_tMR_FurnaceHearth");

                entity.HasOne(d => d.SHeatTreatGu)
                    .WithMany(p => p.THtCycle)
                    .HasForeignKey(d => d.SHeatTreatGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHT_Cycle_tHT_HeatTreat");

                entity.HasOne(d => d.SMrcycleGu)
                    .WithMany(p => p.THtCycle)
                    .HasForeignKey(d => d.SMrcycleGuid)
                    .HasConstraintName("FK_tHT_Cycle_tMR_Cycle");
            });

            modelBuilder.Entity<THtHeatTreat>(entity =>
            {
                entity.HasKey(e => e.SHeatTreatGuid);

                entity.ToTable("tHT_HeatTreat");

                entity.Property(e => e.SHeatTreatGuid)
                    .HasColumnName("sHeatTreatGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BLocked).HasColumnName("bLocked");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCreation)
                    .HasColumnName("dtCreation")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IHeatTreatNo)
                    .HasColumnName("iHeatTreatNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IRevNo).HasColumnName("iRevNo");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SApprovedByHeatTreatUserGuid).HasColumnName("sApprovedByHeatTreatUserGUID");

                entity.Property(e => e.SComments)
                    .HasColumnName("sComments")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SCreatedByUserGuid).HasColumnName("sCreatedByUserGUID");

                entity.Property(e => e.SCreatedByUserName)
                    .HasColumnName("sCreatedByUserName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SHtmrguid).HasColumnName("sHTMRGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SHtmrgu)
                    .WithMany(p => p.THtHeatTreat)
                    .HasForeignKey(d => d.SHtmrguid)
                    .HasConstraintName("FK_tHT_HeatTreat_tMR_MasterRecipe");
            });

            modelBuilder.Entity<THtJob>(entity =>
            {
                entity.HasKey(e => e.SJobGuid);

                entity.ToTable("tHT_Job");

                entity.Property(e => e.SJobGuid)
                    .HasColumnName("sJobGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IHardnessRangeHi).HasColumnName("iHardnessRangeHi");

                entity.Property(e => e.IHardnessRangeLo).HasColumnName("iHardnessRangeLo");

                entity.Property(e => e.IHardnessTestSampleSize).HasColumnName("iHardnessTestSampleSize");

                entity.Property(e => e.IOperationNo).HasColumnName("iOperationNo");

                entity.Property(e => e.IStepNo).HasColumnName("iStepNo");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHardnessScale)
                    .HasColumnName("sHardnessScale")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHtcode)
                    .HasColumnName("sHTCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHtcycleGuid).HasColumnName("sHTCycleGUID");

                entity.Property(e => e.SHtno)
                    .HasColumnName("sHTNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobExt)
                    .HasColumnName("sJobExt")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNo)
                    .HasColumnName("sJobNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SHtcycleGu)
                    .WithMany(p => p.THtJob)
                    .HasForeignKey(d => d.SHtcycleGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHT_Job_tHT_Cycle");
            });

            modelBuilder.Entity<THtJobPiece>(entity =>
            {
                entity.HasKey(e => e.SHtpieceGuid);

                entity.ToTable("tHT_JobPiece");

                entity.Property(e => e.SHtpieceGuid)
                    .HasColumnName("sHTPieceGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BCertified).HasColumnName("bCertified");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblHardnessResult)
                    .HasColumnName("dblHardnessResult")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtTesting)
                    .HasColumnName("dtTesting")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCertifiedByUserGuid).HasColumnName("sCertifiedByUserGUID");

                entity.Property(e => e.SCertifiedByUserName)
                    .HasColumnName("sCertifiedByUserName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SJobGuid).HasColumnName("sJobGUID");

                entity.Property(e => e.SPieceGuid).HasColumnName("sPieceGUID");

                entity.Property(e => e.SSerialNo)
                    .HasColumnName("sSerialNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.STestedByUserGuid).HasColumnName("sTestedByUserGUID");

                entity.Property(e => e.STestedByUserName)
                    .HasColumnName("sTestedByUserName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SJobGu)
                    .WithMany(p => p.THtJobPiece)
                    .HasForeignKey(d => d.SJobGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHT_JobPiece_tHT_Job");

                entity.HasOne(d => d.SPieceGu)
                    .WithMany(p => p.THtJobPiece)
                    .HasForeignKey(d => d.SPieceGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHT_JobPiece_tMR_Piece");
            });

            modelBuilder.Entity<THtPidloop>(entity =>
            {
                entity.HasKey(e => e.SLoopGuid);

                entity.ToTable("tHT_PIDLoop");

                entity.Property(e => e.SLoopGuid)
                    .HasColumnName("sLoopGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblGain)
                    .HasColumnName("dblGain")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDate)
                    .HasColumnName("dtDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ILoopUpdate).HasColumnName("iLoopUpdate");

                entity.Property(e => e.IMaxOutput).HasColumnName("iMaxOutput");

                entity.Property(e => e.IOutput).HasColumnName("iOutput");

                entity.Property(e => e.IRate).HasColumnName("iRate");

                entity.Property(e => e.IReset).HasColumnName("iReset");

                entity.Property(e => e.IRevision).HasColumnName("iRevision");

                entity.Property(e => e.ISetpoint).HasColumnName("iSetpoint");

                entity.Property(e => e.ITemp).HasColumnName("iTemp");

                entity.Property(e => e.IZone).HasColumnName("iZone");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFurnace)
                    .HasColumnName("sFurnace")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STempDiff)
                    .HasColumnName("sTempDiff")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserName)
                    .HasColumnName("sUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<THtQuenchData>(entity =>
            {
                entity.HasKey(e => e.SHtquenchDataGuid);

                entity.ToTable("tHT_QuenchData");

                entity.Property(e => e.SHtquenchDataGuid)
                    .HasColumnName("sHTQuenchDataGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAmps1).HasColumnName("iAmps1");

                entity.Property(e => e.IAmps2).HasColumnName("iAmps2");

                entity.Property(e => e.IAmps3).HasColumnName("iAmps3");

                entity.Property(e => e.IAmps4).HasColumnName("iAmps4");

                entity.Property(e => e.IDelayMins).HasColumnName("iDelayMins");

                entity.Property(e => e.IWaterTempAfter).HasColumnName("iWaterTempAfter");

                entity.Property(e => e.IWaterTempBefore).HasColumnName("iWaterTempBefore");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHtcycleGuid).HasColumnName("sHTCycleGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SHtcycleGu)
                    .WithMany(p => p.THtQuenchData)
                    .HasForeignKey(d => d.SHtcycleGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHT_QuenchData_tHT_Cycle");
            });

            modelBuilder.Entity<THtRegion>(entity =>
            {
                entity.HasKey(e => e.SHtregionGuid);

                entity.ToTable("tHT_Region");

                entity.Property(e => e.SHtregionGuid)
                    .HasColumnName("sHTRegionGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BCertified).HasColumnName("bCertified");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsActual).HasColumnName("bIsActual");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtBenchJobFinish)
                    .HasColumnName("dtBenchJobFinish")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRampStart)
                    .HasColumnName("dtRampStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRampStop)
                    .HasColumnName("dtRampStop")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtSoakStart)
                    .HasColumnName("dtSoakStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtSoakStop)
                    .HasColumnName("dtSoakStop")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IHiLimit)
                    .HasColumnName("iHiLimit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ILoLimit)
                    .HasColumnName("iLoLimit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IOtoffset)
                    .HasColumnName("iOTOffset")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IOvertemp)
                    .HasColumnName("iOvertemp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IRampHh)
                    .HasColumnName("iRampHH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IRampMm)
                    .HasColumnName("iRampMM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IRegionNo)
                    .HasColumnName("iRegionNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IRevNo).HasColumnName("iRevNo");

                entity.Property(e => e.ISetpointOffset).HasColumnName("iSetpointOffset");

                entity.Property(e => e.ISoakHh)
                    .HasColumnName("iSoakHH")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ISoakMm)
                    .HasColumnName("iSoakMM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ISoakTrigger)
                    .HasColumnName("iSoakTrigger")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ITemperature)
                    .HasColumnName("iTemperature")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCertifiedByUserGuid).HasColumnName("sCertifiedByUserGUID");

                entity.Property(e => e.SCertifiedByUserName)
                    .HasColumnName("sCertifiedByUserName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SHtcycleGuid).HasColumnName("sHTCycleGUID");

                entity.Property(e => e.SOperatorUserGuid).HasColumnName("sOperatorUserGUID");

                entity.Property(e => e.SOperatorUserName)
                    .HasColumnName("sOperatorUserName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SHtcycleGu)
                    .WithMany(p => p.THtRegion)
                    .HasForeignKey(d => d.SHtcycleGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHT_Region_tHT_Cycle");
            });

            modelBuilder.Entity<THtschedule>(entity =>
            {
                entity.HasKey(e => e.SHtscheduleGuid);

                entity.ToTable("tHTSchedule");

                entity.Property(e => e.SHtscheduleGuid)
                    .HasColumnName("sHTScheduleGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtScheduled)
                    .HasColumnName("dtScheduled")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SScheduleNotes)
                    .IsRequired()
                    .HasColumnName("sScheduleNotes")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<THtscheduleDetail>(entity =>
            {
                entity.HasKey(e => e.SHtdetailGuid);

                entity.ToTable("tHTScheduleDetail");

                entity.Property(e => e.SHtdetailGuid)
                    .HasColumnName("sHTDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFurnaceKeyGuid).HasColumnName("sFurnaceKeyGUID");

                entity.Property(e => e.SHtscheduleGuid).HasColumnName("sHTScheduleGUID");

                entity.Property(e => e.SNotes)
                    .HasColumnName("sNotes")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SShiftOperators)
                    .HasColumnName("sShiftOperators")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SWorkShift)
                    .HasColumnName("sWorkShift")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.SHtscheduleGu)
                    .WithMany(p => p.THtscheduleDetail)
                    .HasForeignKey(d => d.SHtscheduleGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHTScheduleDetail_tHTSchedule");
            });

            modelBuilder.Entity<TInfoSysIpaddress>(entity =>
            {
                entity.HasKey(e => e.SIpaddressGuid)
                    .IsClustered(false);

                entity.ToTable("tInfoSysIPAddress");

                entity.HasIndex(e => e.SIpaddress)
                    .HasName("ix_IPAddress");

                entity.HasIndex(e => new { e.IOctet1, e.IOctet2, e.IOctet3, e.IOctet4 })
                    .HasName("ix_Octets");

                entity.Property(e => e.SIpaddressGuid)
                    .HasColumnName("sIPAddressGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IOctet1).HasColumnName("iOctet1");

                entity.Property(e => e.IOctet2).HasColumnName("iOctet2");

                entity.Property(e => e.IOctet3).HasColumnName("iOctet3");

                entity.Property(e => e.IOctet4).HasColumnName("iOctet4");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SIpaddress)
                    .HasColumnName("sIPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[fnInfoSys_IPAddress]([iOctet1],[iOctet2],[iOctet3],[iOctet4]))");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TInfoSysIpaddressCategory>(entity =>
            {
                entity.HasKey(e => e.SIpcategoryGuid);

                entity.ToTable("tInfoSysIPAddressCategory");

                entity.Property(e => e.SIpcategoryGuid)
                    .HasColumnName("sIPCategoryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCategory)
                    .IsRequired()
                    .HasColumnName("sCategory")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TInfoSysIpaddressCategoryToAddress>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tInfoSysIPAddressCategoryToAddress");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SIpaddressGuid).HasColumnName("sIPAddressGUID");

                entity.Property(e => e.SIpcategoryGuid).HasColumnName("sIPCategoryGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SIpaddressGu)
                    .WithMany(p => p.TInfoSysIpaddressCategoryToAddress)
                    .HasForeignKey(d => d.SIpaddressGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tInfoSysIPAddressCategoryToAddress_tInfoSysIPAddress");

                entity.HasOne(d => d.SIpcategoryGu)
                    .WithMany(p => p.TInfoSysIpaddressCategoryToAddress)
                    .HasForeignKey(d => d.SIpcategoryGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tInfoSysIPAddressCategoryToAddress_tInfoSysIPAddressCategory");
            });

            modelBuilder.Entity<TInfoSysIpaddressChange>(entity =>
            {
                entity.HasKey(e => e.SIplogGuid)
                    .IsClustered(false);

                entity.ToTable("tInfoSysIPAddressChange");

                entity.HasIndex(e => e.SIpaddressGuid)
                    .HasName("ix_IPAddressGUID");

                entity.Property(e => e.SIplogGuid)
                    .HasColumnName("sIPLogGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtTransaction)
                    .HasColumnName("dtTransaction")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBackupIp)
                    .HasColumnName("sBackupIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SExtDesc)
                    .HasColumnName("sExtDesc")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SIpaddressGuid).HasColumnName("sIPAddressGUID");

                entity.Property(e => e.SMachineName)
                    .HasColumnName("sMachineName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SReasonForChange)
                    .HasColumnName("sReasonForChange")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SIpaddressGu)
                    .WithMany(p => p.TInfoSysIpaddressChange)
                    .HasForeignKey(d => d.SIpaddressGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tInfoSysIPAddressChange_tInfoSysIPAddress");
            });

            modelBuilder.Entity<TInfoSysNewEmployeeDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tInfoSysNewEmployeeDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRequired).HasColumnName("bRequired");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SInfoNeeded)
                    .HasColumnName("sInfoNeeded")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SIsdeptUse)
                    .HasColumnName("sISDeptUse")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SNewEmpGuid).HasColumnName("sNewEmpGUID");

                entity.Property(e => e.SNotesInstructions)
                    .HasColumnName("sNotesInstructions")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SNewEmpGu)
                    .WithMany(p => p.TInfoSysNewEmployeeDetail)
                    .HasForeignKey(d => d.SNewEmpGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tInfoSysNewEmployeeDetail_tInfoSysNewEmployeeMaster");
            });

            modelBuilder.Entity<TInfoSysNewEmployeeMaster>(entity =>
            {
                entity.HasKey(e => e.SNewEmpGuid);

                entity.ToTable("tInfoSysNewEmployeeMaster");

                entity.Property(e => e.SNewEmpGuid)
                    .HasColumnName("sNewEmpGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BComputer).HasColumnName("bComputer");

                entity.Property(e => e.BCopier).HasColumnName("bCopier");

                entity.Property(e => e.BNetwork).HasColumnName("bNetwork");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BTelco).HasColumnName("bTelco");

                entity.Property(e => e.BVideo).HasColumnName("bVideo");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEmpStarts)
                    .HasColumnName("dtEmpStarts")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtOrientation)
                    .HasColumnName("dtOrientation")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRequest)
                    .HasColumnName("dtRequest")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBuilding)
                    .HasColumnName("sBuilding")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SComputerCode)
                    .HasColumnName("sComputerCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDeptAssignedTo)
                    .HasColumnName("sDeptAssignedTo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SDeskLocation)
                    .HasColumnName("sDeskLocation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SFirstName)
                    .IsRequired()
                    .HasColumnName("sFirstName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SInternalNotes)
                    .HasColumnName("sInternalNotes")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.SIsmanager)
                    .HasColumnName("sISManager")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLastName)
                    .IsRequired()
                    .HasColumnName("sLastName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRequestor)
                    .HasColumnName("sRequestor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SShift)
                    .HasColumnName("sShift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSupervisor)
                    .HasColumnName("sSupervisor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TInventoryCount>(entity =>
            {
                entity.HasKey(e => e.SInventoryGuid);

                entity.ToTable("tInventoryCount");

                entity.Property(e => e.SInventoryGuid)
                    .HasColumnName("sInventoryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblLength)
                    .HasColumnName("dblLength")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblWeight)
                    .HasColumnName("dblWeight")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IQty).HasColumnName("iQty");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAlloy)
                    .HasColumnName("sAlloy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBilletNum)
                    .HasColumnName("sBilletNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCountedBy)
                    .HasColumnName("sCountedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHeatNum)
                    .HasColumnName("sHeatNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SLocation)
                    .HasColumnName("sLocation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSize)
                    .HasColumnName("sSize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STagNum)
                    .HasColumnName("sTagNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SType)
                    .HasColumnName("sType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TIpaddress>(entity =>
            {
                entity.HasKey(e => e.SIpguid)
                    .IsClustered(false);

                entity.ToTable("tIPAddress");

                entity.HasIndex(e => new { e.SBuilding, e.SMachineType, e.SIpaddress })
                    .HasName("ix_Primary")
                    .IsClustered();

                entity.Property(e => e.SIpguid)
                    .HasColumnName("sIPGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IOctetPosition1)
                    .HasColumnName("iOctetPosition1")
                    .HasComputedColumnSql("([dbo].[fnIPAddress_GetOctet]([sIPAddress],(0)))");

                entity.Property(e => e.IOctetPosition2)
                    .HasColumnName("iOctetPosition2")
                    .HasComputedColumnSql("([dbo].[fnIPAddress_GetOctet]([sIPAddress],(1)))");

                entity.Property(e => e.IOctetPosition3)
                    .HasColumnName("iOctetPosition3")
                    .HasComputedColumnSql("([dbo].[fnIPAddress_GetOctet]([sIPAddress],(2)))");

                entity.Property(e => e.IOctetPosition4)
                    .HasColumnName("iOctetPosition4")
                    .HasComputedColumnSql("([dbo].[fnIPAddress_GetOctet]([sIPAddress],(3)))");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBuilding)
                    .HasColumnName("sBuilding")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SIpaddress)
                    .HasColumnName("sIPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineType)
                    .HasColumnName("sMachineType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SWorkstationDesc)
                    .HasColumnName("sWorkstationDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SWorkstationName)
                    .HasColumnName("sWorkstationName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TJobDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tJobDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsCoatingUsed).HasColumnName("bIsCoatingUsed");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDieTemperature).HasColumnName("iDieTemperature");

                entity.Property(e => e.IMaxSoakTime).HasColumnName("iMaxSoakTime");

                entity.Property(e => e.IOperationIndex).HasColumnName("iOperationIndex");

                entity.Property(e => e.ISpeed).HasColumnName("iSpeed");

                entity.Property(e => e.ISquareInches).HasColumnName("iSquareInches");

                entity.Property(e => e.ITemperature).HasColumnName("iTemperature");

                entity.Property(e => e.ITonnage).HasColumnName("iTonnage");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCoatingNotes)
                    .HasColumnName("sCoatingNotes")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SCooling)
                    .HasColumnName("sCooling")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SDieTemperatureNotes)
                    .HasColumnName("sDieTemperatureNotes")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SIdentification)
                    .HasColumnName("sIdentification")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SInstructions)
                    .HasColumnName("sInstructions")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SKeyCharacteristics)
                    .HasColumnName("sKeyCharacteristics")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SMasterGuid).HasColumnName("sMasterGUID");

                entity.Property(e => e.SOperationDetail)
                    .HasColumnName("sOperationDetail")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SOperationSummary)
                    .HasColumnName("sOperationSummary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpeedNotes)
                    .HasColumnName("sSpeedNotes")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SSquareInchNotes)
                    .HasColumnName("sSquareInchNotes")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.STemperatureNotes)
                    .HasColumnName("sTemperatureNotes")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.STonnageNotes)
                    .HasColumnName("sTonnageNotes")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMasterGu)
                    .WithMany(p => p.TJobDetail)
                    .HasForeignKey(d => d.SMasterGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tJobDetail_tJobMaster");
            });

            modelBuilder.Entity<TJobMaster>(entity =>
            {
                entity.HasKey(e => e.SMasterGuid);

                entity.ToTable("tJobMaster");

                entity.Property(e => e.SMasterGuid)
                    .HasColumnName("sMasterGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFilePath)
                    .HasColumnName("sFilePath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SFooter)
                    .HasColumnName("sFooter")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SHeader)
                    .HasColumnName("sHeader")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SJob)
                    .IsRequired()
                    .HasColumnName("sJob")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVersion)
                    .HasColumnName("sVersion")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TLabImportBadJobs>(entity =>
            {
                entity.HasKey(e => e.SBadJobGuid);

                entity.ToTable("tLabImportBadJobs");

                entity.Property(e => e.SBadJobGuid)
                    .HasColumnName("sBadJobGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastEmailed)
                    .HasColumnName("dtLastEmailed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtProcessed)
                    .HasColumnName("dtProcessed")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCompany)
                    .HasColumnName("sCompany")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SImportFileNumber)
                    .IsRequired()
                    .HasColumnName("sImportFileNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMessage)
                    .HasColumnName("sMessage")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STimestampIdentifier)
                    .IsRequired()
                    .HasColumnName("sTimestampIdentifier")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TLabImportBend>(entity =>
            {
                entity.HasKey(e => e.SBendGuid);

                entity.ToTable("tLabImportBend");

                entity.Property(e => e.SBendGuid)
                    .HasColumnName("sBendGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BCracksObserved).HasColumnName("bCracksObserved");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblBendAngle)
                    .HasColumnName("dblBendAngle")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblBendDiameter)
                    .HasColumnName("dblBendDiameter")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblBendRadius)
                    .HasColumnName("dblBendRadius")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblSpecimenThickness)
                    .HasColumnName("dblSpecimenThickness")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBendFactor)
                    .HasColumnName("sBendFactor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenDirection)
                    .HasColumnName("sSpecimenDirection")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportBend)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tBend_tTest");
            });

            modelBuilder.Entity<TLabImportChem>(entity =>
            {
                entity.HasKey(e => e.SChemGuid);

                entity.ToTable("tLabImportChem");

                entity.Property(e => e.SChemGuid)
                    .HasColumnName("sChemGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportChem)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tChem_tTest");
            });

            modelBuilder.Entity<TLabImportCompany>(entity =>
            {
                entity.HasKey(e => e.SCompanyGuid);

                entity.ToTable("tLabImportCompany");

                entity.Property(e => e.SCompanyGuid)
                    .HasColumnName("sCompanyGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress)
                    .HasColumnName("sAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SCity)
                    .HasColumnName("sCity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFax)
                    .HasColumnName("sFax")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .HasColumnName("sName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPhone)
                    .HasColumnName("sPhone")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SState)
                    .HasColumnName("sState")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SWebsite)
                    .HasColumnName("sWebsite")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SZip)
                    .HasColumnName("sZip")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TLabImportCompression>(entity =>
            {
                entity.HasKey(e => e.SCompressionGuid);

                entity.ToTable("tLabImportCompression");

                entity.Property(e => e.SCompressionGuid)
                    .HasColumnName("sCompressionGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblGageDiameter)
                    .HasColumnName("dblGageDiameter")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblGageThickness)
                    .HasColumnName("dblGageThickness")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblGageWidth)
                    .HasColumnName("dblGageWidth")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SReqUom)
                    .HasColumnName("sReqUOM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenDirection)
                    .HasColumnName("sSpecimenDirection")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportCompression)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCompression_tTest");
            });

            modelBuilder.Entity<TLabImportCompressionOffset>(entity =>
            {
                entity.HasKey(e => e.SOffsetGuid);

                entity.ToTable("tLabImportCompressionOffset");

                entity.Property(e => e.SOffsetGuid)
                    .HasColumnName("sOffsetGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMaxReqKsi)
                    .HasColumnName("dblMaxReqKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxReqMpa)
                    .HasColumnName("dblMaxReqMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqKsi)
                    .HasColumnName("dblMinReqKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqMpa)
                    .HasColumnName("dblMinReqMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPercent)
                    .HasColumnName("dblPercent")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblYieldLoad)
                    .HasColumnName("dblYieldLoad")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblYieldStrengthKsi)
                    .HasColumnName("dblYieldStrengthKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblYieldStrengthMpa)
                    .HasColumnName("dblYieldStrengthMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCompressionGuid).HasColumnName("sCompressionGUID");

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCompressionGu)
                    .WithMany(p => p.TLabImportCompressionOffset)
                    .HasForeignKey(d => d.SCompressionGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCompressionOffset_tCompression");
            });

            modelBuilder.Entity<TLabImportContact>(entity =>
            {
                entity.HasKey(e => e.SContactGuid);

                entity.ToTable("tLabImportContact");

                entity.Property(e => e.SContactGuid)
                    .HasColumnName("sContactGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCompanyGuid).HasColumnName("sCompanyGUID");

                entity.Property(e => e.SEmail)
                    .HasColumnName("sEmail")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCompanyGu)
                    .WithMany(p => p.TLabImportContact)
                    .HasForeignKey(d => d.SCompanyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabImportContact_tLabImportCompany");
            });

            modelBuilder.Entity<TLabImportCreep>(entity =>
            {
                entity.HasKey(e => e.SCreepGuid);

                entity.ToTable("tLabImportCreep");

                entity.Property(e => e.SCreepGuid)
                    .HasColumnName("sCreepGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblFinalGageDiameter)
                    .HasColumnName("dblFinalGageDiameter")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalGageLength4D)
                    .HasColumnName("dblFinalGageLength4D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalGageLength5D)
                    .HasColumnName("dblFinalGageLength5D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalGageThickness)
                    .HasColumnName("dblFinalGageThickness")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalGageWidth)
                    .HasColumnName("dblFinalGageWidth")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageDiameter)
                    .HasColumnName("dblInitialGageDiameter")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageLength4D)
                    .HasColumnName("dblInitialGageLength4D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageLength5D)
                    .HasColumnName("dblInitialGageLength5D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageThickness)
                    .HasColumnName("dblInitialGageThickness")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageWidth)
                    .HasColumnName("dblInitialGageWidth")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblRequiredStressKsi)
                    .HasColumnName("dblRequiredStressKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblRequiredStressMpa)
                    .HasColumnName("dblRequiredStressMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTestTempC)
                    .HasColumnName("dblTestTempC")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTestTempF)
                    .HasColumnName("dblTestTempF")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SReqUom)
                    .HasColumnName("sReqUOM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenDirection)
                    .HasColumnName("sSpecimenDirection")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenLocation)
                    .HasColumnName("sSpecimenLocation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportCreep)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCreep_tTest");
            });

            modelBuilder.Entity<TLabImportCreepAreaReduction>(entity =>
            {
                entity.HasKey(e => e.SArguid);

                entity.ToTable("tLabImportCreepAreaReduction");

                entity.Property(e => e.SArguid)
                    .HasColumnName("sARGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMinReq)
                    .HasColumnName("dblMinReq")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblResult)
                    .HasColumnName("dblResult")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCreepGuid).HasColumnName("sCreepGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCreepGu)
                    .WithMany(p => p.TLabImportCreepAreaReduction)
                    .HasForeignKey(d => d.SCreepGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCreepAreaReduction_tCreep");
            });

            modelBuilder.Entity<TLabImportCreepElongationResult>(entity =>
            {
                entity.HasKey(e => e.SResultGuid);

                entity.ToTable("tLabImportCreepElongationResult");

                entity.Property(e => e.SResultGuid)
                    .HasColumnName("sResultGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BConforms4D).HasColumnName("bConforms4D");

                entity.Property(e => e.BConforms5D).HasColumnName("bConforms5D");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMinReq4D)
                    .HasColumnName("dblMinReq4D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReq5D)
                    .HasColumnName("dblMinReq5D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblResult4D)
                    .HasColumnName("dblResult4D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblResult5D)
                    .HasColumnName("dblResult5D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCreepGuid).HasColumnName("sCreepGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCreepGu)
                    .WithMany(p => p.TLabImportCreepElongationResult)
                    .HasForeignKey(d => d.SCreepGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCreepElongationResult_tCreep");
            });

            modelBuilder.Entity<TLabImportCreepSystemData>(entity =>
            {
                entity.HasKey(e => e.SDataGuid);

                entity.ToTable("tLabImportCreepSystemData");

                entity.Property(e => e.SDataGuid)
                    .HasColumnName("sDataGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCreepGuid).HasColumnName("sCreepGUID");

                entity.Property(e => e.SData)
                    .HasColumnName("sData")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCreepGu)
                    .WithMany(p => p.TLabImportCreepSystemData)
                    .HasForeignKey(d => d.SCreepGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCreepSystemData_tCreep");
            });

            modelBuilder.Entity<TLabImportCreepTime>(entity =>
            {
                entity.HasKey(e => e.SCreepTimeGuid);

                entity.ToTable("tLabImportCreepTime");

                entity.Property(e => e.SCreepTimeGuid)
                    .HasColumnName("sCreepTimeGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblActualCreep)
                    .HasColumnName("dblActualCreep")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblActualTime)
                    .HasColumnName("dblActualTime")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCreepMax)
                    .HasColumnName("dblCreepMax")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCreepMin)
                    .HasColumnName("dblCreepMin")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTimeMax)
                    .HasColumnName("dblTimeMax")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTimeMin)
                    .HasColumnName("dblTimeMin")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCreepGuid).HasColumnName("sCreepGUID");

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCreepGu)
                    .WithMany(p => p.TLabImportCreepTime)
                    .HasForeignKey(d => d.SCreepGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCreepTime_tCreep");
            });

            modelBuilder.Entity<TLabImportElectricalConductivity>(entity =>
            {
                entity.HasKey(e => e.SEcguid);

                entity.ToTable("tLabImportElectricalConductivity");

                entity.Property(e => e.SEcguid)
                    .HasColumnName("sECGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblElecConductivityIacs)
                    .HasColumnName("dblElecConductivityIACS")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblElecConductivityMsm)
                    .HasColumnName("dblElecConductivityMSm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxReqIacs)
                    .HasColumnName("dblMaxReqIACS")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxReqMsm)
                    .HasColumnName("dblMaxReqMSm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqIacs)
                    .HasColumnName("dblMinReqIACS")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqMsm)
                    .HasColumnName("dblMinReqMSm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportElectricalConductivity)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tElectricalConductivity_tTest");
            });

            modelBuilder.Entity<TLabImportElementResult>(entity =>
            {
                entity.HasKey(e => e.SResultGuid);

                entity.ToTable("tLabImportElementResult");

                entity.Property(e => e.SResultGuid)
                    .HasColumnName("sResultGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblElementAmt)
                    .HasColumnName("dblElementAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxReq)
                    .HasColumnName("dblMaxReq")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReq)
                    .HasColumnName("dblMinReq")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAnalysisMethod)
                    .HasColumnName("sAnalysisMethod")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SChemGuid).HasColumnName("sChemGUID");

                entity.Property(e => e.SElementAmtSymbol)
                    .HasColumnName("sElementAmtSymbol")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SMaxReqSymbol)
                    .HasColumnName("sMaxReqSymbol")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SMinReqSymbol)
                    .HasColumnName("sMinReqSymbol")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUom)
                    .HasColumnName("sUOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SChemGu)
                    .WithMany(p => p.TLabImportElementResult)
                    .HasForeignKey(d => d.SChemGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tElementResult_tChem");
            });

            modelBuilder.Entity<TLabImportEmbrittlement>(entity =>
            {
                entity.HasKey(e => e.SEmbrittlementGuid);

                entity.ToTable("tLabImportEmbrittlement");

                entity.Property(e => e.SEmbrittlementGuid)
                    .HasColumnName("sEmbrittlementGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportEmbrittlement)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tEmbrittlement_tTest");
            });

            modelBuilder.Entity<TLabImportEmbrittlementResult>(entity =>
            {
                entity.HasKey(e => e.SResultGuid);

                entity.ToTable("tLabImportEmbrittlementResult");

                entity.Property(e => e.SResultGuid)
                    .HasColumnName("sResultGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEmbrittlementGuid).HasColumnName("sEmbrittlementGUID");

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SResult)
                    .HasColumnName("sResult")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SEmbrittlementGu)
                    .WithMany(p => p.TLabImportEmbrittlementResult)
                    .HasForeignKey(d => d.SEmbrittlementGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tEmbrittlementResult_tEmbrittlement");
            });

            modelBuilder.Entity<TLabImportEnergyAbsorbed>(entity =>
            {
                entity.HasKey(e => e.SEaguid);

                entity.ToTable("tLabImportEnergyAbsorbed");

                entity.Property(e => e.SEaguid)
                    .HasColumnName("sEAGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblEnergyAbsorbedFtLbf)
                    .HasColumnName("dblEnergyAbsorbedFtLbf")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxReqFtLbf)
                    .HasColumnName("dblMaxReqFtLbf")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqDaJcm)
                    .HasColumnName("dblMinReqDaJCM")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqFtLbf)
                    .HasColumnName("dblMinReqFtLbf")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqJ)
                    .HasColumnName("dblMinReqJ")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqJcm)
                    .HasColumnName("dblMinReqJCm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SImpactGuid).HasColumnName("sImpactGUID");

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SImpactGu)
                    .WithMany(p => p.TLabImportEnergyAbsorbed)
                    .HasForeignKey(d => d.SImpactGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tEnergyAbsorbed_tImpact");
            });

            modelBuilder.Entity<TLabImportHardness>(entity =>
            {
                entity.HasKey(e => e.SHardnessGuid);

                entity.ToTable("tLabImportHardness");

                entity.Property(e => e.SHardnessGuid)
                    .HasColumnName("sHardnessGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportHardness)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHardness_tTest");
            });

            modelBuilder.Entity<TLabImportHardnessResultSet>(entity =>
            {
                entity.HasKey(e => e.SHrguid);

                entity.ToTable("tLabImportHardnessResultSet");

                entity.Property(e => e.SHrguid)
                    .HasColumnName("sHRGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblHardnessNumber)
                    .HasColumnName("dblHardnessNumber")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxReq)
                    .HasColumnName("dblMaxReq")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReq)
                    .HasColumnName("dblMinReq")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHardnessGuid).HasColumnName("sHardnessGUID");

                entity.Property(e => e.SHardnessType)
                    .HasColumnName("sHardnessType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SHardnessTypeReq)
                    .HasColumnName("sHardnessTypeReq")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLocation)
                    .HasColumnName("sLocation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SHardnessGu)
                    .WithMany(p => p.TLabImportHardnessResultSet)
                    .HasForeignKey(d => d.SHardnessGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHardnessResultSet_tHardness");
            });

            modelBuilder.Entity<TLabImportHeatTreatment>(entity =>
            {
                entity.HasKey(e => e.SHtguid);

                entity.ToTable("tLabImportHeatTreatment");

                entity.Property(e => e.SHtguid)
                    .HasColumnName("sHTGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportHeatTreatment)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHeatTreatment_tTest");
            });

            modelBuilder.Entity<TLabImportHeatTreatmentLine>(entity =>
            {
                entity.HasKey(e => e.SHtlineGuid);

                entity.ToTable("tLabImportHeatTreatmentLine");

                entity.Property(e => e.SHtlineGuid)
                    .HasColumnName("sHTLineGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHtguid).HasColumnName("sHTGUID");

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SValue)
                    .HasColumnName("sValue")
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.HasOne(d => d.SHtgu)
                    .WithMany(p => p.TLabImportHeatTreatmentLine)
                    .HasForeignKey(d => d.SHtguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHeatTreatmentLine_tHeatTreatment");
            });

            modelBuilder.Entity<TLabImportImpact>(entity =>
            {
                entity.HasKey(e => e.SImpactGuid);

                entity.ToTable("tLabImportImpact");

                entity.Property(e => e.SImpactGuid)
                    .HasColumnName("sImpactGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblTestTempC)
                    .HasColumnName("dblTestTempC")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTestTempF)
                    .HasColumnName("dblTestTempF")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNotchType)
                    .HasColumnName("sNotchType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.STestTemp)
                    .HasColumnName("sTestTemp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.STestType)
                    .HasColumnName("sTestType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportImpact)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tImpact_tTest");
            });

            modelBuilder.Entity<TLabImportImpactLateralExpansion>(entity =>
            {
                entity.HasKey(e => e.SLateralExpansionGuid);

                entity.ToTable("tLabImportImpactLateralExpansion");

                entity.Property(e => e.SLateralExpansionGuid)
                    .HasColumnName("sLateralExpansionGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblLateralExpansion)
                    .HasColumnName("dblLateralExpansion")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblLateralExpansionMillimeters)
                    .HasColumnName("dblLateralExpansionMillimeters")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxReq)
                    .HasColumnName("dblMaxReq")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReq)
                    .HasColumnName("dblMinReq")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SImpactGuid).HasColumnName("sImpactGUID");

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SImpactGu)
                    .WithMany(p => p.TLabImportImpactLateralExpansion)
                    .HasForeignKey(d => d.SImpactGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tImpactLateralExpansion_tImpact");
            });

            modelBuilder.Entity<TLabImportImpactShear>(entity =>
            {
                entity.HasKey(e => e.SShearGuid);

                entity.ToTable("tLabImportImpactShear");

                entity.Property(e => e.SShearGuid)
                    .HasColumnName("sShearGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMaxReq)
                    .HasColumnName("dblMaxReq")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReq)
                    .HasColumnName("dblMinReq")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblShear)
                    .HasColumnName("dblShear")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SImpactGuid).HasColumnName("sImpactGUID");

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SImpactGu)
                    .WithMany(p => p.TLabImportImpactShear)
                    .HasForeignKey(d => d.SImpactGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tImpactShear_tImpact");
            });

            modelBuilder.Entity<TLabImportMacroMetallurgy>(entity =>
            {
                entity.HasKey(e => e.SMacroMetallurgyGuid);

                entity.ToTable("tLabImportMacroMetallurgy");

                entity.Property(e => e.SMacroMetallurgyGuid)
                    .HasColumnName("sMacroMetallurgyGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportMacroMetallurgy)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMacroMetallurgy_tTest");
            });

            modelBuilder.Entity<TLabImportMacroMetallurgyResult>(entity =>
            {
                entity.HasKey(e => e.SResultGuid);

                entity.ToTable("tLabImportMacroMetallurgyResult");

                entity.Property(e => e.SResultGuid)
                    .HasColumnName("sResultGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMacroMetallurgyGuid).HasColumnName("sMacroMetallurgyGUID");

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SResult)
                    .HasColumnName("sResult")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMacroMetallurgyGu)
                    .WithMany(p => p.TLabImportMacroMetallurgyResult)
                    .HasForeignKey(d => d.SMacroMetallurgyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMacroMetallurgyResult_tMacroMetallurgy");
            });

            modelBuilder.Entity<TLabImportMagneticParticle>(entity =>
            {
                entity.HasKey(e => e.SParticleGuid);

                entity.ToTable("tLabImportMagneticParticle");

                entity.Property(e => e.SParticleGuid)
                    .HasColumnName("sParticleGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SInspectedAt)
                    .HasColumnName("sInspectedAt")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SObservation)
                    .HasColumnName("sObservation")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SReferenceSpec)
                    .HasColumnName("sReferenceSpec")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportMagneticParticle)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMagneticParticle_tTest");
            });

            modelBuilder.Entity<TLabImportMicroMetallurgy>(entity =>
            {
                entity.HasKey(e => e.SMicroMetallurgyGuid);

                entity.ToTable("tLabImportMicroMetallurgy");

                entity.Property(e => e.SMicroMetallurgyGuid)
                    .HasColumnName("sMicroMetallurgyGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportMicroMetallurgy)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMicroMetallurgy_tTest");
            });

            modelBuilder.Entity<TLabImportMicroMetallurgyResult>(entity =>
            {
                entity.HasKey(e => e.SResultGuid);

                entity.ToTable("tLabImportMicroMetallurgyResult");

                entity.Property(e => e.SResultGuid)
                    .HasColumnName("sResultGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMicroMetallurgyGuid).HasColumnName("sMicroMetallurgyGUID");

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SResult)
                    .HasColumnName("sResult")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMicroMetallurgyGu)
                    .WithMany(p => p.TLabImportMicroMetallurgyResult)
                    .HasForeignKey(d => d.SMicroMetallurgyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMicroMetallurgyResult_tMicroMetallurgy");
            });

            modelBuilder.Entity<TLabImportNote>(entity =>
            {
                entity.HasKey(e => e.SNoteGuid);

                entity.ToTable("tLabImportNote");

                entity.Property(e => e.SNoteGuid)
                    .HasColumnName("sNoteGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNote)
                    .IsRequired()
                    .HasColumnName("sNote")
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportNote)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tNote_tTest");
            });

            modelBuilder.Entity<TLabImportPlaneStrain>(entity =>
            {
                entity.HasKey(e => e.SPlaneStrainGuid);

                entity.ToTable("tLabImportPlaneStrain");

                entity.Property(e => e.SPlaneStrainGuid)
                    .HasColumnName("sPlaneStrainGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAmbientRelativeHumidity)
                    .HasColumnName("dblAmbientRelativeHumidity")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblAmbientRoomTemp)
                    .HasColumnName("dblAmbientRoomTemp")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCandidateLoad)
                    .HasColumnName("dblCandidateLoad")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalPrecracking)
                    .HasColumnName("dblFinalPrecracking")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialPrecracking)
                    .HasColumnName("dblInitialPrecracking")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblKrate)
                    .HasColumnName("dblKRate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxLoad)
                    .HasColumnName("dblMaxLoad")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxMpam)
                    .HasColumnName("dblMaxMPam")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxReqNmm)
                    .HasColumnName("dblMaxReqNmm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqKsi)
                    .HasColumnName("dblMinReqKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqMpam)
                    .HasColumnName("dblMinReqMPam")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqNmm)
                    .HasColumnName("dblMinReqNmm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblOffsetYield2TenthsKsi)
                    .HasColumnName("dblOffsetYield2TenthsKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblOffsetYield2TenthsMpa)
                    .HasColumnName("dblOffsetYield2TenthsMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblResultKsi)
                    .HasColumnName("dblResultKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblResultMpam)
                    .HasColumnName("dblResultMPam")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblResultNmm)
                    .HasColumnName("dblResultNmm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IInvaliditiesPresent).HasColumnName("iInvaliditiesPresent");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SObliqueFracture)
                    .HasColumnName("sObliqueFracture")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SReqUom)
                    .HasColumnName("sReqUOM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenDirection)
                    .HasColumnName("sSpecimenDirection")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenGeometry)
                    .HasColumnName("sSpecimenGeometry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SStrengthRatio)
                    .HasColumnName("sStrengthRatio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportPlaneStrain)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tPlaneStrain_tTest");
            });

            modelBuilder.Entity<TLabImportPlaneStrainCrackLength>(entity =>
            {
                entity.HasKey(e => e.SCrackLengthGuid);

                entity.ToTable("tLabImportPlaneStrainCrackLength");

                entity.Property(e => e.SCrackLengthGuid)
                    .HasColumnName("sCrackLengthGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAverageA)
                    .HasColumnName("dblAverageA")
                    .HasColumnType("numeric(18, 4)")
                    .HasComputedColumnSql("([dbo].[fnLabImport_CalcAverageA]([dblQuarterPoint1A2],[dblCenterA1],[dblQuarterPoint2A3]))");

                entity.Property(e => e.DblCenterA1)
                    .HasColumnName("dblCenterA1")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblQuarterPoint1A2)
                    .HasColumnName("dblQuarterPoint1A2")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblQuarterPoint2A3)
                    .HasColumnName("dblQuarterPoint2A3")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblSide1A4)
                    .HasColumnName("dblSide1A4")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblSide2A5)
                    .HasColumnName("dblSide2A5")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPlaneStrainGuid).HasColumnName("sPlaneStrainGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPlaneStrainGu)
                    .WithMany(p => p.TLabImportPlaneStrainCrackLength)
                    .HasForeignKey(d => d.SPlaneStrainGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tPlaneStrainCrackLength_tPlaneStrain");
            });

            modelBuilder.Entity<TLabImportPlaneStrainInvalidity>(entity =>
            {
                entity.HasKey(e => e.SInvalidityGuid);

                entity.ToTable("tLabImportPlaneStrainInvalidity");

                entity.Property(e => e.SInvalidityGuid)
                    .HasColumnName("sInvalidityGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SInvalidity)
                    .HasColumnName("sInvalidity")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SPlaneStrainGuid).HasColumnName("sPlaneStrainGUID");

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPlaneStrainGu)
                    .WithMany(p => p.TLabImportPlaneStrainInvalidity)
                    .HasForeignKey(d => d.SPlaneStrainGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tPlaneStrainInvalidity_tPlaneStrain");
            });

            modelBuilder.Entity<TLabImportPlaneStrainSpecimenDimension>(entity =>
            {
                entity.HasKey(e => e.SDimensionGuid);

                entity.ToTable("tLabImportPlaneStrainSpecimenDimension");

                entity.Property(e => e.SDimensionGuid)
                    .HasColumnName("sDimensionGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblInnerRadius)
                    .HasColumnName("dblInnerRadius")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblLoadingHoleOffset)
                    .HasColumnName("dblLoadingHoleOffset")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblOuterRadius)
                    .HasColumnName("dblOuterRadius")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblSpan)
                    .HasColumnName("dblSpan")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblThickness)
                    .HasColumnName("dblThickness")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblWidth)
                    .HasColumnName("dblWidth")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPlaneStrainGuid).HasColumnName("sPlaneStrainGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPlaneStrainGu)
                    .WithMany(p => p.TLabImportPlaneStrainSpecimenDimension)
                    .HasForeignKey(d => d.SPlaneStrainGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tPlaneStrainSpecimenDimension_tPlaneStrain");
            });

            modelBuilder.Entity<TLabImportPrecrack>(entity =>
            {
                entity.HasKey(e => e.SPrecrackGuid);

                entity.ToTable("tLabImportPrecrack");

                entity.Property(e => e.SPrecrackGuid)
                    .HasColumnName("sPrecrackGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMaxLoad)
                    .HasColumnName("dblMaxLoad")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblNumCycles)
                    .HasColumnName("dblNumCycles")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPlaneStrainGuid).HasColumnName("sPlaneStrainGUID");

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPlaneStrainGu)
                    .WithMany(p => p.TLabImportPrecrack)
                    .HasForeignKey(d => d.SPlaneStrainGuid)
                    .HasConstraintName("FK_tPrecrack_tPlaneStrain");
            });

            modelBuilder.Entity<TLabImportRevision>(entity =>
            {
                entity.HasKey(e => e.SRevisionGuid);

                entity.ToTable("tLabImportRevision");

                entity.Property(e => e.SRevisionGuid)
                    .HasColumnName("sRevisionGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtRevision)
                    .HasColumnName("dtRevision")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportRevision)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tRevision_tTest");
            });

            modelBuilder.Entity<TLabImportShear>(entity =>
            {
                entity.HasKey(e => e.SShearGuid);

                entity.ToTable("tLabImportShear");

                entity.Property(e => e.SShearGuid)
                    .HasColumnName("sShearGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblGageDiameter)
                    .HasColumnName("dblGageDiameter")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblGageThickness)
                    .HasColumnName("dblGageThickness")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblGageWidth)
                    .HasColumnName("dblGageWidth")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SReqUom)
                    .HasColumnName("sReqUOM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportShear)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tShear_tTest");
            });

            modelBuilder.Entity<TLabImportShearSystemData>(entity =>
            {
                entity.HasKey(e => e.SDataGuid);

                entity.ToTable("tLabImportShearSystemData");

                entity.Property(e => e.SDataGuid)
                    .HasColumnName("sDataGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SData)
                    .HasColumnName("sData")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SShearGuid).HasColumnName("sShearGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SShearGu)
                    .WithMany(p => p.TLabImportShearSystemData)
                    .HasForeignKey(d => d.SShearGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tShearSystemData_tShear");
            });

            modelBuilder.Entity<TLabImportShearUltimate>(entity =>
            {
                entity.HasKey(e => e.SUltimateGuid);

                entity.ToTable("tLabImportShearUltimate");

                entity.Property(e => e.SUltimateGuid)
                    .HasColumnName("sUltimateGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMaxReqKsi)
                    .HasColumnName("dblMaxReqKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxReqMpa)
                    .HasColumnName("dblMaxReqMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqKsi)
                    .HasColumnName("dblMinReqKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqMpa)
                    .HasColumnName("dblMinReqMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblUltimateLoad)
                    .HasColumnName("dblUltimateLoad")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblUltimateStrengthKsi)
                    .HasColumnName("dblUltimateStrengthKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblUltimateStrengthMpa)
                    .HasColumnName("dblUltimateStrengthMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SShearGuid).HasColumnName("sShearGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SShearGu)
                    .WithMany(p => p.TLabImportShearUltimate)
                    .HasForeignKey(d => d.SShearGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tShearUltimate_tShear");
            });

            modelBuilder.Entity<TLabImportSpecification>(entity =>
            {
                entity.HasKey(e => e.SSpecGuid);

                entity.ToTable("tLabImportSpecification");

                entity.Property(e => e.SSpecGuid)
                    .HasColumnName("sSpecGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecification)
                    .HasColumnName("sSpecification")
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportSpecification)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSpecification_tTest");
            });

            modelBuilder.Entity<TLabImportSpecimen>(entity =>
            {
                entity.HasKey(e => e.SSpecimenGuid);

                entity.ToTable("tLabImportSpecimen");

                entity.Property(e => e.SSpecimenGuid)
                    .HasColumnName("sSpecimenGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SClassGradeCode)
                    .HasColumnName("sClassGradeCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDrawingNumber)
                    .HasColumnName("sDrawingNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHeatNumber)
                    .HasColumnName("sHeatNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SLotNumber)
                    .HasColumnName("sLotNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMaterial)
                    .HasColumnName("sMaterial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMill)
                    .HasColumnName("sMill")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPartNumber)
                    .HasColumnName("sPartNumber")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SSampleNum)
                    .HasColumnName("sSampleNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSerialNum)
                    .HasColumnName("sSerialNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SStatus)
                    .HasColumnName("sStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportSpecimen)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabImportSpecimen_tLabImportTest");
            });

            modelBuilder.Entity<TLabImportStatus>(entity =>
            {
                entity.HasKey(e => e.SStatusGuid);

                entity.ToTable("tLabImportStatus");

                entity.Property(e => e.SStatusGuid)
                    .HasColumnName("sStatusGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtGenerated)
                    .HasColumnName("dtGenerated")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCompanyGuid).HasColumnName("sCompanyGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TLabImportStatusDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tLabImportStatusDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICut).HasColumnName("iCut");

                entity.Property(e => e.IIncomplete).HasColumnName("iIncomplete");

                entity.Property(e => e.ILoaded).HasColumnName("iLoaded");

                entity.Property(e => e.IMachined).HasColumnName("iMachined");

                entity.Property(e => e.ITotal).HasColumnName("iTotal");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SLabGuid).HasColumnName("sLabGUID");

                entity.Property(e => e.STestType)
                    .IsRequired()
                    .HasColumnName("sTestType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SLabGu)
                    .WithMany(p => p.TLabImportStatusDetail)
                    .HasForeignKey(d => d.SLabGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabImportStatusDetail_tLabImportStatusLab");
            });

            modelBuilder.Entity<TLabImportStatusFacility>(entity =>
            {
                entity.HasKey(e => e.SFacilityGuid);

                entity.ToTable("tLabImportStatusFacility");

                entity.Property(e => e.SFacilityGuid)
                    .HasColumnName("sFacilityGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNumber)
                    .HasColumnName("sNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SStatusGuid).HasColumnName("sStatusGUID");

                entity.Property(e => e.STitle)
                    .HasColumnName("sTitle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SStatusGu)
                    .WithMany(p => p.TLabImportStatusFacility)
                    .HasForeignKey(d => d.SStatusGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabImportStatusFacility_tLabImportStatus");
            });

            modelBuilder.Entity<TLabImportStatusLab>(entity =>
            {
                entity.HasKey(e => e.SLabGuid);

                entity.ToTable("tLabImportStatusLab");

                entity.Property(e => e.SLabGuid)
                    .HasColumnName("sLabGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDue)
                    .HasColumnName("dtDue")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtEntered)
                    .HasColumnName("dtEntered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCompany)
                    .HasColumnName("sCompany")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEnteredBy)
                    .HasColumnName("sEnteredBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFacilityGuid).HasColumnName("sFacilityGUID");

                entity.Property(e => e.SLabNumber)
                    .HasColumnName("sLabNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMaterial)
                    .HasColumnName("sMaterial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNotes)
                    .HasColumnName("sNotes")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SPonum)
                    .HasColumnName("sPONum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SFacilityGu)
                    .WithMany(p => p.TLabImportStatusLab)
                    .HasForeignKey(d => d.SFacilityGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabImportStatusLab_tLabImportStatusFacility");
            });

            modelBuilder.Entity<TLabImportStressCorrosion>(entity =>
            {
                entity.HasKey(e => e.SStressCorrosionGuid);

                entity.ToTable("tLabImportStressCorrosion");

                entity.Property(e => e.SStressCorrosionGuid)
                    .HasColumnName("sStressCorrosionGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblStressKsi)
                    .HasColumnName("dblStressKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblStressMpa)
                    .HasColumnName("dblStressMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SReqUom)
                    .HasColumnName("sReqUOM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenDirection)
                    .HasColumnName("sSpecimenDirection")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportStressCorrosion)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tStressCorrosion_tTest");
            });

            modelBuilder.Entity<TLabImportStressCorrosionResultSet>(entity =>
            {
                entity.HasKey(e => e.SScrguid);

                entity.ToTable("tLabImportStressCorrosionResultSet");

                entity.Property(e => e.SScrguid)
                    .HasColumnName("sSCRGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIntergranularAttack).HasColumnName("bIntergranularAttack");

                entity.Property(e => e.BPittingCorrosion).HasColumnName("bPittingCorrosion");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BTransgranularAttack).HasColumnName("bTransgranularAttack");

                entity.Property(e => e.DblActualDuration)
                    .HasColumnName("dblActualDuration")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqDuration)
                    .HasColumnName("dblMinReqDuration")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SStressCorrosionGuid).HasColumnName("sStressCorrosionGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SStressCorrosionGu)
                    .WithMany(p => p.TLabImportStressCorrosionResultSet)
                    .HasForeignKey(d => d.SStressCorrosionGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tStressCorrosionResultSet_tStressCorrosion");
            });

            modelBuilder.Entity<TLabImportStressRupture>(entity =>
            {
                entity.HasKey(e => e.SSrguid);

                entity.ToTable("tLabImportStressRupture");

                entity.Property(e => e.SSrguid)
                    .HasColumnName("sSRGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblFinalGageDiameter)
                    .HasColumnName("dblFinalGageDiameter")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalGageLength4D)
                    .HasColumnName("dblFinalGageLength4D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalGageLength5D)
                    .HasColumnName("dblFinalGageLength5D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalGageThickness)
                    .HasColumnName("dblFinalGageThickness")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalGageWidth)
                    .HasColumnName("dblFinalGageWidth")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageDiameter)
                    .HasColumnName("dblInitialGageDiameter")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageLength4D)
                    .HasColumnName("dblInitialGageLength4D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageLength5D)
                    .HasColumnName("dblInitialGageLength5D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageThickness)
                    .HasColumnName("dblInitialGageThickness")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageWidth)
                    .HasColumnName("dblInitialGageWidth")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblNotchDiameter)
                    .HasColumnName("dblNotchDiameter")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblNotchRootRadius)
                    .HasColumnName("dblNotchRootRadius")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblNotchWidth)
                    .HasColumnName("dblNotchWidth")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblShoulderDiameter)
                    .HasColumnName("dblShoulderDiameter")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblShoulderThickness)
                    .HasColumnName("dblShoulderThickness")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblShoulderWidth)
                    .HasColumnName("dblShoulderWidth")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTestTempC)
                    .HasColumnName("dblTestTempC")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTestTempF)
                    .HasColumnName("dblTestTempF")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SReqUom)
                    .HasColumnName("sReqUOM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenDirection)
                    .HasColumnName("sSpecimenDirection")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenLocation)
                    .HasColumnName("sSpecimenLocation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenType)
                    .HasColumnName("sSpecimenType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.STestTemp)
                    .HasColumnName("sTestTemp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportStressRupture)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tStressRupture_tTest");
            });

            modelBuilder.Entity<TLabImportStressRuptureAreaReduction>(entity =>
            {
                entity.HasKey(e => e.SArguid);

                entity.ToTable("tLabImportStressRuptureAreaReduction");

                entity.Property(e => e.SArguid)
                    .HasColumnName("sARGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMinReq)
                    .HasColumnName("dblMinReq")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblResult)
                    .HasColumnName("dblResult")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSrguid).HasColumnName("sSRGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SSrgu)
                    .WithMany(p => p.TLabImportStressRuptureAreaReduction)
                    .HasForeignKey(d => d.SSrguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tStressRuptureAreaReduction_tStressRupture");
            });

            modelBuilder.Entity<TLabImportStressRuptureDurationStress>(entity =>
            {
                entity.HasKey(e => e.SStressGuid);

                entity.ToTable("tLabImportStressRuptureDurationStress");

                entity.Property(e => e.SStressGuid)
                    .HasColumnName("sStressGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblDuration)
                    .HasColumnName("dblDuration")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqDuration)
                    .HasColumnName("dblMinReqDuration")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqStressKsi)
                    .HasColumnName("dblMinReqStressKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqStressMpa)
                    .HasColumnName("dblMinReqStressMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblStressKsi)
                    .HasColumnName("dblStressKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblStressMpa)
                    .HasColumnName("dblStressMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSrguid).HasColumnName("sSRGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SSrgu)
                    .WithMany(p => p.TLabImportStressRuptureDurationStress)
                    .HasForeignKey(d => d.SSrguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tStressRuptureDurationStress_tStressRupture");
            });

            modelBuilder.Entity<TLabImportStressRuptureDurationStressStep>(entity =>
            {
                entity.HasKey(e => e.SStepGuid);

                entity.ToTable("tLabImportStressRuptureDurationStressStep");

                entity.Property(e => e.SStepGuid)
                    .HasColumnName("sStepGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblDuration)
                    .HasColumnName("dblDuration")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblStressKsi)
                    .HasColumnName("dblStressKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblStressMpa)
                    .HasColumnName("dblStressMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSrguid).HasColumnName("sSRGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SSrgu)
                    .WithMany(p => p.TLabImportStressRuptureDurationStressStep)
                    .HasForeignKey(d => d.SSrguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tStressRuptureDurationStressStep_tStressRupture");
            });

            modelBuilder.Entity<TLabImportStressRuptureElongationResult>(entity =>
            {
                entity.HasKey(e => e.SResultGuid);

                entity.ToTable("tLabImportStressRuptureElongationResult");

                entity.Property(e => e.SResultGuid)
                    .HasColumnName("sResultGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BConforms4D).HasColumnName("bConforms4D");

                entity.Property(e => e.BConforms5D).HasColumnName("bConforms5D");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMinReq4D)
                    .HasColumnName("dblMinReq4D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReq5D)
                    .HasColumnName("dblMinReq5D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblResult4D)
                    .HasColumnName("dblResult4D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblResult5D)
                    .HasColumnName("dblResult5D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSrguid).HasColumnName("sSRGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SSrgu)
                    .WithMany(p => p.TLabImportStressRuptureElongationResult)
                    .HasForeignKey(d => d.SSrguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tStressRuptureElongationResult_tStressRupture");
            });

            modelBuilder.Entity<TLabImportTensile>(entity =>
            {
                entity.HasKey(e => e.STensileGuid);

                entity.ToTable("tLabImportTensile");

                entity.Property(e => e.STensileGuid)
                    .HasColumnName("sTensileGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblFinalGageDiameter)
                    .HasColumnName("dblFinalGageDiameter")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalGageLength4D)
                    .HasColumnName("dblFinalGageLength4D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalGageLength5D)
                    .HasColumnName("dblFinalGageLength5D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalGageThickness)
                    .HasColumnName("dblFinalGageThickness")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblFinalGageWidth)
                    .HasColumnName("dblFinalGageWidth")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageDiameter)
                    .HasColumnName("dblInitialGageDiameter")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageLength4D)
                    .HasColumnName("dblInitialGageLength4D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageLength5D)
                    .HasColumnName("dblInitialGageLength5D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageThickness)
                    .HasColumnName("dblInitialGageThickness")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInitialGageWidth)
                    .HasColumnName("dblInitialGageWidth")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTestTempC)
                    .HasColumnName("dblTestTempC")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTestTempF)
                    .HasColumnName("dblTestTempF")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SReqUom)
                    .HasColumnName("sReqUOM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenDirection)
                    .HasColumnName("sSpecimenDirection")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSpecimenNumber)
                    .HasColumnName("sSpecimenNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STestGuid).HasColumnName("sTestGUID");

                entity.Property(e => e.STestTemp)
                    .HasColumnName("sTestTemp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STestGu)
                    .WithMany(p => p.TLabImportTensile)
                    .HasForeignKey(d => d.STestGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTensile_tTest");
            });

            modelBuilder.Entity<TLabImportTensileAreaReduction>(entity =>
            {
                entity.HasKey(e => e.SArguid);

                entity.ToTable("tLabImportTensileAreaReduction");

                entity.Property(e => e.SArguid)
                    .HasColumnName("sARGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMinReq)
                    .HasColumnName("dblMinReq")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblResult)
                    .HasColumnName("dblResult")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STensileGuid).HasColumnName("sTensileGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STensileGu)
                    .WithMany(p => p.TLabImportTensileAreaReduction)
                    .HasForeignKey(d => d.STensileGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTensileAreaReduction_tTensile");
            });

            modelBuilder.Entity<TLabImportTensileElongationResult>(entity =>
            {
                entity.HasKey(e => e.SResultGuid);

                entity.ToTable("tLabImportTensileElongationResult");

                entity.Property(e => e.SResultGuid)
                    .HasColumnName("sResultGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BConforms4D).HasColumnName("bConforms4D");

                entity.Property(e => e.BConforms5D).HasColumnName("bConforms5D");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMinReq4D)
                    .HasColumnName("dblMinReq4D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReq5D)
                    .HasColumnName("dblMinReq5D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblResult4D)
                    .HasColumnName("dblResult4D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblResult5D)
                    .HasColumnName("dblResult5D")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STensileGuid).HasColumnName("sTensileGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STensileGu)
                    .WithMany(p => p.TLabImportTensileElongationResult)
                    .HasForeignKey(d => d.STensileGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTensileElongationResult_tTensile");
            });

            modelBuilder.Entity<TLabImportTensileOffset>(entity =>
            {
                entity.HasKey(e => e.SOffsetGuid);

                entity.ToTable("tLabImportTensileOffset");

                entity.Property(e => e.SOffsetGuid)
                    .HasColumnName("sOffsetGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMaxReqKsi)
                    .HasColumnName("dblMaxReqKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxReqMpa)
                    .HasColumnName("dblMaxReqMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqKsi)
                    .HasColumnName("dblMinReqKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqMpa)
                    .HasColumnName("dblMinReqMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPercent)
                    .HasColumnName("dblPercent")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblYieldLoad)
                    .HasColumnName("dblYieldLoad")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblYieldStrengthKsi)
                    .HasColumnName("dblYieldStrengthKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblYieldStrengthMpa)
                    .HasColumnName("dblYieldStrengthMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.STensileGuid).HasColumnName("sTensileGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STensileGu)
                    .WithMany(p => p.TLabImportTensileOffset)
                    .HasForeignKey(d => d.STensileGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTensileOffset_tTensile");
            });

            modelBuilder.Entity<TLabImportTensileSystemData>(entity =>
            {
                entity.HasKey(e => e.SDataGuid);

                entity.ToTable("tLabImportTensileSystemData");

                entity.Property(e => e.SDataGuid)
                    .HasColumnName("sDataGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SData)
                    .HasColumnName("sData")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SRecId)
                    .HasColumnName("sRecID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.STensileGuid).HasColumnName("sTensileGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STensileGu)
                    .WithMany(p => p.TLabImportTensileSystemData)
                    .HasForeignKey(d => d.STensileGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTensileSystemData_tTensile");
            });

            modelBuilder.Entity<TLabImportTensileUltimate>(entity =>
            {
                entity.HasKey(e => e.SUltimateGuid);

                entity.ToTable("tLabImportTensileUltimate");

                entity.Property(e => e.SUltimateGuid)
                    .HasColumnName("sUltimateGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BConforms).HasColumnName("bConforms");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMaxReqKsi)
                    .HasColumnName("dblMaxReqKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMaxReqMpa)
                    .HasColumnName("dblMaxReqMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqKsi)
                    .HasColumnName("dblMinReqKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinReqMpa)
                    .HasColumnName("dblMinReqMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblUltimateLoad)
                    .HasColumnName("dblUltimateLoad")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblUltimateStrengthKsi)
                    .HasColumnName("dblUltimateStrengthKSI")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblUltimateStrengthMpa)
                    .HasColumnName("dblUltimateStrengthMPa")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STensileGuid).HasColumnName("sTensileGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STensileGu)
                    .WithMany(p => p.TLabImportTensileUltimate)
                    .HasForeignKey(d => d.STensileGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTensileUltimate_tTensile");
            });

            modelBuilder.Entity<TLabImportTest>(entity =>
            {
                entity.HasKey(e => e.STestGuid);

                entity.ToTable("tLabImportTest");

                entity.Property(e => e.STestGuid)
                    .HasColumnName("sTestGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BJobHasFailures).HasColumnName("bJobHasFailures");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BShultzCreated).HasColumnName("bShultzCreated");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCertification)
                    .HasColumnName("dtCertification")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRun)
                    .HasColumnName("dtRun")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCertificationType)
                    .HasColumnName("sCertificationType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SCompanyGuid).HasColumnName("sCompanyGUID");

                entity.Property(e => e.SCustomerPonumber)
                    .HasColumnName("sCustomerPONumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SDeliveryNumber)
                    .HasColumnName("sDeliveryNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SFinalCustomer)
                    .HasColumnName("sFinalCustomer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SFinalCustomerPonumber)
                    .HasColumnName("sFinalCustomerPONumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLabNumber)
                    .HasColumnName("sLabNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SLabRevisionLetter)
                    .HasColumnName("sLabRevisionLetter")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSize)
                    .HasColumnName("sSize")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SSsjobNumber)
                    .HasColumnName("sSSJobNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.STestId)
                    .IsRequired()
                    .HasColumnName("sTestID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCompanyGu)
                    .WithMany(p => p.TLabImportTest)
                    .HasForeignKey(d => d.SCompanyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTest_tCompany");
            });

            modelBuilder.Entity<TLabPurchaseOrder>(entity =>
            {
                entity.HasKey(e => e.SPoguid);

                entity.ToTable("tLabPurchaseOrder");

                entity.HasIndex(e => e.DtUpdated)
                    .HasName("ix_dtUpdated");

                entity.Property(e => e.SPoguid)
                    .HasColumnName("sPOGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurPototalAmount)
                    .HasColumnName("curPOTotalAmount")
                    .HasColumnType("numeric(18, 4)")
                    .HasComputedColumnSql("([dbo].[fnLabPOTotal]([sPOGUID]))");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtApproved)
                    .HasColumnName("dtApproved")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtOrder)
                    .HasColumnName("dtOrder")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtRequired)
                    .HasColumnName("dtRequired")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAccountNum)
                    .HasColumnName("sAccountNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SApprovedByEmployeeGuid).HasColumnName("sApprovedByEmployeeGUID");

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SExportCompliance)
                    .HasColumnName("sExportCompliance")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SExtensionByEmployeeGuid).HasColumnName("sExtensionByEmployeeGUID");

                entity.Property(e => e.SFileId)
                    .HasColumnName("sFileID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFinalCustomer)
                    .HasColumnName("sFinalCustomer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SFinalCustomerPonum)
                    .HasColumnName("sFinalCustomerPONum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SFromCompanyGuid).HasColumnName("sFromCompanyGUID");

                entity.Property(e => e.SHeatTreatmentCondition)
                    .HasColumnName("sHeatTreatmentCondition")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SMetalGuid).HasColumnName("sMetalGUID");

                entity.Property(e => e.SModel)
                    .HasColumnName("sModel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPartNumber)
                    .HasColumnName("sPartNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPriceQuotedBy)
                    .HasColumnName("sPriceQuotedBy")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Per Price List')");

                entity.Property(e => e.SRevNum)
                    .HasColumnName("sRevNum")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SSite)
                    .HasColumnName("sSite")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSuffix)
                    .HasColumnName("sSuffix")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.STestNum)
                    .HasColumnName("sTestNum")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SToCompanyGuid).HasColumnName("sToCompanyGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SFromCompanyGu)
                    .WithMany(p => p.TLabPurchaseOrder)
                    .HasForeignKey(d => d.SFromCompanyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabPurchaseOrder_tCompany");

                entity.HasOne(d => d.SMetalGu)
                    .WithMany(p => p.TLabPurchaseOrder)
                    .HasForeignKey(d => d.SMetalGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabPurchaseOrder_tMetal");

                entity.HasOne(d => d.SToCompanyGu)
                    .WithMany(p => p.TLabPurchaseOrder)
                    .HasForeignKey(d => d.SToCompanyGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabPurchaseOrder_tLabImportCompany");
            });

            modelBuilder.Entity<TLabPurchaseOrderApproval>(entity =>
            {
                entity.HasKey(e => e.SApprovalLimitGuid);

                entity.ToTable("tLabPurchaseOrderApproval");

                entity.Property(e => e.SApprovalLimitGuid)
                    .HasColumnName("sApprovalLimitGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurLimit)
                    .IsRequired()
                    .HasColumnName("curLimit")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEmployeeGuid).HasColumnName("sEmployeeGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SEmployeeGu)
                    .WithMany(p => p.TLabPurchaseOrderApproval)
                    .HasForeignKey(d => d.SEmployeeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabPurchaseOrderApproval_tEmployee");
            });

            modelBuilder.Entity<TLabPurchaseOrderDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tLabPurchaseOrderDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BFooterLineItem).HasColumnName("bFooterLineItem");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurExtension)
                    .HasColumnName("curExtension")
                    .HasColumnType("numeric(29, 4)")
                    .HasComputedColumnSql("([curUnitPrice]*[iQty])");

                entity.Property(e => e.CurUnitPrice)
                    .HasColumnName("curUnitPrice")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IId).HasColumnName("iID");

                entity.Property(e => e.IQty).HasColumnName("iQty");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperation)
                    .HasColumnName("sOperation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SPoguid).HasColumnName("sPOGUID");

                entity.Property(e => e.SRequirement)
                    .HasColumnName("sRequirement")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.STestLocation)
                    .HasColumnName("sTestLocation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPogu)
                    .WithMany(p => p.TLabPurchaseOrderDetail)
                    .HasForeignKey(d => d.SPoguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabPurchaseOrderDetail_tLabPurchaseOrder");
            });

            modelBuilder.Entity<TLabPurchaseOrderError>(entity =>
            {
                entity.HasKey(e => e.SErrorGuid);

                entity.ToTable("tLabPurchaseOrderError");

                entity.Property(e => e.SErrorGuid)
                    .HasColumnName("sErrorGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SError)
                    .IsRequired()
                    .HasColumnName("sError")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SPoguid).HasColumnName("sPOGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPogu)
                    .WithMany(p => p.TLabPurchaseOrderError)
                    .HasForeignKey(d => d.SPoguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabPurchaseOrderError_tLabPurchaseOrder");
            });

            modelBuilder.Entity<TLabPurchaseOrderHeatTreatmentLotNumber>(entity =>
            {
                entity.HasKey(e => e.SHtguid);

                entity.ToTable("tLabPurchaseOrderHeatTreatmentLotNumber");

                entity.Property(e => e.SHtguid)
                    .HasColumnName("sHTGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHeatTreatLotNumber)
                    .IsRequired()
                    .HasColumnName("sHeatTreatLotNumber")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SPoguid).HasColumnName("sPOGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPogu)
                    .WithMany(p => p.TLabPurchaseOrderHeatTreatmentLotNumber)
                    .HasForeignKey(d => d.SPoguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabPurchaseOrderHeatTreatmentLotNumber_tLabPurchaseOrder");
            });

            modelBuilder.Entity<TLabPurchaseOrderHistory>(entity =>
            {
                entity.HasKey(e => e.SLabPurchaseOrderHistoryGuid);

                entity.ToTable("tLabPurchaseOrderHistory");

                entity.Property(e => e.SLabPurchaseOrderHistoryGuid)
                    .HasColumnName("sLabPurchaseOrderHistoryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAction)
                    .IsRequired()
                    .HasColumnName("sAction")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPoguid).HasColumnName("sPOGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SPogu)
                    .WithMany(p => p.TLabPurchaseOrderHistory)
                    .HasForeignKey(d => d.SPoguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabPurchaseOrderHistory_tLabPurchaseOrder");
            });

            modelBuilder.Entity<TLabPurchaseOrderNote>(entity =>
            {
                entity.HasKey(e => e.SNoteGuid);

                entity.ToTable("tLabPurchaseOrderNote");

                entity.Property(e => e.SNoteGuid)
                    .HasColumnName("sNoteGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNote)
                    .IsRequired()
                    .HasColumnName("sNote")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SPoguid).HasColumnName("sPOGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPogu)
                    .WithMany(p => p.TLabPurchaseOrderNote)
                    .HasForeignKey(d => d.SPoguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabPurchaseOrderNote_tLabPurchaseOrder");
            });

            modelBuilder.Entity<TLabPurchaseOrderOperation>(entity =>
            {
                entity.HasKey(e => e.SOperationGuid)
                    .IsClustered(false);

                entity.ToTable("tLabPurchaseOrderOperation");

                entity.Property(e => e.SOperationGuid)
                    .HasColumnName("sOperationGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperation)
                    .IsRequired()
                    .HasColumnName("sOperation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TLabPurchaseOrderQualityClause>(entity =>
            {
                entity.HasKey(e => e.SQcguid);

                entity.ToTable("tLabPurchaseOrderQualityClause");

                entity.Property(e => e.SQcguid)
                    .HasColumnName("sQCGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPoguid).HasColumnName("sPOGUID");

                entity.Property(e => e.SQualityClause)
                    .IsRequired()
                    .HasColumnName("sQualityClause")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPogu)
                    .WithMany(p => p.TLabPurchaseOrderQualityClause)
                    .HasForeignKey(d => d.SPoguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabPurchaseOrderQualityClause_tLabPurchaseOrder");
            });

            modelBuilder.Entity<TLabPurchaseOrderSpec>(entity =>
            {
                entity.HasKey(e => e.SSpecGuid);

                entity.ToTable("tLabPurchaseOrderSpec");

                entity.Property(e => e.SSpecGuid)
                    .HasColumnName("sSpecGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPoguid).HasColumnName("sPOGUID");

                entity.Property(e => e.SSpecification)
                    .IsRequired()
                    .HasColumnName("sSpecification")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPogu)
                    .WithMany(p => p.TLabPurchaseOrderSpec)
                    .HasForeignKey(d => d.SPoguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabPurchaseOrderSpec_tLabPurchaseOrder");
            });

            modelBuilder.Entity<TLabPurchaseOrderTestItem>(entity =>
            {
                entity.HasKey(e => e.STestItemGuid);

                entity.ToTable("tLabPurchaseOrderTestItem");

                entity.Property(e => e.STestItemGuid)
                    .HasColumnName("sTestItemGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IId).HasColumnName("iID");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHeatNum)
                    .HasColumnName("sHeatNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPoguid).HasColumnName("sPOGUID");

                entity.Property(e => e.SProducer)
                    .HasColumnName("sProducer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSerialNum)
                    .HasColumnName("sSerialNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPogu)
                    .WithMany(p => p.TLabPurchaseOrderTestItem)
                    .HasForeignKey(d => d.SPoguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tLabPurchaseOrderTestItem_tLabPurchaseOrder");
            });

            modelBuilder.Entity<TLogMachineStatus>(entity =>
            {
                entity.HasKey(e => e.SMachineStatusGuid)
                    .IsClustered(false);

                entity.ToTable("tLogMachineStatus");

                entity.Property(e => e.SMachineStatusGuid)
                    .HasColumnName("sMachineStatusGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DtLogged)
                    .HasColumnName("dtLogged")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IMachinePort).HasColumnName("iMachinePort");

                entity.Property(e => e.SAction)
                    .IsRequired()
                    .HasColumnName("sAction")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SActionType)
                    .IsRequired()
                    .HasColumnName("sActionType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAppVersion)
                    .HasColumnName("sAppVersion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineIp)
                    .HasColumnName("sMachineIP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineName)
                    .HasColumnName("sMachineName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SObjectGuid).HasColumnName("sObjectGUID");

                entity.Property(e => e.SObjectName)
                    .HasColumnName("sObjectName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SObjectXml)
                    .HasColumnName("sObjectXML")
                    .HasColumnType("text");

                entity.Property(e => e.SUserName)
                    .HasColumnName("sUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TLogTrans>(entity =>
            {
                entity.HasKey(e => e.SLogGuid)
                    .IsClustered(false);

                entity.ToTable("tLogTrans");

                entity.HasIndex(e => e.DtLogged)
                    .HasName("IX_dtLogged")
                    .IsClustered();

                entity.Property(e => e.SLogGuid)
                    .HasColumnName("sLogGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DtLogged)
                    .HasColumnName("dtLogged")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IMachinePort).HasColumnName("iMachinePort");

                entity.Property(e => e.SAction)
                    .IsRequired()
                    .HasColumnName("sAction")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SActionType)
                    .IsRequired()
                    .HasColumnName("sActionType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAppVersion)
                    .HasColumnName("sAppVersion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineIp)
                    .HasColumnName("sMachineIP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineName)
                    .HasColumnName("sMachineName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SObjectGuid).HasColumnName("sObjectGUID");

                entity.Property(e => e.SObjectName)
                    .HasColumnName("sObjectName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SObjectXml)
                    .HasColumnName("sObjectXML")
                    .HasColumnType("text");

                entity.Property(e => e.SUserName)
                    .HasColumnName("sUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMachine>(entity =>
            {
                entity.HasKey(e => e.SMachineGuid);

                entity.ToTable("tMachine");

                entity.Property(e => e.SMachineGuid)
                    .HasColumnName("sMachineGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BServiceRequested).HasColumnName("bServiceRequested");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCode)
                    .HasColumnName("sCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMailboxSizeReport>(entity =>
            {
                entity.HasKey(e => e.SRecGuid);

                entity.ToTable("tMailboxSizeReport");

                entity.HasIndex(e => e.DtRecord)
                    .HasName("IX_dtRecord");

                entity.Property(e => e.SRecGuid)
                    .HasColumnName("sRecGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BArchive).HasColumnName("bArchive");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtRecord)
                    .HasColumnName("dtRecord")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IItemCount).HasColumnName("iItemCount");

                entity.Property(e => e.ITotalItemSizeKb).HasColumnName("iTotalItemSizeKB");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDisplayName)
                    .IsRequired()
                    .HasColumnName("sDisplayName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SStorageGroup)
                    .HasColumnName("sStorageGroup")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMasterToolInventory>(entity =>
            {
                entity.HasKey(e => e.SPartGuid);

                entity.ToTable("tMasterToolInventory");

                entity.Property(e => e.SPartGuid)
                    .HasColumnName("sPartGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BCadmodel).HasColumnName("bCADModel");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BItar).HasColumnName("bITAR");

                entity.Property(e => e.BMiscellaneousRecord).HasColumnName("bMiscellaneousRecord");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtApprovedScrap)
                    .HasColumnName("dtApprovedScrap")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLastJob)
                    .HasColumnName("dtLastJob")
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("([dbo].[fnManEng_DateLastJob]([sPartGUID]))");

                entity.Property(e => e.DtScrapped)
                    .HasColumnName("dtScrapped")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStatus)
                    .HasColumnName("dtStatus")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ILastPieceCount)
                    .HasColumnName("iLastPieceCount")
                    .HasComputedColumnSql("([dbo].[fnManEng_LastPieceCount]([sPartGUID]))");

                entity.Property(e => e.ILastStrikeQty)
                    .HasColumnName("iLastStrikeQty")
                    .HasComputedColumnSql("([dbo].[fnManEng_LastStrikeQty]([sPartGUID]))");

                entity.Property(e => e.ISetNum).HasColumnName("iSetNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SApprovedScrap)
                    .HasColumnName("sApprovedScrap")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomer)
                    .HasColumnName("sCustomer")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SExcelSheetName)
                    .HasColumnName("sExcelSheetName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SLastJobNum)
                    .HasColumnName("sLastJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[fnManEng_LastJobNum]([sPartGUID]))");

                entity.Property(e => e.SMasterJobNum)
                    .HasColumnName("sMasterJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOnsiteLocation)
                    .HasColumnName("sOnsiteLocation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperation)
                    .HasColumnName("sOperation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPartName)
                    .HasColumnName("sPartName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SPartNum)
                    .HasColumnName("sPartNum")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SProgramName)
                    .HasColumnName("sProgramName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SScrapOrder)
                    .HasColumnName("sScrapOrder")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SStatusDesc)
                    .HasColumnName("sStatusDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SStorageSite)
                    .HasColumnName("sStorageSite")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMasterToolInventoryDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tMasterToolInventoryDetail");

                entity.HasIndex(e => new { e.DtRun, e.INumStrikes, e.SJobNum, e.SPartGuid })
                    .HasName("IX_PartGUID");

                entity.HasIndex(e => new { e.INumStrikes, e.IPcsToDate, e.SPartGuid, e.ISinkNumber })
                    .HasName("IX_PartGUID_SinkNumber");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtRun)
                    .HasColumnName("dtRun")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.INumStrikes).HasColumnName("iNumStrikes");

                entity.Property(e => e.IPcsToDate).HasColumnName("iPcsToDate");

                entity.Property(e => e.ISinkNumber).HasColumnName("iSinkNumber");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPartGuid).HasColumnName("sPartGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPartGu)
                    .WithMany(p => p.TMasterToolInventoryDetail)
                    .HasForeignKey(d => d.SPartGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMasterToolInventoryDetail_tMasterToolInventory");
            });

            modelBuilder.Entity<TMasterToolInventoryLink>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tMasterToolInventoryLink");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPart1Guid).HasColumnName("sPart1GUID");

                entity.Property(e => e.SPart2Guid).HasColumnName("sPart2GUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMasterToolInventorySink>(entity =>
            {
                entity.HasKey(e => e.SSinkGuid);

                entity.ToTable("tMasterToolInventorySink");

                entity.Property(e => e.SSinkGuid)
                    .HasColumnName("sSinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblSinkUtilizationPieces)
                    .HasColumnName("dblSinkUtilizationPieces")
                    .HasColumnType("numeric(18, 4)")
                    .HasComputedColumnSql("([dbo].[fnManEng_SinkUtilization]([dbo].[fnManEng_TotalPiecesPerSink]([sPartGUID],[iSinkNum]),[iInspectAtQty]))");

                entity.Property(e => e.DblSinkUtilizationStrikes)
                    .HasColumnName("dblSinkUtilizationStrikes")
                    .HasColumnType("numeric(18, 4)")
                    .HasComputedColumnSql("([dbo].[fnManEng_SinkUtilization]([dbo].[fnManEng_TotalStrikesPerSink]([sPartGUID],[iSinkNum]),[iInspectAtQty]))");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastInspection)
                    .HasColumnName("dtLastInspection")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtOrdered)
                    .HasColumnName("dtOrdered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtReceived)
                    .HasColumnName("dtReceived")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IInspectAtQty).HasColumnName("iInspectAtQty");

                entity.Property(e => e.ISinkNum).HasColumnName("iSinkNum");

                entity.Property(e => e.ITotalPcsPerSink)
                    .HasColumnName("iTotalPcsPerSink")
                    .HasComputedColumnSql("([dbo].[fnManEng_TotalPiecesPerSink]([sPartGUID],[iSinkNum]))");

                entity.Property(e => e.ITotalStrikesPerSink)
                    .HasColumnName("iTotalStrikesPerSink")
                    .HasComputedColumnSql("([dbo].[fnManEng_TotalStrikesPerSink]([sPartGUID],[iSinkNum]))");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SInspectionType)
                    .HasColumnName("sInspectionType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPartGuid).HasColumnName("sPartGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPartGu)
                    .WithMany(p => p.TMasterToolInventorySink)
                    .HasForeignKey(d => d.SPartGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMasterToolInventorySink_tMasterToolInventory");
            });

            modelBuilder.Entity<TMetal>(entity =>
            {
                entity.HasKey(e => e.SMetalGuid);

                entity.ToTable("tMetal");

                entity.HasIndex(e => e.SMetalName)
                    .HasName("IX_NAME")
                    .IsUnique();

                entity.Property(e => e.SMetalGuid)
                    .HasColumnName("sMetalGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMetalName)
                    .IsRequired()
                    .HasColumnName("sMetalName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMillImportBadJobs>(entity =>
            {
                entity.HasKey(e => e.SBadJobGuid);

                entity.ToTable("tMillImportBadJobs");

                entity.Property(e => e.SBadJobGuid)
                    .HasColumnName("sBadJobGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastEmailed)
                    .HasColumnName("dtLastEmailed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtProcessed)
                    .HasColumnName("dtProcessed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCompany)
                    .HasColumnName("sCompany")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SImportFileNumber)
                    .IsRequired()
                    .HasColumnName("sImportFileNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMessage)
                    .HasColumnName("sMessage")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STimestampIdentifier)
                    .IsRequired()
                    .HasColumnName("sTimestampIdentifier")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMillImportBillingAddress>(entity =>
            {
                entity.HasKey(e => e.SBillingAddressGuid);

                entity.ToTable("tMillImportBillingAddress");

                entity.Property(e => e.SBillingAddressGuid)
                    .HasColumnName("sBillingAddressGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress)
                    .HasColumnName("sAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SCertificationGuid).HasColumnName("sCertificationGUID");

                entity.Property(e => e.SCity)
                    .HasColumnName("sCity")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .HasColumnName("sName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SState)
                    .HasColumnName("sState")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SZip)
                    .HasColumnName("sZip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCertificationGu)
                    .WithMany(p => p.TMillImportBillingAddress)
                    .HasForeignKey(d => d.SCertificationGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tBillingAddress_tCertifications");
            });

            modelBuilder.Entity<TMillImportCertifications>(entity =>
            {
                entity.HasKey(e => e.SCertificationGuid);

                entity.ToTable("tMillImportCertifications");

                entity.Property(e => e.SCertificationGuid)
                    .HasColumnName("sCertificationGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCertification)
                    .HasColumnName("dtCertification")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCertificationId)
                    .IsRequired()
                    .HasColumnName("sCertificationID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomerPonum)
                    .HasColumnName("sCustomerPONum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SDeliveryCondition)
                    .HasColumnName("sDeliveryCondition")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SFinish)
                    .HasColumnName("sFinish")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SGrade)
                    .HasColumnName("sGrade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SMillGuid).HasColumnName("sMillGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMillGu)
                    .WithMany(p => p.TMillImportCertifications)
                    .HasForeignKey(d => d.SMillGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCertifications_tMills");
            });

            modelBuilder.Entity<TMillImportComplianceStatements>(entity =>
            {
                entity.HasKey(e => e.SComplianceStatementGuid);

                entity.ToTable("tMillImportComplianceStatements");

                entity.Property(e => e.SComplianceStatementGuid)
                    .HasColumnName("sComplianceStatementGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCertificationGuid).HasColumnName("sCertificationGUID");

                entity.Property(e => e.SStatementId)
                    .IsRequired()
                    .HasColumnName("sStatementID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SStatementName)
                    .HasColumnName("sStatementName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCertificationGu)
                    .WithMany(p => p.TMillImportComplianceStatements)
                    .HasForeignKey(d => d.SCertificationGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tComplianceStatements_tCertifications");
            });

            modelBuilder.Entity<TMillImportMills>(entity =>
            {
                entity.HasKey(e => e.SMillGuid);

                entity.ToTable("tMillImportMills");

                entity.Property(e => e.SMillGuid)
                    .HasColumnName("sMillGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFileId)
                    .IsRequired()
                    .HasColumnName("sFileID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMillName)
                    .IsRequired()
                    .HasColumnName("sMillName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMillImportProductChemistryTests>(entity =>
            {
                entity.HasKey(e => e.SProductChemTestGuid);

                entity.ToTable("tMillImportProductChemistryTests");

                entity.Property(e => e.SProductChemTestGuid)
                    .HasColumnName("sProductChemTestGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BPass).HasColumnName("bPass");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblBottom)
                    .HasColumnName("dblBottom")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMaxLimit)
                    .HasColumnName("dblMaxLimit")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMinLimit)
                    .HasColumnName("dblMinLimit")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblResult)
                    .HasColumnName("dblResult")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblTop)
                    .HasColumnName("dblTop")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBottomSymbol)
                    .HasColumnName("sBottomSymbol")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SChemTestId)
                    .IsRequired()
                    .HasColumnName("sChemTestID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SMaxLimitSymbol)
                    .HasColumnName("sMaxLimitSymbol")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SMinLimitSymbol)
                    .HasColumnName("sMinLimitSymbol")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SProductGuid).HasColumnName("sProductGUID");

                entity.Property(e => e.SResultSymbol)
                    .HasColumnName("sResultSymbol")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.STopSymbol)
                    .HasColumnName("sTopSymbol")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SProductGu)
                    .WithMany(p => p.TMillImportProductChemistryTests)
                    .HasForeignKey(d => d.SProductGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tProductChemistryTests_tProducts");
            });

            modelBuilder.Entity<TMillImportProducts>(entity =>
            {
                entity.HasKey(e => e.SProductGuid);

                entity.ToTable("tMillImportProducts");

                entity.Property(e => e.SProductGuid)
                    .HasColumnName("sProductGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblLengthInches)
                    .HasColumnName("dblLengthInches")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblWeightPounds)
                    .HasColumnName("dblWeightPounds")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtMeltDate)
                    .HasColumnName("dtMeltDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCertificationGuid).HasColumnName("sCertificationGUID");

                entity.Property(e => e.SLotId)
                    .HasColumnName("sLotID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMeltCountry)
                    .HasColumnName("sMeltCountry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMeltLocation)
                    .HasColumnName("sMeltLocation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMeltMethod)
                    .HasColumnName("sMeltMethod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMillHeatNumber)
                    .HasColumnName("sMillHeatNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SProductDescription)
                    .HasColumnName("sProductDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SProductId)
                    .IsRequired()
                    .HasColumnName("sProductID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SProductType)
                    .IsRequired()
                    .HasColumnName("sProductType")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SSalesOrderItem).HasColumnName("sSalesOrderItem");

                entity.Property(e => e.SSalesOrderNum)
                    .HasColumnName("sSalesOrderNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSize)
                    .HasColumnName("sSize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCertificationGu)
                    .WithMany(p => p.TMillImportProducts)
                    .HasForeignKey(d => d.SCertificationGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tProducts_tCertifications");
            });

            modelBuilder.Entity<TMillImportProductStatements>(entity =>
            {
                entity.HasKey(e => e.SProductStatementGuid);

                entity.ToTable("tMillImportProductStatements");

                entity.Property(e => e.SProductStatementGuid)
                    .HasColumnName("sProductStatementGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SProductGuid).HasColumnName("sProductGUID");

                entity.Property(e => e.SStatementId)
                    .IsRequired()
                    .HasColumnName("sStatementID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SStatementName)
                    .HasColumnName("sStatementName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SProductGu)
                    .WithMany(p => p.TMillImportProductStatements)
                    .HasForeignKey(d => d.SProductGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tProductStatements_tProducts");
            });

            modelBuilder.Entity<TMillImportShippingAddress>(entity =>
            {
                entity.HasKey(e => e.SShippingAddressGuid);

                entity.ToTable("tMillImportShippingAddress");

                entity.Property(e => e.SShippingAddressGuid)
                    .HasColumnName("sShippingAddressGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress)
                    .HasColumnName("sAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SCertificationGuid).HasColumnName("sCertificationGUID");

                entity.Property(e => e.SCity)
                    .HasColumnName("sCity")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .HasColumnName("sName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SState)
                    .HasColumnName("sState")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SZip)
                    .HasColumnName("sZip")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCertificationGu)
                    .WithMany(p => p.TMillImportShippingAddress)
                    .HasForeignKey(d => d.SCertificationGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tShippingAddress_tCertifications");
            });

            modelBuilder.Entity<TMillImportSpecifications>(entity =>
            {
                entity.HasKey(e => e.SSpecificationGuid);

                entity.ToTable("tMillImportSpecifications");

                entity.Property(e => e.SSpecificationGuid)
                    .HasColumnName("sSpecificationGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCertificationGuid).HasColumnName("sCertificationGUID");

                entity.Property(e => e.SSpecificationName)
                    .IsRequired()
                    .HasColumnName("sSpecificationName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCertificationGu)
                    .WithMany(p => p.TMillImportSpecifications)
                    .HasForeignKey(d => d.SCertificationGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSpecifications_tCertifications");
            });

            modelBuilder.Entity<TMobileEquipmentOperator>(entity =>
            {
                entity.HasKey(e => e.SOperatorGuid);

                entity.ToTable("tMobileEquipmentOperator");

                entity.Property(e => e.SOperatorGuid)
                    .HasColumnName("sOperatorGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEmployeeGuid).HasColumnName("sEmployeeGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMobileEquipmentOperatorDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tMobileEquipmentOperatorDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BApproved).HasColumnName("bApproved");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCert)
                    .HasColumnName("dtCert")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtExpires)
                    .HasColumnName("dtExpires")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCategory)
                    .HasColumnName("sCategory")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SOperatorGuid).HasColumnName("sOperatorGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMotionStudyDefinition>(entity =>
            {
                entity.HasKey(e => e.SDefinitionGuid);

                entity.ToTable("tMotionStudyDefinition");

                entity.Property(e => e.SDefinitionGuid)
                    .HasColumnName("sDefinitionGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .IsRequired()
                    .HasColumnName("sDescription")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SLetterCode)
                    .IsRequired()
                    .HasColumnName("sLetterCode")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SMachineName)
                    .IsRequired()
                    .HasColumnName("sMachineName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMotionStudyDefinitionToJob>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tMotionStudyDefinitionToJob");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDefinitionGuid).HasColumnName("sDefinitionGUID");

                entity.Property(e => e.SJobGuid).HasColumnName("sJobGUID");

                entity.Property(e => e.SNewText)
                    .HasColumnName("sNewText")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SDefinitionGu)
                    .WithMany(p => p.TMotionStudyDefinitionToJob)
                    .HasForeignKey(d => d.SDefinitionGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMotionStudyDefinitionToJob_tMotionStudyDefinition");

                entity.HasOne(d => d.SJobGu)
                    .WithMany(p => p.TMotionStudyDefinitionToJob)
                    .HasForeignKey(d => d.SJobGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMotionStudyDefinitionToJob_tMotionStudyJob");
            });

            modelBuilder.Entity<TMotionStudyJob>(entity =>
            {
                entity.HasKey(e => e.SJobGuid);

                entity.ToTable("tMotionStudyJob");

                entity.Property(e => e.SJobGuid)
                    .HasColumnName("sJobGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomer)
                    .HasColumnName("sCustomer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineCode)
                    .HasColumnName("sMachineCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperation)
                    .HasColumnName("sOperation")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMotionStudyLogDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tMotionStudyLogDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BUndone).HasColumnName("bUndone");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLogged)
                    .HasColumnName("dtLogged")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SComputerName)
                    .IsRequired()
                    .HasColumnName("sComputerName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomer)
                    .HasColumnName("sCustomer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SLetterCode)
                    .HasColumnName("sLetterCode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineName)
                    .IsRequired()
                    .HasColumnName("sMachineName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperation)
                    .HasColumnName("sOperation")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SSerialNum)
                    .HasColumnName("sSerialNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SStepNum).HasColumnName("sStepNum");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserName)
                    .IsRequired()
                    .HasColumnName("sUserName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMotionStudyLogDetailNote>(entity =>
            {
                entity.HasKey(e => e.SNoteGuid);

                entity.ToTable("tMotionStudyLogDetailNote");

                entity.Property(e => e.SNoteGuid)
                    .HasColumnName("sNoteGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDetailGuid).HasColumnName("sDetailGUID");

                entity.Property(e => e.SNote)
                    .IsRequired()
                    .HasColumnName("sNote")
                    .HasColumnType("text");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SDetailGu)
                    .WithMany(p => p.TMotionStudyLogDetailNote)
                    .HasForeignKey(d => d.SDetailGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMotionStudyLogDetailNote_tMotionStudyLogDetail");
            });

            modelBuilder.Entity<TMrCycle>(entity =>
            {
                entity.HasKey(e => e.SMrcycleGuid);

                entity.ToTable("tMR_Cycle");

                entity.Property(e => e.SMrcycleGuid)
                    .HasColumnName("sMRCycleGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BFurnaceControl).HasColumnName("bFurnaceControl");

                entity.Property(e => e.BHardnessRequired).HasColumnName("bHardnessRequired");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMaxSectionSize)
                    .HasColumnName("dblMaxSectionSize")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCreation)
                    .HasColumnName("dtCreation")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCycleNameGuid).HasColumnName("sCycleNameGUID");

                entity.Property(e => e.SHtmrguid).HasColumnName("sHTMRGUID");

                entity.Property(e => e.SMaterialGuid).HasColumnName("sMaterialGUID");

                entity.Property(e => e.SMaterialTypeGuid).HasColumnName("sMaterialTypeGUID");

                entity.Property(e => e.SNotes)
                    .HasColumnName("sNotes")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.SQuenchMediaTypeGuid).HasColumnName("sQuenchMediaTypeGUID");

                entity.Property(e => e.SRacking)
                    .IsRequired()
                    .HasColumnName("sRacking")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SRequiredTime)
                    .IsRequired()
                    .HasColumnName("sRequiredTime")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SSetTemprature)
                    .IsRequired()
                    .HasColumnName("sSetTemprature")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.STestMaterialTypeGuid).HasColumnName("sTestMaterialTypeGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SCycleNameGu)
                    .WithMany(p => p.TMrCycle)
                    .HasForeignKey(d => d.SCycleNameGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_Cycle_tMR_CycleName");

                entity.HasOne(d => d.SHtmrgu)
                    .WithMany(p => p.TMrCycle)
                    .HasForeignKey(d => d.SHtmrguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_Cycle_tMR_MasterRecipe");

                entity.HasOne(d => d.SMaterialTypeGu)
                    .WithMany(p => p.TMrCycle)
                    .HasForeignKey(d => d.SMaterialTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_Cycle_tMR_MaterialType");

                entity.HasOne(d => d.SQuenchMediaTypeGu)
                    .WithMany(p => p.TMrCycle)
                    .HasForeignKey(d => d.SQuenchMediaTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_Cycle_tMR_QuenchMediaType");

                entity.HasOne(d => d.STestMaterialTypeGu)
                    .WithMany(p => p.TMrCycle)
                    .HasForeignKey(d => d.STestMaterialTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_Cycle_tMR_TestMaterialType");
            });

            modelBuilder.Entity<TMrCycleName>(entity =>
            {
                entity.HasKey(e => e.SCycleNameGuid);

                entity.ToTable("tMR_CycleName");

                entity.Property(e => e.SCycleNameGuid)
                    .HasColumnName("sCycleNameGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMrCycleQuery>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tMR_CycleQuery");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMrcycleGuid).HasColumnName("sMRCycleGUID");

                entity.Property(e => e.SQueryGuid).HasColumnName("sQueryGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMrcycleGu)
                    .WithMany(p => p.TMrCycleQuery)
                    .HasForeignKey(d => d.SMrcycleGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_CycleQuery_tMR_Cycle");

                entity.HasOne(d => d.SQueryGu)
                    .WithMany(p => p.TMrCycleQuery)
                    .HasForeignKey(d => d.SQueryGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_CycleQuery_tMR_OperatorQuery");
            });

            modelBuilder.Entity<TMrFurnace>(entity =>
            {
                entity.HasKey(e => e.SFurnaceGuid);

                entity.ToTable("tMR_Furnace");

                entity.Property(e => e.SFurnaceGuid)
                    .HasColumnName("sFurnaceGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BManualWaterQuench).HasColumnName("bManualWaterQuench");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IRangeHi1).HasColumnName("iRangeHi1");

                entity.Property(e => e.IRangeHi2).HasColumnName("iRangeHi2");

                entity.Property(e => e.IRangeHi3).HasColumnName("iRangeHi3");

                entity.Property(e => e.IRangeHi4).HasColumnName("iRangeHi4");

                entity.Property(e => e.IRangeHi5).HasColumnName("iRangeHi5");

                entity.Property(e => e.IRangeLo1).HasColumnName("iRangeLo1");

                entity.Property(e => e.IRangeLo2).HasColumnName("iRangeLo2");

                entity.Property(e => e.IRangeLo3).HasColumnName("iRangeLo3");

                entity.Property(e => e.IRangeLo4).HasColumnName("iRangeLo4");

                entity.Property(e => e.IRangeLo5).HasColumnName("iRangeLo5");

                entity.Property(e => e.IToleranceRange1).HasColumnName("iToleranceRange1");

                entity.Property(e => e.IToleranceRange2).HasColumnName("iToleranceRange2");

                entity.Property(e => e.IToleranceRange3).HasColumnName("iToleranceRange3");

                entity.Property(e => e.IToleranceRange4).HasColumnName("iToleranceRange4");

                entity.Property(e => e.IToleranceRange5).HasColumnName("iToleranceRange5");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SLayoutImagePath)
                    .HasColumnName("sLayoutImagePath")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMrFurnaceHearth>(entity =>
            {
                entity.HasKey(e => e.SHearthGuid);

                entity.ToTable("tMR_FurnaceHearth");

                entity.Property(e => e.SHearthGuid)
                    .HasColumnName("sHearthGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .IsRequired()
                    .HasColumnName("sDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SFurnaceGuid).HasColumnName("sFurnaceGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SFurnaceGu)
                    .WithMany(p => p.TMrFurnaceHearth)
                    .HasForeignKey(d => d.SFurnaceGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_FurnaceHearth_tMR_Furnace");
            });

            modelBuilder.Entity<TMrFurnaceQuery>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tMR_FurnaceQuery");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFurnaceGuid).HasColumnName("sFurnaceGUID");

                entity.Property(e => e.SQueryGuid).HasColumnName("sQueryGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SFurnaceGu)
                    .WithMany(p => p.TMrFurnaceQuery)
                    .HasForeignKey(d => d.SFurnaceGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_FurnaceQuery_tMR_Furnace");

                entity.HasOne(d => d.SQueryGu)
                    .WithMany(p => p.TMrFurnaceQuery)
                    .HasForeignKey(d => d.SQueryGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_FurnaceQuery_tMR_OperatorQuery");
            });

            modelBuilder.Entity<TMrMasterRecipe>(entity =>
            {
                entity.HasKey(e => e.SHtmrguid);

                entity.ToTable("tMR_MasterRecipe");

                entity.Property(e => e.SHtmrguid)
                    .HasColumnName("sHTMRGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BQuenchRequired).HasColumnName("bQuenchRequired");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCreation)
                    .HasColumnName("dtCreation")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SApprovedByHeatTreatUserGuid).HasColumnName("sApprovedByHeatTreatUserGUID");

                entity.Property(e => e.SApprovedByMetallurgyUserGuid).HasColumnName("sApprovedByMetallurgyUserGUID");

                entity.Property(e => e.SCreatedByUserGuid).HasColumnName("sCreatedByUserGUID");

                entity.Property(e => e.SCreatedByUserName)
                    .HasColumnName("sCreatedByUserName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SMrno)
                    .HasColumnName("sMRNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRevision)
                    .HasColumnName("sRevision")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SStatus)
                    .HasColumnName("sStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMrMaterial>(entity =>
            {
                entity.HasKey(e => e.SMaterialGuid);

                entity.ToTable("tMR_Material");

                entity.Property(e => e.SMaterialGuid)
                    .HasColumnName("sMaterialGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMaterialTypeGuid).HasColumnName("sMaterialTypeGUID");

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMaterialTypeGu)
                    .WithMany(p => p.TMrMaterial)
                    .HasForeignKey(d => d.SMaterialTypeGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_Material_tMR_MaterialType");
            });

            modelBuilder.Entity<TMrMaterialType>(entity =>
            {
                entity.HasKey(e => e.SMaterialTypeGuid);

                entity.ToTable("tMR_MaterialType");

                entity.Property(e => e.SMaterialTypeGuid)
                    .HasColumnName("sMaterialTypeGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMrOperatorQuery>(entity =>
            {
                entity.HasKey(e => e.SQueryGuid);

                entity.ToTable("tMR_OperatorQuery");

                entity.Property(e => e.SQueryGuid)
                    .HasColumnName("sQueryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IQueryIndex).HasColumnName("iQueryIndex");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SQueryText)
                    .IsRequired()
                    .HasColumnName("sQueryText")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMrPiece>(entity =>
            {
                entity.HasKey(e => e.SPieceGuid);

                entity.ToTable("tMR_Piece");

                entity.Property(e => e.SPieceGuid)
                    .HasColumnName("sPieceGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BHardnessRequired).HasColumnName("bHardnessRequired");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblSectionSize)
                    .HasColumnName("dblSectionSize")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IPieceNo).HasColumnName("iPieceNo");

                entity.Property(e => e.IWeight).HasColumnName("iWeight");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SLayoutImagePath)
                    .HasColumnName("sLayoutImagePath")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SMaterialGuid).HasColumnName("sMaterialGUID");

                entity.Property(e => e.SPieceTypeGuid).HasColumnName("sPieceTypeGUID");

                entity.Property(e => e.SRackingImagePath)
                    .HasColumnName("sRackingImagePath")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMaterialGu)
                    .WithMany(p => p.TMrPiece)
                    .HasForeignKey(d => d.SMaterialGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_Piece_tMR_Material");

                entity.HasOne(d => d.SPieceTypeGu)
                    .WithMany(p => p.TMrPiece)
                    .HasForeignKey(d => d.SPieceTypeGuid)
                    .HasConstraintName("FK_tMR_Piece_tMR_PieceType");
            });

            modelBuilder.Entity<TMrPieceType>(entity =>
            {
                entity.HasKey(e => e.SPieceTypeGuid);

                entity.ToTable("tMR_PieceType");

                entity.Property(e => e.SPieceTypeGuid)
                    .HasColumnName("sPieceTypeGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMrQuenchMediaType>(entity =>
            {
                entity.HasKey(e => e.SQuenchMediaTypeGuid);

                entity.ToTable("tMR_QuenchMediaType");

                entity.Property(e => e.SQuenchMediaTypeGuid)
                    .HasColumnName("sQuenchMediaTypeGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BQuenchRequired).HasColumnName("bQuenchRequired");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TMrRegion>(entity =>
            {
                entity.HasKey(e => e.SMrregionGuid);

                entity.ToTable("tMR_Region");

                entity.Property(e => e.SMrregionGuid)
                    .HasColumnName("sMRRegionGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IHiLimit).HasColumnName("iHiLimit");

                entity.Property(e => e.ILoLimit).HasColumnName("iLoLimit");

                entity.Property(e => e.IOtoffset).HasColumnName("iOTOffset");

                entity.Property(e => e.IRampHh).HasColumnName("iRampHH");

                entity.Property(e => e.IRampMm).HasColumnName("iRampMM");

                entity.Property(e => e.IRegionNo).HasColumnName("iRegionNo");

                entity.Property(e => e.ISoakHh).HasColumnName("iSoakHH");

                entity.Property(e => e.ISoakMm).HasColumnName("iSoakMM");

                entity.Property(e => e.ISoakTrigger).HasColumnName("iSoakTrigger");

                entity.Property(e => e.ITemperature).HasColumnName("iTemperature");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMrcycleGuid).HasColumnName("sMRCycleGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMrcycleGu)
                    .WithMany(p => p.TMrRegion)
                    .HasForeignKey(d => d.SMrcycleGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tMR_Region_tMR_Cycle");
            });

            modelBuilder.Entity<TMrTestMaterialType>(entity =>
            {
                entity.HasKey(e => e.STestMaterialTypeGuid);

                entity.ToTable("tMR_TestMaterialType");

                entity.Property(e => e.STestMaterialTypeGuid)
                    .HasColumnName("sTestMaterialTypeGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TNonConformingMetal>(entity =>
            {
                entity.HasKey(e => e.SNonConformingMetalGuid);

                entity.ToTable("tNonConformingMetal");

                entity.HasIndex(e => e.SNonConformingName)
                    .HasName("IX_NONCONFORMINGNAME")
                    .IsUnique();

                entity.Property(e => e.SNonConformingMetalGuid)
                    .HasColumnName("sNonConformingMetalGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowVersion)
                    .HasColumnName("bRowVersion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SConformingName)
                    .IsRequired()
                    .HasColumnName("sConformingName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SNonConformingName)
                    .HasColumnName("sNonConformingName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TOpenDieNoteCallout>(entity =>
            {
                entity.HasKey(e => e.SCalloutGuid);

                entity.ToTable("tOpenDieNoteCallout");

                entity.Property(e => e.SCalloutGuid)
                    .HasColumnName("sCalloutGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblXpositionCallout)
                    .HasColumnName("dblXPositionCallout")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblXpositionPointOnDiagram)
                    .HasColumnName("dblXPositionPointOnDiagram")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblYpositionCallout)
                    .HasColumnName("dblYPositionCallout")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblYpositionPointOnDiagram)
                    .HasColumnName("dblYPositionPointOnDiagram")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCalloutText)
                    .IsRequired()
                    .HasColumnName("sCalloutText")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNoteGuid).HasColumnName("sNoteGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SNoteGu)
                    .WithMany(p => p.TOpenDieNoteCallout)
                    .HasForeignKey(d => d.SNoteGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tOpenDieNoteCallout_tOpenDieNoteMaster");
            });

            modelBuilder.Entity<TOpenDieNoteDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tOpenDieNoteDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SHeader)
                    .HasColumnName("sHeader")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SNoteGuid).HasColumnName("sNoteGUID");

                entity.Property(e => e.SNoteRtf)
                    .HasColumnName("sNoteRTF")
                    .HasColumnType("text");

                entity.Property(e => e.SNoteText)
                    .HasColumnName("sNoteText")
                    .HasColumnType("text");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SNoteGu)
                    .WithMany(p => p.TOpenDieNoteDetail)
                    .HasForeignKey(d => d.SNoteGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tOpenDieNoteDetail_tOpenDieNoteMaster");
            });

            modelBuilder.Entity<TOpenDieNoteMaster>(entity =>
            {
                entity.HasKey(e => e.SNoteGuid);

                entity.ToTable("tOpenDieNoteMaster");

                entity.Property(e => e.SNoteGuid)
                    .HasColumnName("sNoteGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BBoothLeft).HasColumnName("bBoothLeft");

                entity.Property(e => e.BGlass).HasColumnName("bGlass");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BKaowool).HasColumnName("bKaowool");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IFinishSticks).HasColumnName("iFinishSticks");

                entity.Property(e => e.IMarkingSticks).HasColumnName("iMarkingSticks");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SCaps)
                    .HasColumnName("sCaps")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SExtArms)
                    .HasColumnName("sExtArms")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SJaws)
                    .HasColumnName("sJaws")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumber)
                    .IsRequired()
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLoadingInstructionsBottom1)
                    .HasColumnName("sLoadingInstructionsBottom1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLoadingInstructionsBottom2)
                    .HasColumnName("sLoadingInstructionsBottom2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLoadingInstructionsBottom3)
                    .HasColumnName("sLoadingInstructionsBottom3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLoadingInstructionsBottom4)
                    .HasColumnName("sLoadingInstructionsBottom4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLoadingInstructionsTop1)
                    .HasColumnName("sLoadingInstructionsTop1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLoadingInstructionsTop2)
                    .HasColumnName("sLoadingInstructionsTop2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLoadingInstructionsTop3)
                    .HasColumnName("sLoadingInstructionsTop3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLoadingInstructionsTop4)
                    .HasColumnName("sLoadingInstructionsTop4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPress)
                    .IsRequired()
                    .HasColumnName("sPress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSize)
                    .HasColumnName("sSize")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SStampType)
                    .HasColumnName("sStampType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SToolingDies)
                    .HasColumnName("sToolingDies")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TOperationCategoryDetail>(entity =>
            {
                entity.HasKey(e => e.SOperationCategoryDetailGuid);

                entity.ToTable("tOperationCategoryDetail");

                entity.Property(e => e.SOperationCategoryDetailGuid)
                    .HasColumnName("sOperationCategoryDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive)
                    .HasColumnName("bInactive")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BRowVersion)
                    .HasColumnName("bRowVersion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobDetailGuid).HasColumnName("sJobDetailGUID");

                entity.Property(e => e.SOperationCategoryMasterGuid).HasColumnName("sOperationCategoryMasterGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SOperationCategoryMasterGu)
                    .WithMany(p => p.TOperationCategoryDetail)
                    .HasForeignKey(d => d.SOperationCategoryMasterGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tOperationCategoryDetail_tOperationCategoryMaster");
            });

            modelBuilder.Entity<TOperationCategoryMaster>(entity =>
            {
                entity.HasKey(e => e.SOperationCategoryMasterGuid);

                entity.ToTable("tOperationCategoryMaster");

                entity.Property(e => e.SOperationCategoryMasterGuid)
                    .HasColumnName("sOperationCategoryMasterGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive)
                    .HasColumnName("bInactive")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BRowVersion)
                    .IsRequired()
                    .HasColumnName("bRowVersion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .IsRequired()
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .IsRequired()
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPcc004>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tPCC004");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BTransmitVendorAddress).HasColumnName("bTransmitVendorAddress");

                entity.Property(e => e.DblInvoiceAmt)
                    .HasColumnName("dblInvoiceAmt")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtConnexionTransmit)
                    .HasColumnName("dtConnexionTransmit")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtDue)
                    .HasColumnName("dtDue")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPay)
                    .HasColumnName("dtPay")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPositivePayTransmit)
                    .HasColumnName("dtPositivePayTransmit")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .IsRequired()
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC_Extract')");

                entity.Property(e => e.SCheckNumber)
                    .HasColumnName("sCheckNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SFileGuid).HasColumnName("sFileGUID");

                entity.Property(e => e.SFileKey)
                    .IsRequired()
                    .HasColumnName("sFileKey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SGlCode)
                    .HasColumnName("sGlCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SHoldPayCode)
                    .HasColumnName("sHoldPayCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SInvoiceNumber)
                    .HasColumnName("sInvoiceNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVendorName)
                    .HasColumnName("sVendorName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SVendorNumber)
                    .HasColumnName("sVendorNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SVoidCode)
                    .HasColumnName("sVoidCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.SFileGu)
                    .WithMany(p => p.TPcc004)
                    .HasForeignKey(d => d.SFileGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tPCC004_tPCC004_FileList");
            });

            modelBuilder.Entity<TPcc004FileList>(entity =>
            {
                entity.HasKey(e => e.SFileGuid);

                entity.ToTable("tPCC004_FileList");

                entity.Property(e => e.SFileGuid)
                    .HasColumnName("sFileGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtRun)
                    .HasColumnName("dtRun")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .IsRequired()
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PCC_EXTRACT')");

                entity.Property(e => e.SFileName)
                    .IsRequired()
                    .HasColumnName("sFileName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccChartOfAccounts>(entity =>
            {
                entity.HasKey(e => e.SCoaguid);

                entity.ToTable("tPCC_ChartOfAccounts");

                entity.Property(e => e.SCoaguid)
                    .HasColumnName("sCOAGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SGlcode)
                    .HasColumnName("sGLCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPlcategory)
                    .HasColumnName("sPLCategory")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SPlsubCategory)
                    .HasColumnName("sPLSubCategory")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccDeptForecast>(entity =>
            {
                entity.HasKey(e => e.SForecastGuid);

                entity.ToTable("tPCC_DeptForecast");

                entity.Property(e => e.SForecastGuid)
                    .HasColumnName("sForecastGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAmount)
                    .HasColumnName("dblAmount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtPostingMonth)
                    .HasColumnName("dtPostingMonth")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDeptNum).HasColumnName("iDeptNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SGlcode)
                    .HasColumnName("sGLCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPlcategory)
                    .IsRequired()
                    .HasColumnName("sPLCategory")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPlsubcategory)
                    .HasColumnName("sPLSubcategory")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccEsh>(entity =>
            {
                entity.HasKey(e => e.SEshguid);

                entity.ToTable("tPCC_ESH");

                entity.Property(e => e.SEshguid)
                    .HasColumnName("sESHGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAbsentVacation)
                    .HasColumnName("dblAbsentVacation")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblOtpercentage)
                    .HasColumnName("dblOTPercentage")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblProdTarget)
                    .HasColumnName("dblProdTarget")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblRegHeadcount)
                    .HasColumnName("dblRegHeadcount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTempHeadcount)
                    .HasColumnName("dblTempHeadcount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtWeekStarting)
                    .HasColumnName("dtWeekStarting")
                    .HasColumnType("datetime");

                entity.Property(e => e.IDaysInWeek)
                    .HasColumnName("iDaysInWeek")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.IEshplanPerDay).HasColumnName("iESHPlanPerDay");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDepartmentName)
                    .IsRequired()
                    .HasColumnName("sDepartmentName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccFlexDepartment>(entity =>
            {
                entity.HasKey(e => e.SDepartmentGuid);

                entity.ToTable("tPCC_FlexDepartment");

                entity.Property(e => e.SDepartmentGuid)
                    .HasColumnName("sDepartmentGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BOrderInFlex).HasColumnName("bOrderInFlex");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BUseInFlex).HasColumnName("bUseInFlex");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDeptNum).HasColumnName("iDeptNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDepartmentCategory)
                    .IsRequired()
                    .HasColumnName("sDepartmentCategory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFlexDepartmentName)
                    .IsRequired()
                    .HasColumnName("sFlexDepartmentName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccGlposting>(entity =>
            {
                entity.HasKey(e => e.SPostingGuid);

                entity.ToTable("tPCC_GLPosting");

                entity.HasIndex(e => e.SKey)
                    .HasName("IX_Key");

                entity.Property(e => e.SPostingGuid)
                    .HasColumnName("sPostingGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblAmount)
                    .HasColumnName("dblAmount")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtPosting)
                    .HasColumnName("dtPosting")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IPeriod).HasColumnName("iPeriod");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SGlcode)
                    .HasColumnName("sGLCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SInvoiceNumber)
                    .HasColumnName("sInvoiceNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SRemarks)
                    .HasColumnName("sRemarks")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SSourceCode)
                    .HasColumnName("sSourceCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccHeadcount>(entity =>
            {
                entity.HasKey(e => e.SHeadcountGuid);

                entity.ToTable("tPCC_Headcount");

                entity.Property(e => e.SHeadcountGuid)
                    .HasColumnName("sHeadcountGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsTemp).HasColumnName("bIsTemp");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDeptId).HasColumnName("iDeptID");

                entity.Property(e => e.IEmpId).HasColumnName("iEmpID");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobTitle)
                    .IsRequired()
                    .HasColumnName("sJobTitle")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccHoliday>(entity =>
            {
                entity.HasKey(e => e.SHolidayGuid);

                entity.ToTable("tPCC_Holiday");

                entity.Property(e => e.SHolidayGuid)
                    .HasColumnName("sHolidayGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtHoliday)
                    .HasColumnName("dtHoliday")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccHrAdp>(entity =>
            {
                entity.HasKey(e => e.SAdpguid);

                entity.ToTable("tPCC_HR_ADP");

                entity.HasIndex(e => e.DtFile)
                    .HasName("NCI_tPCC_HR_ADP_dtFile");

                entity.Property(e => e.SAdpguid)
                    .HasColumnName("sADPGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BIsTemp).HasColumnName("bIsTemp");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblDollars)
                    .HasColumnName("dblDollars")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblHours)
                    .HasColumnName("dblHours")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtFile)
                    .HasColumnName("dtFile")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDepartmentNum).HasColumnName("iDepartmentNum");

                entity.Property(e => e.SAddedByUserId)
                    .IsRequired()
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ShultzService')");

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SEarningsCode)
                    .HasColumnName("sEarningsCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccMonthDef>(entity =>
            {
                entity.HasKey(e => e.SQuarterGuid);

                entity.ToTable("tPCC_MonthDef");

                entity.Property(e => e.SQuarterGuid)
                    .HasColumnName("sQuarterGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dtStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IMonth).HasColumnName("iMonth");

                entity.Property(e => e.IQuarter).HasColumnName("iQuarter");

                entity.Property(e => e.IYear).HasColumnName("iYear");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccOpCodeToDepartment>(entity =>
            {
                entity.HasKey(e => e.SPostingGuid);

                entity.ToTable("tPCC_OpCodeToDepartment");

                entity.Property(e => e.SPostingGuid)
                    .HasColumnName("sPostingGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDeptNum).HasColumnName("iDeptNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOpCode)
                    .IsRequired()
                    .HasColumnName("sOpCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccPcgraf>(entity =>
            {
                entity.HasKey(e => e.SPcgrafguid);

                entity.ToTable("tPCC_PCGRAF");

                entity.Property(e => e.SPcgrafguid)
                    .HasColumnName("sPCGRAFGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblPieces)
                    .HasColumnName("dblPieces")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTimeUsed)
                    .HasColumnName("dblTimeUsed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEntry)
                    .HasColumnName("dtEntry")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IStepNum).HasColumnName("iStepNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperationNum)
                    .HasColumnName("sOperationNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPccTstrav>(entity =>
            {
                entity.HasKey(e => e.STstravguid);

                entity.ToTable("tPCC_TSTRAV");

                entity.Property(e => e.STstravguid)
                    .HasColumnName("sTSTRAVGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BAllSubStepsCompleted).HasColumnName("bAllSubStepsCompleted");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCostActual)
                    .HasColumnName("dblCostActual")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCostEstimated)
                    .HasColumnName("dblCostEstimated")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMachineHoursActual)
                    .HasColumnName("dblMachineHoursActual")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMachineHoursEstimated)
                    .HasColumnName("dblMachineHoursEstimated")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPiecesActual)
                    .HasColumnName("dblPiecesActual")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPiecesEstimated)
                    .HasColumnName("dblPiecesEstimated")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCalculatedDue)
                    .HasColumnName("dtCalculatedDue")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLastDailyProductionDate)
                    .HasColumnName("dtLastDailyProductionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IParentStepNum).HasColumnName("iParentStepNum");

                entity.Property(e => e.IScheduledDays)
                    .HasColumnName("iScheduledDays")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IStepNum).HasColumnName("iStepNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc1)
                    .HasColumnName("sDesc1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc2)
                    .HasColumnName("sDesc2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SField15Holder)
                    .HasColumnName("sField15Holder")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineCode)
                    .HasColumnName("sMachineCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperationNum)
                    .HasColumnName("sOperationNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SStatus)
                    .HasColumnName("sStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPocLog>(entity =>
            {
                entity.HasKey(e => e.SRecGuid);

                entity.ToTable("tPOC_Log");

                entity.Property(e => e.SRecGuid)
                    .HasColumnName("sRecGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtTransaction)
                    .HasColumnName("dtTransaction")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SValue)
                    .HasColumnName("sValue")
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPressOpCode>(entity =>
            {
                entity.HasKey(e => e.SOpCodeGuid)
                    .IsClustered(false);

                entity.ToTable("tPressOpCode");

                entity.HasIndex(e => new { e.SMachineName, e.SJobNum, e.SOperation })
                    .HasName("ix_DefaultIndex")
                    .IsClustered();

                entity.Property(e => e.SOpCodeGuid)
                    .HasColumnName("sOpCodeGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRequiresSerial).HasColumnName("bRequiresSerial");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .IsRequired()
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineName)
                    .HasColumnName("sMachineName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperation)
                    .IsRequired()
                    .HasColumnName("sOperation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TProperty>(entity =>
            {
                entity.HasKey(e => e.SPropertyGuid);

                entity.ToTable("tProperty");

                entity.Property(e => e.SPropertyGuid)
                    .HasColumnName("sPropertyGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SProperty)
                    .IsRequired()
                    .HasColumnName("sProperty")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPurchaseOrder>(entity =>
            {
                entity.HasKey(e => e.SPoguid);

                entity.ToTable("tPurchaseOrder");

                entity.Property(e => e.SPoguid)
                    .HasColumnName("sPOGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BDeliveryRequired)
                    .IsRequired()
                    .HasColumnName("bDeliveryRequired")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BResaleTaxable).HasColumnName("bResaleTaxable");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BShippingTaxable).HasColumnName("bShippingTaxable");

                entity.Property(e => e.CurShipping)
                    .HasColumnName("curShipping")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtApproved)
                    .HasColumnName("dtApproved")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtExpected)
                    .HasColumnName("dtExpected")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtOrderPlaced)
                    .HasColumnName("dtOrderPlaced")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPocreated)
                    .HasColumnName("dtPOCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtSigned)
                    .HasColumnName("dtSigned")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBillToAddressGuid).HasColumnName("sBillToAddressGUID");

                entity.Property(e => e.SBillToContactGuid).HasColumnName("sBillToContactGUID");

                entity.Property(e => e.SBillToFaxGuid).HasColumnName("sBillToFaxGUID");

                entity.Property(e => e.SBillToPhoneGuid).HasColumnName("sBillToPhoneGUID");

                entity.Property(e => e.SChargeTo)
                    .HasColumnName("sChargeTo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SFob)
                    .HasColumnName("sFOB")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SImportKey)
                    .HasColumnName("sImportKey")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineName)
                    .HasColumnName("sMachineName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SOriginalFileName)
                    .HasColumnName("sOriginalFileName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SPonum)
                    .HasColumnName("sPONum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SReason)
                    .HasColumnName("sReason")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SRefQuote)
                    .HasColumnName("sRefQuote")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SShipToAddressGuid).HasColumnName("sShipToAddressGUID");

                entity.Property(e => e.SShipToContactGuid).HasColumnName("sShipToContactGUID");

                entity.Property(e => e.SShipToFaxGuid).HasColumnName("sShipToFaxGUID");

                entity.Property(e => e.SShipToPhoneGuid).HasColumnName("sShipToPhoneGUID");

                entity.Property(e => e.SShipVia)
                    .HasColumnName("sShipVia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSignedForDeptText)
                    .HasColumnName("sSignedForDeptText")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SStatus)
                    .IsRequired()
                    .HasColumnName("sStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STerms)
                    .HasColumnName("sTerms")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SToBeUsedFor)
                    .HasColumnName("sToBeUsedFor")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.STrackingNumber)
                    .HasColumnName("sTrackingNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVendorAddressGuid).HasColumnName("sVendorAddressGUID");

                entity.Property(e => e.SVendorContactGuid).HasColumnName("sVendorContactGUID");

                entity.Property(e => e.SVendorFaxGuid).HasColumnName("sVendorFaxGUID");

                entity.Property(e => e.SVendorGuid).HasColumnName("sVendorGUID");

                entity.Property(e => e.SVendorPhoneGuid).HasColumnName("sVendorPhoneGUID");
            });

            modelBuilder.Entity<TPurchaseOrderAccount>(entity =>
            {
                entity.HasKey(e => e.SRecGuid);

                entity.ToTable("tPurchaseOrderAccount");

                entity.Property(e => e.SRecGuid)
                    .HasColumnName("sRecGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAccountGuid).HasColumnName("sAccountGUID");

                entity.Property(e => e.SAccountNum)
                    .HasColumnName("sAccountNum")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[fnAccountNumber]([sDepartmentGUID],[sAccountGUID]))");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDepartmentGuid).HasColumnName("sDepartmentGUID");

                entity.Property(e => e.SPoguid).HasColumnName("sPOGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPogu)
                    .WithMany(p => p.TPurchaseOrderAccount)
                    .HasForeignKey(d => d.SPoguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tPurchaseOrderAccount_tPurchaseOrder");
            });

            modelBuilder.Entity<TPurchaseOrderContact>(entity =>
            {
                entity.HasKey(e => e.SContactGuid);

                entity.ToTable("tPurchaseOrderContact");

                entity.Property(e => e.SContactGuid)
                    .HasColumnName("sContactGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEmail)
                    .HasColumnName("sEMail")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SFirstName)
                    .HasColumnName("sFirstName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SLastName)
                    .HasColumnName("sLastName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SMiddleName)
                    .HasColumnName("sMiddleName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SPositionTitle)
                    .HasColumnName("sPositionTitle")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SSuffix)
                    .HasColumnName("sSuffix")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.STitle)
                    .HasColumnName("sTitle")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPurchaseOrderContactAddress>(entity =>
            {
                entity.HasKey(e => e.SAddressGuid);

                entity.ToTable("tPurchaseOrderContactAddress");

                entity.Property(e => e.SAddressGuid)
                    .HasColumnName("sAddressGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsBilling).HasColumnName("bIsBilling");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BIsShipping).HasColumnName("bIsShipping");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress1)
                    .HasColumnName("sAddress1")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress2)
                    .HasColumnName("sAddress2")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SAddressHash)
                    .HasColumnName("sAddressHash")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SCity)
                    .HasColumnName("sCity")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SContactGuid).HasColumnName("sContactGUID");

                entity.Property(e => e.SCountry)
                    .HasColumnName("sCountry")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SPostalCode)
                    .HasColumnName("sPostalCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SState)
                    .HasColumnName("sState")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STypeCode)
                    .HasColumnName("sTypeCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SContactGu)
                    .WithMany(p => p.TPurchaseOrderContactAddress)
                    .HasForeignKey(d => d.SContactGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tPurchaseOrderContactAddress_tPurchaseOrderContact");
            });

            modelBuilder.Entity<TPurchaseOrderContactPhone>(entity =>
            {
                entity.HasKey(e => e.SPhoneGuid);

                entity.ToTable("tPurchaseOrderContactPhone");

                entity.Property(e => e.SPhoneGuid)
                    .HasColumnName("sPhoneGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsBilling).HasColumnName("bIsBilling");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BIsShipping).HasColumnName("bIsShipping");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SContactGuid).HasColumnName("sContactGUID");

                entity.Property(e => e.SPhoneHash)
                    .HasColumnName("sPhoneHash")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SPhoneNumber)
                    .HasColumnName("sPhoneNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STypeCode)
                    .HasColumnName("sTypeCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SContactGu)
                    .WithMany(p => p.TPurchaseOrderContactPhone)
                    .HasForeignKey(d => d.SContactGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tPurchaseOrderContactPhone_tPurchaseOrderContact");
            });

            modelBuilder.Entity<TPurchaseOrderDetail>(entity =>
            {
                entity.HasKey(e => e.SLineGuid);

                entity.ToTable("tPurchaseOrderDetail");

                entity.Property(e => e.SLineGuid)
                    .HasColumnName("sLineGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsTaxable)
                    .IsRequired()
                    .HasColumnName("bIsTaxable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurLineTotal)
                    .HasColumnName("curLineTotal")
                    .HasColumnType("numeric(29, 4)")
                    .HasComputedColumnSql("([iQty]*[curPrice])");

                entity.Property(e => e.CurPrice)
                    .HasColumnName("curPrice")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTaxRate)
                    .HasColumnName("dblTaxRate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IQty)
                    .HasColumnName("iQty")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SPoguid).HasColumnName("sPOGUID");

                entity.Property(e => e.SUnit)
                    .HasColumnName("sUnit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SPogu)
                    .WithMany(p => p.TPurchaseOrderDetail)
                    .HasForeignKey(d => d.SPoguid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tPurchaseOrderDetail_tPurchaseOrder");
            });

            modelBuilder.Entity<TQueryWriterSecGroup>(entity =>
            {
                entity.HasKey(e => e.SGroupGuid);

                entity.ToTable("tQueryWriterSecGroup");

                entity.Property(e => e.SGroupGuid)
                    .HasColumnName("sGroupGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TQueryWriterSecGroupToObject>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tQueryWriterSecGroupToObject");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SGroupGuid).HasColumnName("sGroupGUID");

                entity.Property(e => e.SObjectGuid).HasColumnName("sObjectGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SGroupGu)
                    .WithMany(p => p.TQueryWriterSecGroupToObject)
                    .HasForeignKey(d => d.SGroupGuid)
                    .HasConstraintName("FK_tQueryWriterSecGroupToObject_tQueryWriterSecGroup");

                entity.HasOne(d => d.SObjectGu)
                    .WithMany(p => p.TQueryWriterSecGroupToObject)
                    .HasForeignKey(d => d.SObjectGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tQueryWriterSecGroupToObject_tQueryWriterSecObject");
            });

            modelBuilder.Entity<TQueryWriterSecGroupToQuery>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tQueryWriterSecGroupToQuery");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SGroupGuid).HasColumnName("sGroupGUID");

                entity.Property(e => e.SQueryGuid)
                    .HasColumnName("sQueryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SGroupGu)
                    .WithMany(p => p.TQueryWriterSecGroupToQuery)
                    .HasForeignKey(d => d.SGroupGuid)
                    .HasConstraintName("FK_tQueryWriterSecGroupToQuery_tQueryWriterSecGroup");

                entity.HasOne(d => d.SQueryGu)
                    .WithMany(p => p.TQueryWriterSecGroupToQuery)
                    .HasForeignKey(d => d.SQueryGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tQueryWriterSecGroupToQuery_tQueryWriterSecQuery");
            });

            modelBuilder.Entity<TQueryWriterSecObject>(entity =>
            {
                entity.HasKey(e => e.SObjectGuid);

                entity.ToTable("tQueryWriterSecObject");

                entity.Property(e => e.SObjectGuid)
                    .HasColumnName("sObjectGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFieldName)
                    .HasColumnName("sFieldName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.STableName)
                    .HasColumnName("sTableName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TQueryWriterSecQuery>(entity =>
            {
                entity.HasKey(e => e.SQueryGuid);

                entity.ToTable("tQueryWriterSecQuery");

                entity.Property(e => e.SQueryGuid)
                    .HasColumnName("sQueryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TQueryWriterSecUserToGroup>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tQueryWriterSecUserToGroup");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SGroupGuid).HasColumnName("sGroupGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SGroupGu)
                    .WithMany(p => p.TQueryWriterSecUserToGroup)
                    .HasForeignKey(d => d.SGroupGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tQueryWriterSecUserToGroup_tQueryWriterSecGroup");
            });

            modelBuilder.Entity<TRateLookup>(entity =>
            {
                entity.HasKey(e => e.SRateGuid)
                    .IsClustered(false);

                entity.ToTable("tRateLookup");

                entity.HasIndex(e => new { e.SKey, e.DblBottomRate })
                    .HasName("ix_Key_Lower")
                    .IsClustered();

                entity.Property(e => e.SRateGuid)
                    .HasColumnName("sRateGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblBottomRate)
                    .HasColumnName("dblBottomRate")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblReturnRate)
                    .HasColumnName("dblReturnRate")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DblTopRate)
                    .HasColumnName("dblTopRate")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .IsRequired()
                    .HasColumnName("sKey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TReceivingLog>(entity =>
            {
                entity.HasKey(e => e.SReceivingLogGuid);

                entity.ToTable("tReceivingLog");

                entity.Property(e => e.SReceivingLogGuid)
                    .HasColumnName("sReceivingLogGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtReceived)
                    .HasColumnName("dtReceived")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IHeightInInches).HasColumnName("iHeightInInches");

                entity.Property(e => e.ILengthInInches).HasColumnName("iLengthInInches");

                entity.Property(e => e.IPiecesReceived).HasColumnName("iPiecesReceived");

                entity.Property(e => e.IWeightInPounds).HasColumnName("iWeightInPounds");

                entity.Property(e => e.IWidthInInches).HasColumnName("iWidthInInches");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCarrierName)
                    .HasColumnName("sCarrierName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SIdentification)
                    .HasColumnName("sIdentification")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SMetalGuid).HasColumnName("sMetalGUID");

                entity.Property(e => e.SPonum)
                    .HasColumnName("sPONum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SReceiverUserGuid)
                    .HasColumnName("sReceiverUserGUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SType)
                    .HasColumnName("sType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TReport>(entity =>
            {
                entity.HasKey(e => e.SReportGuid);

                entity.ToTable("tReport");

                entity.Property(e => e.SReportGuid)
                    .HasColumnName("sReportGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsFormLetter).HasColumnName("bIsFormLetter");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBackgroundStatus)
                    .HasColumnName("sBackgroundStatus")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SCreatorUserGuid).HasColumnName("sCreatorUserGUID");

                entity.Property(e => e.SElementType)
                    .HasColumnName("sElementType")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SFilterCriteria)
                    .HasColumnName("sFilterCriteria")
                    .HasColumnType("text");

                entity.Property(e => e.SFormLetterRtf)
                    .HasColumnName("sFormLetterRTF")
                    .HasColumnType("text");

                entity.Property(e => e.SModule)
                    .HasColumnName("sModule")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SPreview)
                    .HasColumnName("sPreview")
                    .HasColumnType("image");

                entity.Property(e => e.SReportAsXml)
                    .HasColumnName("sReportAsXml")
                    .HasColumnType("xml");

                entity.Property(e => e.SReportTitle)
                    .IsRequired()
                    .HasColumnName("sReportTitle")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SStream)
                    .HasColumnName("sStream")
                    .HasColumnType("image");

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SViewTitle)
                    .HasColumnName("sViewTitle")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TReportHistory>(entity =>
            {
                entity.HasKey(e => e.SReportHistoryGuid);

                entity.ToTable("tReportHistory");

                entity.Property(e => e.SReportHistoryGuid)
                    .HasColumnName("sReportHistoryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsFormLetter).HasColumnName("bIsFormLetter");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtRun)
                    .HasColumnName("dtRun")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBackgroundStatus)
                    .HasColumnName("sBackgroundStatus")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SElementType)
                    .HasColumnName("sElementType")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SEntityGuid).HasColumnName("sEntityGUID");

                entity.Property(e => e.SFilterCriteria)
                    .HasColumnName("sFilterCriteria")
                    .HasColumnType("text");

                entity.Property(e => e.SFormLetterRtf)
                    .HasColumnName("sFormLetterRTF")
                    .HasColumnType("text");

                entity.Property(e => e.SReportTitle)
                    .IsRequired()
                    .HasColumnName("sReportTitle")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SStream)
                    .HasColumnName("sStream")
                    .HasColumnType("image");

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SViewTitle)
                    .HasColumnName("sViewTitle")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TReportToGroup>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tReportToGroup");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SGroupGuid).HasColumnName("sGroupGUID");

                entity.Property(e => e.SReportGuid).HasColumnName("sReportGUID");

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SGroupGu)
                    .WithMany(p => p.TReportToGroup)
                    .HasForeignKey(d => d.SGroupGuid)
                    .HasConstraintName("FK_tReportToGroup_tSecGroup");

                entity.HasOne(d => d.SReportGu)
                    .WithMany(p => p.TReportToGroup)
                    .HasForeignKey(d => d.SReportGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tReportToGroup_tReport");
            });

            modelBuilder.Entity<TRssnews>(entity =>
            {
                entity.HasKey(e => e.SNewsGuid);

                entity.ToTable("tRSSNews");

                entity.Property(e => e.SNewsGuid)
                    .HasColumnName("sNewsGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtPublication)
                    .HasColumnName("dtPublication")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SImagePath)
                    .HasColumnName("sImagePath")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.STitle)
                    .HasColumnName("sTitle")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TRssweatherDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tRSSWeatherDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtDate)
                    .HasColumnName("dtDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICode).HasColumnName("iCode");

                entity.Property(e => e.IHigh).HasColumnName("iHigh");

                entity.Property(e => e.ILow).HasColumnName("iLow");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDay)
                    .HasColumnName("sDay")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SText)
                    .HasColumnName("sText")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TRssweatherMaster>(entity =>
            {
                entity.HasKey(e => e.SWeatherGuid);

                entity.ToTable("tRSSWeatherMaster");

                entity.Property(e => e.SWeatherGuid)
                    .HasColumnName("sWeatherGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblTemp)
                    .HasColumnName("dblTemp")
                    .HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastBuilt)
                    .HasColumnName("dtLastBuilt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtSunrise)
                    .HasColumnName("dtSunrise")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtSunset)
                    .HasColumnName("dtSunset")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ICode).HasColumnName("iCode");

                entity.Property(e => e.IWindChill)
                    .HasColumnName("iWindChill")
                    .HasMaxLength(10);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCity)
                    .HasColumnName("sCity")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SConditionText)
                    .HasColumnName("sConditionText")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SCountry)
                    .HasColumnName("sCountry")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SState)
                    .HasColumnName("sState")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TRtf>(entity =>
            {
                entity.HasKey(e => e.SRtfguid)
                    .IsClustered(false);

                entity.ToTable("tRTF");

                entity.HasIndex(e => e.SEntityGuid);

                entity.HasIndex(e => e.SRtfguid)
                    .HasName("ix_sRTFGUID");

                entity.Property(e => e.SRtfguid)
                    .HasColumnName("sRTFGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SEntityGuid).HasColumnName("sEntityGUID");

                entity.Property(e => e.SExtendedType)
                    .HasColumnName("sExtendedType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .IsRequired()
                    .HasColumnName("sKey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SRtf)
                    .HasColumnName("sRTF")
                    .HasColumnType("text");

                entity.Property(e => e.SText)
                    .HasColumnName("sText")
                    .HasColumnType("text");

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSalesSurveyResult>(entity =>
            {
                entity.HasKey(e => e.SItemGuid);

                entity.ToTable("tSalesSurveyResult");

                entity.Property(e => e.SItemGuid)
                    .HasColumnName("sItemGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IYear).HasColumnName("iYear");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .IsRequired()
                    .HasColumnName("sKey")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasColumnName("sName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SValue)
                    .HasColumnName("sValue")
                    .HasMaxLength(3000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSawBladeChange>(entity =>
            {
                entity.HasKey(e => e.SChangeGuid);

                entity.ToTable("tSawBladeChange");

                entity.Property(e => e.SChangeGuid)
                    .HasColumnName("sChangeGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BReuse).HasColumnName("bReuse");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BScrapped).HasColumnName("bScrapped");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtChange)
                    .HasColumnName("dtChange")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SNewBladeGuid).HasColumnName("sNewBladeGUID");

                entity.Property(e => e.SNotes)
                    .HasColumnName("sNotes")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SOldBladeGuid).HasColumnName("sOldBladeGUID");

                entity.Property(e => e.SReason)
                    .IsRequired()
                    .HasColumnName("sReason")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SSawName)
                    .IsRequired()
                    .HasColumnName("sSawName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSawBladeDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tSawBladeDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblBladeFeed)
                    .HasColumnName("dblBladeFeed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblBladeSpeed)
                    .HasColumnName("dblBladeSpeed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IPercentageOfCut)
                    .HasColumnName("iPercentageOfCut")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBladeMasterGuid).HasColumnName("sBladeMasterGUID");

                entity.Property(e => e.SEntryGuid).HasColumnName("sEntryGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SBladeMasterGu)
                    .WithMany(p => p.TSawBladeDetail)
                    .HasForeignKey(d => d.SBladeMasterGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSawBladeDetail_tSawBladeMaster");

                entity.HasOne(d => d.SEntryGu)
                    .WithMany(p => p.TSawBladeDetail)
                    .HasForeignKey(d => d.SEntryGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSawBladeDetail_tSawRunChartEntry");
            });

            modelBuilder.Entity<TSawBladeManualEntryCut>(entity =>
            {
                entity.HasKey(e => e.SManualEntryGuid);

                entity.ToTable("tSawBladeManualEntryCut");

                entity.Property(e => e.SManualEntryGuid)
                    .HasColumnName("sManualEntryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblBladeFeed)
                    .HasColumnName("dblBladeFeed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblBladeSpeed)
                    .HasColumnName("dblBladeSpeed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IPercentageOfCut)
                    .HasColumnName("iPercentageOfCut")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAlloyType)
                    .HasColumnName("sAlloyType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBladeMasterGuid).HasColumnName("sBladeMasterGUID");

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMaterialSize)
                    .HasColumnName("sMaterialSize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSawName)
                    .HasColumnName("sSawName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSawBladeMaster>(entity =>
            {
                entity.HasKey(e => e.SBladeMasterGuid);

                entity.ToTable("tSawBladeMaster");

                entity.Property(e => e.SBladeMasterGuid)
                    .HasColumnName("sBladeMasterGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBladeNum)
                    .HasColumnName("sBladeNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SManufacturer)
                    .HasColumnName("sManufacturer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SToothType)
                    .HasColumnName("sToothType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSawConversionDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tSawConversionDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblInventoryLength)
                    .HasColumnName("dblInventoryLength")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DblInventoryWeight)
                    .HasColumnName("dblInventoryWeight")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DblLengthAfterForge)
                    .HasColumnName("dblLengthAfterForge")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DblPlannedSonicUsableLength)
                    .HasColumnName("dblPlannedSonicUsableLength")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPlannedWeightAfterForge)
                    .HasColumnName("dblPlannedWeightAfterForge")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DblSonicUsableLength)
                    .HasColumnName("dblSonicUsableLength")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DblWeightAfterForge)
                    .HasColumnName("dblWeightAfterForge")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBilletNum)
                    .HasColumnName("sBilletNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBilletSize)
                    .HasColumnName("sBilletSize")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SConversionGuid).HasColumnName("sConversionGUID");

                entity.Property(e => e.SPlannedJobForBillet)
                    .HasColumnName("sPlannedJobForBillet")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SConversionGu)
                    .WithMany(p => p.TSawConversionDetail)
                    .HasForeignKey(d => d.SConversionGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSawConversionDetail_tSawConversionMaster");
            });

            modelBuilder.Entity<TSawConversionMaster>(entity =>
            {
                entity.HasKey(e => e.SConversionGuid);

                entity.ToTable("tSawConversionMaster");

                entity.Property(e => e.SConversionGuid)
                    .HasColumnName("sConversionGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblIngotWeight)
                    .HasColumnName("dblIngotWeight")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCompleted)
                    .HasColumnName("dtCompleted")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPlanned)
                    .HasColumnName("dtPlanned")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCompletedBy)
                    .HasColumnName("sCompletedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SConversionNum)
                    .HasColumnName("sConversionNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SHeatCode)
                    .HasColumnName("sHeatCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SHeatNum)
                    .HasColumnName("sHeatNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SIngotSize)
                    .HasColumnName("sIngotSize")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SMaterial)
                    .HasColumnName("sMaterial")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPlannedBy)
                    .HasColumnName("sPlannedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSupplier)
                    .HasColumnName("sSupplier")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSawCustomer>(entity =>
            {
                entity.HasKey(e => e.SRecGuid);

                entity.ToTable("tSawCustomer");

                entity.Property(e => e.SRecGuid)
                    .HasColumnName("sRecGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomerName)
                    .HasColumnName("sCustomerName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumDashed)
                    .HasColumnName("sJobNumDashed")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumPrefix)
                    .HasColumnName("sJobNumPrefix")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSawLogTrans>(entity =>
            {
                entity.HasKey(e => e.SLogGuid);

                entity.ToTable("tSawLogTrans");

                entity.Property(e => e.SLogGuid)
                    .HasColumnName("sLogGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DtLogged)
                    .HasColumnName("dtLogged")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAction)
                    .IsRequired()
                    .HasColumnName("sAction")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SActionType)
                    .IsRequired()
                    .HasColumnName("sActionType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAppVersion)
                    .HasColumnName("sAppVersion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineName)
                    .HasColumnName("sMachineName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SObjectName)
                    .HasColumnName("sObjectName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SObjectXml)
                    .HasColumnName("sObjectXML")
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.SUserName)
                    .HasColumnName("sUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSawRunChartDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tSawRunChartDetail");

                entity.HasIndex(e => e.SMasterGuid)
                    .HasName("IX_MasterGUID");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BComplete).HasColumnName("bComplete");

                entity.Property(e => e.BHasBottomCrop).HasColumnName("bHasBottomCrop");

                entity.Property(e => e.BHasRem).HasColumnName("bHasRem");

                entity.Property(e => e.BHasTopCrop).HasColumnName("bHasTopCrop");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BTestPiece).HasColumnName("bTestPiece");

                entity.Property(e => e.DblActualBilletLength)
                    .HasColumnName("dblActualBilletLength")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DblActualBilletWeight)
                    .HasColumnName("dblActualBilletWeight")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DblBottomCropTarget)
                    .HasColumnName("dblBottomCropTarget")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblHighLimitLength)
                    .HasColumnName("dblHighLimitLength")
                    .HasColumnType("numeric(19, 4)")
                    .HasComputedColumnSql("(isnull([dblTargetLength]+[dblPlusToleranceLength],(0)))");

                entity.Property(e => e.DblHighLimitWeight)
                    .HasColumnName("dblHighLimitWeight")
                    .HasColumnType("numeric(19, 4)")
                    .HasComputedColumnSql("(isnull([dblTargetWeight]+[dblPlusToleranceWeight],(0)))");

                entity.Property(e => e.DblKerfActual)
                    .HasColumnName("dblKerfActual")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblKerfTarget)
                    .HasColumnName("dblKerfTarget")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblLowLimitLength)
                    .HasColumnName("dblLowLimitLength")
                    .HasColumnType("numeric(19, 4)")
                    .HasComputedColumnSql("(isnull([dblTargetLength]-[dblMinusToleranceLength],(0)))");

                entity.Property(e => e.DblLowLimitWeight)
                    .HasColumnName("dblLowLimitWeight")
                    .HasColumnType("numeric(19, 4)")
                    .HasComputedColumnSql("(isnull([dblTargetWeight]-[dblMinusToleranceWeight],(0)))");

                entity.Property(e => e.DblMinusToleranceLength)
                    .HasColumnName("dblMinusToleranceLength")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMinusToleranceWeight)
                    .HasColumnName("dblMinusToleranceWeight")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPlannedBilletLength)
                    .HasColumnName("dblPlannedBilletLength")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DblPlannedBilletWeight)
                    .HasColumnName("dblPlannedBilletWeight")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DblPlusToleranceLength)
                    .HasColumnName("dblPlusToleranceLength")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPlusToleranceWeight)
                    .HasColumnName("dblPlusToleranceWeight")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPoundsPerInch)
                    .HasColumnName("dblPoundsPerInch")
                    .HasColumnType("numeric(38, 20)")
                    .HasComputedColumnSql("(isnull([dblActualBilletWeight],(0))/isnull(case when [dblActualBilletLength]=(0) then (1) else [dblActualBilletLength] end,(1)))");

                entity.Property(e => e.DblRemTarget)
                    .HasColumnName("dblRemTarget")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTargetCutRate)
                    .HasColumnName("dblTargetCutRate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTargetLength)
                    .HasColumnName("dblTargetLength")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTargetWeight)
                    .HasColumnName("dblTargetWeight")
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DblTopCropTarget)
                    .HasColumnName("dblTopCropTarget")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.INumPieces).HasColumnName("iNumPieces");

                entity.Property(e => e.ITravelerStepNum).HasColumnName("iTravelerStepNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAlloyType)
                    .HasColumnName("sAlloyType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBilletNum)
                    .HasColumnName("sBilletNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SConversionNum)
                    .HasColumnName("sConversionNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCutType)
                    .HasColumnName("sCutType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHeatCode)
                    .HasColumnName("sHeatCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SHeatNum)
                    .HasColumnName("sHeatNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMasterGuid).HasColumnName("sMasterGUID");

                entity.Property(e => e.SMaterialSize)
                    .HasColumnName("sMaterialSize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMaterialSupplier)
                    .HasColumnName("sMaterialSupplier")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SReason)
                    .HasColumnName("sReason")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMasterGu)
                    .WithMany(p => p.TSawRunChartDetail)
                    .HasForeignKey(d => d.SMasterGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSawRunChartDetail_tSawRunChartMaster");
            });

            modelBuilder.Entity<TSawRunChartEntry>(entity =>
            {
                entity.HasKey(e => e.SEntryGuid);

                entity.ToTable("tSawRunChartEntry");

                entity.HasIndex(e => e.SDetailGuid)
                    .HasName("ix_DetailGUID");

                entity.Property(e => e.SEntryGuid)
                    .HasColumnName("sEntryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BBottomCrop).HasColumnName("bBottomCrop");

                entity.Property(e => e.BRem).HasColumnName("bRem");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BTopCrop).HasColumnName("bTopCrop");

                entity.Property(e => e.DblLength)
                    .HasColumnName("dblLength")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblWeight)
                    .HasColumnName("dblWeight")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEntered)
                    .HasColumnName("dtEntered")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder)
                    .HasColumnName("iSortOrder")
                    .HasComputedColumnSql("(case when [bBottomCrop]<>(0) then (0) when [bTopCrop]<>(0) then (2) when [bRem]<>(0) then (3) else (1) end)");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDetailGuid).HasColumnName("sDetailGUID");

                entity.Property(e => e.SSawName)
                    .HasColumnName("sSawName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSerialNum)
                    .HasColumnName("sSerialNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SDetailGu)
                    .WithMany(p => p.TSawRunChartEntry)
                    .HasForeignKey(d => d.SDetailGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSawRunChartEntry_tSawRunChartDetail");
            });

            modelBuilder.Entity<TSawRunChartEntryException>(entity =>
            {
                entity.HasKey(e => e.SExceptionGuid);

                entity.ToTable("tSawRunChartEntryException");

                entity.Property(e => e.SExceptionGuid)
                    .HasColumnName("sExceptionGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCategory)
                    .HasColumnName("sCategory")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SEntryGuid).HasColumnName("sEntryGUID");

                entity.Property(e => e.SReason)
                    .HasColumnName("sReason")
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.SSystemDescription)
                    .HasColumnName("sSystemDescription")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SEntryGu)
                    .WithMany(p => p.TSawRunChartEntryException)
                    .HasForeignKey(d => d.SEntryGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSawRunChartEntryException_tSawRunChartEntry");
            });

            modelBuilder.Entity<TSawRunChartMaster>(entity =>
            {
                entity.HasKey(e => e.SMasterGuid)
                    .IsClustered(false);

                entity.ToTable("tSawRunChartMaster");

                entity.HasIndex(e => e.SJobNum)
                    .HasName("ix_JobNum");

                entity.Property(e => e.SMasterGuid)
                    .HasColumnName("sMasterGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomer)
                    .IsRequired()
                    .HasColumnName("sCustomer")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .IsRequired()
                    .HasColumnName("sJobNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSawSession>(entity =>
            {
                entity.HasKey(e => e.SSessionGuid);

                entity.ToTable("tSawSession");

                entity.Property(e => e.SSessionGuid)
                    .HasColumnName("sSessionGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastAccess)
                    .HasColumnName("dtLastAccess")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.ITravelerStepNum).HasColumnName("iTravelerStepNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBilletNum)
                    .HasColumnName("sBilletNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SBladeGuid).HasColumnName("sBladeGUID");

                entity.Property(e => e.SConversionNum)
                    .HasColumnName("sConversionNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SCutType)
                    .HasColumnName("sCutType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDetailGuid).HasColumnName("sDetailGUID");

                entity.Property(e => e.SHeatCode)
                    .HasColumnName("sHeatCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SHeatNum)
                    .HasColumnName("sHeatNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SOperator)
                    .HasColumnName("sOperator")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSawDesc)
                    .IsRequired()
                    .HasColumnName("sSawDesc")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SSawName)
                    .IsRequired()
                    .HasColumnName("sSawName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSawSessionHistory>(entity =>
            {
                entity.HasKey(e => e.SHistoryGuid);

                entity.ToTable("tSawSessionHistory");

                entity.Property(e => e.SHistoryGuid)
                    .HasColumnName("sHistoryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ITravelerStepNum).HasColumnName("iTravelerStepNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBilletNum)
                    .HasColumnName("sBilletNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SBladeGuid).HasColumnName("sBladeGUID");

                entity.Property(e => e.SConversionNum)
                    .HasColumnName("sConversionNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SCutType)
                    .HasColumnName("sCutType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDetailGuid).HasColumnName("sDetailGUID");

                entity.Property(e => e.SHeatCode)
                    .HasColumnName("sHeatCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SHeatNum)
                    .HasColumnName("sHeatNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNum)
                    .HasColumnName("sJobNum")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SOperator)
                    .HasColumnName("sOperator")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSawDesc)
                    .IsRequired()
                    .HasColumnName("sSawDesc")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SSawName)
                    .IsRequired()
                    .HasColumnName("sSawName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSawSystemSetting>(entity =>
            {
                entity.HasKey(e => e.SRecGuid)
                    .IsClustered(false);

                entity.ToTable("tSawSystemSetting");

                entity.HasIndex(e => e.SRecGuid)
                    .HasName("IX_RecGUID");

                entity.HasIndex(e => new { e.SListName, e.ISortOrder })
                    .HasName("IX_SystemSetting")
                    .IsClustered();

                entity.Property(e => e.SRecGuid)
                    .HasColumnName("sRecGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SListName)
                    .HasColumnName("sListName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SValue)
                    .HasColumnName("sValue")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SValueDesc)
                    .HasColumnName("sValueDesc")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSawUser>(entity =>
            {
                entity.HasKey(e => e.SUserGuid);

                entity.ToTable("tSawUser");

                entity.Property(e => e.SUserGuid)
                    .HasColumnName("sUserGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BAdminUser).HasColumnName("bAdminUser");

                entity.Property(e => e.BFixJobsUser).HasColumnName("bFixJobsUser");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastLogin)
                    .HasColumnName("dtLastLogin")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ILoginAttempts).HasColumnName("iLoginAttempts");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFullName)
                    .IsRequired()
                    .HasColumnName("sFullName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SLastOpenSection)
                    .HasColumnName("sLastOpenSection")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPassword)
                    .IsRequired()
                    .HasColumnName("sPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPinNum)
                    .HasColumnName("sPinNum")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SShift)
                    .HasColumnName("sShift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserName)
                    .IsRequired()
                    .HasColumnName("sUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TScheduleBreak>(entity =>
            {
                entity.HasKey(e => e.SScheduleBreakGuid);

                entity.ToTable("tScheduleBreak");

                entity.Property(e => e.SScheduleBreakGuid)
                    .HasColumnName("sScheduleBreakGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInActive).HasColumnName("bInActive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IEndFirstBreak).HasColumnName("iEndFirstBreak");

                entity.Property(e => e.IEndLunch).HasColumnName("iEndLunch");

                entity.Property(e => e.IEndOverTimeBreak1).HasColumnName("iEndOverTimeBreak1");

                entity.Property(e => e.IEndOverTimeBreak2).HasColumnName("iEndOverTimeBreak2");

                entity.Property(e => e.IEndOverTimeBreak3).HasColumnName("iEndOverTimeBreak3");

                entity.Property(e => e.IEndOverTimeBreak4).HasColumnName("iEndOverTimeBreak4");

                entity.Property(e => e.IEndSecondBreak).HasColumnName("iEndSecondBreak");

                entity.Property(e => e.IShift).HasColumnName("iShift");

                entity.Property(e => e.IStartFirstBreak).HasColumnName("iStartFirstBreak");

                entity.Property(e => e.IStartLunch).HasColumnName("iStartLunch");

                entity.Property(e => e.IStartOverTimeBreak1).HasColumnName("iStartOverTimeBreak1");

                entity.Property(e => e.IStartOverTimeBreak2).HasColumnName("iStartOverTimeBreak2");

                entity.Property(e => e.IStartOverTimeBreak3).HasColumnName("iStartOverTimeBreak3");

                entity.Property(e => e.IStartOverTimeBreak4).HasColumnName("iStartOverTimeBreak4");

                entity.Property(e => e.IStartSecondBreak).HasColumnName("iStartSecondBreak");

                entity.Property(e => e.ITimeBeforeShift).HasColumnName("iTimeBeforeShift");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TScheduleDay>(entity =>
            {
                entity.HasKey(e => e.SScheduleDayGuid);

                entity.ToTable("tScheduleDay");

                entity.Property(e => e.SScheduleDayGuid)
                    .HasColumnName("sScheduleDayGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCalendar)
                    .HasColumnName("dtCalendar")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCharacters)
                    .HasColumnName("sCharacters")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineGuid).HasColumnName("sMachineGUID");

                entity.Property(e => e.SScheduleManagerGuid).HasColumnName("sScheduleManagerGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMachineGu)
                    .WithMany(p => p.TScheduleDay)
                    .HasForeignKey(d => d.SMachineGuid)
                    .HasConstraintName("FK_tScheduleDay_tMachine");
            });

            modelBuilder.Entity<TScheduleExclusion>(entity =>
            {
                entity.HasKey(e => e.SScheduleExclusionGuid);

                entity.ToTable("tScheduleExclusion");

                entity.Property(e => e.SScheduleExclusionGuid)
                    .HasColumnName("sScheduleExclusionGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInActive).HasColumnName("bInActive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCode)
                    .IsRequired()
                    .HasColumnName("sCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .IsRequired()
                    .HasColumnName("sDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TScheduleJob>(entity =>
            {
                entity.HasKey(e => e.SScheduleJobGuid);

                entity.ToTable("tScheduleJob");

                entity.Property(e => e.SScheduleJobGuid)
                    .HasColumnName("sScheduleJobGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BCrossSectionBeforeUpdated)
                    .HasColumnName("bCrossSectionBeforeUpdated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BDescriptionUpdated)
                    .HasColumnName("bDescriptionUpdated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsConversion)
                    .HasColumnName("bIsConversion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BIsRework).HasColumnName("bIsRework");

                entity.Property(e => e.BMetalUpdated)
                    .HasColumnName("bMetalUpdated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BMondayTuesdayOnly).HasColumnName("bMondayTuesdayOnly");

                entity.Property(e => e.BOverTimeScheduled)
                    .HasColumnName("bOverTimeScheduled")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BTemperatureUpdated)
                    .HasColumnName("bTemperatureUpdated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BTimeLocked)
                    .HasColumnName("bTimeLocked")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BTimespanUpdated).HasColumnName("bTimespanUpdated");

                entity.Property(e => e.DblCrossSection)
                    .HasColumnName("dblCrossSection")
                    .HasColumnType("numeric(6, 3)");

                entity.Property(e => e.DblForgeTimePerItem)
                    .HasColumnName("dblForgeTimePerItem")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTotalForgeTimeInMinutes)
                    .HasColumnName("dblTotalForgeTimeInMinutes")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTotalForgeTimeRemaining)
                    .HasColumnName("dblTotalForgeTimeRemaining")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dtEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtForgeEnd)
                    .HasColumnName("dtForgeEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtForgeEndPushedBack)
                    .HasColumnName("dtForgeEndPushedBack")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPreFurnace)
                    .HasColumnName("dtPreFurnace")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dtStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IForgeStep).HasColumnName("iForgeStep");

                entity.Property(e => e.IFurnaceGroup)
                    .HasColumnName("iFurnaceGroup")
                    .HasDefaultValueSql("((999))");

                entity.Property(e => e.IItemCount).HasColumnName("iItemCount");

                entity.Property(e => e.IPreFurnaceStep).HasColumnName("iPreFurnaceStep");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFactors)
                    .HasColumnName("sFactors")
                    .IsUnicode(false);

                entity.Property(e => e.SForgeGroup).HasColumnName("sForgeGroup");

                entity.Property(e => e.SMachineGuid).HasColumnName("sMachineGUID");

                entity.Property(e => e.SMetalName)
                    .HasColumnName("sMetalName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SNumber)
                    .HasColumnName("sNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperationSummary)
                    .HasColumnName("sOperationSummary")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SScheduleManagerGuid).HasColumnName("sScheduleManagerGUID");

                entity.Property(e => e.SScheduleSymbol)
                    .HasColumnName("sScheduleSymbol")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SShapeSizeKey)
                    .HasColumnName("sShapeSizeKey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SStartDateString)
                    .HasColumnName("sStartDateString")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.STravelerDescriptionLine1)
                    .HasColumnName("sTravelerDescriptionLine1")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMachineGu)
                    .WithMany(p => p.TScheduleJob)
                    .HasForeignKey(d => d.SMachineGuid)
                    .HasConstraintName("FK_tScheduleJob_tMachine");
            });

            modelBuilder.Entity<TScheduleJobCandidate>(entity =>
            {
                entity.HasKey(e => e.SScheduleJobCandidateGuid);

                entity.ToTable("tScheduleJobCandidate");

                entity.Property(e => e.SScheduleJobCandidateGuid)
                    .HasColumnName("sScheduleJobCandidateGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInActive).HasColumnName("bInActive");

                entity.Property(e => e.BIsConversion).HasColumnName("bIsConversion");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime");

                entity.Property(e => e.IForgeStep).HasColumnName("iForgeStep");

                entity.Property(e => e.INumPieces).HasColumnName("iNumPieces");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SForgeGroup).HasColumnName("sForgeGroup");

                entity.Property(e => e.SJobNumber)
                    .IsRequired()
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SList)
                    .HasColumnName("sList")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SNonConformingMaterial)
                    .HasColumnName("sNonConformingMaterial")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SOperationNum)
                    .HasColumnName("sOperationNum")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TScheduleJobHistory>(entity =>
            {
                entity.HasKey(e => e.SScheduleJobHistoryGuid);

                entity.ToTable("tScheduleJobHistory");

                entity.Property(e => e.SScheduleJobHistoryGuid)
                    .HasColumnName("sScheduleJobHistoryGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsConversion)
                    .HasColumnName("bIsConversion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCrossSection)
                    .HasColumnName("dblCrossSection")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.DblMinutesPerPiece)
                    .HasColumnName("dblMinutesPerPiece")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastUsed)
                    .HasColumnName("dtLastUsed")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IStep).HasColumnName("iStep");

                entity.Property(e => e.ITemperature).HasColumnName("iTemperature");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumber)
                    .IsRequired()
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SMetalName)
                    .HasColumnName("sMetalName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SOperationSummary)
                    .IsRequired()
                    .HasColumnName("sOperationSummary")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SShapeSizeKey)
                    .HasColumnName("sShapeSizeKey")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TScheduleJobOpenTraveler>(entity =>
            {
                entity.HasKey(e => e.SOpenTravelerGuid);

                entity.ToTable("tScheduleJobOpenTraveler");

                entity.HasIndex(e => new { e.SJobNumber, e.IStepNumber })
                    .HasName("IX_JobNumber_StepNumber");

                entity.Property(e => e.SOpenTravelerGuid)
                    .HasColumnName("sOpenTravelerGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMachineHoursEstimated)
                    .HasColumnName("dblMachineHoursEstimated")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtComplete)
                    .HasColumnName("dtComplete")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime");

                entity.Property(e => e.IStepNumber).HasColumnName("iStepNumber");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescLine)
                    .HasColumnName("sDescLine")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SDescLine1Only)
                    .HasColumnName("sDescLine1Only")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SOperationNum)
                    .HasColumnName("sOperationNum")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SStatus)
                    .HasColumnName("sStatus")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TScheduleJobPlan>(entity =>
            {
                entity.HasKey(e => e.SPlanGuid);

                entity.ToTable("tScheduleJobPlan");

                entity.Property(e => e.SPlanGuid)
                    .HasColumnName("sPlanGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BCrossSectionBeforeUpdated)
                    .HasColumnName("bCrossSectionBeforeUpdated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BDescriptionUpdated).HasColumnName("bDescriptionUpdated");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsConversion).HasColumnName("bIsConversion");

                entity.Property(e => e.BIsRework).HasColumnName("bIsRework");

                entity.Property(e => e.BLocked).HasColumnName("bLocked");

                entity.Property(e => e.BMetalUpdated)
                    .HasColumnName("bMetalUpdated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BTemperatureUpdated)
                    .HasColumnName("bTemperatureUpdated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BTimespanUpdated)
                    .HasColumnName("bTimespanUpdated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DblCrossSectionBefore)
                    .HasColumnName("dblCrossSectionBefore")
                    .HasColumnType("decimal(6, 3)");

                entity.Property(e => e.DblForgeTimePerItem)
                    .HasColumnName("dblForgeTimePerItem")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEnd)
                    .HasColumnName("dtEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtForgeEnd)
                    .HasColumnName("dtForgeEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtForgeEndPushedBack)
                    .HasColumnName("dtForgeEndPushedBack")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPreFurnace)
                    .HasColumnName("dtPreFurnace")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dtStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IBlue)
                    .HasColumnName("iBlue")
                    .HasDefaultValueSql("((255))");

                entity.Property(e => e.IForgeStep).HasColumnName("iForgeStep");

                entity.Property(e => e.IGreen)
                    .HasColumnName("iGreen")
                    .HasDefaultValueSql("((255))");

                entity.Property(e => e.IItemCount).HasColumnName("iItemCount");

                entity.Property(e => e.IRed)
                    .HasColumnName("iRed")
                    .HasDefaultValueSql("((255))");

                entity.Property(e => e.IResourceId).HasColumnName("iResourceID");

                entity.Property(e => e.ITemperature).HasColumnName("iTemperature");

                entity.Property(e => e.IType)
                    .HasColumnName("iType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IUniqueId)
                    .HasColumnName("iUniqueID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription).HasColumnName("sDescription");

                entity.Property(e => e.SForgeGroup).HasColumnName("sForgeGroup");

                entity.Property(e => e.SMetal).HasColumnName("sMetal");

                entity.Property(e => e.SOperationSummary)
                    .HasColumnName("sOperationSummary")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SResourceIds).HasColumnName("sResourceIDs");

                entity.Property(e => e.SScheduleSymbol)
                    .HasColumnName("sScheduleSymbol")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SShapeSizeKey)
                    .HasColumnName("sShapeSizeKey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SSubject)
                    .HasColumnName("sSubject")
                    .HasMaxLength(50);

                entity.Property(e => e.STravelerDescriptionLine1).HasColumnName("sTravelerDescriptionLine1");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TScheduleJobPlanReason>(entity =>
            {
                entity.HasKey(e => e.SSchedulePlanReasonGuid);

                entity.ToTable("tScheduleJobPlanReason");

                entity.Property(e => e.SSchedulePlanReasonGuid)
                    .HasColumnName("sSchedulePlanReasonGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAction).HasColumnName("sAction");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPlanGuid).HasColumnName("sPlanGUID");

                entity.Property(e => e.SReason).HasColumnName("sReason");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TScheduleJobPreFurnace>(entity =>
            {
                entity.HasKey(e => e.SPreFurnaceDateGuid);

                entity.ToTable("tScheduleJobPreFurnace");

                entity.Property(e => e.SPreFurnaceDateGuid)
                    .HasColumnName("sPreFurnaceDateGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblBeforeCrossSection)
                    .HasColumnName("dblBeforeCrossSection")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.DblTotalForgeTimeInHours)
                    .HasColumnName("dblTotalForgeTimeInHours")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtMajorPreFurnace)
                    .HasColumnName("dtMajorPreFurnace")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IForgeStep).HasColumnName("iForgeStep");

                entity.Property(e => e.IMajorPreFurnace).HasColumnName("iMajorPreFurnace");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SBeforeSizeDescLine)
                    .HasColumnName("sBeforeSizeDescLine")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SForgeGroup).HasColumnName("sForgeGroup");

                entity.Property(e => e.SJobNumber)
                    .IsRequired()
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SOperationNum)
                    .HasColumnName("sOperationNum")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.STravelerDescriptionLine1)
                    .HasColumnName("sTravelerDescriptionLine1")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TScheduleJobResource>(entity =>
            {
                entity.HasKey(e => e.SResourceGuid);

                entity.ToTable("tScheduleJobResource");

                entity.Property(e => e.SResourceGuid)
                    .HasColumnName("sResourceGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BImage)
                    .HasColumnName("bImage")
                    .HasColumnType("image");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IColor).HasColumnName("iColor");

                entity.Property(e => e.IResourceId).HasColumnName("iResourceID");

                entity.Property(e => e.IUniqueId)
                    .HasColumnName("iUniqueID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomField1).HasColumnName("sCustomField1");

                entity.Property(e => e.SResourceName)
                    .HasColumnName("sResourceName")
                    .HasMaxLength(50);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TScheduleManager>(entity =>
            {
                entity.HasKey(e => e.SScheduleManagerGuid);

                entity.ToTable("tScheduleManager");

                entity.Property(e => e.SScheduleManagerGuid)
                    .HasColumnName("sScheduleManagerGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDaysInWeek).HasColumnName("iDaysInWeek");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SScheduleBreak1Guid).HasColumnName("sScheduleBreak1GUID");

                entity.Property(e => e.SScheduleBreak2Guid).HasColumnName("sScheduleBreak2GUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSearchFavorite>(entity =>
            {
                entity.HasKey(e => e.SSearchGuid)
                    .IsClustered(false);

                entity.ToTable("tSearchFavorite");

                entity.HasIndex(e => e.SSearchGuid)
                    .HasName("ix_sSearchGUID");

                entity.Property(e => e.SSearchGuid)
                    .HasColumnName("sSearchGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BAppearsInLhside).HasColumnName("bAppearsInLHSide");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BIsSystemDefault).HasColumnName("bIsSystemDefault");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SCriteriaString)
                    .HasColumnName("sCriteriaString")
                    .HasColumnType("text");

                entity.Property(e => e.SGroupGuid).HasColumnName("sGroupGUID");

                entity.Property(e => e.SName)
                    .HasColumnName("sName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SScreenObjectGuid).HasColumnName("sScreenObjectGUID");

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.Property(e => e.SViewDefinition)
                    .HasColumnName("sViewDefinition")
                    .HasColumnType("text");

                entity.Property(e => e.SVisibleColumns)
                    .HasColumnName("sVisibleColumns")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TSecGroup>(entity =>
            {
                entity.HasKey(e => e.SGroupGuid)
                    .IsClustered(false);

                entity.ToTable("tSecGroup");

                entity.HasIndex(e => e.DtAdded);

                entity.HasIndex(e => e.DtUpdated);

                entity.HasIndex(e => e.ISortOrder);

                entity.HasIndex(e => e.SDesc);

                entity.HasIndex(e => e.SGroupGuid)
                    .HasName("ix_sGroupGUID");

                entity.HasIndex(e => e.SUpdatedByUser);

                entity.Property(e => e.SGroupGuid)
                    .HasColumnName("sGroupGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BSystemGroup).HasColumnName("bSystemGroup");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSecGroupToObject>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid)
                    .IsClustered(false);

                entity.ToTable("tSecGroupToObject");

                entity.HasIndex(e => e.DtAdded);

                entity.HasIndex(e => e.DtUpdated);

                entity.HasIndex(e => e.IAccessLevel);

                entity.HasIndex(e => e.SGroupGuid);

                entity.HasIndex(e => e.SLinkGuid)
                    .HasName("ix_sLinkGUID");

                entity.HasIndex(e => e.SObjectGuid);

                entity.HasIndex(e => e.SUpdatedByUser);

                entity.HasIndex(e => e.SUserGuid);

                entity.HasIndex(e => new { e.SUserGuid, e.SObjectGuid })
                    .HasName("tSecGroupToObject_sUserGUID_sObjectGUID");

                entity.HasIndex(e => new { e.SGroupGuid, e.SObjectGuid, e.IAccessLevel })
                    .HasName("tSecGroupToObject_sGroupGUID_sObjectGUID_iAccessLevel");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAccessLevel)
                    .HasColumnName("iAccessLevel")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SGroupGuid).HasColumnName("sGroupGUID");

                entity.Property(e => e.SObjectGuid).HasColumnName("sObjectGUID");

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SGroupGu)
                    .WithMany(p => p.TSecGroupToObject)
                    .HasForeignKey(d => d.SGroupGuid)
                    .HasConstraintName("FK_tSecGroupToObject_tSecGroup");

                entity.HasOne(d => d.SObjectGu)
                    .WithMany(p => p.TSecGroupToObject)
                    .HasForeignKey(d => d.SObjectGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSecGroupToObject_tSecObjects");
            });

            modelBuilder.Entity<TSecObject>(entity =>
            {
                entity.HasKey(e => e.SObjectGuid)
                    .IsClustered(false);

                entity.ToTable("tSecObject");

                entity.HasIndex(e => e.SNavBarKey)
                    .HasName("ix_Unique_NavBarKey")
                    .IsUnique();

                entity.HasIndex(e => e.SObjectGuid)
                    .HasName("ix_sObjectGUID");

                entity.HasIndex(e => e.SType)
                    .HasName("ix_tSecObjects_sType");

                entity.HasIndex(e => new { e.SType, e.SScreenName })
                    .HasName("ix_tSecObjects_sType_sScreenName");

                entity.HasIndex(e => new { e.SType, e.SScreenName, e.INavButtonColumn, e.ISortOrder })
                    .HasName("ix_tSecObjects_sType_sScreenName_iNavButtonColumn_iSortOrder");

                entity.Property(e => e.SObjectGuid)
                    .HasColumnName("sObjectGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BHideFromTreeView).HasColumnName("bHideFromTreeView");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsWeb).HasColumnName("bIsWeb");

                entity.Property(e => e.BIsWindows).HasColumnName("bIsWindows");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BVisibleToAdminOnly).HasColumnName("bVisibleToAdminOnly");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.INavButtonColumn)
                    .HasColumnName("iNavButtonColumn")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SControlName)
                    .HasColumnName("sControlName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SFormHref)
                    .HasColumnName("sFormHRef")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SFormName)
                    .HasColumnName("sFormName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SGridColumnName)
                    .HasColumnName("sGridColumnName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SHelpHref)
                    .HasColumnName("sHelpHRef")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SLineage)
                    .HasColumnName("sLineage")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SLineageSort)
                    .HasColumnName("sLineageSort")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SMenuName)
                    .HasColumnName("sMenuName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SMenuText)
                    .HasColumnName("sMenuText")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SNavBarExtDesc)
                    .HasColumnName("sNavBarExtDesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SNavBarImage)
                    .HasColumnName("sNavBarImage")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SNavBarKey)
                    .HasColumnName("sNavBarKey")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SNavBarText)
                    .HasColumnName("sNavBarText")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SNavBarTextColor)
                    .HasColumnName("sNavBarTextColor")
                    .HasMaxLength(10);

                entity.Property(e => e.SNavBarTextDesc)
                    .HasColumnName("sNavBarTextDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SNavBarTextDescColor)
                    .HasColumnName("sNavBarTextDescColor")
                    .HasMaxLength(10);

                entity.Property(e => e.SParentObjectGuid).HasColumnName("sParentObjectGUID");

                entity.Property(e => e.SScreenName)
                    .HasColumnName("sScreenName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SScreenText)
                    .HasColumnName("sScreenText")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SToolTip)
                    .HasColumnName("sToolTip")
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.SType)
                    .HasColumnName("sType")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SWebUrl)
                    .HasColumnName("sWebURL")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSecurityCameraLog>(entity =>
            {
                entity.HasKey(e => e.SLogGuid);

                entity.ToTable("tSecurityCameraLog");

                entity.Property(e => e.SLogGuid)
                    .HasColumnName("sLogGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtEntered)
                    .HasColumnName("dtEntered")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSecurityCameraLogDetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tSecurityCameraLogDetail");

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BAudioOption).HasColumnName("bAudioOption");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsOnline).HasColumnName("bIsOnline");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BStorageAttached).HasColumnName("bStorageAttached");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtTimeOnCamera)
                    .HasColumnName("dtTimeOnCamera")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IFlags).HasColumnName("iFlags");

                entity.Property(e => e.IImageHeight).HasColumnName("iImageHeight");

                entity.Property(e => e.IImageWidth).HasColumnName("iImageWidth");

                entity.Property(e => e.ITimeZoneOffset).HasColumnName("iTimeZoneOffset");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAspectRatio)
                    .HasColumnName("sAspectRatio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAttachmentGuid).HasColumnName("sAttachmentGUID");

                entity.Property(e => e.SCameraIp)
                    .HasColumnName("sCameraIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCameraName)
                    .HasColumnName("sCameraName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SDeviceType)
                    .HasColumnName("sDeviceType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SFirmwareVersion)
                    .HasColumnName("sFirmwareVersion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SFirmwareVersionCamera)
                    .HasColumnName("sFirmwareVersionCamera")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SInitiatorName)
                    .HasColumnName("sInitiatorName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SLogGuid).HasColumnName("sLogGUID");

                entity.Property(e => e.SMacaddress)
                    .HasColumnName("sMACAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SSerialNumber)
                    .HasColumnName("sSerialNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SStream1)
                    .HasColumnName("sStream1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SStream2)
                    .HasColumnName("sStream2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.STemperature)
                    .HasColumnName("sTemperature")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SLogGu)
                    .WithMany(p => p.TSecurityCameraLogDetail)
                    .HasForeignKey(d => d.SLogGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSecurityCameraLogDetail_tSecurityCameraLog");
            });

            modelBuilder.Entity<TSecUserToGroup>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid)
                    .IsClustered(false);

                entity.ToTable("tSecUserToGroup");

                entity.HasIndex(e => e.SGroupGuid);

                entity.HasIndex(e => e.SLinkGuid)
                    .HasName("ix_sLinkGUID");

                entity.HasIndex(e => e.SUserGuid);

                entity.HasIndex(e => new { e.SGroupGuid, e.SUserGuid })
                    .HasName("tSecUserToGroup_sGroupGUID_sUserGUID");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SGroupGuid).HasColumnName("sGroupGUID");

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SGroupGu)
                    .WithMany(p => p.TSecUserToGroup)
                    .HasForeignKey(d => d.SGroupGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSecUserToGroup_tSecGroup");

                entity.HasOne(d => d.SUserGu)
                    .WithMany(p => p.TSecUserToGroup)
                    .HasForeignKey(d => d.SUserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSecUserToGroup_tUser");
            });

            modelBuilder.Entity<TSerialNumber>(entity =>
            {
                entity.HasKey(e => e.ISerialNumberId);

                entity.ToTable("tSerialNumber");

                entity.Property(e => e.ISerialNumberId).HasColumnName("iSerialNumberID");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsWymanGordon)
                    .HasColumnName("bIsWymanGordon")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCustomerPartNumber)
                    .HasColumnName("sCustomerPartNumber")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SFullSerialNumber)
                    .IsRequired()
                    .HasColumnName("sFullSerialNumber")
                    .HasMaxLength(42)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(([sPrefix]+[sSerialNumber])+[sSuffix])");

                entity.Property(e => e.SJobNumberMaster)
                    .IsRequired()
                    .HasColumnName("sJobNumberMaster")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumberPreceding)
                    .HasColumnName("sJobNumberPreceding")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumberSequence)
                    .IsRequired()
                    .HasColumnName("sJobNumberSequence")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SPartnerSerialNumber)
                    .HasColumnName("sPartnerSerialNumber")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SPrefix)
                    .IsRequired()
                    .HasColumnName("sPrefix")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SSerialNumber)
                    .IsRequired()
                    .HasColumnName("sSerialNumber")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.SSuffix)
                    .IsRequired()
                    .HasColumnName("sSuffix")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSession>(entity =>
            {
                entity.HasKey(e => e.SSessionGuid);

                entity.ToTable("tSession");

                entity.HasIndex(e => e.SSessionKey)
                    .HasName("ix_SessionKey");

                entity.Property(e => e.SSessionGuid)
                    .HasColumnName("sSessionGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BExpired).HasColumnName("bExpired");

                entity.Property(e => e.DtCreated)
                    .HasColumnName("dtCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastActivity)
                    .HasColumnName("dtLastActivity")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SSessionKey)
                    .IsRequired()
                    .HasColumnName("sSessionKey")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");
            });

            modelBuilder.Entity<TSiemensFurnace>(entity =>
            {
                entity.HasKey(e => e.SSiemensFurnaceGuid);

                entity.ToTable("tSiemensFurnace");

                entity.Property(e => e.SSiemensFurnaceGuid)
                    .HasColumnName("sSiemensFurnaceGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsForHeatTreat).HasColumnName("bIsForHeatTreat");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDatabaseName)
                    .IsRequired()
                    .HasColumnName("sDatabaseName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDbinstanceName)
                    .HasColumnName("sDBInstanceName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDbuserName)
                    .IsRequired()
                    .HasColumnName("sDBUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDbuserPassword)
                    .IsRequired()
                    .HasColumnName("sDBUserPassword")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SFurnaceName)
                    .IsRequired()
                    .HasColumnName("sFurnaceName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SIpaddress)
                    .IsRequired()
                    .HasColumnName("sIPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSiemensHost>(entity =>
            {
                entity.HasKey(e => e.SHostGuid);

                entity.ToTable("tSiemensHost");

                entity.Property(e => e.SHostGuid)
                    .HasColumnName("sHostGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SComment)
                    .HasColumnName("sComment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SHostName)
                    .IsRequired()
                    .HasColumnName("sHostName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SIpaddress)
                    .IsRequired()
                    .HasColumnName("sIPAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSiemensSecGroup>(entity =>
            {
                entity.HasKey(e => e.SGroupGuid);

                entity.ToTable("tSiemensSecGroup");

                entity.Property(e => e.SGroupGuid)
                    .HasColumnName("sGroupGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BSystemGroup).HasColumnName("bSystemGroup");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SDesc)
                    .HasColumnName("sDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSiemensSecGroupToObject>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tSiemensSecGroupToObject");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAccessLevel)
                    .HasColumnName("iAccessLevel")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SGroupGuid).HasColumnName("sGroupGUID");

                entity.Property(e => e.SObjectGuid).HasColumnName("sObjectGUID");

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SGroupGu)
                    .WithMany(p => p.TSiemensSecGroupToObject)
                    .HasForeignKey(d => d.SGroupGuid)
                    .HasConstraintName("FK_tSiemensSecGroupToObject_tSiemensSecGroup");

                entity.HasOne(d => d.SObjectGu)
                    .WithMany(p => p.TSiemensSecGroupToObject)
                    .HasForeignKey(d => d.SObjectGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSiemensSecGroupToObject_tSiemensSecObject");
            });

            modelBuilder.Entity<TSiemensSecObject>(entity =>
            {
                entity.HasKey(e => e.SObjectGuid);

                entity.ToTable("tSiemensSecObject");

                entity.Property(e => e.SObjectGuid)
                    .HasColumnName("sObjectGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SControlName)
                    .HasColumnName("sControlName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SLineage)
                    .HasColumnName("sLineage")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SLineageSort)
                    .HasColumnName("sLineageSort")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SNavBarKey)
                    .IsRequired()
                    .HasColumnName("sNavBarKey")
                    .HasMaxLength(602)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(((isnull([sScreenKey],'')+'_')+(isnull([sScreenName],'')+'_'))+isnull([sControlName],''))");

                entity.Property(e => e.SParentObjectGuid).HasColumnName("sParentObjectGUID");

                entity.Property(e => e.SScreenKey)
                    .HasColumnName("sScreenKey")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SScreenName)
                    .HasColumnName("sScreenName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SType)
                    .HasColumnName("sType")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSiemensSecUserToGroup>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tSiemensSecUserToGroup");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SGroupGuid).HasColumnName("sGroupGUID");

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SGroupGu)
                    .WithMany(p => p.TSiemensSecUserToGroup)
                    .HasForeignKey(d => d.SGroupGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSiemensSecUserToGroup_tSiemensSecGroup");

                entity.HasOne(d => d.SUserGu)
                    .WithMany(p => p.TSiemensSecUserToGroup)
                    .HasForeignKey(d => d.SUserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tSiemensSecUserToGroup_tSiemensUser");
            });

            modelBuilder.Entity<TSiemensUser>(entity =>
            {
                entity.HasKey(e => e.SUserGuid);

                entity.ToTable("tSiemensUser");

                entity.Property(e => e.SUserGuid)
                    .HasColumnName("sUserGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastLogin)
                    .HasColumnName("dtLastLogin")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IAccessControlEmpId).HasColumnName("iAccessControlEmpID");

                entity.Property(e => e.ILoginAttempts).HasColumnName("iLoginAttempts");

                entity.Property(e => e.SEmployeeName)
                    .IsRequired()
                    .HasColumnName("sEmployeeName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SPassword)
                    .IsRequired()
                    .HasColumnName("sPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserName)
                    .IsRequired()
                    .HasColumnName("sUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSiemensUserBadge>(entity =>
            {
                entity.HasKey(e => e.SBadgeGuid);

                entity.ToTable("tSiemensUserBadge");

                entity.Property(e => e.SBadgeGuid)
                    .HasColumnName("sBadgeGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IBadgeNumber).HasColumnName("iBadgeNumber");

                entity.Property(e => e.SAddedByUser)
                    .HasColumnName("sAddedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");
            });

            modelBuilder.Entity<TState>(entity =>
            {
                entity.HasKey(e => e.SStateGuid);

                entity.ToTable("tState");

                entity.Property(e => e.SStateGuid)
                    .HasColumnName("sStateGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblTaxRate)
                    .HasColumnName("dblTaxRate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCountryGuid).HasColumnName("sCountryGUID");

                entity.Property(e => e.SStateCode)
                    .IsRequired()
                    .HasColumnName("sStateCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SStateName)
                    .IsRequired()
                    .HasColumnName("sStateName")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSystemSetting>(entity =>
            {
                entity.HasKey(e => e.SSettingGuid)
                    .IsClustered(false);

                entity.ToTable("tSystemSetting");

                entity.HasIndex(e => e.SSettingType)
                    .HasName("ix_SettingType");

                entity.HasIndex(e => new { e.SCategory, e.SKey })
                    .HasName("ix_ClusteredCategoryKey")
                    .IsClustered();

                entity.Property(e => e.SSettingGuid)
                    .HasColumnName("sSettingGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BDefault).HasColumnName("bDefault");

                entity.Property(e => e.BDefaultBooleanValue).HasColumnName("bDefaultBooleanValue");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblDefaultNumericValue)
                    .HasColumnName("dblDefaultNumericValue")
                    .HasColumnType("numeric(18, 9)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDefaultIntegerValue).HasColumnName("iDefaultIntegerValue");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.ImgDefaultImageValue)
                    .HasColumnName("imgDefaultImageValue")
                    .HasColumnType("image");

                entity.Property(e => e.SCategory)
                    .HasColumnName("sCategory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDefaultStringValue)
                    .HasColumnName("sDefaultStringValue")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SDefaultStringValueDesc)
                    .HasColumnName("sDefaultStringValueDesc")
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.SDefaultTextValue)
                    .HasColumnName("sDefaultTextValue")
                    .HasColumnType("text");

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SParentSettingGuid).HasColumnName("sParentSettingGUID");

                entity.Property(e => e.SProgrammerComments)
                    .HasColumnName("sProgrammerComments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SSettingType)
                    .HasColumnName("sSettingType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TTravelerLine>(entity =>
            {
                entity.HasKey(e => e.ITravId);

                entity.ToTable("tTravelerLine");

                entity.HasIndex(e => e.SJobNumber)
                    .HasName("IX_JobNumber");

                entity.HasIndex(e => new { e.SJobNumber, e.DtLastDailyProduction })
                    .HasName("IX_dtLastDailyProduction");

                entity.HasIndex(e => new { e.SJobNumber, e.SStepNum })
                    .HasName("IX_JobNumber_StepNum");

                entity.Property(e => e.ITravId).HasColumnName("iTravID");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.CurCostActual)
                    .HasColumnName("curCostActual")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.CurCostEstimated)
                    .HasColumnName("curCostEstimated")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMachineHoursActual)
                    .HasColumnName("dblMachineHoursActual")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMachineHoursEstimated)
                    .HasColumnName("dblMachineHoursEstimated")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCalculatedDueDate)
                    .HasColumnName("dtCalculatedDueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLastDailyProduction)
                    .HasColumnName("dtLastDailyProduction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IPiecesActual).HasColumnName("iPiecesActual");

                entity.Property(e => e.IPiecesEstimated).HasColumnName("iPiecesEstimated");

                entity.Property(e => e.IScheduledDays).HasColumnName("iScheduledDays");

                entity.Property(e => e.SBlankSpace)
                    .HasColumnName("sBlankSpace")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDescLine1)
                    .HasColumnName("sDescLine1")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SDescLine2)
                    .HasColumnName("sDescLine2")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMachineCode)
                    .HasColumnName("sMachineCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperationNum)
                    .HasColumnName("sOperationNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SStatus)
                    .HasColumnName("sStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SStepNum)
                    .HasColumnName("sStepNum")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TTravelerLogDetail>(entity =>
            {
                entity.HasKey(e => e.STravLogDetailId);

                entity.ToTable("tTravelerLogDetail");

                entity.Property(e => e.STravLogDetailId)
                    .HasColumnName("sTravLogDetailID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BDyePenUsed)
                    .HasColumnName("bDyePenUsed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BInProgress).HasColumnName("bInProgress");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRework).HasColumnName("bRework");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblMeterFinishRead)
                    .HasColumnName("dblMeterFinishRead")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DblMeterStartRead)
                    .HasColumnName("dblMeterStartRead")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtCompletion)
                    .HasColumnName("dtCompletion")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStartTime)
                    .HasColumnName("dtStartTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStopTime)
                    .HasColumnName("dtStopTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IFinisherBadgeId).HasColumnName("iFinisherBadgeID");

                entity.Property(e => e.IJobNumberCardId).HasColumnName("iJobNumberCardID");

                entity.Property(e => e.ISerialNumberCardId).HasColumnName("iSerialNumberCardID");

                entity.Property(e => e.IStarterBadgeId).HasColumnName("iStarterBadgeID");

                entity.Property(e => e.IStepNumber).HasColumnName("iStepNumber");

                entity.Property(e => e.IStepShopRoutingRecord).HasColumnName("iStepShopRoutingRecord");

                entity.Property(e => e.IWarehouseId).HasColumnName("iWarehouseID");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SComments)
                    .HasColumnName("sComments")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SMachine)
                    .IsRequired()
                    .HasColumnName("sMachine")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SReason)
                    .HasColumnName("sReason")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SSerialNumber)
                    .IsRequired()
                    .HasColumnName("sSerialNumber")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SShift)
                    .IsRequired()
                    .HasColumnName("sShift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STravLogMasterId).HasColumnName("sTravLogMasterID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.STravLogMaster)
                    .WithMany(p => p.TTravelerLogDetail)
                    .HasForeignKey(d => d.STravLogMasterId)
                    .HasConstraintName("FK_tTravelerLogDetail_tTravelerLogMaster");
            });

            modelBuilder.Entity<TTravelerLogMaster>(entity =>
            {
                entity.HasKey(e => e.STravLogMasterId);

                entity.ToTable("tTravelerLogMaster");

                entity.Property(e => e.STravLogMasterId)
                    .HasColumnName("sTravLogMasterID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BComplete).HasColumnName("bComplete");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblHoursActual)
                    .HasColumnName("dblHoursActual")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblHoursExpected)
                    .HasColumnName("dblHoursExpected")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblQuantityActual)
                    .HasColumnName("dblQuantityActual")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblQuantityExpected)
                    .HasColumnName("dblQuantityExpected")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastDailyProduction)
                    .HasColumnName("dtLastDailyProduction")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IStepNumber).HasColumnName("iStepNumber");

                entity.Property(e => e.IStepShopRoutingRecord).HasColumnName("iStepShopRoutingRecord");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCardId)
                    .HasColumnName("sCardId")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SComment)
                    .HasColumnName("sComment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SDepartment)
                    .HasColumnName("sDepartment")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SJobNumber)
                    .HasColumnName("sJobNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOperation)
                    .HasColumnName("sOperation")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TTravelerOperation>(entity =>
            {
                entity.HasKey(e => e.IMstmopnid);

                entity.ToTable("tTravelerOperation");

                entity.HasIndex(e => e.SOpCode)
                    .HasName("IX_Operation");

                entity.Property(e => e.IMstmopnid).HasColumnName("iMSTMOPNID");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCapacityHours)
                    .HasColumnName("dblCapacityHours")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblConvCapacityPerCwt)
                    .HasColumnName("dblConvCapacityPerCWT")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDefaultScheduledDays)
                    .HasColumnName("dblDefaultScheduledDays")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMtdcostActual)
                    .HasColumnName("dblMTDCostActual")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMtdcostEstimated)
                    .HasColumnName("dblMTDCostEstimated")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMtdhoursActual)
                    .HasColumnName("dblMTDHoursActual")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMtdhoursEstimated)
                    .HasColumnName("dblMTDHoursEstimated")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblOverCapacityHours)
                    .HasColumnName("dblOverCapacityHours")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblScheduledHours)
                    .HasColumnName("dblScheduledHours")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblYtdcostActual)
                    .HasColumnName("dblYTDCostActual")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblYtdcostEstimated)
                    .HasColumnName("dblYTDCostEstimated")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblYtdhoursActual)
                    .HasColumnName("dblYTDHoursActual")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblYtdhoursEstimated)
                    .HasColumnName("dblYTDHoursEstimated")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SDeptName)
                    .HasColumnName("sDeptName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc1)
                    .HasColumnName("sDesc1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SDesc2)
                    .HasColumnName("sDesc2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SMachine)
                    .HasColumnName("sMachine")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SOpCode)
                    .HasColumnName("sOpCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.HasKey(e => e.SUserGuid)
                    .IsClustered(false);

                entity.ToTable("tUser");

                entity.HasIndex(e => e.SUserGuid)
                    .HasName("ix_sUserGUID");

                entity.HasIndex(e => new { e.SUserName, e.BInactive })
                    .HasName("uc_tUser_sUserName_bInactive")
                    .IsUnique();

                entity.HasIndex(e => new { e.SUserName, e.SPassword })
                    .HasName("ix_tUser_sUserName_sPassword");

                entity.Property(e => e.SUserGuid)
                    .HasColumnName("sUserGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsUpdatingUser).HasColumnName("bIsUpdatingUser");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtLastLogin)
                    .HasColumnName("dtLastLogin")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ILoginAttempts).HasColumnName("iLoginAttempts");

                entity.Property(e => e.SEmployeeGuid).HasColumnName("sEmployeeGUID");

                entity.Property(e => e.SLastOpenSection)
                    .HasColumnName("sLastOpenSection")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPassword)
                    .IsRequired()
                    .HasColumnName("sPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SPinNum)
                    .HasColumnName("sPinNum")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserName)
                    .IsRequired()
                    .HasColumnName("sUserName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SEmployeeGu)
                    .WithMany(p => p.TUser)
                    .HasForeignKey(d => d.SEmployeeGuid)
                    .HasConstraintName("FK_tUser_tEmployee");
            });

            modelBuilder.Entity<TUserBadge>(entity =>
            {
                entity.HasKey(e => e.SBadgeGuid);

                entity.ToTable("tUserBadge");

                entity.Property(e => e.SBadgeGuid)
                    .HasColumnName("sBadgeGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BLeadman).HasColumnName("bLeadman");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BSupervisor).HasColumnName("bSupervisor");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IBadgeNum).HasColumnName("iBadgeNum");

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.HasOne(d => d.SUserGu)
                    .WithMany(p => p.TUserBadge)
                    .HasForeignKey(d => d.SUserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tUserBadge_tEmployee");
            });

            modelBuilder.Entity<TUserExtendedProperty>(entity =>
            {
                entity.HasKey(e => e.SPropGuid)
                    .IsClustered(false);

                entity.ToTable("tUserExtendedProperty");

                entity.HasIndex(e => e.SPropGuid)
                    .HasName("ix_sPropGUID");

                entity.Property(e => e.SPropGuid)
                    .HasColumnName("sPropGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.BValue).HasColumnName("bValue");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IValue).HasColumnName("iValue");

                entity.Property(e => e.ImgValue)
                    .HasColumnName("imgValue")
                    .HasColumnType("image");

                entity.Property(e => e.SPropName)
                    .HasColumnName("sPropName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUser)
                    .HasColumnName("sUpdatedByUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.Property(e => e.SValue)
                    .HasColumnName("sValue")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SValueText)
                    .HasColumnName("sValueText")
                    .HasColumnType("text");

                entity.HasOne(d => d.SUserGu)
                    .WithMany(p => p.TUserExtendedProperty)
                    .HasForeignKey(d => d.SUserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tUserExtendedProperties_tUser");
            });

            modelBuilder.Entity<TVardetail>(entity =>
            {
                entity.HasKey(e => e.SDetailGuid);

                entity.ToTable("tVARDetail");

                entity.HasIndex(e => e.DtAdded)
                    .HasName("IX_DateAdded");

                entity.HasIndex(e => e.SMasterGuid);

                entity.Property(e => e.SDetailGuid)
                    .HasColumnName("sDetailGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblBaseSpeed)
                    .HasColumnName("dblBaseSpeed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblBlower1024Speed)
                    .HasColumnName("dblBlower1024Speed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblBlower615Speed)
                    .HasColumnName("dblBlower615Speed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblBlowerInletPressure)
                    .HasColumnName("dblBlowerInletPressure")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblBlowerPressure)
                    .HasColumnName("dblBlowerPressure")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblChamberPressure)
                    .HasColumnName("dblChamberPressure")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblChamberPressureLv)
                    .HasColumnName("dblChamberPressureLV")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCoolingGasSetpoint)
                    .HasColumnName("dblCoolingGasSetpoint")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCoolingPressure)
                    .HasColumnName("dblCoolingPressure")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCrucible1Flow)
                    .HasColumnName("dblCrucible1Flow")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCrucible1Temp)
                    .HasColumnName("dblCrucible1Temp")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCrucible1Wv1position)
                    .HasColumnName("dblCrucible1WV1Position")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCrucible2Flow)
                    .HasColumnName("dblCrucible2Flow")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCrucible2Temp)
                    .HasColumnName("dblCrucible2Temp")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCrucible2Wv2position)
                    .HasColumnName("dblCrucible2WV2Position")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCurrentSetpoint)
                    .HasColumnName("dblCurrentSetpoint")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDripshort)
                    .HasColumnName("dblDripshort")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDripshortSetpoint)
                    .HasColumnName("dblDripshortSetpoint")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDripshortTime)
                    .HasColumnName("dblDripshortTime")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDrivespeedSetpoint)
                    .HasColumnName("dblDrivespeedSetpoint")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDsdterm)
                    .HasColumnName("dblDSDTerm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDsiterm)
                    .HasColumnName("dblDSITerm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblDspterm)
                    .HasColumnName("dblDSPTerm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblElapsedTime)
                    .HasColumnName("dblElapsedTime")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblElectrodeWeight)
                    .HasColumnName("dblElectrodeWeight")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblGroundFaultCurrent)
                    .HasColumnName("dblGroundFaultCurrent")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblLargeBlowerPressure)
                    .HasColumnName("dblLargeBlowerPressure")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMechanicalPumpPressure)
                    .HasColumnName("dblMechanicalPumpPressure")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMeltRate)
                    .HasColumnName("dblMeltRate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMeltRateSetpoint)
                    .HasColumnName("dblMeltRateSetpoint")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMrdterm)
                    .HasColumnName("dblMRDTerm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMriterm)
                    .HasColumnName("dblMRITerm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMrpterm)
                    .HasColumnName("dblMRPTerm")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPhaseAcurrent)
                    .HasColumnName("dblPhaseACurrent")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPhaseBcurrent)
                    .HasColumnName("dblPhaseBCurrent")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPhaseCcurrent)
                    .HasColumnName("dblPhaseCCurrent")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblPscurrent)
                    .HasColumnName("dblPSCurrent")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblRamPosition)
                    .HasColumnName("dblRamPosition")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblRamSpeed)
                    .HasColumnName("dblRamSpeed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblSmallBlowerPressure)
                    .HasColumnName("dblSmallBlowerPressure")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblSupplyTemperature)
                    .HasColumnName("dblSupplyTemperature")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblTrimSpeed)
                    .HasColumnName("dblTrimSpeed")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblVacuumSetpoint)
                    .HasColumnName("dblVacuumSetpoint")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblVoltage)
                    .HasColumnName("dblVoltage")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblVoltageSetpoint)
                    .HasColumnName("dblVoltageSetpoint")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IId).HasColumnName("iID");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SMasterGuid).HasColumnName("sMasterGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SMasterGu)
                    .WithMany(p => p.TVardetail)
                    .HasForeignKey(d => d.SMasterGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tVARDetail_tVARMaster");
            });

            modelBuilder.Entity<TVarmaster>(entity =>
            {
                entity.HasKey(e => e.SMasterGuid);

                entity.ToTable("tVARMaster");

                entity.Property(e => e.SMasterGuid)
                    .HasColumnName("sMasterGUID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblCrucibleHighFlow)
                    .HasColumnName("dblCrucibleHighFlow")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCrucibleHighTemp)
                    .HasColumnName("dblCrucibleHighTemp")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCrucibleLowFlow)
                    .HasColumnName("dblCrucibleLowFlow")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblCrucibleLowTemp)
                    .HasColumnName("dblCrucibleLowTemp")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblIngotWeight)
                    .HasColumnName("dblIngotWeight")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInletOrSysHighTemp)
                    .HasColumnName("dblInletOrSysHighTemp")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblInletOrSysLowTemp)
                    .HasColumnName("dblInletOrSysLowTemp")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMeltAvgMeltRate)
                    .HasColumnName("dblMeltAvgMeltRate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMeltElapsedTime)
                    .HasColumnName("dblMeltElapsedTime")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblMeltEndWeight)
                    .HasColumnName("dblMeltEndWeight")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblStartWeight)
                    .HasColumnName("dblStartWeight")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblSteadyStateElapsedTime)
                    .HasColumnName("dblSteadyStateElapsedTime")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblSteadyStateEndWeight)
                    .HasColumnName("dblSteadyStateEndWeight")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblSteadyStateMeltRate)
                    .HasColumnName("dblSteadyStateMeltRate")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblSteadyStateStartWeight)
                    .HasColumnName("dblSteadyStateStartWeight")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtHotTopStart)
                    .HasColumnName("dtHotTopStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtMeltEnd)
                    .HasColumnName("dtMeltEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtPowerOffTime)
                    .HasColumnName("dtPowerOffTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtStart)
                    .HasColumnName("dtStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtSteadyStateStart)
                    .HasColumnName("dtSteadyStateStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IStationNum).HasColumnName("iStationNum");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAlloy)
                    .HasColumnName("sAlloy")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SCrucibleNum)
                    .HasColumnName("sCrucibleNum")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SElectrodeNum)
                    .HasColumnName("sElectrodeNum")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SFurnaceId)
                    .HasColumnName("sFurnaceID")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SGrade)
                    .HasColumnName("sGrade")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SHeatNum)
                    .HasColumnName("sHeatNum")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SOperatorMeltEnd)
                    .HasColumnName("sOperatorMeltEnd")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SOperatorMeltSecond)
                    .HasColumnName("sOperatorMeltSecond")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SOperatorMeltStart)
                    .HasColumnName("sOperatorMeltStart")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SOperatorMeltThird)
                    .HasColumnName("sOperatorMeltThird")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SProfileNum)
                    .HasColumnName("sProfileNum")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SStationName)
                    .HasColumnName("sStationName")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TVendor>(entity =>
            {
                entity.HasKey(e => e.SVendorGuid);

                entity.ToTable("tVendor");

                entity.HasIndex(e => e.SKey)
                    .HasName("IX_Key");

                entity.HasIndex(e => new { e.SKey, e.IDeptNum })
                    .HasName("IX_Key_DeptNum");

                entity.Property(e => e.SVendorGuid)
                    .HasColumnName("sVendorGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IDeptNum).HasColumnName("iDeptNum");

                entity.Property(e => e.SAccountNumber)
                    .HasColumnName("sAccountNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCompanyName)
                    .HasColumnName("sCompanyName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SHrshorthand)
                    .HasColumnName("sHRShorthand")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SKey)
                    .HasColumnName("sKey")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TVendorAddress>(entity =>
            {
                entity.HasKey(e => e.SAddressGuid);

                entity.ToTable("tVendorAddress");

                entity.Property(e => e.SAddressGuid)
                    .HasColumnName("sAddressGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsBilling).HasColumnName("bIsBilling");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BIsShipping).HasColumnName("bIsShipping");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress1)
                    .HasColumnName("sAddress1")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress2)
                    .HasColumnName("sAddress2")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SAddressHash)
                    .HasColumnName("sAddressHash")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SCity)
                    .HasColumnName("sCity")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SCountry)
                    .HasColumnName("sCountry")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SPostalCode)
                    .HasColumnName("sPostalCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SSingleLine)
                    .HasColumnName("sSingleLine")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComputedColumnSql("([dbo].[fnAddress_SingleLine]([sAddress1],[sAddress2],[sCity],[sState],[sPostalCode]))");

                entity.Property(e => e.SState)
                    .HasColumnName("sState")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STypeCode)
                    .HasColumnName("sTypeCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVendorGuid).HasColumnName("sVendorGUID");

                entity.HasOne(d => d.SVendorGu)
                    .WithMany(p => p.TVendorAddress)
                    .HasForeignKey(d => d.SVendorGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tVendorAddress_tVendor");
            });

            modelBuilder.Entity<TVendorContact>(entity =>
            {
                entity.HasKey(e => e.SContactGuid);

                entity.ToTable("tVendorContact");

                entity.Property(e => e.SContactGuid)
                    .HasColumnName("sContactGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEmail)
                    .HasColumnName("sEMail")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SFirstName)
                    .HasColumnName("sFirstName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SLastName)
                    .HasColumnName("sLastName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SMiddleName)
                    .HasColumnName("sMiddleName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SPositionTitle)
                    .HasColumnName("sPositionTitle")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SSuffix)
                    .HasColumnName("sSuffix")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.STitle)
                    .HasColumnName("sTitle")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVendorGuid).HasColumnName("sVendorGUID");

                entity.HasOne(d => d.SVendorGu)
                    .WithMany(p => p.TVendorContact)
                    .HasForeignKey(d => d.SVendorGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tVendorContact_tVendor");
            });

            modelBuilder.Entity<TVendorContactAddress>(entity =>
            {
                entity.HasKey(e => e.SAddressGuid);

                entity.ToTable("tVendorContactAddress");

                entity.Property(e => e.SAddressGuid)
                    .HasColumnName("sAddressGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsBilling).HasColumnName("bIsBilling");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BIsShipping).HasColumnName("bIsShipping");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress1)
                    .HasColumnName("sAddress1")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SAddress2)
                    .HasColumnName("sAddress2")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SAddressHash)
                    .HasColumnName("sAddressHash")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SCity)
                    .HasColumnName("sCity")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SContactGuid).HasColumnName("sContactGUID");

                entity.Property(e => e.SCountry)
                    .HasColumnName("sCountry")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SPostalCode)
                    .HasColumnName("sPostalCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SState)
                    .HasColumnName("sState")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STypeCode)
                    .HasColumnName("sTypeCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SContactGu)
                    .WithMany(p => p.TVendorContactAddress)
                    .HasForeignKey(d => d.SContactGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tVendorContactAddress_tVendorContact");
            });

            modelBuilder.Entity<TVendorContactPhone>(entity =>
            {
                entity.HasKey(e => e.SPhoneGuid);

                entity.ToTable("tVendorContactPhone");

                entity.Property(e => e.SPhoneGuid)
                    .HasColumnName("sPhoneGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsBilling).HasColumnName("bIsBilling");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BIsShipping).HasColumnName("bIsShipping");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SContactGuid).HasColumnName("sContactGUID");

                entity.Property(e => e.SPhoneHash)
                    .HasColumnName("sPhoneHash")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SPhoneNumber)
                    .HasColumnName("sPhoneNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STypeCode)
                    .HasColumnName("sTypeCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SContactGu)
                    .WithMany(p => p.TVendorContactPhone)
                    .HasForeignKey(d => d.SContactGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tVendorContactPhone_tVendorContact");
            });

            modelBuilder.Entity<TVendorPhone>(entity =>
            {
                entity.HasKey(e => e.SPhoneGuid);

                entity.ToTable("tVendorPhone");

                entity.Property(e => e.SPhoneGuid)
                    .HasColumnName("sPhoneGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BIsBilling).HasColumnName("bIsBilling");

                entity.Property(e => e.BIsDefault).HasColumnName("bIsDefault");

                entity.Property(e => e.BIsShipping).HasColumnName("bIsShipping");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SPhoneHash)
                    .HasColumnName("sPhoneHash")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SPhoneNumber)
                    .HasColumnName("sPhoneNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.STypeCode)
                    .HasColumnName("sTypeCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SVendorGuid).HasColumnName("sVendorGUID");

                entity.HasOne(d => d.SVendorGu)
                    .WithMany(p => p.TVendorPhone)
                    .HasForeignKey(d => d.SVendorGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tVendorPhone_tVendor");
            });

            modelBuilder.Entity<TWidget>(entity =>
            {
                entity.HasKey(e => e.SWidgetGuid);

                entity.ToTable("tWidget");

                entity.Property(e => e.SWidgetGuid)
                    .HasColumnName("sWidgetGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SCategory)
                    .IsRequired()
                    .HasColumnName("sCategory")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SControlKeyGuid).HasColumnName("sControlKeyGUID");

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SImagePath)
                    .HasColumnName("sImagePath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.STitle)
                    .IsRequired()
                    .HasColumnName("sTitle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TWidgetToUser>(entity =>
            {
                entity.HasKey(e => e.SLinkGuid);

                entity.ToTable("tWidgetToUser");

                entity.Property(e => e.SLinkGuid)
                    .HasColumnName("sLinkGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BAllowOutOfZone).HasColumnName("bAllowOutOfZone");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IRefreshIntervalInSeconds).HasColumnName("iRefreshIntervalInSeconds");

                entity.Property(e => e.ISortOrder).HasColumnName("iSortOrder");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SDockColumn)
                    .HasColumnName("sDockColumn")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SUserGuid).HasColumnName("sUserGUID");

                entity.Property(e => e.SWidgetGuid).HasColumnName("sWidgetGUID");

                entity.HasOne(d => d.SUserGu)
                    .WithMany(p => p.TWidgetToUser)
                    .HasForeignKey(d => d.SUserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tWidgetToUser_tUser");

                entity.HasOne(d => d.SWidgetGu)
                    .WithMany(p => p.TWidgetToUser)
                    .HasForeignKey(d => d.SWidgetGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tWidgetToUser_tWidget");
            });

            modelBuilder.Entity<TZendeskUserPhoto>(entity =>
            {
                entity.HasKey(e => e.SPhotoGuid);

                entity.ToTable("tZendeskUserPhoto");

                entity.Property(e => e.SPhotoGuid)
                    .HasColumnName("sPhotoGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BInactive).HasColumnName("bInactive");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SEmail)
                    .IsRequired()
                    .HasColumnName("sEMail")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SPhotoNetworkPath)
                    .IsRequired()
                    .HasColumnName("sPhotoNetworkPath")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TZipCode>(entity =>
            {
                entity.HasKey(e => e.SZipGuid);

                entity.ToTable("tZipCode");

                entity.Property(e => e.SZipGuid)
                    .HasColumnName("sZipGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BRowversion)
                    .IsRequired()
                    .HasColumnName("bRowversion")
                    .IsRowVersion();

                entity.Property(e => e.DblLatitude)
                    .HasColumnName("dblLatitude")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DblLongitude)
                    .HasColumnName("dblLongitude")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DtAdded)
                    .HasColumnName("dtAdded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DtUpdated)
                    .HasColumnName("dtUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SAddedByUserId)
                    .HasColumnName("sAddedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SStateGuid).HasColumnName("sStateGUID");

                entity.Property(e => e.SUpdatedByUserId)
                    .HasColumnName("sUpdatedByUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SZipCode)
                    .HasColumnName("sZipCode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.SStateGu)
                    .WithMany(p => p.TZipCode)
                    .HasForeignKey(d => d.SStateGuid)
                    .HasConstraintName("FK_tZipCode_tState");
            });
        }
    }
}
