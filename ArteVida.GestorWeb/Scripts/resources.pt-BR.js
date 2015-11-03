(function (trv, $) {
    "use strict";

    var sr = {
        controllerNotInitialized: 'Controlador não foi inicializado.',
        noReportInstance: 'Nenhuma instância do relatório.',
        missingTemplate: 'Template ReportViewer está faltando. Por favor, especifique o templateUrl nas opções .',
        noReport: 'Nenhum relatório.',
        noReportDocument: 'Nenhum documento de relatório.',
        invalidParameter: 'Por favor, insira um valor válido.',
        invalidDateTimeValue: 'Por favor, insira uma data válida',
        parameterIsEmpty: 'O valor do parâmetro não pode estar vazio.',
        cannotValidateType: 'Não pode validar parâmetro do tipo {type}.',
        loadingFormats: 'Carregando...',
        loadingReport: 'Carregando relatório...',
        preparingDownload: 'Preparando documento para download. por favor, aguarde...',
        preparingPrint: 'Preparando documento para impressão. por favor, aguarde...',
        errorLoadingTemplates: 'Error loading the report viewer\'s templates.',
        loadingReportPagesInProgress: '{0} páginas carregado até agora ...',
        loadedReportPagesComplete: 'Feito. Total de {0} páginas carregado.',
        noPageToDisplay: "Nenhuma página para exibir.",
        errorDeletingReportInstance: 'Error deleting report instance: {0}',
        errorRegisteringViewer: 'Error registering the viewer with the service.',
        noServiceClient: 'No serviceClient has been specified for this controller.',
        errorRegisteringClientInstance: 'Error registering client instance',
        errorCreatingReportInstance: 'Error creating report instance (Report = {0})',
        errorCreatingReportDocument: 'Error creating report document (Report = {0}; Format = {1})',
        unableToGetReportParameters: "Unable to get report parameters",       
    };

    trv.sr = $.extend(trv.sr, sr);

}(window.telerikReportViewer = window.telerikReportViewer || {}, jQuery));