using Serilog;
using static CoreCode.ExtrasClasses;

namespace UglyCode.Functions
{
    public class PreferExceptions
    {
        //then error codes
        public const string E_OK = "E_OK";
        public const string E_ERROR = "E_ERROR";
        public ILogger log;

        public PreferExceptions(ILogger logger)
        {
            log = logger;
        }

        public void tryDeletePage(Page page)
        {
            if (deletePage(page) == E_OK)
            {
                if (registry.deleteReference(page.name.ToString() == E_OK))
                {
                    if (configKeys.deleteKey(page.name.makeKey == E_OK))
                    {
                        log.Information("Página excluída");
                    }
                    else
                    {
                        log.Information("configkey não foi excluída");
                    }
                }
                else
                {
                    log.Information("deleteReference não foi excluído do registro");
                }
            }
            else
            {
                log.Information("A exclusão falhou");
            }
        }

        public string deletePage(Page page)
        {
            return string.Empty;
        }
    }

}
