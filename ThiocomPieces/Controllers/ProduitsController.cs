using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThiocomPieces.BLL;
using ThiocomPieces.DTO;
using ThiocomPieces.Models;

namespace ThiocomPieces.Controllers
{
    public class ProduitsController : Controller
    {
        private readonly ProduitServices _ProduiService = new ProduitServices();
        // GET: Produit
        public ActionResult Produit(int produitId)
        {
            ProduitInfos produitInfos = _ProduiService.ObtenirProduitParId(produitId);
            ProduitAfficheModelView vm =
                new ProduitAfficheModelView
                {
                    ProduitId=produitInfos.ProduitID,
                    Nom = produitInfos.Nom,
                    prix= (double)produitInfos.Prix,
                    Reference= produitInfos.Reference
                };
            
            return View(vm);
        }

        public ActionResult Image(int id)
        {
            return File(_ProduiService.ObtenirLesPixelsPourUnProduit(id),"image/jpeg");
        }

        public ActionResult Ajout()
        {
            ViewBag.Title = "My View's Title";
            //_photoservice.
            return View(new ProduitAjoutModelView()
            {
                DateReference = DateTime.Now.ToString("dd//MM/yyyy"),
                //Nom = User.Identity.Name
            });
        }

        [HttpPost]
        public ActionResult Ajout(ProduitAjoutModelView vm)
        {
            ViewBag.Title = "My View's Title";
            bool iSAllGood = ModelState.IsValid;
            DateTime dateDeReference;
            if (!DateTime.TryParseExact(vm.DateReference, "dd/MM/yyyy", new CultureInfo("fr-FR"), DateTimeStyles.None, out dateDeReference))
            {
                ModelState.AddModelError(nameof(vm.DateReference), "la date de référence est incorrecte");
                iSAllGood = false;
            }
            if (vm.Pixels.ContentType.Split('/')[1].ToString()!="jpeg")
            {
                ModelState.AddModelError(nameof(vm.Pixels), "le format du fichier est incorrect");
                iSAllGood = false;
            }
            else if(vm.Pixels.ContentLength>2*1024*1024)
            {
                ModelState.AddModelError(nameof(vm.Pixels) ,  "le fichier dépasse la taille maximum autorisée 2Mo");
                iSAllGood = false;
            }

            if(iSAllGood)
            {
                ProduitAjout produitAjoutDTO = new ProduitAjout()
                {
                    Nom = vm.Nom,
                    DateReference = dateDeReference,
                    Description = vm.Description,
                    Prix=vm.prix,
                    Reference=vm.Reference
                };

                //Image img = Bitmap.FromStream(vm.Pixels.InputStream);

                produitAjoutDTO.Pixels = new byte[vm.Pixels.ContentLength];

                vm.Pixels.InputStream.Position = 0;
                vm.Pixels.InputStream.Read(produitAjoutDTO.Pixels, 0, produitAjoutDTO.Pixels.Length);

                int pid = _ProduiService.AjouterProduit(produitAjoutDTO);

                return RedirectToRoute("Produits", new { titre = vm.Nom, produitId = pid });


            }
            return View();
        }

    }
}