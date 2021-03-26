using Serilog;
using System;
using static CoreCode.ExtrasClasses;

namespace PrettyCode.Functions
{
    public class PreferExceptionsRafactor
    {
        //responsabilidades separadas
        public ILogger log;

        public PreferExceptionsRafactor(ILogger logger)
        {
            log = logger;
        }

        public void delete(Page page)
        {
            try
            {
                DeletePageAndAllReferences(page);
            }
            catch (Exception e)
            {
                logError(e);
            }
        }

        public void DeletePageAndAllReferences(Page page)
        {
            deletePage();
            registry.deleteReference(page.name.ToString());
            configKeys.deleteKey(page.name.makeKey);
        }

        public void logError(Exception e)
        {
            log.Error(e, e.Message);
        }

        private void deletePage() => throw new NotImplementedException();
    }
}
