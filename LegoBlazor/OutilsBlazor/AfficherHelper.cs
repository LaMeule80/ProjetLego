using System;
using System.Diagnostics;

namespace ApplicationActrice.Tools
{
    public class AfficherHelper
    {
        public static void OuvrirLienInterne(string lien)
        {
            try
            {
                Process.Start("explorer.exe", lien);
            }
            catch (Exception ex)
            {

            }
        }

        public static void OuvrirLienExterne(string lien)
        {
            try
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {lien}") { CreateNoWindow = true });
            }
            catch (Exception ex)
            {

            }
        }
    }
}