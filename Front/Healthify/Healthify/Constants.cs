namespace Healthify
{
    class Constants
    {
        #region API
        //private const string baseapi                                                    = "http://139.59.38.170:80/";
        private const string baseapi                                                    = "http://localhost:8888/";
        private const string privPass                                                   = "h8mDq5YIF1SWNHkArGmwBsxxwGLSQqQyVHqQMPinwvCSXozPZj1V";

        private const string login                                                      = baseapi + "login";
        private const string getuser                                                    = baseapi + "getuser";
        private const string pathis                                                     = baseapi + "pathis";
        private const string blood                                                      = baseapi + "blood";
        private const string verif                                                      = baseapi + "verify";
        private const string uphis                                                      = baseapi + "uphis";
        private const string getdoc                                                     = baseapi + "getdoc";


        internal const string LOGIN                                                     = login;
        internal const string GETUSER                                                   = getuser;
        internal const string PATHIS                                                    = pathis;
        internal const string BLOOD                                                     = blood;
        internal const string VERIF                                                     = verif;
        internal const string UPHIS                                                     = uphis;
        internal const string PRIVPASS                                                  = privPass;
        internal const string GETDOC                                                    = getdoc;
        #endregion
    }
}
