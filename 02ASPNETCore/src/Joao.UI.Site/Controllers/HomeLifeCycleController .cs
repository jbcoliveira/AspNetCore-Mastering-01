using Joao.UI.Site.Data;
using Joao.UI.Site.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joao.UI.Site.Controllers
{
    public class HomeLifeCycleController : Controller
    {
        public OperacaoService OperacaoService { get; set; }
        public OperacaoService OperacaoService2 { get; set; }

        public HomeLifeCycleController(OperacaoService operacaoService, OperacaoService operacaoService2)
        {
            OperacaoService = operacaoService;
            OperacaoService2 = operacaoService2;
        }

        public string Index()
        {
            return "Primeira Instancia" + Environment.NewLine +
                OperacaoService.Transient.OperacaoId + Environment.NewLine +
                OperacaoService.Scoped.OperacaoId + Environment.NewLine +
                OperacaoService.Singleton.OperacaoId + Environment.NewLine +
                OperacaoService.SingletonInstance.OperacaoId + Environment.NewLine +

                Environment.NewLine +
                Environment.NewLine +

                "Segunda Instancia" + Environment.NewLine +
                OperacaoService2.Transient.OperacaoId + Environment.NewLine +
                OperacaoService2.Scoped.OperacaoId + Environment.NewLine +
                OperacaoService2.Singleton.OperacaoId + Environment.NewLine +
                OperacaoService2.SingletonInstance.OperacaoId + Environment.NewLine;
        }

    }
}
