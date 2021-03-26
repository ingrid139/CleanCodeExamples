using Serilog;
using System;
using static CoreCode.ExtrasClasses;

namespace PrettyCode.Functions
{
    public class PreferExceptions
    {
        //o tratamento de erro poderá ficar separado do código e ser simplificado
        public ILogger log;

        public PreferExceptions(ILogger logger)
        {
            log = logger;
        }
        public void tryDeletePage(Page page)
        {
            try
            {
                deletePage();
                registry.deleteReference(page.name.ToString());
                configKeys.deleteKey(page.name.makeKey);
            }
            catch (Exception e)
            {
                log.Error(e, e.Message);
            }
        }

        private void deletePage() => throw new NotImplementedException();
    }
}
