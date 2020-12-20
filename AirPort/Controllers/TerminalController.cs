using Microsoft.AspNetCore.Mvc;
using System;
using AirPortDataLayer.Crud.InterFace;
using System.Collections.Generic;
using AirPort.Model.ViewModel;


namespace AirPort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TerminalController : ControllerBase
    {
        private readonly ITerminal _terminal;
        public TerminalController(ITerminal terminal)
        {
            _terminal = terminal;
        }
        [HttpGet]
        [Route("TerminalFlight")]
        public List<TerminalFlightViewModel> TerminalFlight()
        {
            List<TerminalFlightViewModel> terminalflightObj = new List<TerminalFlightViewModel>();
            try
            {
                var ListTerminal = _terminal.ToList();
                foreach (var item in ListTerminal)
                {
                    TerminalFlightViewModel terminalObj = new TerminalFlightViewModel();
                    terminalObj.TerminalName = item.Name;
                    terminalObj.AirLineName = item.Name;
                    terminalObj.Type = item.Name;// need to check
                    terminalObj.AirlineIcon = item.Image;
                    terminalflightObj.Add(terminalObj);
                }
                return terminalflightObj;
            }
            catch (Exception ex)
            {
                string Mes = ex.Message;
                return terminalflightObj;
            }
        }
    }
}
