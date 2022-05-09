using ClosedXML.Excel;
using LoginFuzzy.Model;
using LoginFuzzy.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LoginFuzzy.Pages
{
    [Authorize]
    public class HistorialModel : PageModel
    {
        private readonly AuthDbContext _authDbContext;
        private readonly UserManager<ApplicationUser> futbolista;
        public HistorialModel(UserManager<ApplicationUser> futbolista, AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
            this.futbolista = futbolista;
        }

        [BindProperty]
        public Historial Model { get; set; }

        public List<Futbolista> AllFutbolistas = new List<Futbolista>();

        public static List<Futbolista>? listaPeque;

        public async Task<IActionResult> OnPostAsync()
        {
            if (Model.nombre==null)
            {
                switch (Model.position)
                {
                    case "DL":
                        AllFutbolistas = await _authDbContext.Futbolista.Where(s => s.Id == futbolista.GetUserId(User)).OrderByDescending(x => x.DL).ToListAsync();
                        listaPeque = AllFutbolistas;
                        return Partial("HistorialPages/_PartialHistorial", AllFutbolistas);
                    case "DC":
                        AllFutbolistas = await _authDbContext.Futbolista.Where(s => s.Id == futbolista.GetUserId(User)).OrderByDescending(x => x.DC).ToListAsync();
                        listaPeque = AllFutbolistas;
                        return Partial("HistorialPages/_PartialHistorial", AllFutbolistas);
                    case "MC":
                        AllFutbolistas = await _authDbContext.Futbolista.Where(s => s.Id == futbolista.GetUserId(User)).OrderByDescending(x => x.MC).ToListAsync();
                        listaPeque = AllFutbolistas;
                        return Partial("HistorialPages/_PartialHistorial", AllFutbolistas);
                    case "FW":
                        AllFutbolistas = await _authDbContext.Futbolista.Where(s => s.Id == futbolista.GetUserId(User)).OrderByDescending(x => x.FW).ToListAsync();
                        listaPeque = AllFutbolistas;
                        return Partial("HistorialPages/_PartialHistorial", AllFutbolistas);
                    case "PT":
                        AllFutbolistas = await _authDbContext.Futbolista.Where(s => s.Id == futbolista.GetUserId(User)).OrderByDescending(x => x.PT).ToListAsync();
                        listaPeque = AllFutbolistas;
                        return Partial("HistorialPages/_PartialHistorial", AllFutbolistas);
                    case "Normal":
                        AllFutbolistas = await _authDbContext.Futbolista.Where(x => x.Id == futbolista.GetUserId(User)).ToListAsync();
                        listaPeque = AllFutbolistas;
                        return Partial("HistorialPages/_PartialHistorial", AllFutbolistas);
                }
            }
            else if(Model.nombre != null)
            {
                switch (Model.position)
                {
                    case "DL":
                        AllFutbolistas = await _authDbContext.Futbolista.Where(s => s.Id == futbolista.GetUserId(User) && s.nombre.Contains(Model.nombre)).OrderByDescending(x => x.DL).ToListAsync();
                        listaPeque = AllFutbolistas;
                        return Partial("HistorialPages/_PartialHistorial", AllFutbolistas);
                    case "DC":
                        AllFutbolistas = await _authDbContext.Futbolista.Where(s => s.Id == futbolista.GetUserId(User) && s.nombre.Contains(Model.nombre)).OrderByDescending(x => x.DC).ToListAsync();
                        listaPeque = AllFutbolistas;
                        return Partial("HistorialPages/_PartialHistorial", AllFutbolistas);
                    case "MC":
                        AllFutbolistas = await _authDbContext.Futbolista.Where(s => s.Id == futbolista.GetUserId(User) && s.nombre.Contains(Model.nombre)).OrderByDescending(x => x.MC).ToListAsync();
                        listaPeque = AllFutbolistas;
                        return Partial("HistorialPages/_PartialHistorial", AllFutbolistas);
                    case "FW":
                        AllFutbolistas = await _authDbContext.Futbolista.Where(s => s.Id == futbolista.GetUserId(User) && s.nombre.Contains(Model.nombre)).OrderByDescending(x => x.FW).ToListAsync();
                        listaPeque = AllFutbolistas;
                        return Partial("HistorialPages/_PartialHistorial", AllFutbolistas);
                    case "PT":
                        AllFutbolistas = await _authDbContext.Futbolista.Where(s => s.Id == futbolista.GetUserId(User) && s.nombre.Contains(Model.nombre)).OrderByDescending(x => x.PT).ToListAsync();
                        listaPeque = AllFutbolistas;
                        return Partial("HistorialPages/_PartialHistorial", AllFutbolistas);
                    case "Normal":
                        AllFutbolistas = await _authDbContext.Futbolista.Where(s => s.Id == futbolista.GetUserId(User) && s.nombre.Contains(Model.nombre)).ToListAsync();
                        listaPeque = AllFutbolistas;
                        return Partial("HistorialPages/_PartialHistorial", AllFutbolistas);
                }
            }
            return Page();
        }

        public async Task<IActionResult> OnGetAsync()
        {
            AllFutbolistas = await _authDbContext.Futbolista.Where(x=> x.Id == futbolista.GetUserId(User)).ToListAsync();
            listaPeque = AllFutbolistas;
            ViewData["ListaJugadores"] = await _authDbContext.Futbolista.Where(x => x.Id == futbolista.GetUserId(User)).CountAsync();
            return Page();
        }

        public FileResult OnGetExcel()
        {
            //AllFutbolistas = _authDbContext.Futbolista.Where(x => x.Id == futbolista.GetUserId(User)).ToList();
            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet worksheet =
                workbook.Worksheets.Add("Futbolistas");
                worksheet.Cell(1, 1).Value = "Nombre";
                worksheet.Cell(1, 2).Value = "Altura";
                worksheet.Cell(1, 3).Value = "Peso";
                worksheet.Cell(1, 4).Value = "Musculatura";
                worksheet.Cell(1, 5).Value = "Velocidad";
                worksheet.Cell(1, 6).Value = "Resistencia";
                worksheet.Cell(1, 7).Value = "Agilidad";
                worksheet.Cell(1, 8).Value = "Confianza";
                worksheet.Cell(1, 9).Value = "Concentración";
                worksheet.Cell(1, 10).Value = "Rapidez en Decisiones";
                worksheet.Cell(1, 11).Value = "Creatividad";
                worksheet.Cell(1, 12).Value = "Dribling";
                worksheet.Cell(1, 13).Value = "Pases";
                worksheet.Cell(1, 14).Value = "Finalización";
                worksheet.Cell(1, 15).Value = "Defensa Lateral";
                worksheet.Cell(1, 16).Value = "Defensa Central";
                worksheet.Cell(1, 17).Value = "MedioCampista";
                worksheet.Cell(1, 18).Value = "Delantero";
                worksheet.Cell(1, 19).Value = "Portero";

                IXLRange range = worksheet.Range(worksheet.Cell(1, 1).Address, worksheet.Cell(1, 14).Address);
                range.Style.Fill.SetBackgroundColor(XLColor.LightBlue);

                IXLRange range2 = worksheet.Range(worksheet.Cell(1, 15).Address, worksheet.Cell(1, 19).Address);
                range2.Style.Fill.SetBackgroundColor(XLColor.LightGray);

                int index = 1;

                foreach (var item in listaPeque)
                {
                    index++;

                    worksheet.Cell(index, 1).Value = item.nombre;
                    worksheet.Cell(index, 2).Value = item.altura;
                    worksheet.Cell(index, 3).Value = item.peso;
                    worksheet.Cell(index, 4).Value = item.musculatura;
                    worksheet.Cell(index, 5).Value = item.velocidad;
                    worksheet.Cell(index, 6).Value = item.resistencia;
                    worksheet.Cell(index, 7).Value = item.agilidad;
                    worksheet.Cell(index, 8).Value = item.confianza;
                    worksheet.Cell(index, 9).Value = item.concentracion;
                    worksheet.Cell(index, 10).Value = item.decisiones;
                    worksheet.Cell(index, 11).Value = item.creatividad;
                    worksheet.Cell(index, 12).Value = item.dribling;
                    worksheet.Cell(index, 13).Value = item.pases;
                    worksheet.Cell(index, 14).Value = item.finalizacion;
                    worksheet.Cell(index, 15).Value = item.DL;
                    worksheet.Cell(index, 16).Value = item.DC;
                    worksheet.Cell(index, 17).Value = item.MC;
                    worksheet.Cell(index, 18).Value = item.FW;
                    worksheet.Cell(index, 19).Value = item.PT;

                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

                    var strDate = DateTime.Now.ToString("yyyyMMdd");
                    var strHour = DateTime.Now.ToString("HHmmss");
                    string filename = string.Format($"Futbolistas_{strDate}_{strHour}.xlsx");

                    return File(content, contentType, filename);
                }
            }
        }
    }
}